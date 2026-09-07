using Business;
using BusinessLogic;
using LibrarySystem.BookCopies;
using LibrarySystem.Members;
using LibrarySystem.People;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;


namespace LibrarySystem.BorrowingBookCopy
{
    public partial class ViewBookBorrowDetailsForm : BaseForm
    {
        private readonly BorrowTransaction _borrowDetails;

        private RelationalControlInformation _GetLeftPageInformation()
        {
            BookCopy bookCopy = BookCopy.FindBookCopyById(_borrowDetails.BookCopyId);
            RelationalControlInformation rightPageInformation = new RelationalControlInformation();

            if (bookCopy != null)
            {
                relationlControl1.LeftPageLink.Text = "View Book";


                rightPageInformation = new RelationalControlInformation
                    ("book copy",
                    "copy",
                    new List<string>() { bookCopy.BookCopyId.ToString(), bookCopy.OriginalBook.AuthorName, bookCopy.GetConditionText() },
                    new List<string>() { "Copy id", "Author", "Condition" },
                    new List<Image>() { Resources.Book_Copy_32, Resources.Person_32, Resources.Status_32 },
                    () => new ViewBookCopyCardForm(bookCopy.BookCopyId).ShowDialog());
                return rightPageInformation;
            }
            else
            {
                relationlControl1.LeftPageLink.Text = "Add Copy";
                rightPageInformation.PageTitle = "Add New Copy";
                rightPageInformation.Title = "Book Copy";
                rightPageInformation.OnClick = () => new AddUpdateBookCopyForm().ShowDialog();
            }


            return rightPageInformation;
        }

        private RelationalControlInformation _GetRightPageInformation()
        {
            RelationalControlInformation rightPageInformation = new RelationalControlInformation();

            if (_borrowDetails.MemberInfo != null)
            {
                relationlControl1.RightPageLink.Text = "View Member";


                rightPageInformation = new RelationalControlInformation
                    ("Member Info",
                    "Member",
                    new List<string>() { _borrowDetails.MemberInfo.MembershipTypeInfo.MembershipTypeName, _borrowDetails.MemberInfo.MemberId.ToString(), _borrowDetails.MemberInfo.IsMembershipExpired() ? "Expired" : "Active", _borrowDetails.MemberInfo.MembershipExpirationDate.ToShortDateString() },
                    new List<string>() { "Type", "ID", "Status", "Expires" },
                    new List<Image>() { Resources.Membership_32, Resources.ID_32, Resources.Status_32, Resources.Membership_32 },
                    () => new ViewMemberCardForm(_borrowDetails.MemberInfo.MemberId).ShowDialog());
                return rightPageInformation;
            }
            else
            {
                relationlControl1.RightPageLink.Text = "Create Member";
                rightPageInformation.PageTitle = "Membership";
                rightPageInformation.Title = "Member Info";
                rightPageInformation.OnClick = () => new AddUpdateMemberForm().ShowDialog();
            }


            return rightPageInformation;
        }

        public ViewBookBorrowDetailsForm(int borrowId)
        {
            InitializeComponent();
            _borrowDetails = BorrowTransaction.FindByBorrowId(borrowId);
            relationlControl1.SetLeftPage(_GetLeftPageInformation());
            relationlControl1.SetRightPage(_GetRightPageInformation());
            viewBorrowDetailsControl1.LoadBorrowedBookDetails(_borrowDetails.BorrowId);
        }

        private void BtnClose_Click(object sender, EventArgs e) => Close();

        private void LnkReturnBook_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BorrowBookCopyForm returnCopy = new BorrowBookCopyForm(_borrowDetails.BorrowId, BorrowTransaction.StatusType.Return);
            returnCopy.ShowDialog();
        }

        private void LnkMarkLostBook_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BorrowBookCopyForm lostCopy = new BorrowBookCopyForm(_borrowDetails.BorrowId, BorrowTransaction.StatusType.Lost);
            lostCopy.ShowDialog();
        }
    }
}