namespace LibrarySystem.Members
{
    partial class ManageMembersForm
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
            this.DgvMembers = new System.Windows.Forms.DataGridView();
            this.CmsMember = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ViewMemberInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewUserInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CbFilterBy = new System.Windows.Forms.ComboBox();
            this.LblRecords = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnAddPerson = new System.Windows.Forms.Button();
            this.TxtFilter = new WindowsFormsApp1.TextCustomFilterControl();
            this.RenewMembershipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMembers)).BeginInit();
            this.CmsMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvMembers
            // 
            this.DgvMembers.AllowUserToAddRows = false;
            this.DgvMembers.AllowUserToDeleteRows = false;
            this.DgvMembers.AllowUserToOrderColumns = true;
            this.DgvMembers.BackgroundColor = System.Drawing.Color.White;
            this.DgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMembers.ContextMenuStrip = this.CmsMember;
            this.DgvMembers.Location = new System.Drawing.Point(13, 288);
            this.DgvMembers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvMembers.Name = "DgvMembers";
            this.DgvMembers.ReadOnly = true;
            this.DgvMembers.RowHeadersWidth = 51;
            this.DgvMembers.Size = new System.Drawing.Size(926, 393);
            this.DgvMembers.TabIndex = 0;
            this.DgvMembers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMembers_CellDoubleClick);
            // 
            // CmsMember
            // 
            this.CmsMember.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CmsMember.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewMemberInfoToolStripMenuItem,
            this.ViewUserInfoToolStripMenuItem,
            this.AddNewPersonToolStripMenuItem,
            this.RenewMembershipToolStripMenuItem,
            this.DeleteToolStripMenuItem,
            this.CallToolStripMenuItem,
            this.SendEmailToolStripMenuItem});
            this.CmsMember.Name = "CmsMember";
            this.CmsMember.Size = new System.Drawing.Size(247, 298);
            this.CmsMember.Opening += new System.ComponentModel.CancelEventHandler(this.CmsMember_Opening);
            // 
            // ViewMemberInfoToolStripMenuItem
            // 
            this.ViewMemberInfoToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.View_32;
            this.ViewMemberInfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ViewMemberInfoToolStripMenuItem.Name = "ViewMemberInfoToolStripMenuItem";
            this.ViewMemberInfoToolStripMenuItem.Size = new System.Drawing.Size(246, 38);
            this.ViewMemberInfoToolStripMenuItem.Text = "View Member Info";
            this.ViewMemberInfoToolStripMenuItem.Click += new System.EventHandler(this.ViewMemberInfoToolStripMenuItem_Click);
            // 
            // ViewUserInfoToolStripMenuItem
            // 
            this.ViewUserInfoToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.View_32;
            this.ViewUserInfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ViewUserInfoToolStripMenuItem.Name = "ViewUserInfoToolStripMenuItem";
            this.ViewUserInfoToolStripMenuItem.Size = new System.Drawing.Size(246, 38);
            this.ViewUserInfoToolStripMenuItem.Text = "View User Info";
            this.ViewUserInfoToolStripMenuItem.Click += new System.EventHandler(this.ViewUserInfoToolStripMenuItem_Click);
            // 
            // AddNewPersonToolStripMenuItem
            // 
            this.AddNewPersonToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Add_Person;
            this.AddNewPersonToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddNewPersonToolStripMenuItem.Name = "AddNewPersonToolStripMenuItem";
            this.AddNewPersonToolStripMenuItem.Size = new System.Drawing.Size(246, 38);
            this.AddNewPersonToolStripMenuItem.Text = "Add New Member";
            this.AddNewPersonToolStripMenuItem.Click += new System.EventHandler(this.AddNewPersonToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Delete_32;
            this.DeleteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(246, 38);
            this.DeleteToolStripMenuItem.Text = "Delete";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // CallToolStripMenuItem
            // 
            this.CallToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Phone_32;
            this.CallToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CallToolStripMenuItem.Name = "CallToolStripMenuItem";
            this.CallToolStripMenuItem.Size = new System.Drawing.Size(246, 38);
            this.CallToolStripMenuItem.Text = "Call";
            this.CallToolStripMenuItem.Click += new System.EventHandler(this.CallToolStripMenuItem_Click);
            // 
            // SendEmailToolStripMenuItem
            // 
            this.SendEmailToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Email_32;
            this.SendEmailToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SendEmailToolStripMenuItem.Name = "SendEmailToolStripMenuItem";
            this.SendEmailToolStripMenuItem.Size = new System.Drawing.Size(246, 38);
            this.SendEmailToolStripMenuItem.Text = "Send Email";
            this.SendEmailToolStripMenuItem.Click += new System.EventHandler(this.SendEmailToolStripMenuItem_Click);
            // 
            // CbFilterBy
            // 
            this.CbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbFilterBy.Items.AddRange(new object[] {
            "None",
            "MemberID",
            "UserID"});
            this.CbFilterBy.Location = new System.Drawing.Point(123, 243);
            this.CbFilterBy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbFilterBy.Name = "CbFilterBy";
            this.CbFilterBy.Size = new System.Drawing.Size(178, 37);
            this.CbFilterBy.TabIndex = 1;
            this.CbFilterBy.SelectedIndexChanged += new System.EventHandler(this.CbFilterBy_SelectedIndexChanged);
            this.CbFilterBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbFilterBy_KeyPress);
            // 
            // LblRecords
            // 
            this.LblRecords.AutoSize = true;
            this.LblRecords.Location = new System.Drawing.Point(124, 706);
            this.LblRecords.Name = "LblRecords";
            this.LblRecords.Size = new System.Drawing.Size(0, 30);
            this.LblRecords.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 706);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "Records:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(324, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 48);
            this.label2.TabIndex = 11;
            this.label2.Text = "Manage Members";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 30);
            this.label3.TabIndex = 13;
            this.label3.Text = "Filter By";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApp1.Properties.Resources.Members_512;
            this.pictureBox4.Location = new System.Drawing.Point(352, 72);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(266, 152);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Image = global::WindowsFormsApp1.Properties.Resources.Close_32;
            this.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClose.Location = new System.Drawing.Point(788, 688);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(150, 64);
            this.BtnClose.TabIndex = 12;
            this.BtnClose.Text = "Close";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnAddPerson
            // 
            this.BtnAddPerson.Image = global::WindowsFormsApp1.Properties.Resources.Add_64;
            this.BtnAddPerson.Location = new System.Drawing.Point(862, 205);
            this.BtnAddPerson.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAddPerson.Name = "BtnAddPerson";
            this.BtnAddPerson.Size = new System.Drawing.Size(77, 73);
            this.BtnAddPerson.TabIndex = 4;
            this.BtnAddPerson.Click += new System.EventHandler(this.BtnAddPerson_Click);
            // 
            // TxtFilter
            // 
            this.TxtFilter.Location = new System.Drawing.Point(308, 246);
            this.TxtFilter.MaxLength = 7;
            this.TxtFilter.Name = "TxtFilter";
            this.TxtFilter.Size = new System.Drawing.Size(171, 35);
            this.TxtFilter.TabIndex = 25;
            this.TxtFilter.TextChanged += new System.EventHandler(this.TxtFilter_TextChanged);
            this.TxtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFilter_KeyPress);
            // 
            // RenewMembershipToolStripMenuItem
            // 
            this.RenewMembershipToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Update_32;
            this.RenewMembershipToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.RenewMembershipToolStripMenuItem.Name = "RenewMembershipToolStripMenuItem";
            this.RenewMembershipToolStripMenuItem.Size = new System.Drawing.Size(246, 38);
            this.RenewMembershipToolStripMenuItem.Text = "Renew Membership";
            this.RenewMembershipToolStripMenuItem.Click += new System.EventHandler(this.RenewMembershipToolStripMenuItem_Click);
            // 
            // ManageMembersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 758);
            this.Controls.Add(this.TxtFilter);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblRecords);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvMembers);
            this.Controls.Add(this.CbFilterBy);
            this.Controls.Add(this.BtnAddPerson);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ManageMembersForm";
            this.Text = "Manage Members";
            this.Load += new System.EventHandler(this.ManageMembersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvMembers)).EndInit();
            this.CmsMember.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView DgvMembers;
        private System.Windows.Forms.ComboBox CbFilterBy;
        private System.Windows.Forms.Button BtnAddPerson;
        private System.Windows.Forms.ContextMenuStrip CmsMember;
        private System.Windows.Forms.ToolStripMenuItem ViewMemberInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewUserInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddNewPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SendEmailToolStripMenuItem;
        private System.Windows.Forms.Label LblRecords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private WindowsFormsApp1.TextCustomFilterControl TxtFilter;
        private System.Windows.Forms.ToolStripMenuItem RenewMembershipToolStripMenuItem;
    }
}