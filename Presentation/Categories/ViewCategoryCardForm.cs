using BusinessLogic;
using LibrarySystem.Books;
using LibrarySystem.Common;
using System;
using System.Windows.Forms;

namespace LibrarySystem.Categories
{
    public partial class ViewCategoryCardForm : BaseForm
    {
        private int _categoryId;
        public ViewCategoryCardForm(int categoryId)
        {
            InitializeComponent();
            _categoryId = categoryId;
            viewCategoryControl1.LoadCategoryInfo(categoryId);
        }

        private void BtnClose_Click(object sender, EventArgs e) => Close();

        private void LinkEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManageCategories))
                return;

            AddUpdateCategoryForm updateCategory =  new AddUpdateCategoryForm(_categoryId);
            updateCategory.ShowDialog();
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManageBooks))
                return;

            ManageBooksForm manageBooks = new ManageBooksForm(_categoryId);
            manageBooks.ShowDialog();
        }

        private void deleteCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CommonValidation.HandlePermissions(User.Permissions.ManageCategories))
                return;


            if (MessageBox.Show("Delete this category y/n", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (BusinessLogic.BookCategory.DeleteCategory(_categoryId))
                MessageBox.Show("Category deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Delete failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}