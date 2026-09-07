using BusinessLogic;
using LibrarySystem.Categories;
using LibrarySystem.Common;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LibrarySystem.BookCategories
{
    public partial class ManageBookCategoriesForm : BaseForm
    {
        private DataTable _categoriesDataTable;

        public ManageBookCategoriesForm()
        {
            InitializeComponent();
        }

        private async void ManageBookCategoriesForm_Load(object sender, EventArgs e)
        {
            _categoriesDataTable = await BusinessLogic.BookCategory.GetAllCategoriesAsync();
            CbFilterBy.SelectedIndex = 0;

            if (CommonValidation.IsDataTableEmpty(_categoriesDataTable))
                return;

            // Only keep specific columns for display
            _categoriesDataTable = _categoriesDataTable.DefaultView.ToTable(false, "CategoryID", "CategoryDescription", "CategoryName");

            CommonValidation.ConfigureDataGridView(_categoriesDataTable, DgvCategories);
            CommonValidation.UpdateRecordCount(DgvCategories, LblRecords);
        }

        private void TxtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CbFilterBy.Text == "CategoryID")
                CommonValidation.EnableOnlyDigits(e);
        }

        private void CbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            CommonValidation.ResetFilterOnIndexChange(_categoriesDataTable, CbFilterBy, TxtFilter);
            CommonValidation.UpdateRecordCount(DgvCategories, LblRecords);
        }

        private void TxtFilter_TextChanged(object sender, EventArgs e)
        {
            if (!CommonValidation.AllowFilter(TxtFilter, CbFilterBy, _categoriesDataTable))
            {
                CommonValidation.ResetFilterView(_categoriesDataTable);
                CommonValidation.UpdateRecordCount(DgvCategories, LblRecords);
                return;
            }

            string filterName = CommonValidation.GetFilterName(CbFilterBy);

            if (filterName == "CategoryID")
                _categoriesDataTable.DefaultView.RowFilter = $"[{filterName}] = {int.Parse(TxtFilter.Text.Trim())}";
            else
                _categoriesDataTable.DefaultView.RowFilter = $"[{filterName}] LIKE '{TxtFilter.Text.Trim()}%'";

            CommonValidation.UpdateRecordCount(DgvCategories, LblRecords);
        }

        private void ReloadRecords(int categoryId) => MapToGridView(BusinessLogic.BookCategory.FindCategory(categoryId));

        private void MapToGridView(BusinessLogic.BookCategory category)
        {
            if (CommonValidation.IsDataTableEmpty(_categoriesDataTable))
            {
                ManageBookCategoriesForm_Load(null, null);
                return;
            }

            DataRow row = _categoriesDataTable.AsEnumerable().FirstOrDefault(r => r.Field<int>("CategoryID") == category.CategoryId);
            GenericOperations.MapRecordsToGridView(row, DgvCategories, _categoriesDataTable, LblRecords, category);
        }

        private void HandleAddedCategory(int categoryId) => ReloadRecords(categoryId);

        private void BtnAddCategory_Click(object sender, EventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManageCategories))
                return;

            AddUpdateCategoryForm addUpdateCategoryForm = new AddUpdateCategoryForm();
            addUpdateCategoryForm.OnNewCategoryAdded += HandleAddedCategory;
            addUpdateCategoryForm.ShowDialog();
            addUpdateCategoryForm.OnNewCategoryAdded -= HandleAddedCategory;
        }

        private void AddNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManageCategories))
                return;

            AddUpdateCategoryForm addUpdateCategoryForm = new AddUpdateCategoryForm();
            addUpdateCategoryForm.OnNewCategoryAdded += HandleAddedCategory;
            addUpdateCategoryForm.ShowDialog();
            addUpdateCategoryForm.OnNewCategoryAdded -= HandleAddedCategory;
        }

        private void UpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManageCategories))
                return;

            int categoryId = (int)DgvCategories.CurrentRow.Cells["CategoryID"].Value;
            AddUpdateCategoryForm addUpdateCategoryForm = new AddUpdateCategoryForm(categoryId);
            addUpdateCategoryForm.ShowDialog();
            ReloadRecords(categoryId);
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManageCategories))
                return;

            int categoryId = (int)DgvCategories.CurrentRow.Cells["CategoryID"].Value;

            if (MessageBox.Show("Delete this category?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (BusinessLogic.BookCategory.DeleteCategory(categoryId))
            {
                MessageBox.Show("Category deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GenericOperations.DeleteRecord(_categoriesDataTable, DgvCategories, LblRecords, categoryId, "CategoryID");
            }
            else
            {
                MessageBox.Show("Delete failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ViewUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!CommonValidation.HandlePermissions(User.Permissions.ManageFinePayments))
                return;

            int categoryId = (int)DgvCategories.CurrentRow.Cells["CategoryID"].Value;
            ViewCategoryCardForm viewCategoryCardForm = new ViewCategoryCardForm(categoryId);
            viewCategoryCardForm.ShowDialog();
            ReloadRecords(categoryId);
        }

        private void ToggleContextMenu(bool enabled)
        {
            ViewCategoryInfoToolStripMenuItem.Enabled = enabled;
            UpdateToolStripMenuItem.Enabled = enabled;
            DeleteToolStripMenuItem.Enabled = enabled;
        }

        private void CmsCategory_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ToggleContextMenu(DgvCategories.Rows.Count > 0);
        }

        private void DgvCategories_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManageCategories))
                return;

            int categoryId = (int)DgvCategories.CurrentRow.Cells["CategoryID"].Value;
            ViewCategoryCardForm viewCategoryCardForm = new ViewCategoryCardForm(categoryId);
            viewCategoryCardForm.ShowDialog();
            ReloadRecords(categoryId);
        }

        private void CbFilterBy_KeyPress(object sender, KeyPressEventArgs e) => CommonValidation.LockEditingControl(e);

        private void BtnClose_Click(object sender, EventArgs e) => Close();
    }
}