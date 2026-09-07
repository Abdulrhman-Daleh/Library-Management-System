using Business;
using BusinessLogic;
using LibrarySystem.BorrowFinePayments;
using LibrarySystem.BorrowingBookCopy;
using LibrarySystem.Common;
using LibrarySystem.Members;
using LibrarySystem.Memberships;
using LibrarySystem.Users;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;

namespace LibrarySystem.People
{
    public partial class ViewPersonCardInfoForm : BaseForm
    {
        private User _userAccount { get; set; }

        private RelationalControlInformation _GetLeftPageInformation()
        {
            _userAccount = User.FindUserByPersonId(personCardControl.SelectedPerson.PersonId);
            RelationalControlInformation rightPageInformation = new RelationalControlInformation();

            if (_userAccount != null)
            {
                relationlControl1.LeftPageLink.Text = "View User";

                ViewUserCardForm viewUser = new ViewUserCardForm(_userAccount.UserId);
                viewUser.NotifyIfUpdateSuccess += _ReloadUserInfoAtViewMode;

                rightPageInformation = new RelationalControlInformation
                    ("Person Account Info",
                    "Account",
                    new List<string>() { _userAccount.Username, _userAccount.Permission.ToString(), _userAccount.IsActive ? "Active" : "InActive" },
                    new List<string>() { "Username", "Permission", "Status" },
                    new List<Image>() { Resources.User_32, Resources.Permisson_32, Resources.Login_32 },
                    () => viewUser.ShowDialog());
                return rightPageInformation;
            }
            else
            {
                relationlControl1.LeftPageLink.Text = "Create User";
                rightPageInformation.PageTitle = "Account Info";
                rightPageInformation.Title = "User";
                AddUpdateUserForm addUser = new AddUpdateUserForm();
                addUser.NotifyOnSaveSuccess += _ReloadUserInfoAfterSave;
                rightPageInformation.OnClick = () => addUser.ShowDialog();
            }


            return rightPageInformation;
        }

        private RelationalControlInformation _GetRightPageInformation()
        {
            var user = User.FindUserByPersonId(personCardControl.SelectedPerson.PersonId);
            Member memberRecord;
            if (user != null)
            {
                memberRecord = Member.FindByUserId(user.UserId);
            }
            else
                memberRecord = Member.FindByUserId(-1);

            RelationalControlInformation rightPageInformation = new RelationalControlInformation();

            if (memberRecord != null)
            {
                relationlControl1.RightPageLink.Text = "View Member";

                rightPageInformation = new RelationalControlInformation
                    ("Member Info",
                    "Member",
                    new List<string>() { memberRecord.MembershipTypeInfo.MembershipTypeName, memberRecord.MemberId.ToString(), memberRecord.IsMembershipExpired() ? "Expired" : "Active", memberRecord.MembershipExpirationDate.ToShortDateString() },
                    new List<string>() { "Type", "ID", "Status", "Expires" },
                    new List<Image>() { Resources.Membership_32, Resources.ID_32, Resources.Status_32, Resources.Membership_32 },
                    () => new ViewMemberCardForm(memberRecord.MemberId).ShowDialog());
                return rightPageInformation;
            }
            else
            {
                relationlControl1.RightPageLink.Text = "Create Member";
                rightPageInformation.PageTitle = "Membership";
                rightPageInformation.Title = "Member Info";
                AddUpdateMemberForm addMember = new AddUpdateMemberForm();
                addMember.NotifyOnSaveSuccess += AddMember_NotifyOnSaveSuccess;
                rightPageInformation.OnClick = () => addMember.ShowDialog();
            }


            return rightPageInformation;
        }

        private void _ReloadUserInfoAtViewMode() => relationlControl1.SetLeftPage(_GetLeftPageInformation());

        private void _ReloadUserInfoAfterSave(object sender, int userId) => relationlControl1.SetLeftPage(_GetLeftPageInformation());

        private void AddMember_NotifyOnSaveSuccess(int memberId) => relationlControl1.SetRightPage(_GetRightPageInformation());

        public ViewPersonCardInfoForm(int personId)
        {
            InitializeComponent();
            personCardControl.LoadPersonById(personId);
            relationlControl1.SetLeftPage(_GetLeftPageInformation());
            relationlControl1.SetRightPage(_GetRightPageInformation());
            _SetDropdownStatus();
        }

        private void BtnClose_Click(object sender, EventArgs e) => Close();

        private void LinkEdit_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            AddUpdatePersonForm updatePerson = new AddUpdatePersonForm(personCardControl.SelectedPerson.PersonId);
            updatePerson.NotifyOnSaveSuccess += _ReloadPersonInfoAfterSave;
            updatePerson.ShowDialog();
        }

        private void _ReloadPersonInfoAfterSave(object sender, int personId) => personCardControl.LoadPersonById(personId);

        private void LnkCreateUser_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            AddUpdateUserForm addUpdateUser = new AddUpdateUserForm();
            addUpdateUser.NotifyOnSaveSuccess += _ReloadUserInfoAfterSave;
            addUpdateUser.ShowDialog();
        }

        private void LnkCreateMembership_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            AddUpdateMemberForm addUpdateMember = new AddUpdateMemberForm();
            addUpdateMember.NotifyOnSaveSuccess += _RelodateMemberInfo;
            addUpdateMember.ShowDialog();   
        }

        private void _RelodateMemberInfo(int memberId) => relationlControl1.SetRightPage(_GetRightPageInformation());

        private void userAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewUserCardForm userCardForm = new ViewUserCardForm(_userAccount.UserId);
            userCardForm.ShowDialog();
        }

        private void membershipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewMembershipDetailsForm membershipDetailsForm = new ViewMembershipDetailsForm(Member.FindByUserId(_userAccount.UserId).MembershipTypeId);

            membershipDetailsForm.ShowDialog();
        }

        private void borrowHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageBorrowedBookCopiesForm borrows = new ManageBorrowedBookCopiesForm();
            borrows.ShowDialog();
        }

        private void finesPaymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageFinesForm fines = new ManageFinesForm();
            fines.ShowDialog();
            fines.ShowDialog();
        }

        private void deletePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to delete this person y/n?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            int personId = personCardControl.SelectedPerson.PersonId;

            if (!CommonValidation.HandlePermissions(User.Permissions.ManagePeople))
                return;

            if (Person.IsCurrentLoggedInPerson(personId))
            {
                MessageBox.Show("Cannot delete current user's person", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (Person.Delete(personId))
            {
                Console.WriteLine("Person got deleted successfully app is going to close");
                Application.Exit();
            }
            else
                Console.WriteLine("Failed to delete person");
        }

        private void _SetDropdownStatus()
        {
            if (GenericOperations.IsEmptyObject(_userAccount))
            {
                userAccountToolStripMenuItem.Enabled = false;
                return;
            }

            if (_userAccount.IsUserAMember())
            {
                membershipToolStripMenuItem.Enabled = true;

                var member = Member.FindByUserId(_userAccount.UserId);

                if (member.HasBorrowHistory())
                    borrowHistoryToolStripMenuItem.Enabled = true;


                if (member.HasGeneralFees())
                    finesPaymentsToolStripMenuItem.Enabled = true;
            }

        }

    }
}