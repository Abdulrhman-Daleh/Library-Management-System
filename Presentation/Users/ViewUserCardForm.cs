using Business;
using BusinessLogic;
using LibrarySystem.BorrowFinePayments;
using LibrarySystem.BorrowingBookCopy;
using LibrarySystem.Common;
using LibrarySystem.Login;
using LibrarySystem.Members;
using LibrarySystem.Memberships;
using LibrarySystem.People;
using Presentation.Properties;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;



namespace LibrarySystem.Users
{
    public partial class ViewUserCardForm : BaseForm
    {
        private int _userId;
        private User _userAccount { get; set; }

        public Action NotifyIfUpdateSuccess { get; set; }

        public ViewUserCardForm(int userId)
        {
            InitializeComponent();
            _userId = userId;
            _userAccount = User.FindUserById(userId);
        }

        private StateControlInformation UserStateInfo(int userId)
        {
            StateControlInformation stateInfo = new StateControlInformation();
            stateInfo.Images = new List<Image>() { Resources.Borrow_Book_32, Resources.Damaged_Book_32, Resources.Money_Bag_32, Resources.Star_32 };

            stateInfo.LinesLables = new List<string>() { "Borrowed", "Overdue", "Fines", "Standing" };

            stateInfo.LinesValues = new List<string>() { BorrowTransaction.GetTotalBorrowedTransactionForMember(userId).ToString(),
            BorrowTransaction.GetTotalOverdueTransactionForMember(userId).ToString(), Fine.GetAllUnpaidFinesAmount(userId).ToString()};

            return stateInfo;

        }

        private void ViewUserCardForm_Load(object sender, EventArgs e)
        {
            viewUserCardControl.LoadUserById(_userId);
            memberCardControl.LoadMemberById(Member.GetMemberIDByUserID(_userId));
            personCardControl.LoadPersonById(viewUserCardControl.SelectedUser.PersonId);
            statsControl.LoadInfo(UserStateInfo(_userId));
            _SetDropdownStatus();
        }


        private void BtnClose_Click(object sender, EventArgs e) => Close();

        private void LnkEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddUpdateUserForm updateUserForm = new AddUpdateUserForm(_userId);
            updateUserForm.NotifyOnSaveSuccess += _ReloadUserInfo;
            updateUserForm.ShowDialog();
        }

        private void _ReloadUserInfo(object sender, int userId)
        {
            viewUserCardControl.LoadUserById(userId);
            statsControl.LoadInfo(UserStateInfo(userId));
            _SetDropdownStatus();
            NotifyIfUpdateSuccess?.Invoke();
        }

        private void LnkResetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangePasswordForm changePassword = new ChangePasswordForm(_userId);
            changePassword.ShowDialog();
        }

        private void _SetDropdownStatus()
        {
            if (!_userAccount.IsLocked())
                unlockAccountToolStripMenuItem.Visible = false;

            var member = Member.FindByUserId(_userId);

            if(member == null)
            {
                fineToolStripMenuItem.Visible = false;
                addMembershipToolStripMenuItem.Visible =  true;
                membershipInfoToolStripMenuItem.Visible = false;
                borrowHistoryToolStripMenuItem.Visible = false;
                

            }
            else
            {
                if(!member.HasGeneralFees())
                    fineToolStripMenuItem.Visible = false;

                if(!member.HasBorrowHistory())
                    borrowHistoryToolStripMenuItem.Visible = false;

                if (member.IsMembershipExpired())
                {
                    membershipInfoToolStripMenuItem.Visible = false;
                    addMembershipToolStripMenuItem.Visible = true;
                }
                else
                    addMembershipToolStripMenuItem.Visible = false;
            }
            

        }

        private void personProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewPersonCardInfoForm viewPersonCard = new ViewPersonCardInfoForm(_userAccount.PersonId);
            viewPersonCard.ShowDialog();
        }

        private void membershipInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewMembershipDetailsForm viewMembership = new ViewMembershipDetailsForm(Member.FindByUserId(_userId).MembershipTypeId);
            viewMembership.ShowDialog();
        }

        private void addMembershipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUpdateMemberForm addMember = new AddUpdateMemberForm();
            addMember.NotifyOnSaveSuccess += _ReloadMemberInfo;
            addMember.ShowDialog();
        }

        private void _ReloadMemberInfo(int memberId)
        {
            memberCardControl.LoadMemberById(memberId);
            _SetDropdownStatus();

        }

        private void borrowHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageBorrowedBookCopiesForm borrowedBookCopiesForm = new ManageBorrowedBookCopiesForm();
            borrowedBookCopiesForm.ShowDialog();
        }

        private void fineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageFinesForm fines = new ManageFinesForm();
            fines.ShowDialog();
        }

        private void unlockAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _userAccount.Activate();
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void deleteAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Person.IsCurrentLoggedInPerson(_userAccount.PersonId))
            {
                MessageBox.Show("Cannot delete current logged in user", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (GlobalContext.IsLoggedInUser(_userId))
            {
                MessageBox.Show("Cannot delete current user", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!CommonValidation.HandlePermissions(User.Permissions.ManageUsers))
                return;

            if (User.DeleteUser(_userId))
                MessageBox.Show("User deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Delete failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }
    }
}