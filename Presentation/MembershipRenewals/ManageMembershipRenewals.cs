using BusinessLogic;
using LibrarySystem;
using LibrarySystem.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.MembershipRenewals
{
    public partial class ManageMembershipRenewals : BaseForm
    {
        public ManageMembershipRenewals()
        {
            InitializeComponent();
        }

        private DataTable _renewalsDataTable;
        private async void ManageMembershipRenewals_Load(object sender, EventArgs e)
        {
            CbFilterBy.SelectedIndex = 0;
            _renewalsDataTable = await MembershipRenew.GetAllAsync(GlobalContext.CurrentUser, GlobalContext.CurrentMember.MemberId);

            if (!CommonValidation.IsDataTableEmpty(_renewalsDataTable))
            {
                CommonValidation.ConfigureDataGridView(_renewalsDataTable, DgvMembershipRenewals);
                CommonValidation.UpdateRecordCount(DgvMembershipRenewals, LblRecords);
            }
        }

        private void TxtFilter_TextChanged(object sender, EventArgs e)
        {
            if (!CommonValidation.AllowFilter(TxtFilter, CbFilterBy, _renewalsDataTable))
            {
                CommonValidation.ResetFilterView(_renewalsDataTable);
                CommonValidation.UpdateRecordCount(DgvMembershipRenewals, LblRecords);
                return;
            }

            string filterName = CommonValidation.GetFilterName(CbFilterBy);
            _renewalsDataTable.DefaultView.RowFilter = $"[{filterName}] = {int.Parse(TxtFilter.Text.Trim())}";
            CommonValidation.UpdateRecordCount(DgvMembershipRenewals, LblRecords);
        }


        private void CbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            CommonValidation.ResetFilterOnIndexChange(_renewalsDataTable, CbFilterBy, TxtFilter, CbIsPaid);
            CommonValidation.UpdateRecordCount(DgvMembershipRenewals, LblRecords);
        }

        private void BtnClose_Click(object sender, EventArgs e) => Close();

        private void DgvMembers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int renewId = (int)DgvMembershipRenewals.CurrentRow.Cells["RenewID"].Value;
            ViewMembershipRenewalInfo viewRenewal = new ViewMembershipRenewalInfo(renewId);
            viewRenewal.ShowDialog();
        }

        private void CbIsPaid_KeyPress(object sender, KeyPressEventArgs e) => CommonValidation.LockEditingControl(e);

        private void TxtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonValidation.EnableOnlyDigits(e);
        }

        private void CbIsPaid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CommonValidation.IsDataTableEmpty(_renewalsDataTable))
                return;

            string value = CbIsPaid.Text == "Paid" ? "1" : "0";
            _renewalsDataTable.DefaultView.RowFilter = CbIsPaid.Text == "All" ? "" : $"[{CbFilterBy.Text.Trim()}] = {value}";
            CommonValidation.UpdateRecordCount(DgvMembershipRenewals, LblRecords);
        }

        private void viewRenewalInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int renewId = (int)DgvMembershipRenewals.CurrentRow.Cells["RenewID"].Value;
            ViewMembershipRenewalInfo viewRenewal = new ViewMembershipRenewalInfo(renewId);
            viewRenewal.ShowDialog();
        }
    }
}
