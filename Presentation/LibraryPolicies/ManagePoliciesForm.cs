using BusinessLogic;
using LibrarySystem.Common;
using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.LibraryPolicies;

namespace LibrarySystem.LibraryPolicies
{
    public partial class ManagePoliciesForm : BaseForm
    {
        private DataTable _policiesDataTable;

        public ManagePoliciesForm()
        {
            InitializeComponent();
        }

        private async void ManagePoliciesForm_Load(object sender, EventArgs e)
        {
            CbFilterBy.SelectedIndex = 0;
            _policiesDataTable = await Policy.GetAllAsync();

            if (!CommonValidation.IsDataTableEmpty(_policiesDataTable))
            {
                CommonValidation.ConfigureDataGridView(_policiesDataTable, DgvPolicies);
                CommonValidation.UpdateRecordCount(DgvPolicies, LblRecords);
            }
        }

        private void ReloadRecords(int policyId) => MapToGridView(Policy.GetPolicyById(policyId));

        private void MapToGridView(Policy policy)
        {
            if (CommonValidation.IsDataTableEmpty(_policiesDataTable))
            {
                ManagePoliciesForm_Load(null, null);
                return;
            }

            DataRow row = _policiesDataTable.AsEnumerable().FirstOrDefault(r => r.Field<int>("PolicyID") == policy.PolicyId);
            GenericOperations.MapRecordsToGridView(row, DgvPolicies, _policiesDataTable, LblRecords, policy);
        }

        private void CbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            CommonValidation.ResetFilterOnIndexChange(_policiesDataTable, CbFilterBy, TxtFilter);
            CommonValidation.UpdateRecordCount(DgvPolicies, LblRecords);
        }

        private void TxtFilter_TextChanged(object sender, EventArgs e)
        {
            if (!CommonValidation.AllowFilter(TxtFilter, CbFilterBy, _policiesDataTable))
            {
                CommonValidation.ResetFilterView(_policiesDataTable);
                CommonValidation.UpdateRecordCount(DgvPolicies, LblRecords);
                return;
            }

            _policiesDataTable.DefaultView.RowFilter = $"[{CommonValidation.GetFilterName(CbFilterBy)}] = {int.Parse(TxtFilter.Text.Trim())}";
            CommonValidation.UpdateRecordCount(DgvPolicies, LblRecords);
        }

        private void TxtFilter_KeyPress(object sender, KeyPressEventArgs e) => CommonValidation.EnableOnlyDigits(e);

        private void BtnAddPolicy_Click(object sender, EventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManagePolicies))
                return;

            AddUpdatePolicyForm addUpdatePolicyForm = new AddUpdatePolicyForm();
            addUpdatePolicyForm.OnPolicySaved += ReloadRecords;
            addUpdatePolicyForm.ShowDialog();
            addUpdatePolicyForm.OnPolicySaved -= ReloadRecords;
        }

        private void ViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManagePolicies))
                return;

            int policyId = (int)DgvPolicies.CurrentRow.Cells["PolicyID"].Value;
            ViewPolicyForm viewPolicyForm = new ViewPolicyForm(policyId);
            viewPolicyForm.ShowDialog();
            ReloadRecords(policyId);
        }

        private void UpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManagePolicies))
                return;

            int policyId = (int)DgvPolicies.CurrentRow.Cells["PolicyID"].Value;
            AddUpdatePolicyForm addUpdatePolicyForm = new AddUpdatePolicyForm(policyId);
            addUpdatePolicyForm.ShowDialog();
            ReloadRecords(policyId);
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManagePolicies))
                return;

            int policyId = (int)DgvPolicies.CurrentRow.Cells["PolicyID"].Value;

            if (MessageBox.Show("Delete this policy?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (Policy.DeletePolicy(policyId))
            {
                MessageBox.Show("Policy deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GenericOperations.DeleteRecord(_policiesDataTable, DgvPolicies, LblRecords, policyId, "PolicyID");
            }
            else
            {
                MessageBox.Show("Delete failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManagePolicies))
                return;

            AddUpdatePolicyForm addUpdatePolicyForm = new AddUpdatePolicyForm();
            addUpdatePolicyForm.OnPolicySaved += ReloadRecords;
            addUpdatePolicyForm.ShowDialog();
            addUpdatePolicyForm.OnPolicySaved -= ReloadRecords;
        }

        private void BtnClose_Click(object sender, EventArgs e) => Close();

        private void DgvPolicies_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManagePolicies))
                return;

            int policyId = (int)DgvPolicies.CurrentRow.Cells["PolicyID"].Value;
            ViewPolicyForm viewPolicyForm = new ViewPolicyForm(policyId);
            viewPolicyForm.ShowDialog();
            ReloadRecords(policyId);
        }

        private void CmsPolicies_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (DgvPolicies.RowCount < 1)
            {
                CmsPolicies.Enabled = false;
                return;
            }

            CmsPolicies.Enabled = true;
        }
    }
}