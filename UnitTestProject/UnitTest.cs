using BusinessLogic;


using LibrarySystem.Common;

namespace UnitTestProject
{
    public class UnitTest
    {

        [Theory]
        [InlineData("2842848472", true)]
        [InlineData(null, false)]
        [InlineData("284284824", false)]
        public void IsValidPhone_ReturnExpectedResult(string phone, bool expected)
        {
            bool result = Person.IsPhoneValid(phone);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void IsLocked_WhenExpirationDateIsNull_ReturnsFalse()
        {
            User user = new User();
            user.AccountLockExpirationDate = null;

            Assert.False(user.IsLocked());
        }

        [Fact]
        public void IsLocked_WhenExpirationDateIsinFuture_ReturnsTrue()
        {
            User user = new User();
            user.AccountLockExpirationDate = DateTime.Now.AddMinutes(10);

            Assert.True(user.IsLocked());
        }

        [Fact]
        public void IsLocked_WhenExpirationDateIsInPast_ReturnsFalse()
        {
            User user = new User();
            user.AccountLockExpirationDate = DateTime.Now.AddMinutes(-10);

            Assert.False(user.IsLocked());
        }

        [Fact]
        public void CanChangePassword_WhenLastChangeDateIsNull_ReturnsTrue()
        {
            User user = new User();
            user.LastPasswordChangeDate = null;

            Assert.True(user.CanChangePassword());
        }

        [Fact]
        public void CanChangePassword_WhenPasswordWasChangedLessThen30DaysAgo_ReturnsTrue()
        {
            User user = new User();
            user.LastPasswordChangeDate = DateTime.Now.AddDays(-23);

            Assert.False(user.CanChangePassword());
        }

        [Fact]
        public void CanChangePassword_WhenPasswordWasChangedMoreThan30DaysAgo_ReturnsTrue()
        {
            User user = new User();
            user.LastPasswordChangeDate = DateTime.Now.AddDays(-31);

            Assert.True(user.CanChangePassword());
        }


        [Theory]
        [InlineData(null, false)]
        [InlineData((int)User.Permissions.ManageUsers + (int)User.Permissions.ManagePeople + (int)User.Permissions.ManagePolicies, false)]
        [InlineData((int)User.Permissions.All, true)]
        public void HasAdminPermissions_ReturnsExpectResult(int permissions, bool expectedResult)
        {
            User user = new User();
            user.Permission = permissions;

            Assert.Equal(user.HasAdminPermissions(), expectedResult);
        }


        [Fact]
        public void IsPolicyActive_WhenEffectiveToDateIsInFuture_ReturnsTrue()
        {
            Policy policy = new Policy();
            policy.EffectiveTo = DateTime.Now.AddDays(10);

            Assert.True(policy.IsActive());
        }

        [Fact]
        public void IsPolicyActive_WhenEffectiveToDateIsInPast_ReturnsFalse()
        {
            Policy policy = new Policy();
            policy.EffectiveTo = DateTime.Now.AddDays(-10);

            Assert.False(policy.IsActive());
        }


    }
}
