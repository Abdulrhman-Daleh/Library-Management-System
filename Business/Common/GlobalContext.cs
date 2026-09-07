using BusinessLogic;
using System;
using System.Windows.Forms;

namespace LibrarySystem.Common
{
    public static class GlobalContext
    {
        public static User CurrentUser { get; set; }
        public static Member CurrentMember { get; set; }

        public static bool IsLoggedInUser(int userId)
        {
            return CurrentUser != null && CurrentUser.UserId == userId;
        }

        public static bool IsUserValid()
        {
            if (!GenericOperations.IsEmptyObject(CurrentUser))
                return true;
            else
                MessageBox.Show("User is not valid", "Invalid User", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }

        public static bool IsMemberValid()
        {
            if (!GenericOperations.IsEmptyObject(CurrentMember))
                return true;
            else
                MessageBox.Show("Member is not valid", "Invalid Member", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }
    }
}