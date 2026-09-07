namespace LibrarySystem.People
{
    partial class ViewPersonCardInfoForm
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
            this.btnClose = new System.Windows.Forms.Button();
            this.relationlControl1 = new WindowsFormsApp1.Members.Controls.RelationlControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LnkCreateMembership = new System.Windows.Forms.LinkLabel();
            this.LnkCreateUser = new System.Windows.Forms.LinkLabel();
            this.LinkEdit = new System.Windows.Forms.LinkLabel();
            this.msMoreOptions = new System.Windows.Forms.MenuStrip();
            this.moreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membershipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finesPaymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.deletePersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personCardControl = new LibrarySystem.People.PersonCardControl();
            this.groupBox1.SuspendLayout();
            this.msMoreOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(180, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 48);
            this.label2.TabIndex = 10;
            this.label2.Text = "View Person Card";
            // 
            // btnClose
            // 
            this.btnClose.Image = global::WindowsFormsApp1.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point(576, 836);
            this.btnClose.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(148, 58);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // relationlControl1
            // 
            this.relationlControl1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.relationlControl1.Location = new System.Drawing.Point(18, 536);
            this.relationlControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.relationlControl1.Name = "relationlControl1";
            this.relationlControl1.Size = new System.Drawing.Size(706, 302);
            this.relationlControl1.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LnkCreateMembership);
            this.groupBox1.Controls.Add(this.LnkCreateUser);
            this.groupBox1.Controls.Add(this.LinkEdit);
            this.groupBox1.Controls.Add(this.msMoreOptions);
            this.groupBox1.Location = new System.Drawing.Point(19, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(705, 82);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions";
            // 
            // LnkCreateMembership
            // 
            this.LnkCreateMembership.AutoSize = true;
            this.LnkCreateMembership.Location = new System.Drawing.Point(441, 36);
            this.LnkCreateMembership.Name = "LnkCreateMembership";
            this.LnkCreateMembership.Size = new System.Drawing.Size(215, 30);
            this.LnkCreateMembership.TabIndex = 6;
            this.LnkCreateMembership.TabStop = true;
            this.LnkCreateMembership.Text = "Create Membership";
            this.LnkCreateMembership.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkCreateMembership_LinkClicked);
            // 
            // LnkCreateUser
            // 
            this.LnkCreateUser.AutoSize = true;
            this.LnkCreateUser.Location = new System.Drawing.Point(278, 36);
            this.LnkCreateUser.Name = "LnkCreateUser";
            this.LnkCreateUser.Size = new System.Drawing.Size(131, 30);
            this.LnkCreateUser.TabIndex = 5;
            this.LnkCreateUser.TabStop = true;
            this.LnkCreateUser.Text = "Create User";
            this.LnkCreateUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkCreateUser_LinkClicked);
            // 
            // LinkEdit
            // 
            this.LinkEdit.AutoSize = true;
            this.LinkEdit.Location = new System.Drawing.Point(192, 36);
            this.LinkEdit.Name = "LinkEdit";
            this.LinkEdit.Size = new System.Drawing.Size(53, 30);
            this.LinkEdit.TabIndex = 4;
            this.LinkEdit.TabStop = true;
            this.LinkEdit.Text = "Edit";
            this.LinkEdit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkEdit_LinkClicked);
            // 
            // msMoreOptions
            // 
            this.msMoreOptions.Dock = System.Windows.Forms.DockStyle.None;
            this.msMoreOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMoreOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moreToolStripMenuItem});
            this.msMoreOptions.Location = new System.Drawing.Point(16, 36);
            this.msMoreOptions.Name = "msMoreOptions";
            this.msMoreOptions.Size = new System.Drawing.Size(104, 40);
            this.msMoreOptions.TabIndex = 14;
            this.msMoreOptions.Text = "menuStrip1";
            // 
            // moreToolStripMenuItem
            // 
            this.moreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userAccountToolStripMenuItem,
            this.membershipToolStripMenuItem,
            this.borrowHistoryToolStripMenuItem,
            this.finesPaymentsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.deletePersonToolStripMenuItem});
            this.moreToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.more;
            this.moreToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.moreToolStripMenuItem.Name = "moreToolStripMenuItem";
            this.moreToolStripMenuItem.Size = new System.Drawing.Size(96, 36);
            this.moreToolStripMenuItem.Text = "More";
            // 
            // userAccountToolStripMenuItem
            // 
            this.userAccountToolStripMenuItem.Enabled = false;
            this.userAccountToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Login_32;
            this.userAccountToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.userAccountToolStripMenuItem.Name = "userAccountToolStripMenuItem";
            this.userAccountToolStripMenuItem.Size = new System.Drawing.Size(256, 38);
            this.userAccountToolStripMenuItem.Text = "User Account";
            this.userAccountToolStripMenuItem.Click += new System.EventHandler(this.userAccountToolStripMenuItem_Click);
            // 
            // membershipToolStripMenuItem
            // 
            this.membershipToolStripMenuItem.Enabled = false;
            this.membershipToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Membership_32;
            this.membershipToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.membershipToolStripMenuItem.Name = "membershipToolStripMenuItem";
            this.membershipToolStripMenuItem.Size = new System.Drawing.Size(256, 38);
            this.membershipToolStripMenuItem.Text = "Membership";
            this.membershipToolStripMenuItem.Click += new System.EventHandler(this.membershipToolStripMenuItem_Click);
            // 
            // borrowHistoryToolStripMenuItem
            // 
            this.borrowHistoryToolStripMenuItem.Enabled = false;
            this.borrowHistoryToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Borrow_Book_32;
            this.borrowHistoryToolStripMenuItem.Name = "borrowHistoryToolStripMenuItem";
            this.borrowHistoryToolStripMenuItem.Size = new System.Drawing.Size(256, 38);
            this.borrowHistoryToolStripMenuItem.Text = "Borrow History";
            this.borrowHistoryToolStripMenuItem.Click += new System.EventHandler(this.borrowHistoryToolStripMenuItem_Click);
            // 
            // finesPaymentsToolStripMenuItem
            // 
            this.finesPaymentsToolStripMenuItem.Enabled = false;
            this.finesPaymentsToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Fine_32;
            this.finesPaymentsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.finesPaymentsToolStripMenuItem.Name = "finesPaymentsToolStripMenuItem";
            this.finesPaymentsToolStripMenuItem.Size = new System.Drawing.Size(256, 38);
            this.finesPaymentsToolStripMenuItem.Text = "Fines and Payments";
            this.finesPaymentsToolStripMenuItem.Click += new System.EventHandler(this.finesPaymentsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(253, 6);
            // 
            // deletePersonToolStripMenuItem
            // 
            this.deletePersonToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Delete_32;
            this.deletePersonToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deletePersonToolStripMenuItem.Name = "deletePersonToolStripMenuItem";
            this.deletePersonToolStripMenuItem.Size = new System.Drawing.Size(256, 38);
            this.deletePersonToolStripMenuItem.Text = "Delete Person";
            this.deletePersonToolStripMenuItem.Click += new System.EventHandler(this.deletePersonToolStripMenuItem_Click);
            // 
            // personCardControl
            // 
            this.personCardControl.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.personCardControl.Location = new System.Drawing.Point(19, 157);
            this.personCardControl.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.personCardControl.Name = "personCardControl";
            this.personCardControl.Size = new System.Drawing.Size(705, 369);
            this.personCardControl.TabIndex = 8;
            // 
            // ViewPersonCardInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(737, 914);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.relationlControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.personCardControl);
            this.Controls.Add(this.btnClose);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "ViewPersonCardInfoForm";
            this.Text = "Person Card";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.msMoreOptions.ResumeLayout(false);
            this.msMoreOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private WindowsFormsApp1.Members.Controls.RelationlControl relationlControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel LnkCreateMembership;
        private System.Windows.Forms.LinkLabel LnkCreateUser;
        private System.Windows.Forms.LinkLabel LinkEdit;
        private PersonCardControl personCardControl;
        private System.Windows.Forms.MenuStrip msMoreOptions;
        private System.Windows.Forms.ToolStripMenuItem moreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem membershipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finesPaymentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deletePersonToolStripMenuItem;
    }
}