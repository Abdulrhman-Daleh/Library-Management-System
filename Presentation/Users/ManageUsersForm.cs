using BusinessLogic;
using LibrarySystem.Common;
using LibrarySystem.People;
using System;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace LibrarySystem.Users
{
    public partial class ManageUsersForm : BaseForm
    {
        private DataTable _usersDataTable;
        private string _filterName;

        public ManageUsersForm()
        {
            InitializeComponent();
            _LoadUsersInDefaultMode();
            BtnClose.Select();
        }

        public ManageUsersForm(int membershipTypeId)
        {
            InitializeComponent();
            _LoadUsersForMembershipType(membershipTypeId);
            BtnClose.Select();
        }

        private async void _LoadUsersForMembershipType(int membershipTypeId)
        {
            TxtFilter.Visible = true;
            CbIsActive.Visible = false;
            CbFilterBy.SelectedIndex = 0;
            CbIsActive.SelectedIndex = 0;

            _usersDataTable = await User.GetUsersInMembershipType(membershipTypeId, GlobalContext.CurrentUser);

            if (!CommonValidation.IsDataTableEmpty(_usersDataTable))
            {
                CommonValidation.ConfigureDataGridView(_usersDataTable, DgvUsers);
                CommonValidation.UpdateRecordCount(DgvUsers, LblRecords);
            }
        }

        private async void _LoadUsersInDefaultMode()
        {
            TxtFilter.Visible = true;
            CbIsActive.Visible = false;
            CbFilterBy.SelectedIndex = 0;
            CbIsActive.SelectedIndex = 0;

            _usersDataTable = await User.GetAllUsersAsync(GlobalContext.CurrentUser);


            if (!CommonValidation.IsDataTableEmpty(_usersDataTable))
            {
                CommonValidation.ConfigureDataGridView(_usersDataTable, DgvUsers);
                CommonValidation.UpdateRecordCount(DgvUsers, LblRecords);
            }
        }

        private void ReloadRecords(int userId)
        {
            MapToGridView(User.Find(userId, User.FindByType.UserId));
        }

        private void MapToGridView(User user)
        {
            if (CommonValidation.IsDataTableEmpty(_usersDataTable))
            {
                return;
            }

            DataRow row = _usersDataTable.AsEnumerable().FirstOrDefault(r => r.Field<int>("UserID") == user.UserId);
            GenericOperations.MapRecordsToGridView(row, DgvUsers, _usersDataTable, LblRecords, user);
        }

        private void CbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            _filterName = CommonValidation.GetFilterName(CbFilterBy);
            CommonValidation.ResetFilterOnIndexChange(_usersDataTable, CbFilterBy, TxtFilter, CbIsActive);
            CommonValidation.UpdateRecordCount(DgvUsers, LblRecords);
        }

        private void TxtFilter_TextChanged(object sender, EventArgs e)
        {
            if (!CommonValidation.AllowFilter(TxtFilter, CbFilterBy, _usersDataTable))
            {
                CommonValidation.ResetFilterView(_usersDataTable);
                CommonValidation.UpdateRecordCount(DgvUsers, LblRecords);
                return;
            }

            if (_filterName == "UserID")
                _usersDataTable.DefaultView.RowFilter = $"[{_filterName}] = {int.Parse(TxtFilter.Text.Trim())}";
            else
                _usersDataTable.DefaultView.RowFilter = $"[{_filterName}] LIKE '{TxtFilter.Text.Trim()}%'";

            CommonValidation.UpdateRecordCount(DgvUsers, LblRecords);
        }

        private void CbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CommonValidation.IsDataTableEmpty(_usersDataTable))
                return;

            string value = CbIsActive.Text == "Active" ? "1" : "0";
            _usersDataTable.DefaultView.RowFilter = CbIsActive.Text == "All" ? "" : $"[{_filterName}] = {value}";
            CommonValidation.UpdateRecordCount(DgvUsers, LblRecords);
        }

        private void ViewPersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int personId = (int)DgvUsers.CurrentRow.Cells["PersonID"].Value;

            if (GlobalContext.CurrentUser.PersonId != personId && !CommonValidation.HandlePermissions(User.Permissions.ManagePeople))
                return;

            ViewPersonCardInfoForm viewPersonCardInfoForm = new ViewPersonCardInfoForm(personId);
            viewPersonCardInfoForm.ShowDialog();

            Person person = Person.FindById(personId);
            DataRow row = _usersDataTable.AsEnumerable().FirstOrDefault(r => r.Field<int>("PersonID") == person.PersonId);
            GenericOperations.MapRecordsToGridView(row, DgvUsers, _usersDataTable, LblRecords, person);
        }

        private void HandleNewUserAdded(object sender, int userId) => ReloadRecords(userId);

        private void AddNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManageUsers))
                return;

            AddUpdateUserForm addUpdateUserForm = new AddUpdateUserForm();
            addUpdateUserForm.NotifyOnSaveSuccess += HandleNewUserAdded;
            addUpdateUserForm.ShowDialog();
            addUpdateUserForm.NotifyOnSaveSuccess -= HandleNewUserAdded;
        }

        private void ViewUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int userId = (int)DgvUsers.CurrentRow.Cells["UserID"].Value;

            if (GlobalContext.CurrentUser.UserId != userId && !CommonValidation.HandlePermissions(User.Permissions.ManageUsers))
                return;

            ViewUserCardForm viewUserCardForm = new ViewUserCardForm(userId);
            viewUserCardForm.ShowDialog();
            ReloadRecords(userId);
        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManageUsers))
                return;

            AddUpdateUserForm addUpdateUserForm = new AddUpdateUserForm();
            addUpdateUserForm.NotifyOnSaveSuccess += HandleNewUserAdded;
            addUpdateUserForm.ShowDialog();
            addUpdateUserForm.NotifyOnSaveSuccess -= HandleNewUserAdded;
        }

        private void DeactivateAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int userId = (int)DgvUsers.CurrentRow.Cells["UserID"].Value;
            bool isActive = (bool)DgvUsers.CurrentRow.Cells["IsActive"].Value;

            if (GlobalContext.IsLoggedInUser(userId))
            {
                MessageBox.Show("Cannot deactivate current user", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (GlobalContext.CurrentUser.UserId != userId && !CommonValidation.HandlePermissions(User.Permissions.ManageUsers))
                return;

            if (!isActive)
            {
                MessageBox.Show("User is already deactivated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Deactivate this account?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (User.Deactivate(userId))
            {
                MessageBox.Show("Account deactivated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ReloadRecords(userId);
            }
            else
                MessageBox.Show("Deactivation failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ActivateAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int userId = (int)DgvUsers.CurrentRow.Cells["UserID"].Value;
            bool isActive = (bool)DgvUsers.CurrentRow.Cells["IsActive"].Value;

            if (GlobalContext.CurrentUser.UserId != userId && !CommonValidation.HandlePermissions(User.Permissions.ManageUsers))
                return;

            if (isActive)
            {
                MessageBox.Show("User is already active", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Activate this account?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (User.Activate(userId))
            {
                MessageBox.Show("Account activated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ReloadRecords(userId);
            }
            else
            {
                MessageBox.Show("Activation failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int userId = (int)DgvUsers.CurrentRow.Cells["UserID"].Value;

            if (MessageBox.Show("Delete this user?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (GlobalContext.IsLoggedInUser(userId))
            {
                MessageBox.Show("Cannot delete current user", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!CommonValidation.HandlePermissions(User.Permissions.ManageUsers))
                return;

            if (User.DeleteUser(userId))
            {
                MessageBox.Show("User deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GenericOperations.DeleteRecord(_usersDataTable, DgvUsers, LblRecords, userId, "UserID");
            }
            else
            {
                MessageBox.Show("Delete failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int userId = (int)DgvUsers.CurrentRow.Cells["UserID"].Value;

            if (GlobalContext.CurrentUser.UserId != userId && !CommonValidation.HandlePermissions(User.Permissions.ManageUsers))
                return;

            AddUpdateUserForm addUpdateUserForm = new AddUpdateUserForm(userId);
            addUpdateUserForm.ShowDialog();
            ReloadRecords(userId);
        }

        private void ChangePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int userId = (int)DgvUsers.CurrentRow.Cells["UserID"].Value;

            if (GlobalContext.CurrentUser.UserId != userId && !CommonValidation.HandlePermissions(User.Permissions.ManageUsers))
                return;

            ChangePasswordForm changePasswordForm = new ChangePasswordForm(userId);
            changePasswordForm.ShowDialog();
        }

        private void DgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int userId = (int)DgvUsers.CurrentRow.Cells["UserID"].Value;

            ViewUserCardForm viewUserCardForm = new ViewUserCardForm(userId);
            viewUserCardForm.ShowDialog();
            ReloadRecords(userId);
        }

        private void CallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CbFilterBy_KeyPress(object sender, KeyPressEventArgs e) => CommonValidation.LockEditingControl(e);

        private void TxtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_filterName == "UserID")
                CommonValidation.EnableOnlyDigits(e);
        }

        private void CmsUser_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            CmsUser.Enabled = DgvUsers.Rows.Count > 0;
        }

        private void BtnClose_Click(object sender, EventArgs e) => Close();

    }
}