using Business;
using BusinessLogic;
using LibrarySystem.Users;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;


namespace LibrarySystem.Memberships
{
    public partial class ViewMembershipDetailsForm : BaseForm
    {
        private int _membershipTypeId;
        MembershipType _membershipType;
        public ViewMembershipDetailsForm(int membershipTypeId)
        {
            InitializeComponent();
            _membershipTypeId = membershipTypeId;
            _membershipType = MembershipType.FindById(membershipTypeId);
            statsControl1.LoadInfo(_GetMembershipStateInfo());
        }

        private StateControlInformation _GetMembershipStateInfo()
        {
            StateControlInformation stateInfo = new StateControlInformation();
            stateInfo.Images = new List<Image>() { Resources.Person_32, Resources.Books_32, Resources.Money_Bag_32, Resources.Clock_32 };

            stateInfo.LinesLables = new List<string>() { "Members", "Borrowed", "Total", "Overdue" };

            stateInfo.LinesValues = new List<string>() { _membershipType.GetAllMembersCountInType().ToString(),
            _membershipType.GetAllBorrowedCountInType().ToString(), _membershipType.GetFinesAmountInType().ToString() };

            return stateInfo;
        }

        private void ViewMembershipDetailsForm_Load(object sender, EventArgs e)
        {
            _membershipType = MembershipType.FindById(_membershipTypeId);

            if (_membershipType == null)
            {
                MessageBox.Show("Membership type not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }
            viewMembershipCardControl1.LoadMembershipInformation(_membershipType);
        }

        private void BtnClose_Click(object sender, EventArgs e) => Close();

        private void LinkEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddUpdateMembershipForm updateMembershipForm = new AddUpdateMembershipForm(_membershipTypeId);
            updateMembershipForm.ShowDialog();
        }

        private void membersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageUsersForm manageUsers = new ManageUsersForm(_membershipTypeId);
            manageUsers.ShowDialog();
        }

        private void deleteTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this Membership type y/n?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            try
            {
                if (MembershipType.DeleteMembershipType(_membershipTypeId))
                {
                    MessageBox.Show("Membership got deleted successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Failed to delete membership", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show("membership is linked to other data it can't be deleted", "Invalid operation",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}