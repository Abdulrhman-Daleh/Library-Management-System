namespace LibrarySystem.Users
{
    partial class ManageUsersForm
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
            this.DgvUsers = new System.Windows.Forms.DataGridView();
            this.CmsUser = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ViewPersonInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewUserInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeactivateAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ActivateAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CbFilterBy = new System.Windows.Forms.ComboBox();
            this.CbIsActive = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblRecords = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnAddUser = new System.Windows.Forms.Button();
            this.TxtFilter = new WindowsFormsApp1.TextCustomFilterControl();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsers)).BeginInit();
            this.CmsUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvUsers
            // 
            this.DgvUsers.AllowUserToAddRows = false;
            this.DgvUsers.AllowUserToDeleteRows = false;
            this.DgvUsers.AllowUserToOrderColumns = true;
            this.DgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.DgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUsers.ContextMenuStrip = this.CmsUser;
            this.DgvUsers.Location = new System.Drawing.Point(13, 314);
            this.DgvUsers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvUsers.Name = "DgvUsers";
            this.DgvUsers.ReadOnly = true;
            this.DgvUsers.RowHeadersWidth = 51;
            this.DgvUsers.RowTemplate.Height = 24;
            this.DgvUsers.Size = new System.Drawing.Size(740, 407);
            this.DgvUsers.TabIndex = 1;
            this.DgvUsers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUsers_CellDoubleClick);
            // 
            // CmsUser
            // 
            this.CmsUser.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CmsUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewPersonInfoToolStripMenuItem,
            this.ViewUserInfoToolStripMenuItem,
            this.AddNewUserToolStripMenuItem,
            this.UpdateUserToolStripMenuItem,
            this.DeleteUserToolStripMenuItem,
            this.DeactivateAccountToolStripMenuItem,
            this.ActivateAccountToolStripMenuItem,
            this.ChangePasswordToolStripMenuItem,
            this.CallToolStripMenuItem,
            this.SendEmailToolStripMenuItem});
            this.CmsUser.Name = "CmsUser";
            this.CmsUser.Size = new System.Drawing.Size(245, 384);
            this.CmsUser.Opening += new System.ComponentModel.CancelEventHandler(this.CmsUser_Opening);
            // 
            // ViewPersonInfoToolStripMenuItem
            // 
            this.ViewPersonInfoToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.View_32;
            this.ViewPersonInfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ViewPersonInfoToolStripMenuItem.Name = "ViewPersonInfoToolStripMenuItem";
            this.ViewPersonInfoToolStripMenuItem.Size = new System.Drawing.Size(244, 38);
            this.ViewPersonInfoToolStripMenuItem.Text = "View Person Info";
            this.ViewPersonInfoToolStripMenuItem.Click += new System.EventHandler(this.ViewPersonInfoToolStripMenuItem_Click);
            // 
            // ViewUserInfoToolStripMenuItem
            // 
            this.ViewUserInfoToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.View_32;
            this.ViewUserInfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ViewUserInfoToolStripMenuItem.Name = "ViewUserInfoToolStripMenuItem";
            this.ViewUserInfoToolStripMenuItem.Size = new System.Drawing.Size(244, 38);
            this.ViewUserInfoToolStripMenuItem.Text = "View User Info";
            this.ViewUserInfoToolStripMenuItem.Click += new System.EventHandler(this.ViewUserInfoToolStripMenuItem_Click);
            // 
            // AddNewUserToolStripMenuItem
            // 
            this.AddNewUserToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Add_User_32;
            this.AddNewUserToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddNewUserToolStripMenuItem.Name = "AddNewUserToolStripMenuItem";
            this.AddNewUserToolStripMenuItem.Size = new System.Drawing.Size(244, 38);
            this.AddNewUserToolStripMenuItem.Text = "Add New User";
            this.AddNewUserToolStripMenuItem.Click += new System.EventHandler(this.AddNewUserToolStripMenuItem_Click);
            // 
            // UpdateUserToolStripMenuItem
            // 
            this.UpdateUserToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Update_32;
            this.UpdateUserToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.UpdateUserToolStripMenuItem.Name = "UpdateUserToolStripMenuItem";
            this.UpdateUserToolStripMenuItem.Size = new System.Drawing.Size(244, 38);
            this.UpdateUserToolStripMenuItem.Text = "Update User";
            this.UpdateUserToolStripMenuItem.Click += new System.EventHandler(this.UpdateUserToolStripMenuItem_Click);
            // 
            // DeleteUserToolStripMenuItem
            // 
            this.DeleteUserToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Delete_32;
            this.DeleteUserToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DeleteUserToolStripMenuItem.Name = "DeleteUserToolStripMenuItem";
            this.DeleteUserToolStripMenuItem.Size = new System.Drawing.Size(244, 38);
            this.DeleteUserToolStripMenuItem.Text = "Delete User";
            this.DeleteUserToolStripMenuItem.Click += new System.EventHandler(this.DeleteUserToolStripMenuItem_Click);
            // 
            // DeactivateAccountToolStripMenuItem
            // 
            this.DeactivateAccountToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Active;
            this.DeactivateAccountToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DeactivateAccountToolStripMenuItem.Name = "DeactivateAccountToolStripMenuItem";
            this.DeactivateAccountToolStripMenuItem.Size = new System.Drawing.Size(244, 38);
            this.DeactivateAccountToolStripMenuItem.Text = "Deactivate Account";
            this.DeactivateAccountToolStripMenuItem.Click += new System.EventHandler(this.DeactivateAccountToolStripMenuItem_Click);
            // 
            // ActivateAccountToolStripMenuItem
            // 
            this.ActivateAccountToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Active;
            this.ActivateAccountToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ActivateAccountToolStripMenuItem.Name = "ActivateAccountToolStripMenuItem";
            this.ActivateAccountToolStripMenuItem.Size = new System.Drawing.Size(244, 38);
            this.ActivateAccountToolStripMenuItem.Text = "Activate Account";
            this.ActivateAccountToolStripMenuItem.Click += new System.EventHandler(this.ActivateAccountToolStripMenuItem_Click);
            // 
            // ChangePasswordToolStripMenuItem
            // 
            this.ChangePasswordToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.password_reload;
            this.ChangePasswordToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem";
            this.ChangePasswordToolStripMenuItem.Size = new System.Drawing.Size(244, 38);
            this.ChangePasswordToolStripMenuItem.Text = "Change Password";
            this.ChangePasswordToolStripMenuItem.Click += new System.EventHandler(this.ChangePasswordToolStripMenuItem_Click);
            // 
            // CallToolStripMenuItem
            // 
            this.CallToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Phone_32;
            this.CallToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CallToolStripMenuItem.Name = "CallToolStripMenuItem";
            this.CallToolStripMenuItem.Size = new System.Drawing.Size(244, 38);
            this.CallToolStripMenuItem.Text = "Call";
            this.CallToolStripMenuItem.Click += new System.EventHandler(this.CallToolStripMenuItem_Click);
            // 
            // SendEmailToolStripMenuItem
            // 
            this.SendEmailToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Email_32;
            this.SendEmailToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SendEmailToolStripMenuItem.Name = "SendEmailToolStripMenuItem";
            this.SendEmailToolStripMenuItem.Size = new System.Drawing.Size(244, 38);
            this.SendEmailToolStripMenuItem.Text = "Send Email";
            this.SendEmailToolStripMenuItem.Click += new System.EventHandler(this.SendEmailToolStripMenuItem_Click);
            // 
            // CbFilterBy
            // 
            this.CbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbFilterBy.Items.AddRange(new object[] {
            "None",
            "UserID",
            "Username",
            "IsActive"});
            this.CbFilterBy.Location = new System.Drawing.Point(116, 269);
            this.CbFilterBy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbFilterBy.Name = "CbFilterBy";
            this.CbFilterBy.Size = new System.Drawing.Size(178, 37);
            this.CbFilterBy.TabIndex = 3;
            this.CbFilterBy.SelectedIndexChanged += new System.EventHandler(this.CbFilterBy_SelectedIndexChanged);
            this.CbFilterBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbFilterBy_KeyPress);
            // 
            // CbIsActive
            // 
            this.CbIsActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbIsActive.Items.AddRange(new object[] {
            "All",
            "Active",
            "UnActive"});
            this.CbIsActive.Location = new System.Drawing.Point(306, 270);
            this.CbIsActive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbIsActive.Name = "CbIsActive";
            this.CbIsActive.Size = new System.Drawing.Size(103, 37);
            this.CbIsActive.TabIndex = 4;
            this.CbIsActive.SelectedIndexChanged += new System.EventHandler(this.CbIsActive_SelectedIndexChanged);
            this.CbIsActive.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbFilterBy_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 30);
            this.label3.TabIndex = 11;
            this.label3.Text = "Filter By:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(238, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 48);
            this.label2.TabIndex = 12;
            this.label2.Text = "Manage Users";
            // 
            // LblRecords
            // 
            this.LblRecords.AutoSize = true;
            this.LblRecords.Location = new System.Drawing.Point(118, 739);
            this.LblRecords.Name = "LblRecords";
            this.LblRecords.Size = new System.Drawing.Size(0, 30);
            this.LblRecords.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 739);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 30);
            this.label4.TabIndex = 13;
            this.label4.Text = "Records:";
            // 
            // BtnClose
            // 
            this.BtnClose.Image = global::WindowsFormsApp1.Properties.Resources.Close_32;
            this.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClose.Location = new System.Drawing.Point(603, 732);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(150, 54);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Text = "Close";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Users_512;
            this.pictureBox1.Location = new System.Drawing.Point(246, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // BtnAddUser
            // 
            this.BtnAddUser.Image = global::WindowsFormsApp1.Properties.Resources.Add_User_32;
            this.BtnAddUser.Location = new System.Drawing.Point(686, 251);
            this.BtnAddUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAddUser.Name = "BtnAddUser";
            this.BtnAddUser.Size = new System.Drawing.Size(67, 56);
            this.BtnAddUser.TabIndex = 6;
            this.BtnAddUser.UseVisualStyleBackColor = true;
            this.BtnAddUser.Click += new System.EventHandler(this.BtnAddUser_Click);
            // 
            // TxtFilter
            // 
            this.TxtFilter.Location = new System.Drawing.Point(306, 273);
            this.TxtFilter.MaxLength = 5;
            this.TxtFilter.Name = "TxtFilter";
            this.TxtFilter.Size = new System.Drawing.Size(178, 35);
            this.TxtFilter.TabIndex = 5;
            // 
            // ManageUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 802);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblRecords);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DgvUsers);
            this.Controls.Add(this.CbFilterBy);
            this.Controls.Add(this.CbIsActive);
            this.Controls.Add(this.BtnAddUser);
            this.Controls.Add(this.TxtFilter);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ManageUsersForm";
            this.Text = "Manage Users";
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsers)).EndInit();
            this.CmsUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView DgvUsers;
        private System.Windows.Forms.ComboBox CbFilterBy;
        private System.Windows.Forms.ComboBox CbIsActive;
        private System.Windows.Forms.Button BtnAddUser;
        private System.Windows.Forms.ContextMenuStrip CmsUser;
        private System.Windows.Forms.ToolStripMenuItem ViewPersonInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewUserInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UpdateUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeactivateAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ActivateAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SendEmailToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblRecords;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnClose;
        private WindowsFormsApp1.TextCustomFilterControl TxtFilter;
    }
}