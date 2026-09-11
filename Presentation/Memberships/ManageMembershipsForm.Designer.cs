namespace LibrarySystem.Memberships
{
    partial class ManageMembershipsForm
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
            this.DgvMemberships = new System.Windows.Forms.DataGridView();
            this.CmsMemberships = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ViewMemberInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CbFilterBy = new System.Windows.Forms.ComboBox();
            this.LblRecords = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnAddMembership = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.TxtFilter = new WindowsFormsApp1.TextCustomFilterControl();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMemberships)).BeginInit();
            this.CmsMemberships.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvMemberships
            // 
            this.DgvMemberships.AllowUserToAddRows = false;
            this.DgvMemberships.AllowUserToDeleteRows = false;
            this.DgvMemberships.AllowUserToOrderColumns = true;
            this.DgvMemberships.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DgvMemberships.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMemberships.ContextMenuStrip = this.CmsMemberships;
            this.DgvMemberships.Location = new System.Drawing.Point(21, 334);
            this.DgvMemberships.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvMemberships.Name = "DgvMemberships";
            this.DgvMemberships.ReadOnly = true;
            this.DgvMemberships.RowHeadersWidth = 51;
            this.DgvMemberships.Size = new System.Drawing.Size(942, 456);
            this.DgvMemberships.TabIndex = 0;
            this.DgvMemberships.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMemberships_CellDoubleClick);
            // 
            // CmsMemberships
            // 
            this.CmsMemberships.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CmsMemberships.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewMemberInfoToolStripMenuItem,
            this.AddNewPersonToolStripMenuItem,
            this.UpdateToolStripMenuItem,
            this.DeleteToolStripMenuItem});
            this.CmsMemberships.Name = "CmsMemberships";
            this.CmsMemberships.Size = new System.Drawing.Size(227, 184);
            this.CmsMemberships.Opening += new System.ComponentModel.CancelEventHandler(this.CmsMemberships_Opening);
            // 
            // ViewMemberInfoToolStripMenuItem
            // 
            this.ViewMemberInfoToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.View_32;
            this.ViewMemberInfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ViewMemberInfoToolStripMenuItem.Name = "ViewMemberInfoToolStripMenuItem";
            this.ViewMemberInfoToolStripMenuItem.Size = new System.Drawing.Size(226, 38);
            this.ViewMemberInfoToolStripMenuItem.Text = "View";
            this.ViewMemberInfoToolStripMenuItem.Click += new System.EventHandler(this.ViewMemberInfoToolStripMenuItem_Click);
            // 
            // AddNewPersonToolStripMenuItem
            // 
            this.AddNewPersonToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Add_Membership_32;
            this.AddNewPersonToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddNewPersonToolStripMenuItem.Name = "AddNewPersonToolStripMenuItem";
            this.AddNewPersonToolStripMenuItem.Size = new System.Drawing.Size(226, 38);
            this.AddNewPersonToolStripMenuItem.Text = "Add New";
            this.AddNewPersonToolStripMenuItem.Click += new System.EventHandler(this.AddNewPersonToolStripMenuItem_Click);
            // 
            // UpdateToolStripMenuItem
            // 
            this.UpdateToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Update_Membership_32;
            this.UpdateToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem";
            this.UpdateToolStripMenuItem.Size = new System.Drawing.Size(226, 38);
            this.UpdateToolStripMenuItem.Text = "Update";
            this.UpdateToolStripMenuItem.Click += new System.EventHandler(this.UpdateToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Delete_Membership_32;
            this.DeleteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(226, 38);
            this.DeleteToolStripMenuItem.Text = "Delete";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // CbFilterBy
            // 
            this.CbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbFilterBy.Items.AddRange(new object[] {
            "None",
            "MembershipTypeID",
            "MembershipTypeName"});
            this.CbFilterBy.Location = new System.Drawing.Point(128, 287);
            this.CbFilterBy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbFilterBy.Name = "CbFilterBy";
            this.CbFilterBy.Size = new System.Drawing.Size(178, 37);
            this.CbFilterBy.TabIndex = 1;
            this.CbFilterBy.SelectedIndexChanged += new System.EventHandler(this.CbFilterBy_SelectedIndexChanged);
            // 
            // LblRecords
            // 
            this.LblRecords.AutoSize = true;
            this.LblRecords.Location = new System.Drawing.Point(122, 814);
            this.LblRecords.Name = "LblRecords";
            this.LblRecords.Size = new System.Drawing.Size(0, 30);
            this.LblRecords.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 814);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 30);
            this.label3.TabIndex = 13;
            this.label3.Text = "Records:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(279, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(405, 48);
            this.label2.TabIndex = 15;
            this.label2.Text = "Manage Memberships";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 30);
            this.label1.TabIndex = 17;
            this.label1.Text = "Filter By";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Membership_512;
            this.pictureBox1.Location = new System.Drawing.Point(358, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // BtnAddMembership
            // 
            this.BtnAddMembership.Image = global::WindowsFormsApp1.Properties.Resources.Membership_64;
            this.BtnAddMembership.Location = new System.Drawing.Point(881, 251);
            this.BtnAddMembership.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnAddMembership.Name = "BtnAddMembership";
            this.BtnAddMembership.Size = new System.Drawing.Size(82, 72);
            this.BtnAddMembership.TabIndex = 11;
            this.BtnAddMembership.Click += new System.EventHandler(this.BtnAddMembership_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Image = global::WindowsFormsApp1.Properties.Resources.Close_32;
            this.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClose.Location = new System.Drawing.Point(812, 801);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(150, 54);
            this.BtnClose.TabIndex = 12;
            this.BtnClose.Text = "Close";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // TxtFilter
            // 
            this.TxtFilter.Location = new System.Drawing.Point(313, 288);
            this.TxtFilter.MaxLength = 20;
            this.TxtFilter.Name = "TxtFilter";
            this.TxtFilter.Size = new System.Drawing.Size(171, 35);
            this.TxtFilter.TabIndex = 24;
            // 
            // ManageMembershipsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 870);
            this.Controls.Add(this.TxtFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblRecords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnAddMembership);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.DgvMemberships);
            this.Controls.Add(this.CbFilterBy);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ManageMembershipsForm";
            this.Text = "Manage Memberships";
            this.Load += new System.EventHandler(this.ManageMembershipsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvMemberships)).EndInit();
            this.CmsMemberships.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView DgvMemberships;
        private System.Windows.Forms.ComboBox CbFilterBy;
        private System.Windows.Forms.ContextMenuStrip CmsMemberships;
        private System.Windows.Forms.ToolStripMenuItem ViewMemberInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddNewPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.Button BtnAddMembership;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label LblRecords;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private WindowsFormsApp1.TextCustomFilterControl TxtFilter;
    }
}