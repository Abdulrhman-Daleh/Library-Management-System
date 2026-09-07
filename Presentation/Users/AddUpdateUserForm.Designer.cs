using Presentation.Properties;

namespace LibrarySystem.Users
{
    partial class AddUpdateUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUpdateUserForm));
            this.LblTitle = new System.Windows.Forms.Label();
            this.TcPages = new System.Windows.Forms.TabControl();
            this.TpSelectPerson = new System.Windows.Forms.TabPage();
            this.findPersonWithFilterControl = new LibrarySystem.People.Controls.FindPersonWithFilterControl();
            this.BtnNext = new System.Windows.Forms.Button();
            this.TpAddNewUser = new System.Windows.Forms.TabPage();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnNextPermissions = new System.Windows.Forms.Button();
            this.PreviousToSelect = new System.Windows.Forms.Button();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtConfirmPassword = new System.Windows.Forms.TextBox();
            this.ChkIsActive = new System.Windows.Forms.CheckBox();
            this.ChkShowPassword = new System.Windows.Forms.CheckBox();
            this.LblUserId = new System.Windows.Forms.Label();
            this.TbPermissions = new System.Windows.Forms.TabPage();
            this.GbPermissions = new System.Windows.Forms.GroupBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.ChkAll = new System.Windows.Forms.CheckBox();
            this.ChkNone = new System.Windows.Forms.CheckBox();
            this.ChkManagePeople = new System.Windows.Forms.CheckBox();
            this.ChkManageUsers = new System.Windows.Forms.CheckBox();
            this.ChkManageMembers = new System.Windows.Forms.CheckBox();
            this.ChkManageCategories = new System.Windows.Forms.CheckBox();
            this.ChkManageBooks = new System.Windows.Forms.CheckBox();
            this.ChkManageBookCopies = new System.Windows.Forms.CheckBox();
            this.ChkManageMemberships = new System.Windows.Forms.CheckBox();
            this.ChkManagePolicies = new System.Windows.Forms.CheckBox();
            this.ChkManageReports = new System.Windows.Forms.CheckBox();
            this.ChkMembershipRenewals = new System.Windows.Forms.CheckBox();
            this.ChkBorrowTransactions = new System.Windows.Forms.CheckBox();
            this.ChkManageFinePayments = new System.Windows.Forms.CheckBox();
            this.LblPermissionMessage = new System.Windows.Forms.Label();
            this.BtnPrevious = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.TcPages.SuspendLayout();
            this.TpSelectPerson.SuspendLayout();
            this.TpAddNewUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.TbPermissions.SuspendLayout();
            this.GbPermissions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.LblTitle.ForeColor = System.Drawing.Color.Red;
            this.LblTitle.Location = new System.Drawing.Point(274, 11);
            this.LblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(289, 46);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Add New User";
            // 
            // TcPages
            // 
            this.TcPages.Controls.Add(this.TpSelectPerson);
            this.TcPages.Controls.Add(this.TpAddNewUser);
            this.TcPages.Controls.Add(this.TbPermissions);
            this.TcPages.Location = new System.Drawing.Point(13, 227);
            this.TcPages.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TcPages.Name = "TcPages";
            this.TcPages.SelectedIndex = 0;
            this.TcPages.Size = new System.Drawing.Size(821, 625);
            this.TcPages.TabIndex = 1;
            // 
            // TpSelectPerson
            // 
            this.TpSelectPerson.Controls.Add(this.findPersonWithFilterControl);
            this.TpSelectPerson.Controls.Add(this.BtnNext);
            this.TpSelectPerson.Location = new System.Drawing.Point(4, 38);
            this.TpSelectPerson.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TpSelectPerson.Name = "TpSelectPerson";
            this.TpSelectPerson.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TpSelectPerson.Size = new System.Drawing.Size(813, 583);
            this.TpSelectPerson.TabIndex = 0;
            this.TpSelectPerson.Text = "Select Person";
            this.TpSelectPerson.UseVisualStyleBackColor = true;
            // 
            // findPersonWithFilterControl
            // 
            this.findPersonWithFilterControl.AllowSearchSection = false;
            this.findPersonWithFilterControl.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.findPersonWithFilterControl.Location = new System.Drawing.Point(9, 11);
            this.findPersonWithFilterControl.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.findPersonWithFilterControl.Name = "findPersonWithFilterControl";
            this.findPersonWithFilterControl.Size = new System.Drawing.Size(795, 479);
            this.findPersonWithFilterControl.TabIndex = 9;
            // 
            // BtnNext
            // 
            this.BtnNext.Image = global::WindowsFormsApp1.Properties.Resources.Next_32;
            this.BtnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNext.Location = new System.Drawing.Point(654, 501);
            this.BtnNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(150, 64);
            this.BtnNext.TabIndex = 1;
            this.BtnNext.Text = "Next";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // TpAddNewUser
            // 
            this.TpAddNewUser.Controls.Add(this.pictureBox6);
            this.TpAddNewUser.Controls.Add(this.pictureBox5);
            this.TpAddNewUser.Controls.Add(this.pictureBox4);
            this.TpAddNewUser.Controls.Add(this.pictureBox2);
            this.TpAddNewUser.Controls.Add(this.pictureBox1);
            this.TpAddNewUser.Controls.Add(this.pictureBox3);
            this.TpAddNewUser.Controls.Add(this.label4);
            this.TpAddNewUser.Controls.Add(this.label3);
            this.TpAddNewUser.Controls.Add(this.label2);
            this.TpAddNewUser.Controls.Add(this.label1);
            this.TpAddNewUser.Controls.Add(this.BtnNextPermissions);
            this.TpAddNewUser.Controls.Add(this.PreviousToSelect);
            this.TpAddNewUser.Controls.Add(this.TxtUsername);
            this.TpAddNewUser.Controls.Add(this.TxtPassword);
            this.TpAddNewUser.Controls.Add(this.TxtConfirmPassword);
            this.TpAddNewUser.Controls.Add(this.ChkIsActive);
            this.TpAddNewUser.Controls.Add(this.ChkShowPassword);
            this.TpAddNewUser.Controls.Add(this.LblUserId);
            this.TpAddNewUser.Enabled = false;
            this.TpAddNewUser.Location = new System.Drawing.Point(4, 38);
            this.TpAddNewUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TpAddNewUser.Name = "TpAddNewUser";
            this.TpAddNewUser.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TpAddNewUser.Size = new System.Drawing.Size(813, 583);
            this.TpAddNewUser.TabIndex = 1;
            this.TpAddNewUser.Text = "User Details";
            this.TpAddNewUser.UseVisualStyleBackColor = true;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::WindowsFormsApp1.Properties.Resources.ID_32;
            this.pictureBox6.Location = new System.Drawing.Point(160, 38);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(37, 35);
            this.pictureBox6.TabIndex = 26;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::WindowsFormsApp1.Properties.Resources.Show_Password_32;
            this.pictureBox5.Location = new System.Drawing.Point(313, 366);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(37, 35);
            this.pictureBox5.TabIndex = 25;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(304, 238);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(37, 35);
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(304, 175);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 35);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Active;
            this.pictureBox1.Location = new System.Drawing.Point(313, 312);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 35);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.Person_32;
            this.pictureBox3.Location = new System.Drawing.Point(304, 109);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 35);
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(76, 242);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 31);
            this.label4.TabIndex = 13;
            this.label4.Text = "Confirm Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(171, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 31);
            this.label3.TabIndex = 12;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(166, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(62, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "User ID:";
            // 
            // BtnNextPermissions
            // 
            this.BtnNextPermissions.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNextPermissions.Location = new System.Drawing.Point(653, 507);
            this.BtnNextPermissions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnNextPermissions.Name = "BtnNextPermissions";
            this.BtnNextPermissions.Size = new System.Drawing.Size(150, 64);
            this.BtnNextPermissions.TabIndex = 8;
            this.BtnNextPermissions.Text = "Next";
            this.BtnNextPermissions.UseVisualStyleBackColor = true;
            this.BtnNextPermissions.Click += new System.EventHandler(this.NextSetPermissions_Click);
            // 
            // PreviousToSelect
            // 
            this.PreviousToSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PreviousToSelect.Location = new System.Drawing.Point(453, 503);
            this.PreviousToSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PreviousToSelect.Name = "PreviousToSelect";
            this.PreviousToSelect.Size = new System.Drawing.Size(192, 68);
            this.PreviousToSelect.TabIndex = 7;
            this.PreviousToSelect.Text = "Previous";
            this.PreviousToSelect.UseVisualStyleBackColor = true;
            this.PreviousToSelect.Click += new System.EventHandler(this.PreviousToSelect_Click);
            // 
            // TxtUsername
            // 
            this.TxtUsername.Location = new System.Drawing.Point(348, 109);
            this.TxtUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(238, 35);
            this.TxtUsername.TabIndex = 2;
            this.TxtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.TxtUsername_Validating);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(348, 175);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(238, 35);
            this.TxtPassword.TabIndex = 3;
            this.TxtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.TxtPassword_Validating);
            // 
            // TxtConfirmPassword
            // 
            this.TxtConfirmPassword.Location = new System.Drawing.Point(348, 238);
            this.TxtConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtConfirmPassword.Name = "TxtConfirmPassword";
            this.TxtConfirmPassword.Size = new System.Drawing.Size(238, 35);
            this.TxtConfirmPassword.TabIndex = 4;
            this.TxtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.TxtConfirmPassword_Validating);
            // 
            // ChkIsActive
            // 
            this.ChkIsActive.AutoSize = true;
            this.ChkIsActive.Location = new System.Drawing.Point(357, 312);
            this.ChkIsActive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChkIsActive.Name = "ChkIsActive";
            this.ChkIsActive.Size = new System.Drawing.Size(98, 34);
            this.ChkIsActive.TabIndex = 5;
            this.ChkIsActive.Text = "Active";
            // 
            // ChkShowPassword
            // 
            this.ChkShowPassword.AutoSize = true;
            this.ChkShowPassword.Location = new System.Drawing.Point(357, 367);
            this.ChkShowPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChkShowPassword.Name = "ChkShowPassword";
            this.ChkShowPassword.Size = new System.Drawing.Size(193, 34);
            this.ChkShowPassword.TabIndex = 6;
            this.ChkShowPassword.Text = "Show Password";
            this.ChkShowPassword.CheckedChanged += new System.EventHandler(this.ChkShowPassword_CheckedChanged);
            // 
            // LblUserId
            // 
            this.LblUserId.AutoSize = true;
            this.LblUserId.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserId.ForeColor = System.Drawing.Color.Red;
            this.LblUserId.Location = new System.Drawing.Point(198, 40);
            this.LblUserId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblUserId.Name = "LblUserId";
            this.LblUserId.Size = new System.Drawing.Size(77, 33);
            this.LblUserId.TabIndex = 5;
            this.LblUserId.Text = "[????]";
            // 
            // TbPermissions
            // 
            this.TbPermissions.Controls.Add(this.GbPermissions);
            this.TbPermissions.Controls.Add(this.LblPermissionMessage);
            this.TbPermissions.Controls.Add(this.BtnPrevious);
            this.TbPermissions.Enabled = false;
            this.TbPermissions.Location = new System.Drawing.Point(4, 38);
            this.TbPermissions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TbPermissions.Name = "TbPermissions";
            this.TbPermissions.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TbPermissions.Size = new System.Drawing.Size(813, 583);
            this.TbPermissions.TabIndex = 2;
            this.TbPermissions.Text = "Permissions";
            this.TbPermissions.UseVisualStyleBackColor = true;
            // 
            // GbPermissions
            // 
            this.GbPermissions.Controls.Add(this.pictureBox20);
            this.GbPermissions.Controls.Add(this.pictureBox19);
            this.GbPermissions.Controls.Add(this.pictureBox18);
            this.GbPermissions.Controls.Add(this.pictureBox17);
            this.GbPermissions.Controls.Add(this.pictureBox16);
            this.GbPermissions.Controls.Add(this.pictureBox15);
            this.GbPermissions.Controls.Add(this.pictureBox14);
            this.GbPermissions.Controls.Add(this.pictureBox13);
            this.GbPermissions.Controls.Add(this.pictureBox12);
            this.GbPermissions.Controls.Add(this.pictureBox11);
            this.GbPermissions.Controls.Add(this.pictureBox10);
            this.GbPermissions.Controls.Add(this.pictureBox9);
            this.GbPermissions.Controls.Add(this.pictureBox7);
            this.GbPermissions.Controls.Add(this.pictureBox8);
            this.GbPermissions.Controls.Add(this.ChkAll);
            this.GbPermissions.Controls.Add(this.ChkNone);
            this.GbPermissions.Controls.Add(this.ChkManagePeople);
            this.GbPermissions.Controls.Add(this.ChkManageUsers);
            this.GbPermissions.Controls.Add(this.ChkManageMembers);
            this.GbPermissions.Controls.Add(this.ChkManageCategories);
            this.GbPermissions.Controls.Add(this.ChkManageBooks);
            this.GbPermissions.Controls.Add(this.ChkManageBookCopies);
            this.GbPermissions.Controls.Add(this.ChkManageMemberships);
            this.GbPermissions.Controls.Add(this.ChkManagePolicies);
            this.GbPermissions.Controls.Add(this.ChkManageReports);
            this.GbPermissions.Controls.Add(this.ChkMembershipRenewals);
            this.GbPermissions.Controls.Add(this.ChkBorrowTransactions);
            this.GbPermissions.Controls.Add(this.ChkManageFinePayments);
            this.GbPermissions.Location = new System.Drawing.Point(8, 10);
            this.GbPermissions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GbPermissions.Name = "GbPermissions";
            this.GbPermissions.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GbPermissions.Size = new System.Drawing.Size(799, 475);
            this.GbPermissions.TabIndex = 0;
            this.GbPermissions.TabStop = false;
            this.GbPermissions.Text = "Permissions";
            // 
            // pictureBox20
            // 
            this.pictureBox20.Image = global::WindowsFormsApp1.Properties.Resources.Book_32;
            this.pictureBox20.Location = new System.Drawing.Point(39, 323);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(35, 29);
            this.pictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox20.TabIndex = 48;
            this.pictureBox20.TabStop = false;
            // 
            // pictureBox19
            // 
            this.pictureBox19.Image = global::WindowsFormsApp1.Properties.Resources.Book_Copy_32;
            this.pictureBox19.Location = new System.Drawing.Point(39, 378);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(35, 29);
            this.pictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox19.TabIndex = 47;
            this.pictureBox19.TabStop = false;
            // 
            // pictureBox18
            // 
            this.pictureBox18.Image = global::WindowsFormsApp1.Properties.Resources.Manage_Borrowing_32;
            this.pictureBox18.Location = new System.Drawing.Point(382, 264);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(35, 29);
            this.pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox18.TabIndex = 46;
            this.pictureBox18.TabStop = false;
            // 
            // pictureBox17
            // 
            this.pictureBox17.Image = global::WindowsFormsApp1.Properties.Resources.Permission_None_32;
            this.pictureBox17.Location = new System.Drawing.Point(250, 39);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(35, 29);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox17.TabIndex = 45;
            this.pictureBox17.TabStop = false;
            // 
            // pictureBox16
            // 
            this.pictureBox16.Image = global::WindowsFormsApp1.Properties.Resources.Person_32;
            this.pictureBox16.Location = new System.Drawing.Point(39, 103);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(35, 29);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox16.TabIndex = 44;
            this.pictureBox16.TabStop = false;
            // 
            // pictureBox15
            // 
            this.pictureBox15.Image = global::WindowsFormsApp1.Properties.Resources.User_32;
            this.pictureBox15.Location = new System.Drawing.Point(39, 159);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(35, 29);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox15.TabIndex = 43;
            this.pictureBox15.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.Image = global::WindowsFormsApp1.Properties.Resources.Member_32;
            this.pictureBox14.Location = new System.Drawing.Point(39, 215);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(35, 29);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox14.TabIndex = 42;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = global::WindowsFormsApp1.Properties.Resources.Category_32;
            this.pictureBox13.Location = new System.Drawing.Point(39, 269);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(35, 29);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox13.TabIndex = 41;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::WindowsFormsApp1.Properties.Resources.Policy_32;
            this.pictureBox12.Location = new System.Drawing.Point(382, 103);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(35, 29);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 40;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::WindowsFormsApp1.Properties.Resources.Report_32;
            this.pictureBox11.Location = new System.Drawing.Point(382, 159);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(35, 29);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 39;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::WindowsFormsApp1.Properties.Resources.Fine_32;
            this.pictureBox10.Location = new System.Drawing.Point(382, 318);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(35, 29);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 38;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::WindowsFormsApp1.Properties.Resources.Membership_32;
            this.pictureBox9.Location = new System.Drawing.Point(39, 427);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(35, 29);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 37;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::WindowsFormsApp1.Properties.Resources.Membership_Renewal_32;
            this.pictureBox7.Location = new System.Drawing.Point(382, 215);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(35, 29);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 36;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::WindowsFormsApp1.Properties.Resources.Permission_All_32;
            this.pictureBox8.Location = new System.Drawing.Point(39, 39);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(35, 29);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 35;
            this.pictureBox8.TabStop = false;
            // 
            // ChkAll
            // 
            this.ChkAll.AutoSize = true;
            this.ChkAll.Location = new System.Drawing.Point(87, 36);
            this.ChkAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChkAll.Name = "ChkAll";
            this.ChkAll.Size = new System.Drawing.Size(62, 34);
            this.ChkAll.TabIndex = 9;
            this.ChkAll.Tag = "-1";
            this.ChkAll.Text = "All";
            this.ChkAll.CheckedChanged += new System.EventHandler(this.ChkAll_CheckedChanged);
            // 
            // ChkNone
            // 
            this.ChkNone.AutoSize = true;
            this.ChkNone.Location = new System.Drawing.Point(293, 36);
            this.ChkNone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChkNone.Name = "ChkNone";
            this.ChkNone.Size = new System.Drawing.Size(90, 34);
            this.ChkNone.TabIndex = 10;
            this.ChkNone.Tag = "0";
            this.ChkNone.Text = "None";
            this.ChkNone.CheckedChanged += new System.EventHandler(this.ChkNone_CheckedChanged);
            // 
            // ChkManagePeople
            // 
            this.ChkManagePeople.AutoSize = true;
            this.ChkManagePeople.Location = new System.Drawing.Point(87, 100);
            this.ChkManagePeople.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChkManagePeople.Name = "ChkManagePeople";
            this.ChkManagePeople.Size = new System.Drawing.Size(195, 34);
            this.ChkManagePeople.TabIndex = 11;
            this.ChkManagePeople.Tag = "1";
            this.ChkManagePeople.Text = "Manage People";
            // 
            // ChkManageUsers
            // 
            this.ChkManageUsers.AutoSize = true;
            this.ChkManageUsers.Location = new System.Drawing.Point(87, 156);
            this.ChkManageUsers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChkManageUsers.Name = "ChkManageUsers";
            this.ChkManageUsers.Size = new System.Drawing.Size(181, 34);
            this.ChkManageUsers.TabIndex = 13;
            this.ChkManageUsers.Tag = "2";
            this.ChkManageUsers.Text = "Manage Users";
            // 
            // ChkManageMembers
            // 
            this.ChkManageMembers.AutoSize = true;
            this.ChkManageMembers.Location = new System.Drawing.Point(87, 210);
            this.ChkManageMembers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChkManageMembers.Name = "ChkManageMembers";
            this.ChkManageMembers.Size = new System.Drawing.Size(222, 34);
            this.ChkManageMembers.TabIndex = 15;
            this.ChkManageMembers.Tag = "4";
            this.ChkManageMembers.Text = "Manage Members";
            // 
            // ChkManageCategories
            // 
            this.ChkManageCategories.AutoSize = true;
            this.ChkManageCategories.Location = new System.Drawing.Point(87, 264);
            this.ChkManageCategories.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChkManageCategories.Name = "ChkManageCategories";
            this.ChkManageCategories.Size = new System.Drawing.Size(234, 34);
            this.ChkManageCategories.TabIndex = 17;
            this.ChkManageCategories.Tag = "8";
            this.ChkManageCategories.Text = "Manage Categories";
            // 
            // ChkManageBooks
            // 
            this.ChkManageBooks.AutoSize = true;
            this.ChkManageBooks.Location = new System.Drawing.Point(87, 318);
            this.ChkManageBooks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChkManageBooks.Name = "ChkManageBooks";
            this.ChkManageBooks.Size = new System.Drawing.Size(185, 34);
            this.ChkManageBooks.TabIndex = 19;
            this.ChkManageBooks.Tag = "16";
            this.ChkManageBooks.Text = "Manage Books";
            // 
            // ChkManageBookCopies
            // 
            this.ChkManageBookCopies.AutoSize = true;
            this.ChkManageBookCopies.Location = new System.Drawing.Point(87, 373);
            this.ChkManageBookCopies.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChkManageBookCopies.Name = "ChkManageBookCopies";
            this.ChkManageBookCopies.Size = new System.Drawing.Size(250, 34);
            this.ChkManageBookCopies.TabIndex = 21;
            this.ChkManageBookCopies.Tag = "32";
            this.ChkManageBookCopies.Text = "Manage Book Copies";
            // 
            // ChkManageMemberships
            // 
            this.ChkManageMemberships.AutoSize = true;
            this.ChkManageMemberships.Location = new System.Drawing.Point(87, 427);
            this.ChkManageMemberships.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChkManageMemberships.Name = "ChkManageMemberships";
            this.ChkManageMemberships.Size = new System.Drawing.Size(265, 34);
            this.ChkManageMemberships.TabIndex = 22;
            this.ChkManageMemberships.Tag = "64";
            this.ChkManageMemberships.Text = "Manage Memberships";
            // 
            // ChkManagePolicies
            // 
            this.ChkManagePolicies.AutoSize = true;
            this.ChkManagePolicies.Location = new System.Drawing.Point(426, 100);
            this.ChkManagePolicies.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChkManagePolicies.Name = "ChkManagePolicies";
            this.ChkManagePolicies.Size = new System.Drawing.Size(202, 34);
            this.ChkManagePolicies.TabIndex = 12;
            this.ChkManagePolicies.Tag = "128";
            this.ChkManagePolicies.Text = "Manage Policies";
            // 
            // ChkManageReports
            // 
            this.ChkManageReports.AutoSize = true;
            this.ChkManageReports.Location = new System.Drawing.Point(426, 156);
            this.ChkManageReports.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChkManageReports.Name = "ChkManageReports";
            this.ChkManageReports.Size = new System.Drawing.Size(169, 34);
            this.ChkManageReports.TabIndex = 14;
            this.ChkManageReports.Tag = "256";
            this.ChkManageReports.Text = "View Reports";
            // 
            // ChkMembershipRenewals
            // 
            this.ChkMembershipRenewals.AutoSize = true;
            this.ChkMembershipRenewals.Location = new System.Drawing.Point(426, 210);
            this.ChkMembershipRenewals.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChkMembershipRenewals.Name = "ChkMembershipRenewals";
            this.ChkMembershipRenewals.Size = new System.Drawing.Size(357, 34);
            this.ChkMembershipRenewals.TabIndex = 16;
            this.ChkMembershipRenewals.Tag = "1024";
            this.ChkMembershipRenewals.Text = "Manage Membership Renewals";
            // 
            // ChkBorrowTransactions
            // 
            this.ChkBorrowTransactions.AutoSize = true;
            this.ChkBorrowTransactions.Location = new System.Drawing.Point(426, 264);
            this.ChkBorrowTransactions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChkBorrowTransactions.Name = "ChkBorrowTransactions";
            this.ChkBorrowTransactions.Size = new System.Drawing.Size(331, 34);
            this.ChkBorrowTransactions.TabIndex = 18;
            this.ChkBorrowTransactions.Tag = "512";
            this.ChkBorrowTransactions.Text = "Manage Borrow Transactions";
            // 
            // ChkManageFinePayments
            // 
            this.ChkManageFinePayments.AutoSize = true;
            this.ChkManageFinePayments.Location = new System.Drawing.Point(426, 318);
            this.ChkManageFinePayments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChkManageFinePayments.Name = "ChkManageFinePayments";
            this.ChkManageFinePayments.Size = new System.Drawing.Size(272, 34);
            this.ChkManageFinePayments.TabIndex = 20;
            this.ChkManageFinePayments.Tag = "2048";
            this.ChkManageFinePayments.Text = "Manage Fine Payments";
            // 
            // LblPermissionMessage
            // 
            this.LblPermissionMessage.AutoSize = true;
            this.LblPermissionMessage.ForeColor = System.Drawing.Color.Red;
            this.LblPermissionMessage.Location = new System.Drawing.Point(42, 524);
            this.LblPermissionMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPermissionMessage.Name = "LblPermissionMessage";
            this.LblPermissionMessage.Size = new System.Drawing.Size(0, 30);
            this.LblPermissionMessage.TabIndex = 1;
            this.LblPermissionMessage.Visible = false;
            // 
            // BtnPrevious
            // 
            this.BtnPrevious.Image = global::WindowsFormsApp1.Properties.Resources.Previous_32;
            this.BtnPrevious.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPrevious.Location = new System.Drawing.Point(617, 495);
            this.BtnPrevious.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnPrevious.Name = "BtnPrevious";
            this.BtnPrevious.Size = new System.Drawing.Size(192, 68);
            this.BtnPrevious.TabIndex = 23;
            this.BtnPrevious.Text = "Previous";
            this.BtnPrevious.UseVisualStyleBackColor = true;
            this.BtnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // BtnSave
            // 
            this.BtnSave.Image = global::WindowsFormsApp1.Properties.Resources.Save_32;
            this.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSave.Location = new System.Drawing.Point(684, 858);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(150, 64);
            this.BtnSave.TabIndex = 25;
            this.BtnSave.Text = "Save";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Image = global::WindowsFormsApp1.Properties.Resources.Close_32;
            this.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClose.Location = new System.Drawing.Point(524, 858);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(150, 64);
            this.BtnClose.TabIndex = 24;
            this.BtnClose.Text = "Close";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // pictureBox21
            // 
            this.pictureBox21.Image = global::WindowsFormsApp1.Properties.Resources.Users_512;
            this.pictureBox21.Location = new System.Drawing.Point(282, 60);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(269, 159);
            this.pictureBox21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox21.TabIndex = 11;
            this.pictureBox21.TabStop = false;
            // 
            // AddUpdateUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 937);
            this.Controls.Add(this.pictureBox21);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.TcPages);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddUpdateUserForm";
            this.Text = "Add/Update User";
            this.Load += new System.EventHandler(this.AddUpdateUserForm_Load);
            this.TcPages.ResumeLayout(false);
            this.TpSelectPerson.ResumeLayout(false);
            this.TpAddNewUser.ResumeLayout(false);
            this.TpAddNewUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.TbPermissions.ResumeLayout(false);
            this.TbPermissions.PerformLayout();
            this.GbPermissions.ResumeLayout(false);
            this.GbPermissions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.TabControl TcPages;
        private System.Windows.Forms.TabPage TpSelectPerson;
        private System.Windows.Forms.TabPage TpAddNewUser;
        private System.Windows.Forms.TabPage TbPermissions;
        private System.Windows.Forms.Button BtnPrevious;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtConfirmPassword;
        private System.Windows.Forms.CheckBox ChkIsActive;
        private System.Windows.Forms.CheckBox ChkShowPassword;
        private System.Windows.Forms.Label LblUserId;
        private System.Windows.Forms.GroupBox GbPermissions;
        private System.Windows.Forms.CheckBox ChkAll;
        private System.Windows.Forms.CheckBox ChkNone;
        private System.Windows.Forms.CheckBox ChkManagePeople;
        private System.Windows.Forms.CheckBox ChkManageUsers;
        private System.Windows.Forms.CheckBox ChkManageMembers;
        private System.Windows.Forms.CheckBox ChkManageCategories;
        private System.Windows.Forms.CheckBox ChkManageBooks;
        private System.Windows.Forms.CheckBox ChkManageBookCopies;
        private System.Windows.Forms.CheckBox ChkManageMemberships;
        private System.Windows.Forms.CheckBox ChkManagePolicies;
        private System.Windows.Forms.CheckBox ChkManageReports;
        private System.Windows.Forms.CheckBox ChkMembershipRenewals;
        private System.Windows.Forms.CheckBox ChkBorrowTransactions;
        private System.Windows.Forms.CheckBox ChkManageFinePayments;
        private System.Windows.Forms.Label LblPermissionMessage;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnNextPermissions;
        private System.Windows.Forms.Button PreviousToSelect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox20;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.PictureBox pictureBox18;
        private People.Controls.FindPersonWithFilterControl findPersonWithFilterControl;
        private System.Windows.Forms.PictureBox pictureBox21;
    }
}