using BusinessLogic;
using LibrarySystem.Common;
using LibrarySystem.Users;
using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem.Members
{
    public partial class ManageMembersForm : BaseForm
    {
        private DataTable _membersDataTable;

        public ManageMembersForm()
        {
            InitializeComponent();
        }

        private async void ManageMembersForm_Load(object sender, EventArgs e)
        {
            CbFilterBy.SelectedIndex = 0;
            _membersDataTable = await Member.GetAllAsync(GlobalContext.CurrentUser);

            if (!CommonValidation.IsDataTableEmpty(_membersDataTable))
            {
                CommonValidation.ConfigureDataGridView(_membersDataTable, DgvMembers);
                CommonValidation.UpdateRecordCount(DgvMembers, LblRecords);
            }
        }

        private void ReloadRecords(int memberId) => MapToGridView(Member.FindByMemberId(memberId));

        private void MapToGridView(Member member)
        {
            if (CommonValidation.IsDataTableEmpty(_membersDataTable))
            {
                ManageMembersForm_Load(null, null);
                return;
            }

            DataRow row = _membersDataTable.AsEnumerable().FirstOrDefault(r => r.Field<int>("MemberID") == member.MemberId);
            GenericOperations.MapRecordsToGridView(row, DgvMembers, _membersDataTable, LblRecords, member);
        }

        private void CbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            CommonValidation.ResetFilterOnIndexChange(_membersDataTable, CbFilterBy, TxtFilter);
            CommonValidation.UpdateRecordCount(DgvMembers, LblRecords);
        }

        private void TxtFilter_TextChanged(object sender, EventArgs e)
        {
            if (!CommonValidation.AllowFilter(TxtFilter, CbFilterBy, _membersDataTable))
            {
                CommonValidation.ResetFilterView(_membersDataTable);
                CommonValidation.UpdateRecordCount(DgvMembers, LblRecords);
                return;
            }

            string filterName = CommonValidation.GetFilterName(CbFilterBy);
            _membersDataTable.DefaultView.RowFilter = $"[{filterName}] = {int.Parse(TxtFilter.Text.Trim())}";
            CommonValidation.UpdateRecordCount(DgvMembers, LblRecords);
        }

        private void HandleAddedMember(int memberId) => ReloadRecords(memberId);

        private void BtnAddPerson_Click(object sender, EventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManageMembers))
                return;

            AddUpdateMemberForm addUpdateMemberForm = new AddUpdateMemberForm();
            addUpdateMemberForm.NotifyOnSaveSuccess += HandleAddedMember;
            addUpdateMemberForm.ShowDialog();
            addUpdateMemberForm.NotifyOnSaveSuccess -= HandleAddedMember;
        }

        private void ViewUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int userId = (int)DgvMembers.CurrentRow.Cells["UserID"].Value;
            int memberId = (int)DgvMembers.CurrentRow.Cells["MemberID"].Value;

            if (GlobalContext.CurrentMember.MemberId != memberId && !CommonValidation.HandlePermissions(User.Permissions.ManageUsers))
                return;

            ViewUserCardForm viewUserCardForm = new ViewUserCardForm(userId);
            viewUserCardForm.ShowDialog();
            ReloadRecords(memberId);
        }

        private void ViewMemberInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int memberId = (int)DgvMembers.CurrentRow.Cells["MemberID"].Value;

            if (GlobalContext.CurrentMember.MemberId != memberId && !CommonValidation.HandlePermissions(User.Permissions.ManageMembers))
                return;

            ViewMemberCardForm viewMemberCardForm = new ViewMemberCardForm(memberId);
            viewMemberCardForm.ShowDialog();
            ReloadRecords(memberId);
        }

        private void AddNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManageMembers))
                return;

            AddUpdateMemberForm addUpdateMemberForm = new AddUpdateMemberForm();
            addUpdateMemberForm.NotifyOnSaveSuccess += HandleAddedMember;
            addUpdateMemberForm.ShowDialog();
            addUpdateMemberForm.NotifyOnSaveSuccess -= HandleAddedMember;
        }

        private void UpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int memberId = (int)DgvMembers.CurrentRow.Cells["MemberID"].Value;

            if (GlobalContext.CurrentMember.MemberId != memberId && !CommonValidation.HandlePermissions(User.Permissions.ManageMembers))
                return;

            AddUpdateMemberForm addUpdateMemberForm = new AddUpdateMemberForm(memberId);
            addUpdateMemberForm.ShowDialog();
            ReloadRecords(memberId);
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManageMembers))
                return;

            int memberId = (int)DgvMembers.CurrentRow.Cells["MemberID"].Value;

            if (MessageBox.Show("Delete this member?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            try
            {
                if (Member.Delete(memberId))
                {
                    MessageBox.Show("Member deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GenericOperations.DeleteRecord(_membersDataTable, DgvMembers, LblRecords, memberId, "MemberID");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetContextMenuState(bool enabled)
        {
            ViewMemberInfoToolStripMenuItem.Enabled = enabled;
            ViewUserInfoToolStripMenuItem.Enabled = enabled;
            RenewMembershipToolStripMenuItem.Enabled = enabled;
            DeleteToolStripMenuItem.Enabled = enabled;
        }

        private void CmsMember_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SetContextMenuState(DgvMembers.Rows.Count > 0);
        }

        private void DgvMembers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int memberId = (int)DgvMembers.CurrentRow.Cells["MemberID"].Value;

            if (GlobalContext.CurrentMember.MemberId != memberId && !CommonValidation.HandlePermissions(User.Permissions.ManageMembers))
                return;

            ViewMemberCardForm viewMemberCardForm = new ViewMemberCardForm(memberId);
            viewMemberCardForm.ShowDialog();
            ReloadRecords(memberId);
        }

        private void CbFilterBy_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = true;

        private void BtnClose_Click(object sender, EventArgs e) => Close();

        private void CallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TxtFilter_KeyPress(object sender, KeyPressEventArgs e) => CommonValidation.EnableOnlyDigits(e);

        private void RenewMembershipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int memberId = (int)DgvMembers.CurrentRow.Cells["MemberID"].Value;

            if (GlobalContext.CurrentMember.MemberId != memberId && !CommonValidation.HandlePermissions(User.Permissions.ManageMembers))
                return;

            AddUpdateMemberForm addUpdateMemberForm = new AddUpdateMemberForm(memberId);
            addUpdateMemberForm.ShowDialog();
            ReloadRecords(memberId);
        }
    }
}