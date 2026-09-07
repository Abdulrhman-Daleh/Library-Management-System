using BusinessLogic;
using LibrarySystem.Common;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LibrarySystem.FinePayments
{
    public partial class ManageFinePaymentsForm : BaseForm
    {
        private DataTable _finePaymentsDataTable;
        private string _filterName;

        public ManageFinePaymentsForm()
        {
            InitializeComponent();
        }

        private async void ManageFinePaymentsForm_Load(object sender, EventArgs e)
        {
            CbFilterBy.SelectedIndex = 0;
            _finePaymentsDataTable = await FinePayment.GetAllAsync(GlobalContext.CurrentUser, GlobalContext.CurrentMember.MemberId);

            if (!CommonValidation.IsDataTableEmpty(_finePaymentsDataTable))
            {
                CommonValidation.ConfigureDataGridView(_finePaymentsDataTable, DgvFinePayments);
                CommonValidation.UpdateRecordCount(DgvFinePayments, LblRecords);
            }
        }

        private void RefreshFinePaymentRecord(int paymentId) => MapFinePaymentToRow(FinePayment.FindByPaymentId(paymentId));

        private void MapFinePaymentToRow(FinePayment finePayment)
        {
            if (finePayment == null)
                return;

            if (CommonValidation.IsDataTableEmpty(_finePaymentsDataTable))
            {
                ManageFinePaymentsForm_Load(null, null);
                return;
            }

            DataRow row = _finePaymentsDataTable.AsEnumerable().FirstOrDefault(r => r.Field<int>("PaymentID") == finePayment.PaymentId);
            GenericOperations.MapRecordsToGridView(row, DgvFinePayments, _finePaymentsDataTable, LblRecords, finePayment);
        }

        private void SetContextMenuControlsState(bool enabled) => ViewRenewInfoToolStripMenuItem.Enabled = enabled;

        private void CbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            _filterName = CommonValidation.GetFilterName(CbFilterBy);
            CommonValidation.ResetFilterOnIndexChange(_finePaymentsDataTable, CbFilterBy, TxtFilter);
            CommonValidation.UpdateRecordCount(DgvFinePayments, LblRecords);
        }

        private void TxtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_filterName == "PaymentID" || _filterName == "FineID")
                CommonValidation.EnableOnlyDigits(e);
        }

        private void ViewRenewInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManageFinePayments))
                return;

            int paymentId = (int)DgvFinePayments.CurrentRow.Cells["PaymentID"].Value;
            ViewFinePaymentInfoForm finePaymentInfoForm = new ViewFinePaymentInfoForm(paymentId);
            finePaymentInfoForm.ShowDialog();
            RefreshFinePaymentRecord(paymentId);
        }

        private void CmsFinePayment_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SetContextMenuControlsState(DgvFinePayments.Rows.Count > 0);
        }

        private void CbFilterBy_KeyPress(object sender, KeyPressEventArgs e) => CommonValidation.LockEditingControl(e);

        private void BtnClose_Click(object sender, EventArgs e) => Close();

        private void DgvFinePayments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManageFinePayments))
                return;

            if (DgvFinePayments.CurrentRow == null)
                return;

            int paymentId = (int)DgvFinePayments.CurrentRow.Cells["PaymentID"].Value;
            ViewFinePaymentInfoForm finePaymentInfoForm = new ViewFinePaymentInfoForm(paymentId);
            finePaymentInfoForm.ShowDialog();
            RefreshFinePaymentRecord(paymentId);
        }

        private void TxtFilter_TextChanged(object sender, EventArgs e)
        {
            if (!CommonValidation.AllowFilter(TxtFilter, CbFilterBy, _finePaymentsDataTable))
            {
                CommonValidation.ResetFilterView(_finePaymentsDataTable);
                CommonValidation.UpdateRecordCount(DgvFinePayments, LblRecords);
                return;
            }

            if (_filterName == "PaymentID" || _filterName == "FineID")
                _finePaymentsDataTable.DefaultView.RowFilter = $"[{_filterName}] = {int.Parse(TxtFilter.Text.Trim())}";
            else
                _finePaymentsDataTable.DefaultView.RowFilter = $"[{_filterName}] LIKE '{TxtFilter.Text.Trim()}%'";

            CommonValidation.UpdateRecordCount(DgvFinePayments, LblRecords);
        }
    }
}