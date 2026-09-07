namespace LibrarySystem.Users
{
    partial class ChangePasswordForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TxtCurrentPassword = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtConfirmPassword = new System.Windows.Forms.TextBox();
            this.ChkShowPassword = new System.Windows.Forms.CheckBox();
            this.LblCurrentPassword = new System.Windows.Forms.Label();
            this.LblNewPassword = new System.Windows.Forms.Label();
            this.LblConfirmPassword = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.LblTitle = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.BtnChangePassword = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.viewUserCardControl = new LibrarySystem.Users.Controls.ViewUserCardControl.AccountControl();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtCurrentPassword
            // 
            this.TxtCurrentPassword.Location = new System.Drawing.Point(282, 509);
            this.TxtCurrentPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCurrentPassword.Name = "TxtCurrentPassword";
            this.TxtCurrentPassword.Size = new System.Drawing.Size(219, 35);
            this.TxtCurrentPassword.TabIndex = 1;
            this.TxtCurrentPassword.UseSystemPasswordChar = true;
            this.TxtCurrentPassword.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCurrentPassword_Validating);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(282, 565);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(219, 35);
            this.TxtPassword.TabIndex = 2;
            this.TxtPassword.UseSystemPasswordChar = true;
            this.TxtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.TxtPassword_Validating);
            // 
            // TxtConfirmPassword
            // 
            this.TxtConfirmPassword.Location = new System.Drawing.Point(282, 622);
            this.TxtConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtConfirmPassword.Name = "TxtConfirmPassword";
            this.TxtConfirmPassword.Size = new System.Drawing.Size(219, 35);
            this.TxtConfirmPassword.TabIndex = 3;
            this.TxtConfirmPassword.UseSystemPasswordChar = true;
            this.TxtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.TxtConfirmPassword_Validating);
            // 
            // ChkShowPassword
            // 
            this.ChkShowPassword.AutoSize = true;
            this.ChkShowPassword.Location = new System.Drawing.Point(284, 686);
            this.ChkShowPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChkShowPassword.Name = "ChkShowPassword";
            this.ChkShowPassword.Size = new System.Drawing.Size(193, 34);
            this.ChkShowPassword.TabIndex = 4;
            this.ChkShowPassword.Text = "Show Password";
            this.ChkShowPassword.CheckedChanged += new System.EventHandler(this.ChkShowPassword_CheckedChanged);
            // 
            // LblCurrentPassword
            // 
            this.LblCurrentPassword.AutoSize = true;
            this.LblCurrentPassword.Location = new System.Drawing.Point(30, 514);
            this.LblCurrentPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCurrentPassword.Name = "LblCurrentPassword";
            this.LblCurrentPassword.Size = new System.Drawing.Size(197, 30);
            this.LblCurrentPassword.TabIndex = 0;
            this.LblCurrentPassword.Text = "Current Password:";
            // 
            // LblNewPassword
            // 
            this.LblNewPassword.AutoSize = true;
            this.LblNewPassword.Location = new System.Drawing.Point(60, 571);
            this.LblNewPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNewPassword.Name = "LblNewPassword";
            this.LblNewPassword.Size = new System.Drawing.Size(167, 30);
            this.LblNewPassword.TabIndex = 2;
            this.LblNewPassword.Text = "New Password:";
            // 
            // LblConfirmPassword
            // 
            this.LblConfirmPassword.AutoSize = true;
            this.LblConfirmPassword.Location = new System.Drawing.Point(25, 627);
            this.LblConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblConfirmPassword.Name = "LblConfirmPassword";
            this.LblConfirmPassword.Size = new System.Drawing.Size(202, 30);
            this.LblConfirmPassword.TabIndex = 3;
            this.LblConfirmPassword.Text = "Confirm Password:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.LblTitle.ForeColor = System.Drawing.Color.Red;
            this.LblTitle.Location = new System.Drawing.Point(140, 14);
            this.LblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(361, 46);
            this.LblTitle.TabIndex = 30;
            this.LblTitle.Text = "Change Password";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApp1.Properties.Resources.Change_Password_512;
            this.pictureBox4.Location = new System.Drawing.Point(191, 63);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(276, 154);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 31;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.Change_Password_24;
            this.pictureBox3.Location = new System.Drawing.Point(232, 627);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 29;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.Change_Password_24;
            this.pictureBox2.Location = new System.Drawing.Point(231, 565);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Change_Password_24;
            this.pictureBox1.Location = new System.Drawing.Point(232, 514);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::WindowsFormsApp1.Properties.Resources.Password_32;
            this.pictureBox5.Location = new System.Drawing.Point(234, 686);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(37, 35);
            this.pictureBox5.TabIndex = 26;
            this.pictureBox5.TabStop = false;
            // 
            // BtnChangePassword
            // 
            this.BtnChangePassword.Image = global::WindowsFormsApp1.Properties.Resources.Save_32;
            this.BtnChangePassword.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnChangePassword.Location = new System.Drawing.Point(224, 744);
            this.BtnChangePassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnChangePassword.Name = "BtnChangePassword";
            this.BtnChangePassword.Size = new System.Drawing.Size(265, 63);
            this.BtnChangePassword.TabIndex = 5;
            this.BtnChangePassword.Text = "Change Password";
            this.BtnChangePassword.UseVisualStyleBackColor = true;
            this.BtnChangePassword.Click += new System.EventHandler(this.BtnChangePassword_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Image = global::WindowsFormsApp1.Properties.Resources.Close_32;
            this.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClose.Location = new System.Drawing.Point(510, 744);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(150, 63);
            this.BtnClose.TabIndex = 6;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // viewUserCardControl
            // 
            this.viewUserCardControl.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.viewUserCardControl.Location = new System.Drawing.Point(14, 239);
            this.viewUserCardControl.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.viewUserCardControl.Name = "viewUserCardControl";
            this.viewUserCardControl.Size = new System.Drawing.Size(646, 244);
            this.viewUserCardControl.TabIndex = 32;
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 821);
            this.Controls.Add(this.viewUserCardControl);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.LblCurrentPassword);
            this.Controls.Add(this.TxtCurrentPassword);
            this.Controls.Add(this.LblNewPassword);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.LblConfirmPassword);
            this.Controls.Add(this.TxtConfirmPassword);
            this.Controls.Add(this.ChkShowPassword);
            this.Controls.Add(this.BtnChangePassword);
            this.Controls.Add(this.BtnClose);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChangePasswordForm";
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.ChangePasswordForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox TxtCurrentPassword;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtConfirmPassword;
        private System.Windows.Forms.CheckBox ChkShowPassword;
        private System.Windows.Forms.Button BtnChangePassword;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label LblCurrentPassword;
        private System.Windows.Forms.Label LblNewPassword;
        private System.Windows.Forms.Label LblConfirmPassword;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label LblTitle;
        private Controls.ViewUserCardControl.AccountControl viewUserCardControl;
    }
}