using BusinessLogic;
using LibrarySystem.Common;
using LibrarySystem.People;
using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using WindowsFormsApp1;
using WindowsFormsApp1.Properties;


namespace LibrarySystem.Users.Controls.ViewUserCardControl
{
    public partial class AccountControl : BaseUserControl
    {
        private User _selectedUser;

        public User SelectedUser => _selectedUser;

        public AccountControl()
        {
            InitializeComponent();
            ResetDefaultFields();
        }

        public void ResetDefaultFields()
        {
            LblUserName.Text = "[Not Set]";
            LblPermissions.Text = "[Not Set]";
            LblStatus.Text = "[Not Set]";
            pbStatus.ImageLocation = Resources.round.ToString();
            LblLastLogin.Text = "[Not Set]";
            _selectedUser = null;
        }

        private bool ValidateSelectedUser()
        {
            if (_selectedUser == null)
            {
                MessageBox.Show("Invalid user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetDefaultFields();
                return false;
            }

            return true;
        }

        private void PopulateUserFields()
        {
            LblUserName.Text = _selectedUser.Username;
            pbStatus.Image = _selectedUser.IsActive ? Resources.button : Resources.round;
            LblStatus.Text = _selectedUser.IsActive ? "Active" : "Not Active";
            LblPermissions.Text = _selectedUser.Permission.ToString();
            LblLastLogin.Text = _selectedUser.GetLastLoginDateText();
        }

        public void LoadUserById(int userId)
        {
            _selectedUser = User.Find(userId, User.FindByType.UserId);
            if (!ValidateSelectedUser())
                return;

            PopulateUserFields();
        }

        public void LoadUserByPersonId(int personId)
        {
            _selectedUser = User.Find(personId, User.FindByType.PersonId);
            if (!ValidateSelectedUser())
                return;

            _selectedUser.PersonInfo = Person.FindById(personId);
            PopulateUserFields();
        }

        private void LnkUpdatePerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!ValidateSelectedUser())
                return;

            if (GlobalContext.CurrentUser.PersonId != _selectedUser.PersonId && !CommonValidation.HandlePermissions(User.Permissions.ManageUsers))
                return;

            AddUpdatePersonForm addUpdatePersonForm = new AddUpdatePersonForm(_selectedUser.PersonId);
            addUpdatePersonForm.ShowDialog();
        }

        private void LnkUpdateUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!ValidateSelectedUser())
                return;

            if (GlobalContext.CurrentUser.UserId != _selectedUser.UserId && !CommonValidation.HandlePermissions(User.Permissions.ManageUsers))
                return;

            AddUpdateUserForm addUpdateUserForm = new AddUpdateUserForm(_selectedUser.UserId);
            addUpdateUserForm.ShowDialog();
            LoadUserById(_selectedUser.UserId);
        }
    }
}