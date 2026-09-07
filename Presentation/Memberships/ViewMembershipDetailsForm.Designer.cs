namespace LibrarySystem.Memberships
{
    partial class ViewMembershipDetailsForm
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
            this.BtnClose = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LinkEdit = new System.Windows.Forms.LinkLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.moreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMembershipCardControl1 = new WindowsFormsApp1.Memberships.Controls.ViewMembershipCardControl();
            this.statsControl1 = new WindowsFormsApp1.BorrowingBookCopy.Controls.StatsControl();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Image = global::WindowsFormsApp1.Properties.Resources.Close_32;
            this.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClose.Location = new System.Drawing.Point(511, 497);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(150, 64);
            this.BtnClose.TabIndex = 17;
            this.BtnClose.Text = "Close";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(159, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(335, 48);
            this.label5.TabIndex = 18;
            this.label5.Text = "View Membership";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LinkEdit);
            this.groupBox2.Controls.Add(this.menuStrip1);
            this.groupBox2.Location = new System.Drawing.Point(14, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(647, 100);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actions";
            // 
            // LinkEdit
            // 
            this.LinkEdit.AutoSize = true;
            this.LinkEdit.Location = new System.Drawing.Point(53, 48);
            this.LinkEdit.Name = "LinkEdit";
            this.LinkEdit.Size = new System.Drawing.Size(53, 30);
            this.LinkEdit.TabIndex = 0;
            this.LinkEdit.TabStop = true;
            this.LinkEdit.Text = "Edit";
            this.LinkEdit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkEdit_LinkClicked);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(390, 38);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(254, 40);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // moreToolStripMenuItem
            // 
            this.moreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.membersToolStripMenuItem,
            this.deleteTypeToolStripMenuItem});
            this.moreToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.more;
            this.moreToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.moreToolStripMenuItem.Name = "moreToolStripMenuItem";
            this.moreToolStripMenuItem.Size = new System.Drawing.Size(96, 36);
            this.moreToolStripMenuItem.Text = "More";
            // 
            // membersToolStripMenuItem
            // 
            this.membersToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Member_32;
            this.membersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.membersToolStripMenuItem.Name = "membersToolStripMenuItem";
            this.membersToolStripMenuItem.Size = new System.Drawing.Size(236, 38);
            this.membersToolStripMenuItem.Text = "Members List";
            this.membersToolStripMenuItem.Click += new System.EventHandler(this.membersToolStripMenuItem_Click);
            // 
            // deleteTypeToolStripMenuItem
            // 
            this.deleteTypeToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Delete_Membership_32;
            this.deleteTypeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteTypeToolStripMenuItem.Name = "deleteTypeToolStripMenuItem";
            this.deleteTypeToolStripMenuItem.Size = new System.Drawing.Size(236, 38);
            this.deleteTypeToolStripMenuItem.Text = "Delete Type";
            this.deleteTypeToolStripMenuItem.Click += new System.EventHandler(this.deleteTypeToolStripMenuItem_Click);
            // 
            // viewMembershipCardControl1
            // 
            this.viewMembershipCardControl1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.viewMembershipCardControl1.Location = new System.Drawing.Point(14, 179);
            this.viewMembershipCardControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.viewMembershipCardControl1.Name = "viewMembershipCardControl1";
            this.viewMembershipCardControl1.Size = new System.Drawing.Size(462, 161);
            this.viewMembershipCardControl1.TabIndex = 20;
            // 
            // statsControl1
            // 
            this.statsControl1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.statsControl1.Location = new System.Drawing.Point(13, 348);
            this.statsControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.statsControl1.Name = "statsControl1";
            this.statsControl1.Size = new System.Drawing.Size(648, 139);
            this.statsControl1.TabIndex = 21;
            // 
            // ViewMembershipDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 569);
            this.Controls.Add(this.statsControl1);
            this.Controls.Add(this.viewMembershipCardControl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnClose);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewMembershipDetailsForm";
            this.Text = "Membership Details";
            this.Load += new System.EventHandler(this.ViewMembershipDetailsForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel LinkEdit;
        private WindowsFormsApp1.Memberships.Controls.ViewMembershipCardControl viewMembershipCardControl1;
        private WindowsFormsApp1.BorrowingBookCopy.Controls.StatsControl statsControl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem moreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem membersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteTypeToolStripMenuItem;
    }
}