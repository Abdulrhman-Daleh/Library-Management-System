using BusinessLogic;
using System;
using System.Data;
using System.Reflection.Emit;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LibrarySystem.Common
{
    public static class CommonValidation
    {
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            string pattern = @"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z]{2,})+$";
            return Regex.IsMatch(email, pattern);
        }

        public static bool IsPasswordMatch(string password, string confirmPassword)
        {
            return password == confirmPassword;
        }

        public static bool IsDataTableEmpty(DataTable dataTable)
        {
            return dataTable == null || dataTable.Rows.Count == 0;
        }

        public static string GetFilterName(ComboBox comboBox)
        {
            return comboBox.Text.Replace(" ", "");
        }

        public static bool IsNoneFilter(ComboBox comboBox)
        {
            return GetFilterName(comboBox) == "None";
        }

        public static void LockEditingControl(KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        public static void EnableOnlyDigits(KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        public static void ConfigureDataGridView(DataTable dataTable, DataGridView dataGridView)
        {
            dataGridView.DataSource = dataTable;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
        }

        public static void UpdateRecordCount(DataGridView dataGridView, System.Windows.Forms.Label recordLabel)
        {
            recordLabel.Text = dataGridView.Rows.Count.ToString();
        }

        public static bool HasValidationErrors(Control.ControlCollection controls, ErrorProvider errorProvider, Form form)
        {
            form.ValidateChildren();
            foreach (Control control in controls)
            {
                if (control is TextBox || control is MaskedTextBox)
                {
                    if (!string.IsNullOrWhiteSpace(errorProvider.GetError(control)))
                        return true;
                }
            }
            return false;
        }

        public static bool IsRequired(Control control, ErrorProvider errorProvider)
        {
            if (string.IsNullOrWhiteSpace(control.Text.Trim()))
            {
                errorProvider.SetError(control, "This field is required");
                return true;
            }

            errorProvider.SetError(control, null);
            return false;
        }

        public static bool HandlePermissions(User.Permissions requiredPermission)
        {
            if (!GlobalContext.IsUserValid())
                return false;


            if (!GlobalContext.CurrentUser.HasPermission(requiredPermission))
            {
                MessageBox.Show("You don't have permission to perform this operation", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public static bool IsNotValidIsbn(string isbn)
        {
            if (isbn.Length > 14 || isbn.Length <= 12)
                return false;

            return Book.IsIsbnAlreadyUsed(isbn);
        }

        private static void _ResetTextBox(TextBox tBox)
        {
            if (tBox == null) return;

            tBox.Text = string.Empty;
            tBox.Visible = false;
        }

        private static void _ResetComboBox(ComboBox cBox)
        {
            if (cBox == null) return;

            cBox.SelectedIndex = 0;
            cBox.Visible = false;
        }


        private static void _ToggleComboBox(ComboBox cBox)
        {
            if (cBox != null)
            {
                cBox.Visible = true;
                cBox.SelectedIndex = 0;
                cBox.Select();
            }
        }

        private static void _ToggleFilter(string filterName, TextBox txtFilter, ComboBox cbIsActive)
        {
            if (filterName == "IsActive" || filterName == "IsPaid")
            {
                _ToggleComboBox(cbIsActive);
                _ResetTextBox(txtFilter);
            }
            else
            {
                _ResetComboBox(cbIsActive);
                txtFilter.Text = string.Empty;
                txtFilter.Visible = true;
                txtFilter.Select();
            }
        }


        public static void ResetFilterOnIndexChange(DataTable dataTable, ComboBox filterComboBox, TextBox filterTextBox, ComboBox secondaryComboBox = null)
        {
            if (!IsDataTableEmpty(dataTable))
                ResetFilterView(dataTable);

            if (IsNoneFilter(filterComboBox))
            {
                filterComboBox.SelectedIndex = 0;
                _ResetTextBox(filterTextBox);
                _ResetComboBox(secondaryComboBox);
            }
            else
                _ToggleFilter(GetFilterName(filterComboBox), filterTextBox, secondaryComboBox);
        }

        public static void ResetFilterView(DataTable dataTable)
        {
            if (!IsDataTableEmpty(dataTable))
                dataTable.DefaultView.RowFilter = "";
        }

        public static bool AllowFilter(TextBox filterTextBox, ComboBox filterComboBox, DataTable dataTable)
        {
            if (IsDataTableEmpty(dataTable))
            {
                ResetFilterOnIndexChange(dataTable, filterComboBox, filterTextBox);
                return false;
            }

            if (string.IsNullOrEmpty(filterTextBox.Text) || IsNoneFilter(filterComboBox))
            {
                ResetFilterView(dataTable);
                return false;
            }

            return true;
        }
    }
}