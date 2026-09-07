using BusinessLogic;
using LibrarySystem.Common;
using System;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace LibrarySystem.Users.Controls
{
    public partial class FindAcountcontrol : BaseUserControl
    {
        public class UserEventArgs : EventArgs
        {
            public User SelectedUser { get; }
            public UserEventArgs(User user) => SelectedUser = user;
        }

        public event EventHandler<UserEventArgs> OnUserSelected;

        public bool EnableSearchSection
        {
            get
            {
                return GbFilter.Enabled;
            }
            set
            {
                GbFilter.Enabled = value;
            }
        }

        public FindAcountcontrol()
        {
            InitializeComponent();
            CbFilters.SelectedIndex = 1;
        }

        public void PublishUserInfo(User user) => OnUserSelected?.Invoke(this, new UserEventArgs(user));

        public void SetFilterFocus(string value)
        {
            TxtFilterBy.Text = value;
            TxtFilterBy.Select();
        }

        public void LoadData(object sender, int userId) => _ReceiveUserId(sender, userId);

        private void _ReceiveUserId(object sender, int userId)
        {
            CbFilters.SelectedIndex = 1;
            SetFilterFocus(userId.ToString());
            _ExecuteSearch();
        }

        private bool CanExecuteSearch()
        {
            if (string.IsNullOrEmpty(TxtFilterBy.Text))
            {
                MessageBox.Show("Cannot search with empty filter", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                accountControl.ResetDefaultFields();
                return false;
            }

            return true;
        }

        private void _ExecuteSearch()
        {
          if (!CanExecuteSearch())
              return;
        
          switch (CbFilters.Text)
          {
              case "Person ID":
                    accountControl.LoadUserByPersonId(int.Parse(TxtFilterBy.Text.Trim()));
                  break;
              case "User ID":
                    accountControl.LoadUserById(int.Parse(TxtFilterBy.Text.Trim()));
                  break;
          }
        
          PublishUserInfo(accountControl.SelectedUser);
        }

        private void TxtFilterBy_KeyPress(object sender, KeyPressEventArgs e) => CommonValidation.EnableOnlyDigits(e);

        private void CbFilters_SelectedIndexChanged(object sender, EventArgs e) => TxtFilterBy.Text = "";

        private void CbFilters_KeyPress(object sender, KeyPressEventArgs e) => CommonValidation.LockEditingControl(e);

        private void BtnFind_Click(object sender, EventArgs e)
        {
            _ExecuteSearch();
        }

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            AddUpdateUserForm frm = new AddUpdateUserForm();
            frm.NotifyOnSaveSuccess += _ReceiveUserId;
            frm.Show();
        }
    }
}