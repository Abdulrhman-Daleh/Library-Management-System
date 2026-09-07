using BusinessLogic;
using LibrarySystem.BorrowFines;
using LibrarySystem.FinePayments;
using LibrarySystem.Common;
using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem.BorrowFinePayments
{
    public partial class ManageFinesForm : BaseForm
    {
        private DataTable _finesDataTable;

        public ManageFinesForm()
        {
            InitializeComponent();
        }

        private async void ManageFinesForm_Load(object sender, EventArgs e)
        {
            _finesDataTable = await Fine.GetAllAsync(GlobalContext.CurrentUser, GlobalContext.CurrentMember.MemberId);

            if (!CommonValidation.IsDataTableEmpty(_finesDataTable))
            {
                CommonValidation.ConfigureDataGridView(_finesDataTable, DgvFines);
                CommonValidation.UpdateRecordCount(DgvFines, LblRecords);
            }
        }

        private void ReloadRecords(int fineId) => MapToGridView(Fine.FindByFineId(fineId));

        private void MapToGridView(Fine fine)
        {
            if (fine == null)
                return;

            DataRow row = _finesDataTable.AsEnumerable().FirstOrDefault(r => r.Field<int>("FineID") == fine.FineId);
            GenericOperations.MapRecordsToGridView(row, DgvFines, _finesDataTable, LblRecords, fine);
        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManageFinePayments))
                return;

            int fineId = (int)DgvFines.CurrentRow.Cells["FineID"].Value;
            ViewFineDetailsForm viewFineDetailsForm = new ViewFineDetailsForm(fineId);
            viewFineDetailsForm.ShowDialog();
        }

        private void ProccessFinePaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int fineId = (int)DgvFines.CurrentRow.Cells["FineID"].Value;
            ProcessFinePaymentForm processFinePaymentForm = new ProcessFinePaymentForm(fineId);
            processFinePaymentForm.ShowDialog();
            ReloadRecords(fineId);
        }

        private void HandleProcessEnability()
        {
            if (DgvFines.CurrentRow.Cells["BorrowID"].Value != DBNull.Value)
            {
                ProccessFinePaymentToolStripMenuItem.Enabled = Fine.HasReturnFees((int)DgvFines.CurrentRow.Cells["BorrowID"].Value);
            }
            else
            {
                ProccessFinePaymentToolStripMenuItem.Enabled = Fine.HasMembershipRenewalFees((int)DgvFines.CurrentRow.Cells["RenewID"].Value);
            }
        }

        private void CmsBorrowFines_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (DgvFines.Rows.Count < 1)
            {
                CmsBorrowFines.Enabled = false;
                return;
            }

            CmsBorrowFines.Enabled = true;
            HandleProcessEnability();
        }

        private void BtnClose_Click(object sender, EventArgs e) => Close();

        private void DgvFines_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManageFinePayments))
                return;

            int fineId = (int)DgvFines.CurrentRow.Cells["FineID"].Value;
            ViewFineDetailsForm viewFineDetailsForm = new ViewFineDetailsForm(fineId);
            viewFineDetailsForm.ShowDialog();
        }

        private void ViewFineMenuItem_Click(object sender, EventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManageFinePayments))
                return;

            int fineId = (int)DgvFines.CurrentRow.Cells["FineID"].Value;
            ViewFineDetailsForm viewFineDetailsForm = new ViewFineDetailsForm(fineId);
            viewFineDetailsForm.ShowDialog();
        }
    }
}