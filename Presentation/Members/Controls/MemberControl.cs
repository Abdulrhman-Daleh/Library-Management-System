using BusinessLogic;
using LibrarySystem.Common;
using LibrarySystem.Users;
using System;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace LibrarySystem.Members.Controls
{
    public partial class MemberCardControl : BaseUserControl
    {
        private Member _selectedMember;

        public MemberCardControl()
        {
            InitializeComponent();
        }

        private void InitializeEmptyState()
        {
            LblMemberID.Text = "[Not Set]";
            LblMemberJoinDate.Text = "[??/??/????]";
            LblMembershipExpirationDate.Text = "[??/??/????]";
            LblMembershipTypeName.Text = "[??????]";
            LblDaysLeft.Text = "[Not Set]";
            pBarRemaining.Value = 0;
        }

        private void BindMemberData()
        {
            if (_selectedMember == null)
                return;

            LblMemberID.Text = _selectedMember.MemberId.ToString() ?? "Unknown";
            LblMemberJoinDate.Text = _selectedMember.MemberJoinDate.ToShortDateString();
            LblMembershipTypeName.Text = MembershipType.FindById(_selectedMember.MembershipTypeId)?.MembershipTypeName ?? "None";
            LblMembershipExpirationDate.Text = _selectedMember.MembershipExpirationDate.ToShortDateString();
            LblDaysLeft.Text = Convert.ToInt32(_selectedMember.MembershipExpirationDate.Subtract(DateTime.Now).TotalDays).ToString() + " Days";
            int Days = Convert.ToInt32(LblDaysLeft.Text.Substring(0, LblDaysLeft.Text.Length - 5));
            pBarRemaining.Value = Days > 100 ? 100 : Days;
        }

        public void LoadMemberById(int memberId)
        {
            _selectedMember = Member.FindByMemberId(memberId);

            if (_selectedMember == null)
            {
                MessageBox.Show("Member not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                InitializeEmptyState();
                return;
            }

            BindMemberData();
        }

        private void LnkUpdateUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_selectedMember == null)
                return;

            if (GlobalContext.CurrentUser.UserId != _selectedMember.UserId && !CommonValidation.HandlePermissions(User.Permissions.ManageUsers))
                return;

            AddUpdateUserForm addUpdateUserForm = new AddUpdateUserForm(_selectedMember.UserId);
            addUpdateUserForm.ShowDialog();
            LoadMemberById(_selectedMember.MemberId);
        }

        private void LnkUpdateMember_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_selectedMember == null)
                return;

            if (GlobalContext.CurrentMember.MemberId != _selectedMember.MemberId && !CommonValidation.HandlePermissions(User.Permissions.ManageMembers))
                return;

            AddUpdateMemberForm addUpdateMemberForm = new AddUpdateMemberForm(_selectedMember.MemberId);
            addUpdateMemberForm.ShowDialog();
            LoadMemberById(_selectedMember.MemberId);
        }
    }
}