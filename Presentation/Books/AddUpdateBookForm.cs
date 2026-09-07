using BusinessLogic;
using LibrarySystem.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace LibrarySystem.Books
{
    public partial class AddUpdateBookForm : BaseForm
    {
        private Book _currentBook;
        private bool _saved;

        public class BookInfoEventArgs : EventArgs
        {
            public Book AddedBook { get; }
            public BookInfoEventArgs(Book book) => AddedBook = book;
        }

        public event EventHandler<BookInfoEventArgs> SendBookInfoOnSaveEvent;

        public AddUpdateBookForm()
        {
            InitializeComponent();
            _currentBook = new Book();
        }

        public AddUpdateBookForm(int bookId)
        {
            InitializeComponent();
            _currentBook = Book.FindBookById(bookId);
        }

        private void RaiseSendBookInfoEvent(Book book) => SendBookInfoOnSaveEvent?.Invoke(this, new BookInfoEventArgs(book));

        private bool IsBookCategoryListValid(List<string> categoryNames) => categoryNames != null;

        private void LoadBookCategories()
        {
            List<string> categoryNames = BookCategory.GetAllCategoryNames();

            if (IsBookCategoryListValid(categoryNames))
            {
                foreach (string categoryName in categoryNames)
                    CbCategories.Items.Add(categoryName);
            }
            else
            {
                MessageBox.Show("Failed to load book categories", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetUpdateBook()
        {
            LblTitle.Text = "Update Book";
            this.Text = "Update Book Info";
            LblBookId.Text = _currentBook.BookId.ToString();
            TxtIsbn.Text = _currentBook.Isbn;
            TxtAuthor.Text = _currentBook.AuthorName;
            CbCategories.SelectedIndex = CbCategories.FindString(_currentBook.Category.CategoryName);
            DtpPublicationDate.Value = _currentBook.PublicationDate;
        }

        private bool ValidateIfCategoriesAvailable()
        {
            if (CbCategories.Items.Count < 1)
            {
                MessageBox.Show("No book categories available", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BtnSave.Enabled = false;
                return false;
            }

            BtnSave.Enabled = true;
            return true;
        }

        private void SetupPage()
        {
            CbCategories.SelectedIndex = 0;
            LblTitle.Text = "Add New Book";
            this.Text = "Add New Book Info";
            DtpPublicationDate.MaxDate = DateTime.Now;
            DtpPublicationDate.MinDate = DateTime.Now.AddYears(-30);
            DtpPublicationDate.Value = DtpPublicationDate.MaxDate;
        }

        private void AddUpdateBookForm_Load(object sender, EventArgs e)
        {
            LoadBookCategories();

            if (!ValidateIfCategoriesAvailable())
                return;

            SetupPage();

            if (_currentBook.CurrentMode == Book.Mode.Update)
                SetUpdateBook();
        }

        private void TxtAuthor_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (string.IsNullOrEmpty(textBox.Text.Trim()))
                errorProvider.SetError(textBox, "Author name is required");
            else
                errorProvider.SetError(textBox, null);
        }

        private void TxtIsbn_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string isbn = textBox.Text.Trim();

            if (string.IsNullOrEmpty(isbn))
            {
                errorProvider.SetError(textBox, "ISBN is required");
                return;
            }

            errorProvider.SetError(textBox, null);

            if (CommonValidation.IsNotValidIsbn(isbn) && _currentBook.CurrentMode == Book.Mode.Add)
                errorProvider.SetError(textBox, "Invalid ISBN (already used or incorrect length)");
            else
                errorProvider.SetError(textBox, null);
        }

        private void PopulateBookInfo()
        {
            _currentBook.Isbn = TxtIsbn.Text.Trim();
            _currentBook.AuthorName = TxtAuthor.Text.Trim();
            _currentBook.PublicationDate = DtpPublicationDate.Value;
            _currentBook.CategoryId = BookCategory.FindCategory(CbCategories.Text.Trim())?.CategoryId ?? -1;
        }

        private void SaveBookInfoSuccess()
        {
            _saved = true;
            MessageBox.Show("Data saved successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LblBookId.Text = _currentBook.BookId.ToString();
            this.Text = "Update Book Info";
            LblTitle.Text = "Update Book";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (CommonValidation.HasValidationErrors(GbCategoryInfo.Controls, errorProvider, this))
            {
                MessageBox.Show("Form is not valid", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PopulateBookInfo();

            if (_currentBook.Save())
            {
                SaveBookInfoSuccess();
                RaiseSendBookInfoEvent(_currentBook);
            }
            else
            {
                MessageBox.Show("Save failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtIsbn_KeyPress(object sender, KeyPressEventArgs e) => CommonValidation.EnableOnlyDigits(e);

        private bool ShouldCancelClosing(DialogResult result) => result != DialogResult.Yes;

        private void ApplyClosingDecision(FormClosingEventArgs e, bool cancel) => e.Cancel = cancel;

        private void AddUpdateBookForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_saved)
            {
                DialogResult result = MessageBox.Show("Unsaved changes. Exit?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                ApplyClosingDecision(e, ShouldCancelClosing(result));
            }
        }

        private void BtnClose_Click(object sender, EventArgs e) => Close();
    }
}