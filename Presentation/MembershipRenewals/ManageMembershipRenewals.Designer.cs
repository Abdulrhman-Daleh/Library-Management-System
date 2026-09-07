namespace WindowsFormsApp1.MembershipRenewals
{
    partial class ManageMembershipRenewals
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
            this.components = new System.ComponentModel.Container();
            this.TxtFilter = new WindowsFormsApp1.TextCustomFilterControl();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblRecords = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CbFilterBy = new System.Windows.Forms.ComboBox();
            this.DgvMembershipRenewals = new System.Windows.Forms.DataGridView();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.CbIsPaid = new System.Windows.Forms.ComboBox();
            this.msRenewals = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewRenewalInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMembershipRenewals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.msRenewals.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtFilter
            // 
            this.TxtFilter.Location = new System.Drawing.Point(308, 235);
            this.TxtFilter.MaxLength = 7;
            this.TxtFilter.Name = "TxtFilter";
            this.TxtFilter.Size = new System.Drawing.Size(171, 35);
            this.TxtFilter.TabIndex = 35;
            this.TxtFilter.TextChanged += new System.EventHandler(this.TxtFilter_TextChanged);
            this.TxtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFilter_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 30);
            this.label3.TabIndex = 33;
            this.label3.Text = "Filter By";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(300, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(412, 48);
            this.label2.TabIndex = 31;
            this.label2.Text = "Membership Renewals";
            // 
            // LblRecords
            // 
            this.LblRecords.AutoSize = true;
            this.LblRecords.Location = new System.Drawing.Point(124, 695);
            this.LblRecords.Name = "LblRecords";
            this.LblRecords.Size = new System.Drawing.Size(0, 30);
            this.LblRecords.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 695);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 30);
            this.label1.TabIndex = 29;
            this.label1.Text = "Records:";
            // 
            // CbFilterBy
            // 
            this.CbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbFilterBy.Items.AddRange(new object[] {
            "None",
            "RenewID",
            "MemberID",
            "IsPaid"});
            this.CbFilterBy.Location = new System.Drawing.Point(123, 232);
            this.CbFilterBy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbFilterBy.Name = "CbFilterBy";
            this.CbFilterBy.Size = new System.Drawing.Size(178, 37);
            this.CbFilterBy.TabIndex = 27;
            this.CbFilterBy.SelectedIndexChanged += new System.EventHandler(this.CbFilterBy_SelectedIndexChanged);
            this.CbFilterBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbIsPaid_KeyPress);
            // 
            // DgvMembershipRenewals
            // 
            this.DgvMembershipRenewals.AllowUserToAddRows = false;
            this.DgvMembershipRenewals.AllowUserToDeleteRows = false;
            this.DgvMembershipRenewals.AllowUserToOrderColumns = true;
            this.DgvMembershipRenewals.BackgroundColor = System.Drawing.Color.White;
            this.DgvMembershipRenewals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMembershipRenewals.ContextMenuStrip = this.msRenewals;
            this.DgvMembershipRenewals.Location = new System.Drawing.Point(13, 277);
            this.DgvMembershipRenewals.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvMembershipRenewals.Name = "DgvMembershipRenewals";
            this.DgvMembershipRenewals.ReadOnly = true;
            this.DgvMembershipRenewals.RowHeadersWidth = 51;
            this.DgvMembershipRenewals.Size = new System.Drawing.Size(926, 393);
            this.DgvMembershipRenewals.TabIndex = 26;
            this.DgvMembershipRenewals.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMembers_CellDoubleClick);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApp1.Properties.Resources.Membership_Renewal_512;
            this.pictureBox4.Location = new System.Drawing.Point(362, 64);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(266, 152);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 34;
            this.pictureBox4.TabStop = false;
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Image = global::WindowsFormsApp1.Properties.Resources.Close_32;
            this.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClose.Location = new System.Drawing.Point(788, 677);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(150, 64);
            this.BtnClose.TabIndex = 32;
            this.BtnClose.Text = "Close";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // CbIsPaid
            // 
            this.CbIsPaid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbIsPaid.Items.AddRange(new object[] {
            "All",
            "Paid",
            "Unpaid"});
            this.CbIsPaid.Location = new System.Drawing.Point(308, 235);
            this.CbIsPaid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbIsPaid.Name = "CbIsPaid";
            this.CbIsPaid.Size = new System.Drawing.Size(100, 37);
            this.CbIsPaid.TabIndex = 36;
            this.CbIsPaid.SelectedIndexChanged += new System.EventHandler(this.CbIsPaid_SelectedIndexChanged);
            this.CbIsPaid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbIsPaid_KeyPress);
            // 
            // msRenewals
            // 
            this.msRenewals.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msRenewals.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewRenewalInfoToolStripMenuItem});
            this.msRenewals.Name = "msRenewals";
            this.msRenewals.Size = new System.Drawing.Size(236, 70);
            // 
            // viewRenewalInfoToolStripMenuItem
            // 
            this.viewRenewalInfoToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.View_32;
            this.viewRenewalInfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.viewRenewalInfoToolStripMenuItem.Name = "viewRenewalInfoToolStripMenuItem";
            this.viewRenewalInfoToolStripMenuItem.Size = new System.Drawing.Size(235, 38);
            this.viewRenewalInfoToolStripMenuItem.Text = "View Renewal Info";
            this.viewRenewalInfoToolStripMenuItem.Click += new System.EventHandler(this.viewRenewalInfoToolStripMenuItem_Click);
            // 
            // ManageMembershipRenewals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 746);
            this.Controls.Add(this.CbIsPaid);
            this.Controls.Add(this.TxtFilter);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblRecords);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbFilterBy);
            this.Controls.Add(this.DgvMembershipRenewals);
            this.Name = "ManageMembershipRenewals";
            this.Text = "Manage Membership Renewals";
            this.Load += new System.EventHandler(this.ManageMembershipRenewals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvMembershipRenewals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.msRenewals.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextCustomFilterControl TxtFilter;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblRecords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbFilterBy;
        private System.Windows.Forms.DataGridView DgvMembershipRenewals;
        private System.Windows.Forms.ComboBox CbIsPaid;
        private System.Windows.Forms.ContextMenuStrip msRenewals;
        private System.Windows.Forms.ToolStripMenuItem viewRenewalInfoToolStripMenuItem;
    }
}