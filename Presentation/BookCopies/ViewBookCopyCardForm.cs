using Business;
using BusinessLogic;
using LibrarySystem.Books;
using LibrarySystem.Books.Controls;
using LibrarySystem.BorrowingBookCopy;
using LibrarySystem.Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;


namespace LibrarySystem.BookCopies
{
    public partial class ViewBookCopyCardForm : BaseForm
    {
        private int _bookCopyId;
        public ViewBookCopyCardForm(int bookCopyId)
        {
            InitializeComponent();
            _bookCopyId = bookCopyId;
            viewBookCopyCardControl.LoadByBookCopyId(bookCopyId);
            relationlControl1.SetLeftPage(_GetLeftPageInformation());
            relationlControl1.SetRightPage(_GetRightPageInformation());
        }

        private RelationalControlInformation _GetLeftPageInformation()
        {
            RelationalControlInformation leftPageInformation = new RelationalControlInformation();

            BookCopy bookCopy = BookCopy.FindBookCopyById(_bookCopyId);
            if (bookCopy != null)
            {
                relationlControl1.LeftPageLink.Text = "View Copy";

                relationlControl1.RightPageLink.Visible = false;

                leftPageInformation = new RelationalControlInformation
                    ("View book copy",
                    "Book Copy",
                    new List<string>() { bookCopy.BookCopyId.ToString(), bookCopy.GetConditionText(), bookCopy.BookCopyPrice.ToString() },
                    new List<string>() { "Copy Id", "Condition", "Price" },
                    new List<Image>() { Resources.Book_Copy_32, Resources.Status_32, Resources.Money_Bag_32 },
                    () => new ViewBookCopyCardForm(bookCopy.BookCopyId).ShowDialog());
                return leftPageInformation;
            }
            else
            {
                relationlControl1.LeftPageLink.Text = "Add Copy";
                leftPageInformation.PageTitle = "insert copy info";
                leftPageInformation.Title = "Add copy";
                leftPageInformation.OnClick = () => new AddUpdateBookCopyForm().ShowDialog();
            }


            return leftPageInformation;
        }

        private RelationalControlInformation _GetRightPageInformation()
        {
            RelationalControlInformation rightPageInformation = new RelationalControlInformation();
            BorrowTransaction borrowTransaction = BorrowTransaction.FindByBookCopyId(_bookCopyId);


            if (!GenericOperations.IsEmptyObject(borrowTransaction))
            {
                relationlControl1.RightPageLink.Text = "View Book";
                
                rightPageInformation = new RelationalControlInformation
                    ("Category info",
                    "Category",
                    new List<string>() {borrowTransaction.BorrowId.ToString(), borrowTransaction.BorrowStatus.ToString(), borrowTransaction.BookCopyInfo.GetConditionText(), borrowTransaction.DueDate.ToShortDateString()},
                    new List<string>() { "Borrow Id", "Status", "Condition", "Due Date" },
                    new List<Image>() { Resources.Borrow_Book_32, Resources.Status_32, Resources.View_32, Resources.Calendar_32 },
                    () => new ViewBookCardForm(borrowTransaction.BookCopyInfo.OriginalBook.BookId).ShowDialog());
                return rightPageInformation;
            }
            else
            {
                relationlControl1.RightPageLink.Visible = true;
                relationlControl1.RightPageLink.Text = "Borrow copy";
                rightPageInformation.PageTitle = "borrowing book copy";
                rightPageInformation.Title = "Not Borrowed";  
                rightPageInformation.OnClick = () => new BorrowBookCopyForm(BorrowTransaction.StatusType.Borrow).ShowDialog();
            }


            return rightPageInformation;
        }

        private void BtnClose_Click(object sender, EventArgs e) => Close();

        private void LnkUpdate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddUpdateBookCopyForm updateCopy = new AddUpdateBookCopyForm(_bookCopyId);
            updateCopy.ShowDialog();
        }

        private void LnkAddCopy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddUpdateBookCopyForm addCopy = new AddUpdateBookCopyForm();
            addCopy.ShowDialog();
        }
    }
}