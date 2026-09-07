using BusinessLogic;
using LibrarySystem.Books;
using LibrarySystem.BorrowingBookCopy;
using LibrarySystem.Common;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem.BookCopies
{
    public partial class ManageBookCopiesForm : BaseForm
    {
        private DataTable _bookCopiesDataTable;
        private string _filterName;
        private int _bookId = -1;

        public ManageBookCopiesForm()
        {
            InitializeComponent();
        }

        public ManageBookCopiesForm(int bookId)
        {
            InitializeComponent();
            _bookId = bookId;
        }

        private async void ManageBookCopiesForm_Load(object sender, EventArgs e)
        {
            CbFilterBy.SelectedIndex = 0;

            _bookCopiesDataTable = _bookId != -1
                ? await BookCopy.GetAllBookCopiesByBookIdAsync(_bookId)
                : await BookCopy.GetAllBookCopiesAsync();

            if (!CommonValidation.IsDataTableEmpty(_bookCopiesDataTable))
            {
                CommonValidation.ConfigureDataGridView(_bookCopiesDataTable, DgvBookCopies);
                CommonValidation.UpdateRecordCount(DgvBookCopies, LblRecords);
            }
        }

        private void ReloadRecords(int bookCopyId) => MapToGridView(BookCopy.FindBookCopyById(bookCopyId));

        private void MapToGridView(BookCopy bookCopy)
        {
            if (CommonValidation.IsDataTableEmpty(_bookCopiesDataTable))
            {
                ManageBookCopiesForm_Load(null, null);
                return;
            }

            DataRow row = _bookCopiesDataTable.AsEnumerable().FirstOrDefault(r => r.Field<int>("BookCopyID") == bookCopy.BookCopyId);
            GenericOperations.MapRecordsToGridView(row, DgvBookCopies, _bookCopiesDataTable, LblRecords, bookCopy);
        }

        private void CbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            _filterName = CommonValidation.GetFilterName(CbFilterBy);
            CommonValidation.ResetFilterOnIndexChange(_bookCopiesDataTable, CbFilterBy, TxtFilter);
            CommonValidation.UpdateRecordCount(DgvBookCopies, LblRecords);
        }

        private void TxtFilter_TextChanged(object sender, EventArgs e)
        {
            if (!CommonValidation.AllowFilter(TxtFilter, CbFilterBy, _bookCopiesDataTable))
            {
                CommonValidation.ResetFilterView(_bookCopiesDataTable);
                CommonValidation.UpdateRecordCount(DgvBookCopies, LblRecords);
                return;
            }

            if (_filterName == "BookCopyID" || _filterName == "BookID")
                _bookCopiesDataTable.DefaultView.RowFilter = $"[{_filterName}] = {int.Parse(TxtFilter.Text.Trim())}";
            else
                _bookCopiesDataTable.DefaultView.RowFilter = $"[{_filterName}] LIKE '{TxtFilter.Text.Trim()}%'";

            CommonValidation.UpdateRecordCount(DgvBookCopies, LblRecords);
        }

        private void TxtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_filterName == "BookID" || _filterName == "BookCopyID")
                CommonValidation.EnableOnlyDigits(e);
        }

        private void ViewUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManageBookCopies))
                return;

            int bookCopyId = (int)DgvBookCopies.CurrentRow.Cells["BookCopyID"].Value;
            ViewBookCopyCardForm viewBookCopyCardForm = new ViewBookCopyCardForm(bookCopyId);
            viewBookCopyCardForm.ShowDialog();
            ReloadRecords(bookCopyId);
        }

        private void SetControlsEnabled(bool enabled)
        {
            ReturnBorrowedBookToolStripMenuItem.Enabled = enabled;
            LostBookReportToolStripMenuItem.Enabled = enabled;
            DamageToolStripMenuItem.Enabled = enabled;
        }

        private void CmsBookCopies_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

            if (DgvBookCopies.Rows.Count < 1)
            {
                CmsBookCopies.Enabled = false;
                return;
            }
            else
                CmsBookCopies.Enabled = true;

            int bookCopyId = (int)DgvBookCopies.CurrentRow.Cells["BookCopyId"].Value;
            BorrowTransaction transaction = BorrowTransaction.FindByBookCopyId(bookCopyId);
            bool isBorrowed = transaction?.IsSameTransaction(BorrowTransaction.StatusType.Borrow) ?? false;
            SetControlsEnabled(isBorrowed);

            BorrowBookCopyMenuItem1.Enabled = !isBorrowed;
        }

        private void GetBookCopyId(object sender, int bookCopyId) => ReloadRecords(bookCopyId);

        private void AddNewCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManageBookCopies))
                return;

            AddUpdateBookCopyForm addUpdateBookCopyForm = new AddUpdateBookCopyForm();
            addUpdateBookCopyForm.SendBookCopyId += GetBookCopyId;
            addUpdateBookCopyForm.ShowDialog();
            addUpdateBookCopyForm.SendBookCopyId -= GetBookCopyId;
        }

        private void BtnAddNewCopy_Click(object sender, EventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManageBookCopies))
                return;

            AddUpdateBookCopyForm addUpdateBookCopyForm = new AddUpdateBookCopyForm();
            addUpdateBookCopyForm.SendBookCopyId += GetBookCopyId;
            addUpdateBookCopyForm.ShowDialog();
            addUpdateBookCopyForm.SendBookCopyId -= GetBookCopyId;
        }

        private void UpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManageBookCopies))
                return;

            int bookCopyId = (int)DgvBookCopies.CurrentRow.Cells["BookCopyID"].Value;
            AddUpdateBookCopyForm addUpdateBookCopyForm = new AddUpdateBookCopyForm(bookCopyId);
            addUpdateBookCopyForm.ShowDialog();
            ReloadRecords(bookCopyId);
        }

        private void ViewOriginalbookitem_Click(object sender, EventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManageBooks))
                return;

            int bookId = (int)DgvBookCopies.CurrentRow.Cells["BookID"].Value;
            int bookCopyId = (int)DgvBookCopies.CurrentRow.Cells["BookCopyID"].Value;

            ViewBookCardForm viewBookCardForm = new ViewBookCardForm(bookId);
            viewBookCardForm.ShowDialog();
            ReloadRecords(bookCopyId);
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManageBookCopies))
                return;

            int bookCopyId = (int)DgvBookCopies.CurrentRow.Cells["BookCopyID"].Value;

            if (MessageBox.Show($"Delete copy {bookCopyId}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (BookCopy.DeleteBookCopy(bookCopyId))
            {
                MessageBox.Show("Book copy deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GenericOperations.DeleteRecord(_bookCopiesDataTable, DgvBookCopies, LblRecords, bookCopyId, "BookCopyID");
            }
            else
            {
                MessageBox.Show("Delete failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvBookCopies_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int bookCopyId = (int)DgvBookCopies.CurrentRow.Cells["BookCopyID"].Value;
            ViewBookCopyCardForm viewBookCopyCardForm = new ViewBookCopyCardForm(bookCopyId);
            viewBookCopyCardForm.ShowDialog();
            ReloadRecords(bookCopyId);
        }

        private void BtnClose_Click(object sender, EventArgs e) => Close();

        private void CbFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonValidation.LockEditingControl(e);
        }

        private void ReturnBorrowedBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int bookCopyId = (int)DgvBookCopies.CurrentRow.Cells["BookCopyID"].Value;

            BorrowBookCopyForm borrowBookCopyForm = new BorrowBookCopyForm(bookCopyId, BorrowTransaction.StatusType.Return);
            borrowBookCopyForm.OnBorrowAdded += (id) => ReloadRecords(bookCopyId);
            borrowBookCopyForm.ShowDialog();
        }

        private void BorrowBookCopyMenuItem1_Click(object sender, EventArgs e)
        {
            int bookCopyId = (int)DgvBookCopies.CurrentRow.Cells["BookCopyID"].Value;

            BorrowBookCopyForm borrowBookCopyForm = new BorrowBookCopyForm(bookCopyId, BorrowTransaction.StatusType.Borrow);
            borrowBookCopyForm.OnBorrowAdded += (id) => ReloadRecords(bookCopyId);
            borrowBookCopyForm.ShowDialog();
        }

        private void LostBookReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int bookCopyId = (int)DgvBookCopies.CurrentRow.Cells["BookCopyID"].Value;

            BorrowBookCopyForm borrowBookCopyForm = new BorrowBookCopyForm(bookCopyId, BorrowTransaction.StatusType.Lost);
            borrowBookCopyForm.OnBorrowAdded += (id) => ReloadRecords(bookCopyId);
            borrowBookCopyForm.ShowDialog();
        }

        private void DamageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int bookCopyId = (int)DgvBookCopies.CurrentRow.Cells["BookCopyID"].Value;

            BorrowBookCopyForm borrowBookCopyForm = new BorrowBookCopyForm(bookCopyId, BorrowTransaction.StatusType.Damage);
            borrowBookCopyForm.OnBorrowAdded += (id) => ReloadRecords(bookCopyId);
            borrowBookCopyForm.ShowDialog();
        }
    }
}