using BusinessLogic;
using LibrarySystem.Common;
using LibrarySystem.Users;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LibrarySystem.Login
{
    public partial class LoginForm : BaseForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private string _loginFilePath = "LoginInfo.txt";
        private void FocusUsername() => TxtUserName.Select();

        private void OpenMainForm()
        {
            this.Hide();
            MainForm mainForm = new MainForm(this);
            mainForm.ShowDialog();
        }

        private void SetSuccessfulLogin(User.LoginResult result)
        {
            GlobalContext.CurrentUser = result.Data;
            GlobalContext.CurrentMember = Member.FindByUserId(result.Data.UserId);
            SaveLoginInfo();
            FocusUsername();
            OpenMainForm();
            TxtPassword.Text = string.Empty;
        }

        private void ProcessLogin(User.LoginResult result)
        {
            if (!result.Success)
            {
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FocusUsername();
                return;
            }

            SetSuccessfulLogin(result);
        }

        private string[] SplitLoginData(string line, string separator)
        {
            if (string.IsNullOrEmpty(line) || string.IsNullOrEmpty(separator))
                return Array.Empty<string>();

            return line.Split(new[] { separator }, StringSplitOptions.None);
        }

        private void _FillSavedDataInControls(string Line)
        {
            string[] tokens = SplitLoginData(Line, "#//#");

            if (tokens.Count() <= 0)
                return;

            TxtUserName.Text = tokens[0];
            ChkRememberMe.Checked = true;
        }
        private void LoadSavedLoginInfo()
        {
            if (!File.Exists(_loginFilePath))
                return;

            using(StreamReader Reader = new StreamReader(_loginFilePath))
            {
                string Line = Reader.ReadLine();

                _FillSavedDataInControls(Line);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            ChkShowPassword.Checked = false;
            TxtPassword.UseSystemPasswordChar = !ChkShowPassword.Checked;

            User user = new User();
            user.AddAdminAccount();

            LoadSavedLoginInfo();
            FocusUsername();
            //  Console.WriteLine(PasswordHasher.HashPassword("Admin12345"));
            //100000.mZjoTlHRolr408N81cGZUQ==.SjHDUtGwU/7rXSlex+tIDm5WZvTYpPvM544GlMiz8hk=

        }

        private void ChkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            TxtPassword.UseSystemPasswordChar = !ChkShowPassword.Checked;
        }

        private bool SaveLoginInfo()
        {
            if (ChkRememberMe.Checked)
            {
                string loginLine = TxtUserName.Text.Trim();

                if (!File.Exists(_loginFilePath))
                    File.Create(_loginFilePath);


                File.WriteAllText(_loginFilePath, loginLine);
            }
            else
                File.WriteAllText(_loginFilePath, null);

                return true;
        }

        private void PerformLogin()
        {
            User.LoginResult result = User.Login(TxtUserName.Text.Trim(), TxtPassword.Text.Trim());
            ProcessLogin(result);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (CommonValidation.HasValidationErrors(splitContainer1.Panel1.Controls, errorProvider, this))
            {
                MessageBox.Show("Form is not valid", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PerformLogin();
        }

        private void TxtPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TxtPassword.Text.Trim()))
                errorProvider.SetError(TxtPassword, "This field is required");
            else
                errorProvider.SetError(TxtPassword, null);
        }

        private void LnkRegisterNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddUpdateUserForm addUpdateUserForm = new AddUpdateUserForm();
            addUpdateUserForm.ShowDialog();
        }

        private void TxtUserName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TxtUserName.Text.Trim()))
                errorProvider.SetError(TxtUserName, "This field is required");
            else
                errorProvider.SetError(TxtUserName, null);
        }
    }
}