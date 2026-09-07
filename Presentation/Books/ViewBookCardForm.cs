using Business;
using BusinessLogic;
using LibrarySystem.Books.Controls;
using LibrarySystem.Categories;
using LibrarySystem.People;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;


namespace LibrarySystem.Books
{
    public partial class ViewBookCardForm : BaseForm
    {
        private int _bookId;

        public ViewBookCardForm(int bookId)
        {
            InitializeComponent();
            _bookId = bookId;
            viewBookCardControl1.LoadBookInfo(bookId);
            relationlControl1.SetLeftPage(_GetLeftPageInformation());
            relationlControl1.SetRightPage(_GetRightPageInformation());
             
        }

        private RelationalControlInformation _GetLeftPageInformation()
        {
            RelationalControlInformation leftPageInformation = new RelationalControlInformation();

            if (viewBookCardControl1.SelectedBook != null)
            {
                relationlControl1.LeftPageLink.Text = "View Category";

                relationlControl1.RightPageLink.Visible = false;

                leftPageInformation = new RelationalControlInformation
                    ("book author",
                    "Author",
                    new List<string>() { viewBookCardControl1.SelectedBook.AuthorName, viewBookCardControl1.SelectedBook.Category.CategoryName, viewBookCardControl1.SelectedBook.Isbn },
                    new List<string>() { "Author", "Category", "Isbn" },
                    new List<Image>() { Resources.Person_32, Resources.Category_32, Resources.ISBN_32 },
                    () => new ViewCategoryCardForm(viewBookCardControl1.SelectedBook.Category.CategoryId).ShowDialog());
                return leftPageInformation;
            }
            else
            {
                relationlControl1.LeftPageLink.Text = "Create Book";
                leftPageInformation.PageTitle = "book info";
                leftPageInformation.Title = "Add Book";
                leftPageInformation.OnClick = () => new AddUpdateBookForm().ShowDialog();
            }


            return leftPageInformation;
        }

        private RelationalControlInformation _GetRightPageInformation()
        {
            RelationalControlInformation rightPageInformation = new RelationalControlInformation();

            if (viewBookCardControl1.SelectedBook != null && viewBookCardControl1.SelectedBook.Category != null)
            {
                relationlControl1.RightPageLink.Text = "View Category";

                rightPageInformation = new RelationalControlInformation
                    ("Category info",
                    "Category",
                    new List<string>() {viewBookCardControl1.SelectedBook.Category.CategoryName, viewBookCardControl1.SelectedBook.Category.GetCategoryDescription(), viewBookCardControl1.SelectedBook.CategoryId.ToString(), viewBookCardControl1.SelectedBook.BookId.ToString()},
                    new List<string>() { "Name", "Description", "Category Id", "Book Id" },
                    new List<Image>() { Resources.Category_32, Resources.Reason_32, Resources.ID_32, Resources.Book_32 },
                    () => new ViewCategoryCardForm(viewBookCardControl1.SelectedBook.CategoryId).ShowDialog());
                return rightPageInformation;
            }
            else
            {
                relationlControl1.RightPageLink.Text = "Create Member";
                rightPageInformation.PageTitle = "Membership";
                rightPageInformation.Title = "Member Info";
                rightPageInformation.OnClick = () => new AddUpdateCategoryForm().ShowDialog();
            }


            return rightPageInformation;
        }

        private void BtnClose_Click(object sender, EventArgs e) => Close();

        private void LnkUpdateBook_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddUpdateBookForm updateBook = new AddUpdateBookForm(_bookId);
            updateBook.ShowDialog();
        }

        private void LnkAddBook_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddUpdateBookForm addBook = new AddUpdateBookForm();
            addBook.ShowDialog();
        }
    }
}