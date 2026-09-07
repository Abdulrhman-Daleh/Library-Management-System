using BusinessLogic;
using LibrarySystem.Common;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using static BusinessLogic.User;

namespace LibrarySystem.Users
{
    public partial class AddUpdateUserForm : BaseForm
    {
        private User _selectedUser;
        private int _newAddedPersonId;

        public event EventHandler<int> NotifyOnSaveSuccess;

        public AddUpdateUserForm()
        {
            InitializeComponent();
        }

        public AddUpdateUserForm(int userId)
        {
            InitializeComponent();
            _selectedUser = User.Find(userId, User.FindByType.UserId);
        }

        private bool HasValidSelectedPerson() => findPersonWithFilterControl.SelectedPerson != null;

        private void ReceivePersonId(object sender, int personId) => _newAddedPersonId = personId;

        private void ApplyUpdateMode()
        {
            LblTitle.Text = "Update User";
            TxtUsername.Text = _selectedUser.Username;
            ChkIsActive.Checked = _selectedUser.IsActive;
            TcPages.TabPages["tpAddNewUser"].Enabled = true;
            LblUserId.Text = _selectedUser.UserId.ToString();
            findPersonWithFilterControl.LoadPerson(_selectedUser.PersonId);
            findPersonWithFilterControl.AllowSearchSection = false;
        }

        private void ApplyAddMode()
        {
            LblTitle.Text = "Add New User";
            TcPages.TabPages["tpAddNewUser"].Enabled = false;
            ChkShowPassword.Checked = false;
            ChkIsActive.Checked = true;
            HandleDefaultPermissions(true);
            findPersonWithFilterControl.ResetFilterInputFocus();
            findPersonWithFilterControl.AllowSearchSection = true;
        }

        private void HandleDefaultPermissions(bool status)
        {
            ChkManagePeople.Checked = status;
            ChkManagePeople.Enabled = status;
            ChkManageUsers.Checked = status;
            ChkManageUsers.Enabled = status;
            ChkManageMembers.Checked = status;
            ChkManageMembers.Enabled = status;
        }

        private void HandleOptionalPermissions(bool status)
        {
            ChkManageCategories.Checked = status;
            ChkManageCategories.Enabled = status;
            ChkManageBooks.Checked = status;
            ChkManageBooks.Enabled = status;
            ChkManageBookCopies.Checked = status;
            ChkManageBookCopies.Enabled = status;
            ChkManageMemberships.Checked = status;
            ChkManageMemberships.Enabled = status;
            ChkManagePolicies.Checked = status;
            ChkManagePolicies.Enabled = status;
            ChkManageReports.Checked = status;
            ChkManageReports.Enabled = status;
            ChkMembershipRenewals.Checked = status;
            ChkMembershipRenewals.Enabled = status;
            ChkBorrowTransactions.Checked = status;
            ChkBorrowTransactions.Enabled = status;
            ChkManageFinePayments.Checked = status;
            ChkManageFinePayments.Enabled = status;
        }

        private void SetPermissions()
        {
            if (GenericOperations.IsEmptyObject(_selectedUser))
            {
                ChkAll.Enabled = false;
                ChkNone.Enabled = false;
                HandleDefaultPermissions(true);
                _selectedUser = new User();
            }
            else if (!_selectedUser.HasAdminPermissions())
            {
                LblPermissionMessage.Visible = true;
                LblPermissionMessage.Text = "Admin only are allowed to change permissions";
                GbPermissions.Enabled = false;

                if (_selectedUser.HasPermission(User.Permissions.None))
                {
                    ChkNone.Checked = true;
                }
                else
                {
                    ChkManagePeople.Checked = _selectedUser.HasPermission(User.Permissions.ManagePeople);
                    ChkManageUsers.Checked = _selectedUser.HasPermission(User.Permissions.ManageUsers);
                    ChkManageMembers.Checked = _selectedUser.HasPermission(User.Permissions.ManageMembers);
                    ChkManageBooks.Checked = _selectedUser.HasPermission(User.Permissions.ManageBooks);
                    ChkManageBookCopies.Checked = _selectedUser.HasPermission(User.Permissions.ManageBookCopies);
                    ChkManageCategories.Checked = _selectedUser.HasPermission(User.Permissions.ManageCategories);
                    ChkManagePolicies.Checked = _selectedUser.HasPermission(User.Permissions.ManagePolicies);
                    ChkManageReports.Checked = _selectedUser.HasPermission(User.Permissions.ViewReports);
                    ChkManageMemberships.Checked = _selectedUser.HasPermission(User.Permissions.ManageMemberships);
                    ChkBorrowTransactions.Checked = _selectedUser.HasPermission(User.Permissions.ManageBorrowTransactions);
                    ChkManageFinePayments.Checked = _selectedUser.HasPermission(User.Permissions.ManageFinePayments);
                    ChkMembershipRenewals.Checked = _selectedUser.HasPermission(User.Permissions.ManageMembershipRenews);
                }
            }
            else
            {
                ChkAll.Checked = true;
            }
        }

        private void ChkAll_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkAll.Checked)
            {
                HandleDefaultPermissions(false);
                HandleOptionalPermissions(false);
                ChkNone.Checked = false;
            }
            else if (!ChkNone.Checked)
            {
                HandleDefaultPermissions(true);
                HandleOptionalPermissions(true);
            }
        }

        private void ChkNone_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkNone.Checked)
            {
                HandleDefaultPermissions(false);
                HandleOptionalPermissions(false);
                ChkAll.Checked = false;
            }
            else if (!ChkAll.Checked)
            {
                HandleDefaultPermissions(true);
                HandleOptionalPermissions(true);
            }
        }

        private void AddUpdateUserForm_Load(object sender, EventArgs e)
        {
            SetPasswordVisibility(false);
            ApplyAddMode();
            SetPermissions();
            findPersonWithFilterControl.Publisher.PersonFoundPublisherEvent += ReceivePersonId;

            if (!GenericOperations.IsEmptyObject(_selectedUser) && _selectedUser.CurrentMode == User.ModeType.Update)
                ApplyUpdateMode();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
           if (!HasValidSelectedPerson())
           {
               MessageBox.Show("No person selected", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return;
           }
           
           if (User.IsPersonAlreadyUser(findPersonWithFilterControl.SelectedPerson.PersonId) && _selectedUser.CurrentMode == User.ModeType.Add)
           {
               MessageBox.Show("Person is already a user", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return;
           }

            TcPages.SelectedIndex = TcPages.TabPages.IndexOfKey("tpAddNewUser");
            TcPages.TabPages["tpAddNewUser"].Enabled = true;
        }

        private void SetPasswordVisibility(bool show)
        {
            TxtPassword.UseSystemPasswordChar = !show;
            TxtConfirmPassword.UseSystemPasswordChar = !show;
        }

        private void ChkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            SetPasswordVisibility(ChkShowPassword.Checked);
        }

        private bool IsEmptyField(TextBox textBox) => string.IsNullOrEmpty(textBox.Text.Trim());

        private void TxtUsername_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (IsEmptyField(textBox))
                errorProvider.SetError(textBox, "Invalid empty field");
            else
                errorProvider.SetError(textBox, null);
        }

        private void TxtPassword_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (CommonValidation.IsRequired(textBox, errorProvider))
                return;

            if (_selectedUser.CurrentMode == ModeType.Update)
            {
                if (!PasswordHasher.VerifyPassword(TxtPassword.Text.Trim(), _selectedUser.HashedPassword))
                {
                    errorProvider.SetError(textBox, "Current password is incorrect");
                    return;
                }
            }


            if (textBox.Text.Trim().Length < 8)
                errorProvider.SetError(textBox, "Password must be at least 8 characters");
            else
                errorProvider.SetError(textBox, null);
        }

        private bool IsPasswordMatch() => TxtConfirmPassword.Text.Trim() == TxtPassword.Text.Trim();

        private void TxtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (IsEmptyField(textBox))
            {
                errorProvider.SetError(textBox, "Invalid empty field");
                return;
            }

            if (!IsPasswordMatch())
            {
                errorProvider.SetError(textBox, "Passwords do not match");
                return;
            }

            errorProvider.SetError(textBox, null);
        }

        private int CollectPermission()
        {
            if (ChkAll.Checked)
                return -1;

            if (ChkNone.Checked)
                return 0;

            int permission = 0;
            foreach (Control control in GbPermissions.Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                    permission |= Convert.ToInt32(control.Tag);
            }

            return permission;
        }

        private void MapFormToUser()
        {
            try
            {
                string[] passwordParts = PasswordHasher.HashPassword(TxtPassword.Text.Trim()).Split('.');
                _selectedUser.HashedPassword = PasswordHasher.CombinePasswordParts(passwordParts);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

           _selectedUser.PersonId = findPersonWithFilterControl.SelectedPerson != null
               ? findPersonWithFilterControl.SelectedPerson.PersonId
               : _newAddedPersonId;

            _selectedUser.Username = TxtUsername.Text.Trim();
            _selectedUser.AccountLockExpirationDate = null;
            _selectedUser.IsActive = ChkIsActive.Checked;
            _selectedUser.Permission = CollectPermission();
        }

        private void Save()
        {
            if (CommonValidation.HasValidationErrors(TpAddNewUser.Controls, errorProvider, this))
            {
                MessageBox.Show("Form is not valid", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MapFormToUser();

            if (_selectedUser.Save())
            {
                MessageBox.Show("Data saved successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LblUserId.Text = _selectedUser.UserId.ToString();
                LblTitle.Text = "Update User Info";
                 findPersonWithFilterControl.AllowSearchSection = false;
                NotifyOnSaveSuccess?.Invoke(this, _selectedUser.UserId);
                GlobalContext.CurrentUser = _selectedUser;
            }
            else
            {
                MessageBox.Show("Failed to save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NextSetPermissions_Click(object sender, EventArgs e)
        {
            TcPages.SelectedIndex = TcPages.TabPages.IndexOfKey("tbPermissions");
            TcPages.TabPages["tbPermissions"].Enabled = true;
            SetPermissions();
        }

        private void BtnClose_Click(object sender, EventArgs e) => Close();

        private void BtnSave_Click(object sender, EventArgs e) => Save();

        private void PreviousToSelect_Click(object sender, EventArgs e)
        {
            TcPages.SelectedIndex = TcPages.TabPages.IndexOfKey("tpSelectPerson");
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            TcPages.SelectedIndex = TcPages.TabPages.IndexOfKey("TpAddNewUser");
        }
    }
}