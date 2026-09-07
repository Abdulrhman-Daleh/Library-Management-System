using BusinessLogic;
using LibrarySystem.Common;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace LibrarySystem.Categories
{
    public partial class AddUpdateCategoryForm : BaseForm
    {
        private BusinessLogic.BookCategory _category;

        public delegate void CategoryAddedHandler(int categoryId);
        public event CategoryAddedHandler OnNewCategoryAdded;

        public AddUpdateCategoryForm()
        {
            InitializeComponent();
            _category = new BusinessLogic.BookCategory();
        }

        public AddUpdateCategoryForm(int categoryId)
        {
            InitializeComponent();
            _category = BusinessLogic.BookCategory.FindCategory(categoryId);
        }

        private void LoadUpdatePage()
        {
            LblTitle.Text = "Update Category";
            this.Text = "Update Category Info";
            LblCategoryId.Text = _category.CategoryId.ToString();
            TxtCategoryName.Text = _category.CategoryName;
            TxtCategoryDescription.Text = _category.CategoryDescription;
        }

        private void LoadStartupPage()
        {
            LblTitle.Text = "Add New Book Category";
            this.Text = "Add New Category";
            LblCategoryId.Text = "[????]";
            TxtCategoryDescription.Text = "";
            TxtCategoryName.Text = "";
        }

        private void AddUpdateCategoryForm_Load(object sender, EventArgs e)
        {
            LoadStartupPage();

            if (_category == null)
            {
                MessageBox.Show("Category not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_category.CurrentMode == BusinessLogic.BookCategory.Mode.Update)
                LoadUpdatePage();
        }

        private void BindCategoryInfo()
        {
            _category.CategoryName = TxtCategoryName.Text.Trim();
            _category.CategoryDescription = TxtCategoryDescription.Text.Trim();
        }

        private void ShowSuccessMessage()
        {
            MessageBox.Show("Data saved successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LblCategoryId.Text = _category.CategoryId.ToString();
            LblTitle.Text = "Update Book Category";
            this.Text = "Update Category";
        }

        private void RaiseEvent(int categoryId) => OnNewCategoryAdded?.Invoke(categoryId);

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (CommonValidation.HasValidationErrors(GbCategoryInfo.Controls, errorProvider, this))
            {
                MessageBox.Show("Form is not valid", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            BindCategoryInfo();

            if (_category.Save())
            {
                ShowSuccessMessage();
                RaiseEvent(_category.CategoryId);
            }
            else
            {
                MessageBox.Show("Failed to save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e) => Close();

        private void TxtCategoryName_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(textBox.Text.Trim()))
                errorProvider.SetError(textBox, "This field is required");
            else
                errorProvider.SetError(textBox, null);
        }


    }
}