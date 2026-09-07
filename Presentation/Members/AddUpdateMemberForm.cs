using BusinessLogic;
using LibrarySystem.Common;
using LibrarySystem.Users.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace LibrarySystem.Members
{
    public partial class AddUpdateMemberForm : BaseForm
    {
        private Member _currentMember;

        public delegate void OnNewMemberAddedHandler(int memberId);
        public event OnNewMemberAddedHandler NotifyOnSaveSuccess;

        public AddUpdateMemberForm()
        {
            InitializeComponent();
            _currentMember = new Member();
            findUserByFilterControl.SetFilterFocus("");
            findUserByFilterControl.EnableSearchSection = true;
        }

        public AddUpdateMemberForm(int memberId)
        {
            InitializeComponent();
            _currentMember = Member.FindByMemberId(memberId);
            findUserByFilterControl.LoadData(this, _currentMember.UserId);
            findUserByFilterControl.EnableSearchSection = false;
        }

        private void LoadMemberForUpdate()
        {
            LblTitle.Text = "Update Member";
            this.Text = "Update Member Info";

            if (_currentMember == null)
            {
                MessageBox.Show("Member not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!_currentMember.IsMembershipExpired())
            {
                MessageBox.Show("Membership is not expired", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BtnSave.Enabled = false;
                BtnNext.Enabled = false;
            }

            tpAddMember.Text = "Update Member";
            LblMemberId.Text = _currentMember.MemberId.ToString();
            CbMembershipTypes.SelectedIndex = CbMembershipTypes.FindString(_currentMember.MembershipTypeInfo.MembershipTypeName);
            findUserByFilterControl.EnableSearchSection = false;
            TbPages.TabPages["tpAddMember"].Enabled = _currentMember.IsMembershipExpired();
        }

        private void LoadMembershipTypes(List<string> memberships)
        {
            foreach (string membership in memberships)
                CbMembershipTypes.Items.Add(membership);
        }

        private void InitializeAddMode()
        {
            LblTitle.Text = "Add Member";
            this.Text = "Add New Member";
            TbPages.TabPages["tpAddMember"].Enabled = false;
            CbMembershipTypes.SelectedIndex = 0;
        }

        private void GetData(object sender, FindAcountcontrol.UserEventArgs e)
        {
            if (e.SelectedUser == null)
                return;


            if (e.SelectedUser.IsUserAMember())
            {
                MessageBox.Show("User is already a member", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _currentMember.UserInfo = e.SelectedUser;
            _currentMember.UserId = e.SelectedUser.UserId;
        }

        private void AddUpdateMemberForm_Load(object sender, EventArgs e)
        {
            List<string> membershipTypeNames = MembershipType.GetMembershipTypeNames();
            LoadMembershipTypes(membershipTypeNames);

            InitializeAddMode();
            findUserByFilterControl.OnUserSelected += GetData;

            if (_currentMember.CurrentMode == Member.ModeType.Update)
                LoadMemberForUpdate();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (_currentMember.UserInfo == null)
            {
                MessageBox.Show("Select a user first", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TbPages.SelectedTab = TbPages.TabPages["tpAddMember"];
            TbPages.TabPages["tpAddMember"].Enabled = true;
        }

        private bool IsMembershipEmpty() => _currentMember.MembershipTypeInfo == null;

        private void CbMembershipTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbMembershipTypes.SelectedItem != null)
            {
                MembershipType selected = MembershipType.FindByName(CbMembershipTypes.SelectedItem.ToString());
                if (selected != null)
                    LblMembershipTypeFees.Text = selected.MembershipFees.ToString();
            }
        }

        private void BtnPrevious_Click(object sender, EventArgs e) => TbPages.SelectedTab = TbPages.TabPages["tbLinkUser"];

        private void MapMemberDataFromUi()
        {
            if (_currentMember.CurrentMode == Member.ModeType.Add)
            {
                _currentMember.MembershipTypeInfo = new MembershipType();
                _currentMember.MemberJoinDate = DateTime.Now;
                _currentMember.MembershipExpirationDate = DateTime.Now.AddMonths(1);
                _currentMember.MembershipTypeId = MembershipType.FindByName(CbMembershipTypes.Text.Trim()).MembershipTypeId;
            }
            else
            {
                _currentMember.MembershipTypeId = MembershipType.FindByName(CbMembershipTypes.Text.Trim()).MembershipTypeId;
            }
        }

        private void RaiseEvent(int memberId) => NotifyOnSaveSuccess?.Invoke(memberId);

        private void ShowSaveSuccess()
        {
            MessageBox.Show("Data saved successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LblMemberId.Text = _currentMember.MemberId.ToString();
            this.Text = "Update Member Info";
            LblTitle.Text = "Update Member";
            findUserByFilterControl.EnableSearchSection = false;
        }

        private void _SetCurrentMemberAccount()
        {
            if (GlobalContext.CurrentMember == null)
            {
                GlobalContext.CurrentMember = _currentMember;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (CommonValidation.HasValidationErrors(tpAddMember.Controls, errorProvider, this))
            {
                MessageBox.Show("Form is not valid", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MapMemberDataFromUi();

            if (IsMembershipEmpty())
            {
                MessageBox.Show("Membership type is required", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_currentMember.Save())
            {
                RaiseEvent(_currentMember.MemberId);
                ShowSaveSuccess();
                _SetCurrentMemberAccount();
                Close();
            }
            else
            {
                MessageBox.Show("Failed to save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e) => Close();

        private void CbMembershipTypes_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = string.IsNullOrEmpty(CbMembershipTypes.Text.Trim());
        }

    }
}