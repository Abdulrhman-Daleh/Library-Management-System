namespace LibrarySystem.Users
{
    partial class ViewUserCardForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LnkResetPassword = new System.Windows.Forms.LinkLabel();
            this.LnkEdit = new System.Windows.Forms.LinkLabel();
            this.msUserOptions = new System.Windows.Forms.MenuStrip();
            this.moreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membershipInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMembershipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.unlockAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personCardControl = new LibrarySystem.People.PersonCardControl();
            this.statsControl = new WindowsFormsApp1.BorrowingBookCopy.Controls.StatsControl();
            this.viewUserCardControl = new LibrarySystem.Users.Controls.ViewUserCardControl.AccountControl();
            this.memberCardControl = new LibrarySystem.Members.Controls.MemberCardControl();
            this.groupBox1.SuspendLayout();
            this.msUserOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(326, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 48);
            this.label2.TabIndex = 13;
            this.label2.Text = "View User Card";
            // 
            // BtnClose
            // 
            this.BtnClose.Image = global::WindowsFormsApp1.Properties.Resources.Close_32;
            this.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClose.Location = new System.Drawing.Point(763, 987);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(150, 54);
            this.BtnClose.TabIndex = 17;
            this.BtnClose.Text = "Close";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LnkResetPassword);
            this.groupBox1.Controls.Add(this.LnkEdit);
            this.groupBox1.Controls.Add(this.msUserOptions);
            this.groupBox1.Location = new System.Drawing.Point(14, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(899, 100);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions";
            // 
            // LnkResetPassword
            // 
            this.LnkResetPassword.AutoSize = true;
            this.LnkResetPassword.Location = new System.Drawing.Point(149, 48);
            this.LnkResetPassword.Name = "LnkResetPassword";
            this.LnkResetPassword.Size = new System.Drawing.Size(172, 30);
            this.LnkResetPassword.TabIndex = 2;
            this.LnkResetPassword.TabStop = true;
            this.LnkResetPassword.Text = "Reset Password";
            this.LnkResetPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkResetPassword_LinkClicked);
            // 
            // LnkEdit
            // 
            this.LnkEdit.AutoSize = true;
            this.LnkEdit.Location = new System.Drawing.Point(53, 48);
            this.LnkEdit.Name = "LnkEdit";
            this.LnkEdit.Size = new System.Drawing.Size(53, 30);
            this.LnkEdit.TabIndex = 0;
            this.LnkEdit.TabStop = true;
            this.LnkEdit.Text = "Edit";
            this.LnkEdit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkEdit_LinkClicked);
            // 
            // msUserOptions
            // 
            this.msUserOptions.Dock = System.Windows.Forms.DockStyle.None;
            this.msUserOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msUserOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moreToolStripMenuItem});
            this.msUserOptions.Location = new System.Drawing.Point(634, 38);
            this.msUserOptions.Name = "msUserOptions";
            this.msUserOptions.Size = new System.Drawing.Size(254, 40);
            this.msUserOptions.TabIndex = 4;
            this.msUserOptions.Text = "menuStrip1";
            // 
            // moreToolStripMenuItem
            // 
            this.moreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personProfileToolStripMenuItem,
            this.membershipInfoToolStripMenuItem,
            this.addMembershipToolStripMenuItem,
            this.borrowHistoryToolStripMenuItem,
            this.fineToolStripMenuItem,
            this.toolStripMenuItem1,
            this.unlockAccountToolStripMenuItem,
            this.sendEmailToolStripMenuItem,
            this.deleteAccountToolStripMenuItem});
            this.moreToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.more;
            this.moreToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.moreToolStripMenuItem.Name = "moreToolStripMenuItem";
            this.moreToolStripMenuItem.Size = new System.Drawing.Size(96, 36);
            this.moreToolStripMenuItem.Text = "More";
            // 
            // personProfileToolStripMenuItem
            // 
            this.personProfileToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Person_32;
            this.personProfileToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.personProfileToolStripMenuItem.Name = "personProfileToolStripMenuItem";
            this.personProfileToolStripMenuItem.Size = new System.Drawing.Size(241, 38);
            this.personProfileToolStripMenuItem.Text = "Person Profile";
            this.personProfileToolStripMenuItem.Click += new System.EventHandler(this.personProfileToolStripMenuItem_Click);
            // 
            // membershipInfoToolStripMenuItem
            // 
            this.membershipInfoToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Membership_32;
            this.membershipInfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.membershipInfoToolStripMenuItem.Name = "membershipInfoToolStripMenuItem";
            this.membershipInfoToolStripMenuItem.Size = new System.Drawing.Size(241, 38);
            this.membershipInfoToolStripMenuItem.Text = "Membership Info";
            this.membershipInfoToolStripMenuItem.Click += new System.EventHandler(this.membershipInfoToolStripMenuItem_Click);
            // 
            // addMembershipToolStripMenuItem
            // 
            this.addMembershipToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Membership_32;
            this.addMembershipToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addMembershipToolStripMenuItem.Name = "addMembershipToolStripMenuItem";
            this.addMembershipToolStripMenuItem.Size = new System.Drawing.Size(241, 38);
            this.addMembershipToolStripMenuItem.Text = "Add Membership";
            this.addMembershipToolStripMenuItem.Click += new System.EventHandler(this.addMembershipToolStripMenuItem_Click);
            // 
            // borrowHistoryToolStripMenuItem
            // 
            this.borrowHistoryToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Borrow_Book_32;
            this.borrowHistoryToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.borrowHistoryToolStripMenuItem.Name = "borrowHistoryToolStripMenuItem";
            this.borrowHistoryToolStripMenuItem.Size = new System.Drawing.Size(241, 38);
            this.borrowHistoryToolStripMenuItem.Text = "Borrow History";
            this.borrowHistoryToolStripMenuItem.Click += new System.EventHandler(this.borrowHistoryToolStripMenuItem_Click);
            // 
            // fineToolStripMenuItem
            // 
            this.fineToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Money_Bag_32;
            this.fineToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.fineToolStripMenuItem.Name = "fineToolStripMenuItem";
            this.fineToolStripMenuItem.Size = new System.Drawing.Size(241, 38);
            this.fineToolStripMenuItem.Text = "Fines && Payments";
            this.fineToolStripMenuItem.Click += new System.EventHandler(this.fineToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(238, 6);
            // 
            // unlockAccountToolStripMenuItem
            // 
            this.unlockAccountToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Login_32;
            this.unlockAccountToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.unlockAccountToolStripMenuItem.Name = "unlockAccountToolStripMenuItem";
            this.unlockAccountToolStripMenuItem.Size = new System.Drawing.Size(241, 38);
            this.unlockAccountToolStripMenuItem.Text = "Unlock Account";
            this.unlockAccountToolStripMenuItem.Click += new System.EventHandler(this.unlockAccountToolStripMenuItem_Click);
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Email_32;
            this.sendEmailToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(241, 38);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            this.sendEmailToolStripMenuItem.Click += new System.EventHandler(this.sendEmailToolStripMenuItem_Click);
            // 
            // deleteAccountToolStripMenuItem
            // 
            this.deleteAccountToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Delete_32;
            this.deleteAccountToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteAccountToolStripMenuItem.Name = "deleteAccountToolStripMenuItem";
            this.deleteAccountToolStripMenuItem.Size = new System.Drawing.Size(241, 38);
            this.deleteAccountToolStripMenuItem.Text = "Delete Account";
            this.deleteAccountToolStripMenuItem.Click += new System.EventHandler(this.deleteAccountToolStripMenuItem_Click);
            // 
            // personCardControl
            // 
            this.personCardControl.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.personCardControl.Location = new System.Drawing.Point(14, 187);
            this.personCardControl.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.personCardControl.Name = "personCardControl";
            this.personCardControl.Size = new System.Drawing.Size(665, 342);
            this.personCardControl.TabIndex = 19;
            // 
            // statsControl
            // 
            this.statsControl.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.statsControl.Location = new System.Drawing.Point(13, 870);
            this.statsControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.statsControl.Name = "statsControl";
            this.statsControl.Size = new System.Drawing.Size(654, 139);
            this.statsControl.TabIndex = 21;
            // 
            // viewUserCardControl
            // 
            this.viewUserCardControl.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.viewUserCardControl.Location = new System.Drawing.Point(14, 542);
            this.viewUserCardControl.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.viewUserCardControl.Name = "viewUserCardControl";
            this.viewUserCardControl.Size = new System.Drawing.Size(429, 289);
            this.viewUserCardControl.TabIndex = 2;
            // 
            // memberCardControl
            // 
            this.memberCardControl.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.memberCardControl.Location = new System.Drawing.Point(453, 542);
            this.memberCardControl.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.memberCardControl.Name = "memberCardControl";
            this.memberCardControl.Size = new System.Drawing.Size(460, 309);
            this.memberCardControl.TabIndex = 20;
            // 
            // ViewUserCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(928, 1056);
            this.Controls.Add(this.statsControl);
            this.Controls.Add(this.memberCardControl);
            this.Controls.Add(this.personCardControl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.viewUserCardControl);
            this.MainMenuStrip = this.msUserOptions;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewUserCardForm";
            this.Text = "View User Card";
            this.Load += new System.EventHandler(this.ViewUserCardForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.msUserOptions.ResumeLayout(false);
            this.msUserOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel LnkEdit;
        private System.Windows.Forms.LinkLabel LnkResetPassword;
        private People.PersonCardControl personCardControl;
        private WindowsFormsApp1.BorrowingBookCopy.Controls.StatsControl statsControl;
        private Controls.ViewUserCardControl.AccountControl viewUserCardControl;
        private Members.Controls.MemberCardControl memberCardControl;
        private System.Windows.Forms.MenuStrip msUserOptions;
        private System.Windows.Forms.ToolStripMenuItem moreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem membershipInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fineToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem unlockAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMembershipToolStripMenuItem;
    }
}