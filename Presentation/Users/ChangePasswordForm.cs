using BusinessLogic;
using LibrarySystem.Common;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace LibrarySystem.Users
{
    public partial class ChangePasswordForm : BaseForm
    {
        private User _selectedUser;

        public ChangePasswordForm(int userId)
        {
            InitializeComponent();
            _selectedUser = User.Find(userId, User.FindByType.UserId);
        }

        private bool IsEmptyField(TextBox textBox) => string.IsNullOrEmpty(textBox.Text.Trim());

        private void ResetFields()
        {
            TxtConfirmPassword.Text = "";
            TxtPassword.Text = "";
            TxtCurrentPassword.Text = "";
        }

        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
            if (!_selectedUser.CanChangePassword())
            {
                MessageBox.Show("Password change is locked", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (CommonValidation.HasValidationErrors(this.Controls, errorProvider, this))
            {
                MessageBox.Show("form is not valid to save", "invalid state", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (MessageBox.Show("Change password?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            string newHashedPassword = PasswordHasher.HashPassword(TxtPassword.Text.Trim());

            if (_selectedUser.ChangePassword(newHashedPassword))
            {
                MessageBox.Show("Password changed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetFields();
                Close();
            }
            else
            {
                MessageBox.Show("Failed to change password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (IsEmptyField(textBox))
                return;

            if (!PasswordHasher.VerifyPassword(TxtCurrentPassword.Text.Trim(), _selectedUser.HashedPassword))
            {
                errorProvider.SetError(textBox, "Current password is incorrect");
                return;
            }

            errorProvider.SetError(textBox, null);
        }

        private void TxtPassword_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (IsEmptyField(textBox))
                return;

            if (_selectedUser.DoesPasswordsMatch(TxtPassword.Text.Trim()))
            {
                errorProvider.SetError(TxtPassword, "Password is already used");
                return;
            }

            if (PasswordHasher.VerifyPassword(TxtPassword.Text.Trim(), _selectedUser.HashedPassword))
            {
                errorProvider.SetError(textBox, "Cannot use the same password");
                return;
            }

            if (!GenericOperations.IsInRange(TxtPassword.Text.Trim().Length, 8, 15))
            {
                errorProvider.SetError(textBox, "Password must be 8-15 characters");
                return;
            }

            errorProvider.SetError(textBox, null);
        }

        private void TxtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (IsEmptyField(textBox))
                return;

            if (!CommonValidation.IsPasswordMatch(TxtConfirmPassword.Text.Trim(), TxtPassword.Text.Trim()))
            {
                errorProvider.SetError(textBox, "Passwords do not match");
                return;
            }

            errorProvider.SetError(textBox, null);
        }

        private void SetPasswordVisibility(bool show)
        {
            TxtCurrentPassword.UseSystemPasswordChar = !show;
            TxtPassword.UseSystemPasswordChar = !show;
            TxtConfirmPassword.UseSystemPasswordChar = !show;
        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {
            if (_selectedUser == null)
            {
                MessageBox.Show("User not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            ChkShowPassword.Checked = true;
            viewUserCardControl.LoadUserById(_selectedUser.UserId);
        }

        private void ChkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            SetPasswordVisibility(ChkShowPassword.Checked);
        }

        private void BtnClose_Click(object sender, EventArgs e) => Close();

    }
}