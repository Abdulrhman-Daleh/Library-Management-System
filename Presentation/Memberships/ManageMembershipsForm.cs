using BusinessLogic;
using LibrarySystem.Common;
using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem.Memberships
{
    public partial class ManageMembershipsForm : BaseForm
    {
        private DataTable _membershipsDataTable;

        public ManageMembershipsForm()
        {
            InitializeComponent();
        }

        private async void ManageMembershipsForm_Load(object sender, EventArgs e)
        {
            CbFilterBy.SelectedIndex = 0;
            _membershipsDataTable = await MembershipType.GetAllAsync();

            if (!CommonValidation.IsDataTableEmpty(_membershipsDataTable))
            {
                CommonValidation.ConfigureDataGridView(_membershipsDataTable, DgvMemberships);
                CommonValidation.UpdateRecordCount(DgvMemberships, LblRecords);
            }
        }

        private void ReloadRecords(int membershipId) => MapToGridView(MembershipType.FindById(membershipId));

        private void MapToGridView(MembershipType membershipType)
        {
            if (CommonValidation.IsDataTableEmpty(_membershipsDataTable))
            {
                ManageMembershipsForm_Load(null, null);
                return;
            }

            DataRow row = _membershipsDataTable.AsEnumerable().FirstOrDefault(r => r.Field<int>("MembershipTypeID") == membershipType.MembershipTypeId);
            GenericOperations.MapRecordsToGridView(row, DgvMemberships, _membershipsDataTable, LblRecords, membershipType);
        }

        private void CbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            CommonValidation.ResetFilterOnIndexChange(_membershipsDataTable, CbFilterBy, TxtFilter);
            CommonValidation.UpdateRecordCount(DgvMemberships, LblRecords);
        }

        private void TxtFilter_TextChanged(object sender, EventArgs e)
        {
            if (!CommonValidation.AllowFilter(TxtFilter, CbFilterBy, _membershipsDataTable))
            {
                CommonValidation.ResetFilterView(_membershipsDataTable);
                CommonValidation.UpdateRecordCount(DgvMemberships, LblRecords);
                return;
            }

            string filterName = CommonValidation.GetFilterName(CbFilterBy);

            if (filterName == "MembershipTypeName")
                _membershipsDataTable.DefaultView.RowFilter = $"[{filterName}] LIKE '{TxtFilter.Text.Trim()}%'";
            else
                _membershipsDataTable.DefaultView.RowFilter = $"[{filterName}] = {int.Parse(TxtFilter.Text.Trim())}";

            CommonValidation.UpdateRecordCount(DgvMemberships, LblRecords);
        }

        private void HandleAddedMembership(int membershipId) => ReloadRecords(membershipId);

        private void BtnAddMembership_Click(object sender, EventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManageMemberships))
                return;

            AddUpdateMembershipForm addUpdateMembershipForm = new AddUpdateMembershipForm();
            addUpdateMembershipForm.OnNewMembershipAdded += HandleAddedMembership;
            addUpdateMembershipForm.ShowDialog();
            addUpdateMembershipForm.OnNewMembershipAdded -= HandleAddedMembership;
        }

        private void ViewMemberInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManageMemberships))
                return;

            int membershipId = (int)DgvMemberships.CurrentRow.Cells["MembershipTypeID"].Value;
            ViewMembershipDetailsForm viewMembershipDetailsForm = new ViewMembershipDetailsForm(membershipId);
            viewMembershipDetailsForm.ShowDialog();
            ReloadRecords(membershipId);
        }

        private void AddNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManageMemberships))
                return;

            AddUpdateMembershipForm addUpdateMembershipForm = new AddUpdateMembershipForm();
            addUpdateMembershipForm.OnNewMembershipAdded += HandleAddedMembership;
            addUpdateMembershipForm.ShowDialog();
            addUpdateMembershipForm.OnNewMembershipAdded -= HandleAddedMembership;
        }

        private void UpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int membershipId = (int)DgvMemberships.CurrentRow.Cells["MembershipTypeID"].Value;

            if (GlobalContext.CurrentMember.MembershipTypeId != membershipId && !CommonValidation.HandlePermissions(User.Permissions.ManageMemberships))
                return;

            AddUpdateMembershipForm addUpdateMembershipForm = new AddUpdateMembershipForm(membershipId);
            addUpdateMembershipForm.ShowDialog();
            ReloadRecords(membershipId);
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManageMemberships))
                return;

            int membershipId = (int)DgvMemberships.CurrentRow.Cells["MembershipTypeID"].Value;

            if (MessageBox.Show("Delete this membership type?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (MembershipType.DeleteMembershipType(membershipId))
            {
                MessageBox.Show("Membership type deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GenericOperations.DeleteRecord(_membershipsDataTable, DgvMemberships, LblRecords, membershipId, "MembershipTypeID");
            }
            else
            {
                MessageBox.Show("Delete failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CbFilterBy.Text.Trim() != "MembershipTypeName")
                CommonValidation.EnableOnlyDigits(e);
        }

        private void BtnClose_Click(object sender, EventArgs e) => Close();

        private void DgvMemberships_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManageMemberships))
                return;

            int membershipId = (int)DgvMemberships.CurrentRow.Cells["MembershipTypeID"].Value;
            ViewMembershipDetailsForm viewMembershipDetailsForm = new ViewMembershipDetailsForm(membershipId);
            viewMembershipDetailsForm.ShowDialog();
            ReloadRecords(membershipId);
        }
    }
}