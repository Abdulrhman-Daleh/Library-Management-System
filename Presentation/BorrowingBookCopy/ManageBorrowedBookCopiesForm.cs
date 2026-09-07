using BusinessLogic;
using LibrarySystem.BookCopies;
using LibrarySystem.FinePayments;
using LibrarySystem.Common;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LibrarySystem.BorrowingBookCopy
{
    public partial class ManageBorrowedBookCopiesForm : BaseForm
    {
        private DataTable _borrowedRecordsDataTable;

        public ManageBorrowedBookCopiesForm()
        {
            InitializeComponent();
        }

        private async void ManageBorrowedBookCopiesForm_Load(object sender, EventArgs e)
        {
            CbFilterBy.SelectedIndex = 0;
            _borrowedRecordsDataTable = await BorrowTransaction.GetAllAsync(GlobalContext.CurrentUser, GlobalContext.CurrentMember.MemberId);

            if (!CommonValidation.IsDataTableEmpty(_borrowedRecordsDataTable))
            {
                CommonValidation.ConfigureDataGridView(_borrowedRecordsDataTable, DgvBorrowedBookCopies);
                CommonValidation.UpdateRecordCount(DgvBorrowedBookCopies, LblRecords);
            }
        }

        private void CbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            CommonValidation.ResetFilterOnIndexChange(_borrowedRecordsDataTable, CbFilterBy, TxtFilter);
            CommonValidation.UpdateRecordCount(DgvBorrowedBookCopies, LblRecords);
        }

        private void TxtFilter_KeyPress(object sender, KeyPressEventArgs e) => CommonValidation.EnableOnlyDigits(e);

        private void TxtFilter_TextChanged(object sender, EventArgs e)
        {
            string filterName = CommonValidation.GetFilterName(CbFilterBy);

            if (!CommonValidation.AllowFilter(TxtFilter, CbFilterBy, _borrowedRecordsDataTable))
            {
                CommonValidation.ResetFilterView(_borrowedRecordsDataTable);
                CommonValidation.UpdateRecordCount(DgvBorrowedBookCopies, LblRecords);
                return;
            }

            _borrowedRecordsDataTable.DefaultView.RowFilter = $"[{filterName}] = {int.Parse(TxtFilter.Text.Trim())}";
            CommonValidation.UpdateRecordCount(DgvBorrowedBookCopies, LblRecords);
        }

        private void ReloadRecords(int borrowId) => MapToGridView(BorrowTransaction.FindByBorrowId(borrowId));

        private void MapToGridView(BorrowTransaction transaction)
        {
            if (transaction == null)
                return;

            DataRow row = _borrowedRecordsDataTable.AsEnumerable().FirstOrDefault(r => r.Field<int>("BorrowID") == transaction.BorrowId);
            GenericOperations.MapRecordsToGridView(row, DgvBorrowedBookCopies, _borrowedRecordsDataTable, LblRecords, transaction);
        }

        private void HandleNewAddedBorrow(int borrowId) => ReloadRecords(borrowId);

        private void ViewBookCardInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManageBookCopies))
                return;

            int bookCopyId = (int)DgvBorrowedBookCopies.CurrentRow.Cells["BookCopyID"].Value;
            int borrowId = (int)DgvBorrowedBookCopies.CurrentRow.Cells["BorrowID"].Value;

            ViewBookCopyCardForm viewBookCopyCardForm = new ViewBookCopyCardForm(bookCopyId);
            viewBookCopyCardForm.ShowDialog();
            ReloadRecords(borrowId);
        }

        private void SetActionControlsState(bool enabled)
        {
            ReturnBorrowedBookToolStripMenuItem.Enabled = enabled;
            LostBookReportToolStripMenuItem.Enabled = enabled;
            DamageToolStripMenuItem.Enabled = enabled;
        }

        private void CmsBookCopies_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (DgvBorrowedBookCopies.Rows.Count < 1)
            {
                CmsBookCopies.Enabled = false;
                return;
            }
            else
                CmsBookCopies.Enabled = true;

            int borrowId = (int)DgvBorrowedBookCopies.CurrentRow.Cells["BorrowID"].Value;
            BorrowTransaction transaction = BorrowTransaction.FindByBorrowId(borrowId);
            bool isBorrowed = transaction?.IsSameTransaction(BorrowTransaction.StatusType.Borrow) ?? false;
            SetActionControlsState(isBorrowed);

            ProccessFinePaymentToolStripMenuItem.Enabled = Fine.HasReturnFees(borrowId);
        }

        private void DgvBorrowedBookCopies_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManageBorrowTransactions))
                return;


            int borrowId = (int)DgvBorrowedBookCopies.CurrentRow.Cells["BorrowID"].Value;
            ViewBookBorrowDetailsForm viewBookBorrowDetailsForm = new ViewBookBorrowDetailsForm(borrowId);
            viewBookBorrowDetailsForm.ShowDialog();
            ReloadRecords(borrowId);
        }

        private void ProccessFinePaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManageFinePayments))
                return;

            int borrowId = (int)DgvBorrowedBookCopies.CurrentRow.Cells["BorrowID"].Value;
            Fine fine = Fine.FindByBorrowId(borrowId);

            if (fine != null)
            {
                ProcessFinePaymentForm processFinePaymentForm = new ProcessFinePaymentForm(fine.FineId);
                processFinePaymentForm.ShowDialog();
                ReloadRecords(borrowId);
            }
        }

        private void CbFilterBy_KeyPress(object sender, KeyPressEventArgs e) => CommonValidation.LockEditingControl(e);

        private void BtnBorrowNewBook_Click(object sender, EventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManageBorrowTransactions))
                return;

            BorrowBookCopyForm borrowBookCopyForm = new BorrowBookCopyForm(BorrowTransaction.StatusType.Borrow);
            borrowBookCopyForm.OnBorrowAdded += HandleNewAddedBorrow;
            borrowBookCopyForm.ShowDialog();
            borrowBookCopyForm.OnBorrowAdded -= HandleNewAddedBorrow;
        }

        private void AddNewCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManageBorrowTransactions))
                return;

            BorrowBookCopyForm borrowBookCopyForm = new BorrowBookCopyForm(BorrowTransaction.StatusType.Borrow);
            borrowBookCopyForm.OnBorrowAdded += HandleNewAddedBorrow;
            borrowBookCopyForm.ShowDialog();
            borrowBookCopyForm.OnBorrowAdded -= HandleNewAddedBorrow;
        }

        private void ReturnBorrowedBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManageBorrowTransactions))
                return;

            int borrowId = (int)DgvBorrowedBookCopies.CurrentRow.Cells["BorrowID"].Value;
            BorrowBookCopyForm borrowBookCopyForm = new BorrowBookCopyForm(borrowId, BorrowTransaction.StatusType.Return);
            borrowBookCopyForm.OnBorrowAdded += (id) => ReloadRecords(borrowId);
            borrowBookCopyForm.ShowDialog();
        }

        private void LostBookReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManageBorrowTransactions))
                return;

            int borrowId = (int)DgvBorrowedBookCopies.CurrentRow.Cells["BorrowID"].Value;
            BorrowBookCopyForm borrowBookCopyForm = new BorrowBookCopyForm(borrowId, BorrowTransaction.StatusType.Lost);
            borrowBookCopyForm.OnBorrowAdded += (id) => ReloadRecords(borrowId);
            borrowBookCopyForm.ShowDialog();
        }

        private void DamageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManageBorrowTransactions))
                return;

            int borrowId = (int)DgvBorrowedBookCopies.CurrentRow.Cells["BorrowID"].Value;
            BorrowBookCopyForm borrowBookCopyForm = new BorrowBookCopyForm(borrowId, BorrowTransaction.StatusType.Damage);
            borrowBookCopyForm.OnBorrowAdded += (id) => ReloadRecords(borrowId);
            borrowBookCopyForm.ShowDialog();
        }

        private void BtnClose_Click(object sender, EventArgs e) => Close();

        private void ViewBorrowMenuItem2_Click(object sender, EventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManageBorrowTransactions))
                return;

            int borrowId = (int)DgvBorrowedBookCopies.CurrentRow.Cells["BorrowID"].Value;
            ViewBookBorrowDetailsForm viewBookBorrowDetailsForm = new ViewBookBorrowDetailsForm(borrowId);
            viewBookBorrowDetailsForm.ShowDialog();
            ReloadRecords(borrowId);
        }
    }
}