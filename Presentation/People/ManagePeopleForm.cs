using BusinessLogic;
using LibrarySystem.Common;
using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem.People
{
    public partial class ManagePeopleForm : BaseForm
    {
        private DataTable _peopleDataTable;
        private string _filterName;

        public ManagePeopleForm()
        {
            InitializeComponent();
        }

        private async void ManagePeopleForm_Load(object sender, EventArgs e)
        {
            _peopleDataTable = await Person.GetAllAsync(GlobalContext.CurrentUser);
            CbFilterBy.SelectedIndex = 0;

            if (!CommonValidation.IsDataTableEmpty(_peopleDataTable))
            {
                CommonValidation.ConfigureDataGridView(_peopleDataTable, DgvPeople);
                CommonValidation.UpdateRecordCount(DgvPeople, LblRecords);
            }
        }

        private void RefreshPersonRecord(int personId) => MapPersonToRow(Person.FindById(personId));

        private void MapPersonToRow(Person person)
        {
            if (CommonValidation.IsDataTableEmpty(_peopleDataTable))
            {
                ManagePeopleForm_Load(null, null);
                return;
            }

            DataRow row = _peopleDataTable.AsEnumerable().FirstOrDefault(r => r.Field<int>("PersonID") == person.PersonId);
            GenericOperations.MapRecordsToGridView(row, DgvPeople, _peopleDataTable, LblRecords, person);
        }

        private void SetContextMenuControlsState(bool enabled)
        {
            ViewPersonInfoToolStripMenuItem.Enabled = enabled;
            UpdateToolStripMenuItem.Enabled = enabled;
            DeleteToolStripMenuItem.Enabled = enabled;
        }

        private void CbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            _filterName = CommonValidation.GetFilterName(CbFilterBy);
            CommonValidation.ResetFilterOnIndexChange(_peopleDataTable, CbFilterBy, TxtFilter, CbGender);
            CommonValidation.UpdateRecordCount(DgvPeople, LblRecords);
        }

        private void TxtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_filterName == "PersonID")
                CommonValidation.EnableOnlyDigits(e);
        }

        private void TxtFilter_TextChanged(object sender, EventArgs e)
        {
            if (!CommonValidation.AllowFilter(TxtFilter, CbFilterBy, _peopleDataTable))
            {
                CommonValidation.ResetFilterView(_peopleDataTable);
                CommonValidation.UpdateRecordCount(DgvPeople, LblRecords);
                return;
            }

            if (_filterName == "PersonID")
                _peopleDataTable.DefaultView.RowFilter = $"[{_filterName}] = {int.Parse(TxtFilter.Text.Trim())}";
            else
                _peopleDataTable.DefaultView.RowFilter = $"[{_filterName}] LIKE '{TxtFilter.Text.Trim()}%'";

            CommonValidation.UpdateRecordCount(DgvPeople, LblRecords);
        }

        private void CbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CommonValidation.IsDataTableEmpty(_peopleDataTable))
                return;

            _peopleDataTable.DefaultView.RowFilter = CbGender.Text == "All" ? "" : $"[{_filterName}] LIKE '{CbGender.Text}%'";
            CommonValidation.UpdateRecordCount(DgvPeople, LblRecords);
        }

        private void AddPersonRecord(object sender, int personId) => MapPersonToRow(Person.FindById(personId));

        private void BtnAddPerson_Click(object sender, EventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManagePeople))
                return;

            AddUpdatePersonForm addUpdatePersonForm = new AddUpdatePersonForm();
            addUpdatePersonForm.NotifyOnSaveSuccess += AddPersonRecord;
            addUpdatePersonForm.ShowDialog();
            addUpdatePersonForm.NotifyOnSaveSuccess -= AddPersonRecord;
        }

        private void CallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ViewPersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int personId = (int)DgvPeople.CurrentRow.Cells["PersonID"].Value;

            if (GlobalContext.CurrentUser.PersonId != personId && !CommonValidation.HandlePermissions(User.Permissions.ManagePeople))
                return;

            ViewPersonCardInfoForm viewPersonCardInfoForm = new ViewPersonCardInfoForm(personId);
            viewPersonCardInfoForm.ShowDialog();
        }

        private void AddNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManagePeople))
                return;

            AddUpdatePersonForm addUpdatePersonForm = new AddUpdatePersonForm();
            addUpdatePersonForm.NotifyOnSaveSuccess += AddPersonRecord;
            addUpdatePersonForm.ShowDialog();
            addUpdatePersonForm.NotifyOnSaveSuccess -= AddPersonRecord;
        }

        private void UpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int personId = (int)DgvPeople.CurrentRow.Cells["PersonID"].Value;

            if (GlobalContext.CurrentUser.PersonId != personId && !CommonValidation.HandlePermissions(User.Permissions.ManagePeople))
                return;

            AddUpdatePersonForm addUpdatePersonForm = new AddUpdatePersonForm(personId);
            addUpdatePersonForm.ShowDialog();
            RefreshPersonRecord(personId);
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManagePeople))
                return;

            int personId = (int)DgvPeople.CurrentRow.Cells["PersonID"].Value;

            if (MessageBox.Show("Delete this person?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (Person.IsCurrentLoggedInPerson(personId))
            {
                MessageBox.Show("Cannot delete current user's person", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Person.Delete(personId))
            {
                MessageBox.Show("Person deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GenericOperations.DeleteRecord(_peopleDataTable, DgvPeople, LblRecords, personId, "PersonID");
            }
            else
            {
                MessageBox.Show("Delete failed – person may be linked to other data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmsPeople_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SetContextMenuControlsState(DgvPeople.Rows.Count > 0);
        }

        private void DgvPeople_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int personId = (int)DgvPeople.CurrentRow.Cells["PersonID"].Value;

            if (GlobalContext.CurrentUser.PersonId != personId && !CommonValidation.HandlePermissions(User.Permissions.ManagePeople))
                return;

            ViewPersonCardInfoForm viewPersonCardInfoForm = new ViewPersonCardInfoForm(personId);
            viewPersonCardInfoForm.ShowDialog();
            RefreshPersonRecord(personId);
        }

        private void CbFilterBy_KeyPress(object sender, KeyPressEventArgs e) => CommonValidation.LockEditingControl(e);

        private void BtnClose_Click(object sender, EventArgs e) => Close();

        private void CbGender_KeyPress(object sender, KeyPressEventArgs e) => CommonValidation.LockEditingControl(e);
    }
}