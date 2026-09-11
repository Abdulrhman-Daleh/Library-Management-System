namespace LibrarySystem.LibraryPolicies
{
    partial class ManagePoliciesForm
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
            this.DgvPolicies = new System.Windows.Forms.DataGridView();
            this.CmsPolicies = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CbFilterBy = new System.Windows.Forms.ComboBox();
            this.LblRecords = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnAddPolicy = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtFilter = new WindowsFormsApp1.TextCustomFilterControl();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPolicies)).BeginInit();
            this.CmsPolicies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvPolicies
            // 
            this.DgvPolicies.AllowUserToAddRows = false;
            this.DgvPolicies.AllowUserToDeleteRows = false;
            this.DgvPolicies.AllowUserToOrderColumns = true;
            this.DgvPolicies.BackgroundColor = System.Drawing.Color.White;
            this.DgvPolicies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPolicies.ContextMenuStrip = this.CmsPolicies;
            this.DgvPolicies.Location = new System.Drawing.Point(13, 331);
            this.DgvPolicies.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvPolicies.Name = "DgvPolicies";
            this.DgvPolicies.ReadOnly = true;
            this.DgvPolicies.RowHeadersWidth = 51;
            this.DgvPolicies.Size = new System.Drawing.Size(922, 368);
            this.DgvPolicies.TabIndex = 0;
            this.DgvPolicies.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPolicies_CellDoubleClick);
            // 
            // CmsPolicies
            // 
            this.CmsPolicies.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CmsPolicies.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewToolStripMenuItem,
            this.UpdateToolStripMenuItem,
            this.DeleteToolStripMenuItem,
            this.AddToolStripMenuItem});
            this.CmsPolicies.Name = "CmsPolicies";
            this.CmsPolicies.Size = new System.Drawing.Size(227, 184);
            this.CmsPolicies.Opening += new System.ComponentModel.CancelEventHandler(this.CmsPolicies_Opening);
            // 
            // ViewToolStripMenuItem
            // 
            this.ViewToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.View_32;
            this.ViewToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem";
            this.ViewToolStripMenuItem.Size = new System.Drawing.Size(226, 38);
            this.ViewToolStripMenuItem.Text = "View";
            this.ViewToolStripMenuItem.Click += new System.EventHandler(this.ViewToolStripMenuItem_Click);
            // 
            // UpdateToolStripMenuItem
            // 
            this.UpdateToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Update_Policy_32;
            this.UpdateToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem";
            this.UpdateToolStripMenuItem.Size = new System.Drawing.Size(226, 38);
            this.UpdateToolStripMenuItem.Text = "Update";
            this.UpdateToolStripMenuItem.Click += new System.EventHandler(this.UpdateToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Delete_Policy_32;
            this.DeleteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(226, 38);
            this.DeleteToolStripMenuItem.Text = "Delete";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // AddToolStripMenuItem
            // 
            this.AddToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Policy_32;
            this.AddToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(226, 38);
            this.AddToolStripMenuItem.Text = "Add New";
            this.AddToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // CbFilterBy
            // 
            this.CbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbFilterBy.Items.AddRange(new object[] {
            "None",
            "PolicyID"});
            this.CbFilterBy.Location = new System.Drawing.Point(123, 286);
            this.CbFilterBy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbFilterBy.Name = "CbFilterBy";
            this.CbFilterBy.Size = new System.Drawing.Size(178, 37);
            this.CbFilterBy.TabIndex = 1;
            this.CbFilterBy.SelectedIndexChanged += new System.EventHandler(this.CbFilterBy_SelectedIndexChanged);
            // 
            // LblRecords
            // 
            this.LblRecords.AutoSize = true;
            this.LblRecords.Location = new System.Drawing.Point(124, 716);
            this.LblRecords.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblRecords.Name = "LblRecords";
            this.LblRecords.Size = new System.Drawing.Size(0, 30);
            this.LblRecords.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 716);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 30);
            this.label1.TabIndex = 11;
            this.label1.Text = "Records:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(333, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 48);
            this.label2.TabIndex = 17;
            this.label2.Text = "Manage Policies";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 30);
            this.label3.TabIndex = 19;
            this.label3.Text = "Filter By";
            // 
            // BtnAddPolicy
            // 
            this.BtnAddPolicy.Image = global::WindowsFormsApp1.Properties.Resources.Policy_64;
            this.BtnAddPolicy.Location = new System.Drawing.Point(853, 251);
            this.BtnAddPolicy.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnAddPolicy.Name = "BtnAddPolicy";
            this.BtnAddPolicy.Size = new System.Drawing.Size(82, 72);
            this.BtnAddPolicy.TabIndex = 21;
            this.BtnAddPolicy.Click += new System.EventHandler(this.BtnAddPolicy_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Image = global::WindowsFormsApp1.Properties.Resources.Close_32;
            this.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClose.Location = new System.Drawing.Point(785, 710);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(150, 54);
            this.BtnClose.TabIndex = 20;
            this.BtnClose.Text = "Close";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Policies_512;
            this.pictureBox1.Location = new System.Drawing.Point(357, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // TxtFilter
            // 
            this.TxtFilter.Location = new System.Drawing.Point(308, 289);
            this.TxtFilter.MaxLength = 7;
            this.TxtFilter.Name = "TxtFilter";
            this.TxtFilter.Size = new System.Drawing.Size(171, 35);
            this.TxtFilter.TabIndex = 25;
            this.TxtFilter.TextChanged += new System.EventHandler(this.TxtFilter_TextChanged);
            this.TxtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFilter_KeyPress);
            // 
            // ManagePoliciesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 772);
            this.Controls.Add(this.TxtFilter);
            this.Controls.Add(this.BtnAddPolicy);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblRecords);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvPolicies);
            this.Controls.Add(this.CbFilterBy);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ManagePoliciesForm";
            this.Text = "Manage Policies";
            this.Load += new System.EventHandler(this.ManagePoliciesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPolicies)).EndInit();
            this.CmsPolicies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView DgvPolicies;
        private System.Windows.Forms.ComboBox CbFilterBy;
        private System.Windows.Forms.ContextMenuStrip CmsPolicies;
        private System.Windows.Forms.ToolStripMenuItem ViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.Label LblRecords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnAddPolicy;
        private WindowsFormsApp1.TextCustomFilterControl TxtFilter;
    }
}