using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Categories.Controls
{
    public partial class ViewCategoryControl : BaseUserControl
    {
        public ViewCategoryControl()
        {
            InitializeComponent();
        }

        public void LoadCategoryInfo(int categoryId)
        {
            BookCategory category = BookCategory.FindCategory(categoryId);

            if (category == null)
            {
                MessageBox.Show($"Category ID {categoryId} not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LblCategoryId.Text = category.CategoryId.ToString();
            LblCategoryName.Text = category.CategoryName;
            LblCategoryDescription.Text = category.CategoryDescription;
        }
    }
}
