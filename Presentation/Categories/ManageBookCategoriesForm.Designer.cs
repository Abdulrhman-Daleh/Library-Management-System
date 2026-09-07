namespace LibrarySystem.BookCategories
{
    partial class ManageBookCategoriesForm
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
            this.DgvCategories = new System.Windows.Forms.DataGridView();
            this.CmsCategory = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ViewCategoryInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CbFilterBy = new System.Windows.Forms.ComboBox();
            this.LblRecords = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.BtnAddCategory = new System.Windows.Forms.Button();
            this.TxtFilter = new WindowsFormsApp1.TextCustomFilterControl();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCategories)).BeginInit();
            this.CmsCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvCategories
            // 
            this.DgvCategories.AllowUserToAddRows = false;
            this.DgvCategories.AllowUserToDeleteRows = false;
            this.DgvCategories.AllowUserToOrderColumns = true;
            this.DgvCategories.BackgroundColor = System.Drawing.Color.White;
            this.DgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCategories.ContextMenuStrip = this.CmsCategory;
            this.DgvCategories.Location = new System.Drawing.Point(13, 290);
            this.DgvCategories.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvCategories.Name = "DgvCategories";
            this.DgvCategories.ReadOnly = true;
            this.DgvCategories.RowHeadersWidth = 51;
            this.DgvCategories.Size = new System.Drawing.Size(704, 308);
            this.DgvCategories.TabIndex = 0;
            this.DgvCategories.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCategories_CellDoubleClick);
            // 
            // CmsCategory
            // 
            this.CmsCategory.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CmsCategory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewCategoryInfoToolStripMenuItem,
            this.UpdateToolStripMenuItem,
            this.DeleteToolStripMenuItem,
            this.AddNewPersonToolStripMenuItem});
            this.CmsCategory.Name = "CmsCategory";
            this.CmsCategory.Size = new System.Drawing.Size(167, 156);
            this.CmsCategory.Opening += new System.ComponentModel.CancelEventHandler(this.CmsCategory_Opening);
            // 
            // ViewCategoryInfoToolStripMenuItem
            // 
            this.ViewCategoryInfoToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.View_32;
            this.ViewCategoryInfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ViewCategoryInfoToolStripMenuItem.Name = "ViewCategoryInfoToolStripMenuItem";
            this.ViewCategoryInfoToolStripMenuItem.Size = new System.Drawing.Size(166, 38);
            this.ViewCategoryInfoToolStripMenuItem.Text = "View";
            this.ViewCategoryInfoToolStripMenuItem.Click += new System.EventHandler(this.ViewUserInfoToolStripMenuItem_Click);
            // 
            // UpdateToolStripMenuItem
            // 
            this.UpdateToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Update_Categories_32;
            this.UpdateToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem";
            this.UpdateToolStripMenuItem.Size = new System.Drawing.Size(166, 38);
            this.UpdateToolStripMenuItem.Text = "Update";
            this.UpdateToolStripMenuItem.Click += new System.EventHandler(this.UpdateToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Delete_Categories_32;
            this.DeleteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(166, 38);
            this.DeleteToolStripMenuItem.Text = "Delete";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // AddNewPersonToolStripMenuItem
            // 
            this.AddNewPersonToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Add_Categories_32;
            this.AddNewPersonToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddNewPersonToolStripMenuItem.Name = "AddNewPersonToolStripMenuItem";
            this.AddNewPersonToolStripMenuItem.Size = new System.Drawing.Size(166, 38);
            this.AddNewPersonToolStripMenuItem.Text = "Add New";
            this.AddNewPersonToolStripMenuItem.Click += new System.EventHandler(this.AddNewPersonToolStripMenuItem_Click);
            // 
            // CbFilterBy
            // 
            this.CbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbFilterBy.Items.AddRange(new object[] {
            "None",
            "CategoryID",
            "CategoryName"});
            this.CbFilterBy.Location = new System.Drawing.Point(122, 243);
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
            this.LblRecords.Location = new System.Drawing.Point(122, 619);
            this.LblRecords.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblRecords.Name = "LblRecords";
            this.LblRecords.Size = new System.Drawing.Size(0, 30);
            this.LblRecords.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 619);
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
            this.label2.Location = new System.Drawing.Point(190, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 48);
            this.label2.TabIndex = 15;
            this.label2.Text = "Manage Categories";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 30);
            this.label3.TabIndex = 17;
            this.label3.Text = "Filter By";
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Image = global::WindowsFormsApp1.Properties.Resources.Close_32;
            this.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClose.Location = new System.Drawing.Point(567, 609);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(150, 64);
            this.BtnClose.TabIndex = 18;
            this.BtnClose.Text = "Close";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApp1.Properties.Resources.Book_Categories_512;
            this.pictureBox4.Location = new System.Drawing.Point(230, 70);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(266, 152);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // BtnAddCategory
            // 
            this.BtnAddCategory.Image = global::WindowsFormsApp1.Properties.Resources.Category_64;
            this.BtnAddCategory.Location = new System.Drawing.Point(637, 212);
            this.BtnAddCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAddCategory.Name = "BtnAddCategory";
            this.BtnAddCategory.Size = new System.Drawing.Size(80, 70);
            this.BtnAddCategory.TabIndex = 4;
            this.BtnAddCategory.Click += new System.EventHandler(this.BtnAddCategory_Click);
            // 
            // TxtFilter
            // 
            this.TxtFilter.Location = new System.Drawing.Point(307, 247);
            this.TxtFilter.MaxLength = 7;
            this.TxtFilter.Name = "TxtFilter";
            this.TxtFilter.Size = new System.Drawing.Size(170, 35);
            this.TxtFilter.TabIndex = 20;
            this.TxtFilter.TextChanged += new System.EventHandler(this.TxtFilter_TextChanged);
            this.TxtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFilter_KeyPress);
            // 
            // ManageBookCategoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 679);
            this.Controls.Add(this.TxtFilter);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblRecords);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvCategories);
            this.Controls.Add(this.CbFilterBy);
            this.Controls.Add(this.BtnAddCategory);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ManageBookCategoriesForm";
            this.Text = "Manage Categories";
            this.Load += new System.EventHandler(this.ManageBookCategoriesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCategories)).EndInit();
            this.CmsCategory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView DgvCategories;
        private System.Windows.Forms.ComboBox CbFilterBy;
        private System.Windows.Forms.Button BtnAddCategory;
        private System.Windows.Forms.ContextMenuStrip CmsCategory;
        private System.Windows.Forms.ToolStripMenuItem ViewCategoryInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddNewPersonToolStripMenuItem;
        private System.Windows.Forms.Label LblRecords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnClose;
        private WindowsFormsApp1.TextCustomFilterControl TxtFilter;
    }
}