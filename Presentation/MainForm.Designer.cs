namespace LibrarySystem
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MsOptions = new System.Windows.Forms.MenuStrip();
            this.peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookCopiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageBookCopiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageBorrowingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lostBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.damagedBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.manageFinePaymentsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.membershipsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membershipsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.membershipRenewalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCurrentMembershipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.policiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPersonCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCurrentUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatePermissionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MsOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MsOptions
            // 
            resources.ApplyResources(this.MsOptions, "MsOptions");
            this.MsOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MsOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.peopleToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.membersToolStripMenuItem,
            this.categoriesToolStripMenuItem,
            this.booksToolStripMenuItem,
            this.bookCopiesToolStripMenuItem,
            this.finesToolStripMenuItem,
            this.membershipsToolStripMenuItem,
            this.policiesToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.MsOptions.Name = "MsOptions";
            // 
            // peopleToolStripMenuItem
            // 
            this.peopleToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Person_64;
            resources.ApplyResources(this.peopleToolStripMenuItem, "peopleToolStripMenuItem");
            this.peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            this.peopleToolStripMenuItem.Click += new System.EventHandler(this.PeopleToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.User_64;
            resources.ApplyResources(this.usersToolStripMenuItem, "usersToolStripMenuItem");
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.UsersToolStripMenuItem_Click);
            // 
            // membersToolStripMenuItem
            // 
            this.membersToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Member_54;
            resources.ApplyResources(this.membersToolStripMenuItem, "membersToolStripMenuItem");
            this.membersToolStripMenuItem.Name = "membersToolStripMenuItem";
            this.membersToolStripMenuItem.Click += new System.EventHandler(this.MembersToolStripMenuItem_Click);
            // 
            // categoriesToolStripMenuItem
            // 
            this.categoriesToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Category_64;
            resources.ApplyResources(this.categoriesToolStripMenuItem, "categoriesToolStripMenuItem");
            this.categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            this.categoriesToolStripMenuItem.Click += new System.EventHandler(this.BookCategoriesToolStripMenuItem_Click);
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Book_64;
            resources.ApplyResources(this.booksToolStripMenuItem, "booksToolStripMenuItem");
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Click += new System.EventHandler(this.ManageBooksToolStripMenuItem_Click);
            // 
            // bookCopiesToolStripMenuItem
            // 
            this.bookCopiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageBookCopiesToolStripMenuItem,
            this.manageBorrowingToolStripMenuItem1,
            this.borrowBookToolStripMenuItem,
            this.returnBookToolStripMenuItem,
            this.lostBookToolStripMenuItem,
            this.damagedBookToolStripMenuItem});
            this.bookCopiesToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Book_Copy_64;
            resources.ApplyResources(this.bookCopiesToolStripMenuItem, "bookCopiesToolStripMenuItem");
            this.bookCopiesToolStripMenuItem.Name = "bookCopiesToolStripMenuItem";
            this.bookCopiesToolStripMenuItem.DoubleClick += new System.EventHandler(this.BookCopiesToolStripMenuItem_Click);
            // 
            // manageBookCopiesToolStripMenuItem
            // 
            this.manageBookCopiesToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Book_Copy_32;
            resources.ApplyResources(this.manageBookCopiesToolStripMenuItem, "manageBookCopiesToolStripMenuItem");
            this.manageBookCopiesToolStripMenuItem.Name = "manageBookCopiesToolStripMenuItem";
            this.manageBookCopiesToolStripMenuItem.Click += new System.EventHandler(this.manageBookCopiesToolStripMenuItem_Click);
            // 
            // manageBorrowingToolStripMenuItem1
            // 
            this.manageBorrowingToolStripMenuItem1.Image = global::WindowsFormsApp1.Properties.Resources.Manage_Borrowing_32;
            resources.ApplyResources(this.manageBorrowingToolStripMenuItem1, "manageBorrowingToolStripMenuItem1");
            this.manageBorrowingToolStripMenuItem1.Name = "manageBorrowingToolStripMenuItem1";
            this.manageBorrowingToolStripMenuItem1.Click += new System.EventHandler(this.manageBorrowingToolStripMenuItem1_Click);
            // 
            // borrowBookToolStripMenuItem
            // 
            this.borrowBookToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Borrow_Book_32;
            resources.ApplyResources(this.borrowBookToolStripMenuItem, "borrowBookToolStripMenuItem");
            this.borrowBookToolStripMenuItem.Name = "borrowBookToolStripMenuItem";
            this.borrowBookToolStripMenuItem.Click += new System.EventHandler(this.BorrowBookToolStripMenuItem_Click);
            // 
            // returnBookToolStripMenuItem
            // 
            this.returnBookToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Return_Book_32;
            resources.ApplyResources(this.returnBookToolStripMenuItem, "returnBookToolStripMenuItem");
            this.returnBookToolStripMenuItem.Name = "returnBookToolStripMenuItem";
            this.returnBookToolStripMenuItem.Click += new System.EventHandler(this.ReturnBookToolStripMenuItem_Click);
            // 
            // lostBookToolStripMenuItem
            // 
            this.lostBookToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Lost_Book_32;
            resources.ApplyResources(this.lostBookToolStripMenuItem, "lostBookToolStripMenuItem");
            this.lostBookToolStripMenuItem.Name = "lostBookToolStripMenuItem";
            this.lostBookToolStripMenuItem.Click += new System.EventHandler(this.LostBookReportToolStripMenuItem_Click);
            // 
            // damagedBookToolStripMenuItem
            // 
            this.damagedBookToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Damaged_Book_32;
            resources.ApplyResources(this.damagedBookToolStripMenuItem, "damagedBookToolStripMenuItem");
            this.damagedBookToolStripMenuItem.Name = "damagedBookToolStripMenuItem";
            this.damagedBookToolStripMenuItem.Click += new System.EventHandler(this.DamagedBookToolStripMenuItem_Click);
            // 
            // finesToolStripMenuItem
            // 
            this.finesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.finesToolStripMenuItem1,
            this.manageFinePaymentsToolStripMenuItem1});
            this.finesToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Fine_64;
            resources.ApplyResources(this.finesToolStripMenuItem, "finesToolStripMenuItem");
            this.finesToolStripMenuItem.Name = "finesToolStripMenuItem";
            // 
            // finesToolStripMenuItem1
            // 
            this.finesToolStripMenuItem1.Image = global::WindowsFormsApp1.Properties.Resources.Fine_32;
            resources.ApplyResources(this.finesToolStripMenuItem1, "finesToolStripMenuItem1");
            this.finesToolStripMenuItem1.Name = "finesToolStripMenuItem1";
            this.finesToolStripMenuItem1.Click += new System.EventHandler(this.FinesToolStripMenuItem_Click);
            // 
            // manageFinePaymentsToolStripMenuItem1
            // 
            this.manageFinePaymentsToolStripMenuItem1.Image = global::WindowsFormsApp1.Properties.Resources.Fine_32;
            resources.ApplyResources(this.manageFinePaymentsToolStripMenuItem1, "manageFinePaymentsToolStripMenuItem1");
            this.manageFinePaymentsToolStripMenuItem1.Name = "manageFinePaymentsToolStripMenuItem1";
            this.manageFinePaymentsToolStripMenuItem1.Click += new System.EventHandler(this.manageFinePaymentsToolStripMenuItem1_Click);
            // 
            // membershipsToolStripMenuItem
            // 
            this.membershipsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.membershipsToolStripMenuItem1,
            this.membershipRenewalToolStripMenuItem,
            this.viewCurrentMembershipToolStripMenuItem});
            this.membershipsToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Membership_64;
            resources.ApplyResources(this.membershipsToolStripMenuItem, "membershipsToolStripMenuItem");
            this.membershipsToolStripMenuItem.Name = "membershipsToolStripMenuItem";
            this.membershipsToolStripMenuItem.DoubleClick += new System.EventHandler(this.BookCopiesToolStripMenuItem_Click);
            // 
            // membershipsToolStripMenuItem1
            // 
            this.membershipsToolStripMenuItem1.Image = global::WindowsFormsApp1.Properties.Resources.Membership_32;
            resources.ApplyResources(this.membershipsToolStripMenuItem1, "membershipsToolStripMenuItem1");
            this.membershipsToolStripMenuItem1.Name = "membershipsToolStripMenuItem1";
            this.membershipsToolStripMenuItem1.Click += new System.EventHandler(this.MembershipsToolStripMenuItem_Click);
            // 
            // membershipRenewalToolStripMenuItem
            // 
            this.membershipRenewalToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Membership_Renewal_32;
            resources.ApplyResources(this.membershipRenewalToolStripMenuItem, "membershipRenewalToolStripMenuItem");
            this.membershipRenewalToolStripMenuItem.Name = "membershipRenewalToolStripMenuItem";
            this.membershipRenewalToolStripMenuItem.Click += new System.EventHandler(this.MembershipRenewalsToolStripMenuItem_Click);
            // 
            // viewCurrentMembershipToolStripMenuItem
            // 
            this.viewCurrentMembershipToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Membership_32;
            resources.ApplyResources(this.viewCurrentMembershipToolStripMenuItem, "viewCurrentMembershipToolStripMenuItem");
            this.viewCurrentMembershipToolStripMenuItem.Name = "viewCurrentMembershipToolStripMenuItem";
            this.viewCurrentMembershipToolStripMenuItem.Click += new System.EventHandler(this.viewCurrentMembershipToolStripMenuItem_Click);
            // 
            // policiesToolStripMenuItem
            // 
            this.policiesToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Policy_64;
            resources.ApplyResources(this.policiesToolStripMenuItem, "policiesToolStripMenuItem");
            this.policiesToolStripMenuItem.Name = "policiesToolStripMenuItem";
            this.policiesToolStripMenuItem.Click += new System.EventHandler(this.PoliciesToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewPersonCardToolStripMenuItem,
            this.viewCurrentUserToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.updatePermissionsToolStripMenuItem,
            this.signOutToolStripMenuItem});
            this.settingsToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Settings_64;
            resources.ApplyResources(this.settingsToolStripMenuItem, "settingsToolStripMenuItem");
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            // 
            // viewPersonCardToolStripMenuItem
            // 
            this.viewPersonCardToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.View_32;
            resources.ApplyResources(this.viewPersonCardToolStripMenuItem, "viewPersonCardToolStripMenuItem");
            this.viewPersonCardToolStripMenuItem.Name = "viewPersonCardToolStripMenuItem";
            this.viewPersonCardToolStripMenuItem.Click += new System.EventHandler(this.viewPersonCardToolStripMenuItem_Click);
            // 
            // viewCurrentUserToolStripMenuItem
            // 
            this.viewCurrentUserToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.viewUser_24;
            resources.ApplyResources(this.viewCurrentUserToolStripMenuItem, "viewCurrentUserToolStripMenuItem");
            this.viewCurrentUserToolStripMenuItem.Name = "viewCurrentUserToolStripMenuItem";
            this.viewCurrentUserToolStripMenuItem.Click += new System.EventHandler(this.ViewUserInfoToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Change_Password_24;
            resources.ApplyResources(this.changePasswordToolStripMenuItem, "changePasswordToolStripMenuItem");
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.ChangePasswordToolStripMenuItem_Click);
            // 
            // updatePermissionsToolStripMenuItem
            // 
            this.updatePermissionsToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Status_32;
            resources.ApplyResources(this.updatePermissionsToolStripMenuItem, "updatePermissionsToolStripMenuItem");
            this.updatePermissionsToolStripMenuItem.Name = "updatePermissionsToolStripMenuItem";
            this.updatePermissionsToolStripMenuItem.Click += new System.EventHandler(this.UpdatePermissionsToolStripMenuItem_Click);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Log_Out_24;
            resources.ApplyResources(this.signOutToolStripMenuItem, "signOutToolStripMenuItem");
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.SignOutToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.inaki_del_olmo_NIJuEQw0RKg_unsplash;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MsOptions);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MsOptions;
            this.Name = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.MsOptions.ResumeLayout(false);
            this.MsOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MsOptions;
        private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem membersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookCopiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lostBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem damagedBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem membershipsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem membershipRenewalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem policiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCurrentUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageBorrowingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem manageFinePaymentsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem manageBookCopiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updatePermissionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPersonCardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem membershipsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewCurrentMembershipToolStripMenuItem;
    }
}