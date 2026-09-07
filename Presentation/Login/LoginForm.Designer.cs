namespace LibrarySystem.Login
{
    partial class LoginForm
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
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LnkRegisterNewUser = new System.Windows.Forms.LinkLabel();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.ChkRememberMe = new System.Windows.Forms.CheckBox();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.ChkShowPassword = new System.Windows.Forms.CheckBox();
            this.LblPassword = new System.Windows.Forms.Label();
            this.LblUserName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Library_512;
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TxtPassword);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox4);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox3);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox2);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.LnkRegisterNewUser);
            this.splitContainer1.Panel2.Controls.Add(this.BtnLogin);
            this.splitContainer1.Panel2.Controls.Add(this.ChkRememberMe);
            this.splitContainer1.Panel2.Controls.Add(this.TxtUserName);
            this.splitContainer1.Panel2.Controls.Add(this.ChkShowPassword);
            this.splitContainer1.Panel2.Controls.Add(this.LblPassword);
            this.splitContainer1.Panel2.Controls.Add(this.LblUserName);
            this.splitContainer1.Size = new System.Drawing.Size(913, 589);
            this.splitContainer1.SplitterDistance = 394;
            this.splitContainer1.TabIndex = 1;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(227, 238);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(223, 35);
            this.TxtPassword.TabIndex = 14;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApp1.Properties.Resources.Remember_Me_32;
            this.pictureBox4.Location = new System.Drawing.Point(262, 324);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(34, 39);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.Show_Password_32;
            this.pictureBox3.Location = new System.Drawing.Point(19, 324);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 39);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.Change_Password_24;
            this.pictureBox2.Location = new System.Drawing.Point(186, 239);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Person_32;
            this.pictureBox1.Location = new System.Drawing.Point(186, 172);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 48);
            this.label1.TabIndex = 6;
            this.label1.Text = "Log In";
            // 
            // LnkRegisterNewUser
            // 
            this.LnkRegisterNewUser.AutoSize = true;
            this.LnkRegisterNewUser.Location = new System.Drawing.Point(284, 391);
            this.LnkRegisterNewUser.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LnkRegisterNewUser.Name = "LnkRegisterNewUser";
            this.LnkRegisterNewUser.Size = new System.Drawing.Size(194, 30);
            this.LnkRegisterNewUser.TabIndex = 5;
            this.LnkRegisterNewUser.TabStop = true;
            this.LnkRegisterNewUser.Text = "Register new user";
            this.LnkRegisterNewUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkRegisterNewUser_LinkClicked);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Image = global::WindowsFormsApp1.Properties.Resources.Login_32;
            this.BtnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLogin.Location = new System.Drawing.Point(351, 507);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(150, 55);
            this.BtnLogin.TabIndex = 4;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // ChkRememberMe
            // 
            this.ChkRememberMe.AutoSize = true;
            this.ChkRememberMe.Location = new System.Drawing.Point(304, 327);
            this.ChkRememberMe.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ChkRememberMe.Name = "ChkRememberMe";
            this.ChkRememberMe.Size = new System.Drawing.Size(185, 34);
            this.ChkRememberMe.TabIndex = 2;
            this.ChkRememberMe.Text = "Remember me";
            // 
            // TxtUserName
            // 
            this.TxtUserName.Location = new System.Drawing.Point(227, 173);
            this.TxtUserName.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(223, 35);
            this.TxtUserName.TabIndex = 0;
            this.TxtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.TxtUserName_Validating);
            // 
            // ChkShowPassword
            // 
            this.ChkShowPassword.AutoSize = true;
            this.ChkShowPassword.Location = new System.Drawing.Point(68, 327);
            this.ChkShowPassword.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ChkShowPassword.Name = "ChkShowPassword";
            this.ChkShowPassword.Size = new System.Drawing.Size(193, 34);
            this.ChkShowPassword.TabIndex = 3;
            this.ChkShowPassword.Text = "Show Password";
            this.ChkShowPassword.CheckedChanged += new System.EventHandler(this.ChkShowPassword_CheckedChanged);
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(63, 243);
            this.LblPassword.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(115, 30);
            this.LblPassword.TabIndex = 0;
            this.LblPassword.Text = "Password:";
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.Location = new System.Drawing.Point(57, 177);
            this.LblUserName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(121, 30);
            this.LblUserName.TabIndex = 0;
            this.LblUserName.Text = "Username:";
            // 
            // LoginForm
            // 
            this.AcceptButton = this.BtnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 589);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel LnkRegisterNewUser;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.CheckBox ChkRememberMe;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.CheckBox ChkShowPassword;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox TxtPassword;
    }
}