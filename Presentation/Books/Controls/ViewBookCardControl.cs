using BusinessLogic;
using LibrarySystem.Common;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace LibrarySystem.Books.Controls
{
    public partial class ViewBookCardControl : BaseUserControl
    {
        private Book _selectedBook;

        public Book SelectedBook => _selectedBook;

        public ViewBookCardControl()
        {
            InitializeComponent();
        }

        private void ResetDefaultFields()
        {
            LblBookId.Text = "[Not Set]";
            LblIsbn.Text = "[Not Set]";
            LblPublicationDate.Text = "[Not Set]";
            LblTotalCopies.Text = "[Not Set]";
            LblAuthor.Text = "[Not Set]";
        }

        private bool HandleEmptyBook()
        {
            if (_selectedBook == null)
            {
                MessageBox.Show("Book not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetDefaultFields();
                return false;
            }

            return true;
        }

        private void PopulateBookInfo()
        {
            LblBookId.Text = _selectedBook.BookId.ToString();
            LblIsbn.Text = _selectedBook.Isbn;
            LblPublicationDate.Text = _selectedBook.PublicationDate.ToShortDateString();
            LblTotalCopies.Text = _selectedBook.TotalCopies().ToString();
            LblAuthor.Text = _selectedBook.AuthorName;
        }

        public void LoadBookInfo(int bookId)
        {
            _selectedBook = Book.FindBookById(bookId);

            if (!HandleEmptyBook())
                return;

            PopulateBookInfo();
        }

        public void LoadBookInfoByCategoryId(int categoryId)
        {
            _selectedBook = Book.FindBookByCategoryId(categoryId);

            if (_selectedBook == null)
            {
                MessageBox.Show("No book found for this category", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetDefaultFields();
                return;
            }

            PopulateBookInfo();
        }

        private void LnkUpdate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManageBooks))
                return;

            AddUpdateBookForm addUpdateBookForm = new AddUpdateBookForm(_selectedBook.BookId);
            addUpdateBookForm.ShowDialog();
            LoadBookInfo(_selectedBook.BookId);
        }
    }
}