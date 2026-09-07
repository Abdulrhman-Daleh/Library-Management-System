using BusinessLogic;
using LibrarySystem.BookCopies;
using LibrarySystem.Common;
using System;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace LibrarySystem.Books
{
    public partial class ManageBooksForm : BaseForm
    {
        private DataTable _booksDataTable;
        private string _filterName;

        public ManageBooksForm()
        {
            InitializeComponent();
            _LoadDefaultBooks();
        }

        public ManageBooksForm(int categoryId)
        {
            InitializeComponent();
            _LoadBooksForCategory(categoryId);
        }

        private void ResetFilterValue()
        {
            _filterName = CommonValidation.GetFilterName(CbFilterBy);
            CommonValidation.ResetFilterOnIndexChange(_booksDataTable, CbFilterBy, TxtFilter);
            CommonValidation.UpdateRecordCount(DgvBooks, LblRecords);
        }

        private async void _LoadDefaultBooks()
        {
            _booksDataTable = await Book.GetAllBooksAsync();
            CbFilterBy.SelectedIndex = 0;

            if (!CommonValidation.IsDataTableEmpty(_booksDataTable))
            {
                CommonValidation.ConfigureDataGridView(_booksDataTable, DgvBooks);
                CommonValidation.UpdateRecordCount(DgvBooks, LblRecords);
            }
        }

        private async void _LoadBooksForCategory(int categoryId)
        {
            _booksDataTable = await Book.GetAllBooksByCategoryAsync(categoryId);
            CbFilterBy.SelectedIndex = 0;

            if (!CommonValidation.IsDataTableEmpty(_booksDataTable))
            {
                CommonValidation.ConfigureDataGridView(_booksDataTable, DgvBooks);
                CommonValidation.UpdateRecordCount(DgvBooks, LblRecords);
            }
        }

        private void HandleAddedBook(object sender, AddUpdateBookForm.BookInfoEventArgs e) => ReloadRecords(e.AddedBook.BookId);

        private void ReloadRecords(int bookId) => MapToGridView(Book.FindBookById(bookId));

        private void MapToGridView(Book book)
        {
            if (CommonValidation.IsDataTableEmpty(_booksDataTable))
            {
                _LoadDefaultBooks();
                return;
            }

            DataRow row = _booksDataTable.AsEnumerable().FirstOrDefault(r => r.Field<int>("BookID") == book.BookId);
            GenericOperations.MapRecordsToGridView(row, DgvBooks, _booksDataTable, LblRecords, book);
        }

        private void CbFilterBy_SelectedIndexChanged(object sender, EventArgs e) => ResetFilterValue();

        private void TxtFilter_TextChanged(object sender, EventArgs e)
        {
            if (!CommonValidation.AllowFilter(TxtFilter, CbFilterBy, _booksDataTable))
            {
                CommonValidation.ResetFilterView(_booksDataTable);
                CommonValidation.UpdateRecordCount(DgvBooks, LblRecords);
                return;
            }

            if (_filterName == "AuthorName" || _filterName == "ISBN")
                _booksDataTable.DefaultView.RowFilter = $"[{_filterName}] LIKE '{TxtFilter.Text.Trim()}%'";
            else
                _booksDataTable.DefaultView.RowFilter = $"[{_filterName}] = {int.Parse(TxtFilter.Text.Trim())}";

            CommonValidation.UpdateRecordCount(DgvBooks, LblRecords);
        }

        private void UpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int bookId = (int)DgvBooks.CurrentRow.Cells["BookID"].Value;

            if (!CommonValidation.HandlePermissions(User.Permissions.ManageBooks))
                return;

            AddUpdateBookForm addUpdateBookForm = new AddUpdateBookForm(bookId);
            addUpdateBookForm.ShowDialog();
            ReloadRecords(bookId);
        }

        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManageBooks))
                return;

            AddUpdateBookForm addUpdateBookForm = new AddUpdateBookForm();
            addUpdateBookForm.SendBookInfoOnSaveEvent += HandleAddedBook;
            addUpdateBookForm.ShowDialog();
            addUpdateBookForm.SendBookInfoOnSaveEvent -= HandleAddedBook;
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManageBooks))
                return;

            int bookId = (int)DgvBooks.CurrentRow.Cells["BookID"].Value;

            if (MessageBox.Show("Delete this book?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (Book.DeleteBook(bookId))
            {
                MessageBox.Show("Book deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GenericOperations.DeleteRecord(_booksDataTable, DgvBooks, LblRecords, bookId, "BookID");
            }
            else
            {
                MessageBox.Show("Delete failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ViewUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManageBooks))
                return;

            int bookId = (int)DgvBooks.CurrentRow.Cells["BookID"].Value;
            ViewBookCardForm viewBookCardForm = new ViewBookCardForm(bookId);
            viewBookCardForm.ShowDialog();
            ReloadRecords(bookId);
        }

        private void ViewCopiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManageBookCopies))
                return;

            int bookId = (int)DgvBooks.CurrentRow.Cells["BookID"].Value;
            ManageBookCopiesForm manageBookCopiesForm = new ManageBookCopiesForm(bookId);
            manageBookCopiesForm.ShowDialog();
            ReloadRecords(bookId);
        }

        private void ChangeControlStatus(bool enabled)
        {
            ViewUserInfoToolStripMenuItem.Enabled = enabled;
            ViewCopiesToolStripMenuItem.Enabled = enabled;
            UpdateToolStripMenuItem.Enabled = enabled;
            DeleteToolStripMenuItem.Enabled = enabled;
        }

        private void CmsBooks_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ChangeControlStatus(DgvBooks.Rows.Count > 0);
        }

        private void DgvBooks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int bookId = (int)DgvBooks.CurrentRow.Cells["BookID"].Value;
            ViewBookCardForm viewBookCardForm = new ViewBookCardForm(bookId);
            viewBookCardForm.ShowDialog();
            ReloadRecords(bookId);
        }

        private void CbFilterBy_KeyPress(object sender, KeyPressEventArgs e) => CommonValidation.LockEditingControl(e);

        private void AddNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManageBooks))
                return;

            AddUpdateBookForm addUpdateBookForm = new AddUpdateBookForm();
            addUpdateBookForm.SendBookInfoOnSaveEvent += HandleAddedBook;
            addUpdateBookForm.ShowDialog();
            addUpdateBookForm.SendBookInfoOnSaveEvent -= HandleAddedBook;
        }

        private void BtnClose_Click(object sender, EventArgs e) => Close();

        private void TxtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CbFilterBy.Text != "Author Name" && CbFilterBy.Text != "ISBN")
                CommonValidation.EnableOnlyDigits(e);
        }
    }
}