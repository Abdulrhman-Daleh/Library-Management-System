using DataAccess;
using DataAccess.DTOs;
using LibrarySystem.Common;
using Microsoft.Win32;
using System;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class User
    {
        [Flags]
        public enum Permissions
        {
            None = 0,
            ManagePeople = 1,
            ManageUsers = 2,
            ManageMembers = 4,
            ManageCategories = 8,
            ManageBooks = 16,
            ManageBookCopies = 32,
            ManageMemberships = 64,
            ManagePolicies = 128,
            ViewReports = 256,
            ManageBorrowTransactions = 512,
            ManageMembershipRenews = 1024,
            ManageFinePayments = 2048,
            All = -1
        }

        public enum FindByType
        {
            PersonId = 1,
            UserId = 2
        }

        public enum ModeType
        {
            Add,
            Update
        }

        private const int MaxLoginAttemptsConstant = 3;

        private UserDTO _userDto;
        private ModeType _currentMode;

        public ModeType CurrentMode
        {
            get => _currentMode;
            set => _currentMode = value;
        }

        public int UserId
        {
            get => _userDto.UserId;
            set => _userDto.UserId = value;
        }

        public int PersonId
        {
            get => _userDto.PersonId;
            set => _userDto.PersonId = value;
        }

        public string Username
        {
            get => _userDto.Username;
            set => _userDto.Username = value;
        }

        public string HashedPassword
        {
            get => _userDto.HashedPassword;
            set => _userDto.HashedPassword = value;
        }

        public bool IsActive
        {
            get => _userDto.IsActive;
            set => _userDto.IsActive = value;
        }

        public int? FailedLoginAttempts
        {
            get => _userDto.FailedLoginAttempts;
            set => _userDto.FailedLoginAttempts = value;
        }

        public DateTime? AccountLockExpirationDate
        {
            get => _userDto.AccountLockExpirationDate;
            set => _userDto.AccountLockExpirationDate = value;
        }

        public DateTime? LastLoginDate
        {
            get => _userDto.LastLoginDate;
            set => _userDto.LastLoginDate = value;
        }

        public DateTime? LastPasswordChangeDate
        {
            get => _userDto.LastPasswordChangeDate;
            set => _userDto.LastPasswordChangeDate = value;
        }

        public int Permission
        {
            get => _userDto.Permission;
            set => _userDto.Permission = value;
        }

        public Person PersonInfo { get; set; }

        public User()
        {
            _userDto = new UserDTO();
            _currentMode = ModeType.Add;
        }

        private User(UserDTO userDto)
        {
            _userDto = userDto;
            PersonInfo = Person.FindById(userDto.PersonId);
            _currentMode = ModeType.Update;
        }

        public class LoginResult
        {
            public bool Success { get; set; }
            public string Message { get; set; }
            public User Data { get; set; }

            public LoginResult(bool success, string message, User data)
            {
                Success = success;
                Message = message;
                Data = data;
            }
        }

        public bool IsUserAMember()
        {
            return UserData.IsUserAMember(UserId);
        }

        public static LoginResult Login(string username, string password)
        {
            UserDTO userDto = UserData.GetUserByUsername(username);
            if (userDto == null)
                return new LoginResult(false, "Invalid username", null);

            User user = new User(userDto);

            if (user.IsLocked())
                return new LoginResult(false, "Account locked", null);

            if (!user.IsActive)
                return new LoginResult(false, "Inactive account", null);

            if (PasswordHasher.VerifyPassword(password, user.HashedPassword))
            {
                user.ResetLoginInfo();
                return new LoginResult(true, "Success", user);
            }

            
            user.IncreaseFailedLoginAttempts();

            if (user.IsLastAttempt())
                user.LockAccount(1);

            return new LoginResult(false, "Invalid password", null);
        }

        public static async Task<DataTable> GetUsersInMembershipType(int membershipTypeId, User currentUser)
        {
            if (currentUser.HasPermission(Permissions.All))
                return await UserData.GetAllUsersAsyncInType(membershipTypeId);

            if (currentUser.HasPermission(Permissions.ManageUsers))
                return await UserData.GetAllUsersAsyncInTypeAndUser(membershipTypeId, currentUser.UserId);

            return null;
        }

        public static async Task<DataTable> GetAllUsersAsync(User currentUser)
        {
            if (currentUser.HasPermission(Permissions.All))
                return await UserData.GetAllUsersAsync();

            if (currentUser.HasPermission(Permissions.ManageUsers))
                return await UserData.GetUsersByUserIdAsync(currentUser.UserId);

            return null;
        }

        public static User FindUserById(int userId)
        {
            UserDTO userDto = UserData.GetUserById(userId);
            return userDto == null ? null : new User(userDto);
        }

        public static User FindUserByPersonId(int personId)
        {
            UserDTO userDto = UserData.GetUserByPersonId(personId);
            return userDto == null ? null : new User(userDto);
        }

        public static User Find(int id, FindByType findBy)
        {
            if (findBy == FindByType.UserId)
                return FindUserById(id);

            return FindUserByPersonId(id);
        }

        private bool Add()
        {
            UserId = UserData.CreateUser(_userDto);
            return UserId != -1;
        }

        private bool Update()
        {
            return UserData.UpdateUser(_userDto);
        }

        public bool Save()
        {
            if (_currentMode == ModeType.Add)
            {
                if (Add())
                {
                    _currentMode = ModeType.Update;
                    return true;
                }

                return false;
            }

            return Update();
        }

        public static bool DeleteUser(int userId)
        {
            return UserData.DeleteUser(userId);
        }

        public static bool IsPersonAlreadyUser(int personId)
        {
            return FindUserByPersonId(personId) != null;
        }

        public static bool Activate(int userId)
        {
            return UserData.SetUserActiveStatus(userId, true);
        }

        public bool Activate()
        {
            return UserData.SetUserActiveStatus(UserId, true);
        }

        public static bool Deactivate(int userId)
        {
            return UserData.SetUserActiveStatus(userId, false);
        }

        public bool Deactivate()
        {
            return UserData.SetUserActiveStatus(UserId, false);
        }

        public bool ChangePassword(string newHashedPassword)
        {
            return UserData.UpdateUserPassword(UserId, newHashedPassword);
        }

        public static User FindByUsername(string username)
        {
            UserDTO userDto = UserData.GetUserByUsername(username);
            return userDto == null ? null : new User(userDto);
        }

        public bool IncreaseFailedLoginAttempts()
        {
            int currentAttempts = (FailedLoginAttempts ?? 0) + 1;
            return UserData.UpdateFailedLoginAttempts(UserId, currentAttempts);
        }

        public void ResetLoginInfo()
        {
            LastLoginDate = DateTime.Now;
            AccountLockExpirationDate = null;
            FailedLoginAttempts = null;
            UserData.UpdateUser(_userDto);
        }

        public int AttemptsLeft()
        {
            return MaxLoginAttemptsConstant - (FailedLoginAttempts ?? 0);
        }

        public bool LockAccount(int minutes)
        {
            AccountLockExpirationDate = DateTime.Now.AddMinutes(minutes);
            return UserData.UpdateAccountLockExpirationDate(UserId, AccountLockExpirationDate);
        }

        public bool IsLastAttempt()
        {
            return AttemptsLeft() <= 1;
        }

        public bool IsLocked()
        {
            return AccountLockExpirationDate != null && AccountLockExpirationDate > DateTime.Now;
        }

        public bool CanChangePassword()
        {
            return LastPasswordChangeDate == null || LastPasswordChangeDate <= DateTime.Now.AddDays(-30);
        }

        private static bool AdminAccountExists()
        {
            return FindByUsername("admin") != null;
        }

        public bool AddAdminAccount()
        {
            if (AdminAccountExists())
                return false;

            Person adminPerson = Person.GetAdminPerson();
            adminPerson.Save();

            UserId = -1;
            PersonId = adminPerson.PersonId;
            Username = "Admin";
            HashedPassword = LibrarySystem.Common.PasswordHasher.HashPassword("Admin12345");
            IsActive = true;
            Permission = (int)Permissions.All;

            return Save();
        }

        public bool HasPermission(Permissions requiredPermission)
        {
            Permissions currentPermission = (Permissions)Permission;

            if (currentPermission == Permissions.All)
                return true;

            if (requiredPermission == Permissions.None)
                return currentPermission == Permissions.None;

            return (currentPermission & requiredPermission) == requiredPermission;
        }

        public bool HasAdminPermissions()
        {
            return (Permissions)Permission == Permissions.All;
        }

        public bool DoesPasswordsMatch(string newPassword)
        {
            return HashedPassword == PasswordHasher.HashPassword(newPassword);
        }

        private bool BuildLastLoginDate(StringBuilder result, int timeUnit)
        {
            if (timeUnit > 0)
            {
                result.Append(timeUnit.ToString());
                return true;
            }

            return false;
        }

        public string GetLastLoginDateText()
        {
            if (LastLoginDate == null)
                return "did not login yet!";

            TimeSpan span = new TimeSpan(LastLoginDate.Value.Ticks);
            TimeSpan different = new TimeSpan(DateTime.Now.Ticks).Subtract(span);

            int days = different.Days;
            int hours = different.Hours;    
            int minutes = different.Minutes;
            int seconds = different.Seconds;

            StringBuilder result = new StringBuilder();

            if (BuildLastLoginDate(result, days))
                result.Append("dys ");

            if (BuildLastLoginDate(result, hours))
                result.Append("hrs ");


            if (BuildLastLoginDate(result, minutes))
                result.Append("minu ");


            if (BuildLastLoginDate(result, seconds))
                result.Append("sec ");


            return result.ToString() + "only";
        }
    }
}