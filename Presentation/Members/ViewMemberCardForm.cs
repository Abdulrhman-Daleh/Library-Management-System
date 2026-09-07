using Business;
using BusinessLogic;
using LibrarySystem.BorrowFinePayments;
using LibrarySystem.BorrowingBookCopy;
using LibrarySystem.FinePayments;
using LibrarySystem.Memberships;
using LibrarySystem.People;
using LibrarySystem.Users;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1.MembershipRenewals;
using WindowsFormsApp1.Properties;

namespace LibrarySystem.Members
{
    public partial class ViewMemberCardForm : BaseForm
    {
        private Member _member { get; set; }

        private StateControlInformation _GetMemberStateInfo()
        {
            StateControlInformation stateInfo = new StateControlInformation();
            stateInfo.Images = new List<Image>() { Resources.Borrow_Book_32, Resources.Damaged_Book_32, Resources.Money_Bag_32, Resources.Star_32 };

            stateInfo.LinesLables = new List<string>() { "Borrowed", "Overdue", "Fines", "Standing" };

            stateInfo.LinesValues = new List<string>() { BorrowTransaction.GetTotalBorrowedTransactionForMember(_member.MemberId).ToString(),
            BorrowTransaction.GetTotalOverdueTransactionForMember(_member.MemberId).ToString(), Fine.GetAllUnpaidFinesAmount(_member.MemberId).ToString()}; ;

            return stateInfo;
        }

        public ViewMemberCardForm(int memberId)
        {
            InitializeComponent();
            _member = Member.FindByMemberId(memberId);
            if (_member != null)
            {
                memberCardControl.LoadMemberById(memberId);
                personCardControl1.LoadPersonById(_member.UserInfo.PersonId);
                statsControl1.LoadInfo(_GetMemberStateInfo());
            }
        }

        private void BtnClose_Click(object sender, EventArgs e) => Close();

        private void LnkRenew_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddUpdateMemberForm renewMembership = new AddUpdateMemberForm(_member.MemberId);
            renewMembership.NotifyOnSaveSuccess += _ReloadMemberOnSave;
            renewMembership.ShowDialog();
        }

        private void _ReloadMemberOnSave(int memberId)
        {
            memberCardControl.LoadMemberById(memberId);
            statsControl1.LoadInfo(_GetMemberStateInfo());
        }

        private void personProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUpdatePersonForm addPerson = new AddUpdatePersonForm(_member.UserInfo.PersonId);
            addPerson.ShowDialog();
        }

        private void userAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewUserCardForm viewUser = new ViewUserCardForm(_member.UserId);
            viewUser.ShowDialog();
        }

        private void borrowHisoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageBorrowedBookCopiesForm manageBorrowedBook = new ManageBorrowedBookCopiesForm();
            manageBorrowedBook.ShowDialog();
        }

        private void finToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageFinesForm manageFines = new ManageFinesForm();
            manageFines.ShowDialog();
        }
    }
}