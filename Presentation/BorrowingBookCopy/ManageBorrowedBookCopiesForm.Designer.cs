namespace LibrarySystem.BorrowingBookCopy
{
    partial class ManageBorrowedBookCopiesForm
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
            this.DgvBorrowedBookCopies = new System.Windows.Forms.DataGridView();
            this.CmsBookCopies = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ViewBookCardInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewBorrowMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ReturnBorrowedBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LostBookReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DamageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProccessFinePaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CbFilterBy = new System.Windows.Forms.ComboBox();
            this.BtnBorrowNewBook = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LblRecords = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtFilter = new WindowsFormsApp1.TextCustomFilterControl();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBorrowedBookCopies)).BeginInit();
            this.CmsBookCopies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvBorrowedBookCopies
            // 
            this.DgvBorrowedBookCopies.AllowUserToAddRows = false;
            this.DgvBorrowedBookCopies.AllowUserToDeleteRows = false;
            this.DgvBorrowedBookCopies.AllowUserToOrderColumns = true;
            this.DgvBorrowedBookCopies.BackgroundColor = System.Drawing.Color.White;
            this.DgvBorrowedBookCopies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBorrowedBookCopies.ContextMenuStrip = this.CmsBookCopies;
            this.DgvBorrowedBookCopies.Location = new System.Drawing.Point(14, 278);
            this.DgvBorrowedBookCopies.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvBorrowedBookCopies.Name = "DgvBorrowedBookCopies";
            this.DgvBorrowedBookCopies.ReadOnly = true;
            this.DgvBorrowedBookCopies.RowHeadersWidth = 51;
            this.DgvBorrowedBookCopies.Size = new System.Drawing.Size(941, 400);
            this.DgvBorrowedBookCopies.TabIndex = 0;
            this.DgvBorrowedBookCopies.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBorrowedBookCopies_CellDoubleClick);
            // 
            // CmsBookCopies
            // 
            this.CmsBookCopies.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CmsBookCopies.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewBookCardInfoToolStripMenuItem,
            this.ViewBorrowMenuItem2,
            this.ReturnBorrowedBookToolStripMenuItem,
            this.LostBookReportToolStripMenuItem,
            this.DamageToolStripMenuItem,
            this.ProccessFinePaymentToolStripMenuItem,
            this.AddNewCopyToolStripMenuItem});
            this.CmsBookCopies.Name = "CmsBookCopies";
            this.CmsBookCopies.Size = new System.Drawing.Size(261, 298);
            this.CmsBookCopies.Opening += new System.ComponentModel.CancelEventHandler(this.CmsBookCopies_Opening);
            // 
            // ViewBookCardInfoToolStripMenuItem
            // 
            this.ViewBookCardInfoToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.View_32;
            this.ViewBookCardInfoToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ViewBookCardInfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ViewBookCardInfoToolStripMenuItem.Name = "ViewBookCardInfoToolStripMenuItem";
            this.ViewBookCardInfoToolStripMenuItem.Size = new System.Drawing.Size(260, 38);
            this.ViewBookCardInfoToolStripMenuItem.Text = "View Book Copy";
            this.ViewBookCardInfoToolStripMenuItem.Click += new System.EventHandler(this.ViewBookCardInfoToolStripMenuItem_Click);
            // 
            // ViewBorrowMenuItem2
            // 
            this.ViewBorrowMenuItem2.Image = global::WindowsFormsApp1.Properties.Resources.View_32;
            this.ViewBorrowMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ViewBorrowMenuItem2.Name = "ViewBorrowMenuItem2";
            this.ViewBorrowMenuItem2.Size = new System.Drawing.Size(260, 38);
            this.ViewBorrowMenuItem2.Text = "View Borrow Details";
            this.ViewBorrowMenuItem2.Click += new System.EventHandler(this.ViewBorrowMenuItem2_Click);
            // 
            // ReturnBorrowedBookToolStripMenuItem
            // 
            this.ReturnBorrowedBookToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Return_Book_32;
            this.ReturnBorrowedBookToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ReturnBorrowedBookToolStripMenuItem.Name = "ReturnBorrowedBookToolStripMenuItem";
            this.ReturnBorrowedBookToolStripMenuItem.Size = new System.Drawing.Size(260, 38);
            this.ReturnBorrowedBookToolStripMenuItem.Text = "Return";
            this.ReturnBorrowedBookToolStripMenuItem.Click += new System.EventHandler(this.ReturnBorrowedBookToolStripMenuItem_Click);
            // 
            // LostBookReportToolStripMenuItem
            // 
            this.LostBookReportToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Lost_Book_32;
            this.LostBookReportToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.LostBookReportToolStripMenuItem.Name = "LostBookReportToolStripMenuItem";
            this.LostBookReportToolStripMenuItem.Size = new System.Drawing.Size(260, 38);
            this.LostBookReportToolStripMenuItem.Text = "Lost";
            this.LostBookReportToolStripMenuItem.Click += new System.EventHandler(this.LostBookReportToolStripMenuItem_Click);
            // 
            // DamageToolStripMenuItem
            // 
            this.DamageToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Damaged_Book_32;
            this.DamageToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DamageToolStripMenuItem.Name = "DamageToolStripMenuItem";
            this.DamageToolStripMenuItem.Size = new System.Drawing.Size(260, 38);
            this.DamageToolStripMenuItem.Text = "Damage";
            this.DamageToolStripMenuItem.Click += new System.EventHandler(this.DamageToolStripMenuItem_Click);
            // 
            // ProccessFinePaymentToolStripMenuItem
            // 
            this.ProccessFinePaymentToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Fine_32;
            this.ProccessFinePaymentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ProccessFinePaymentToolStripMenuItem.Name = "ProccessFinePaymentToolStripMenuItem";
            this.ProccessFinePaymentToolStripMenuItem.Size = new System.Drawing.Size(260, 38);
            this.ProccessFinePaymentToolStripMenuItem.Text = "Process Fine Payment";
            this.ProccessFinePaymentToolStripMenuItem.Click += new System.EventHandler(this.ProccessFinePaymentToolStripMenuItem_Click);
            // 
            // AddNewCopyToolStripMenuItem
            // 
            this.AddNewCopyToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Borrow_Book_32;
            this.AddNewCopyToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddNewCopyToolStripMenuItem.Name = "AddNewCopyToolStripMenuItem";
            this.AddNewCopyToolStripMenuItem.Size = new System.Drawing.Size(260, 38);
            this.AddNewCopyToolStripMenuItem.Text = "Add New Borrow";
            this.AddNewCopyToolStripMenuItem.Click += new System.EventHandler(this.AddNewCopyToolStripMenuItem_Click);
            // 
            // CbFilterBy
            // 
            this.CbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbFilterBy.Items.AddRange(new object[] {
            "None",
            "BorrowID",
            "BookCopyID",
            "MemberID"});
            this.CbFilterBy.Location = new System.Drawing.Point(104, 231);
            this.CbFilterBy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbFilterBy.Name = "CbFilterBy";
            this.CbFilterBy.Size = new System.Drawing.Size(178, 37);
            this.CbFilterBy.TabIndex = 1;
            this.CbFilterBy.SelectedIndexChanged += new System.EventHandler(this.CbFilterBy_SelectedIndexChanged);
            this.CbFilterBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbFilterBy_KeyPress);
            // 
            // BtnBorrowNewBook
            // 
            this.BtnBorrowNewBook.Image = global::WindowsFormsApp1.Properties.Resources.Borrow_Book_32;
            this.BtnBorrowNewBook.Location = new System.Drawing.Point(892, 214);
            this.BtnBorrowNewBook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnBorrowNewBook.Name = "BtnBorrowNewBook";
            this.BtnBorrowNewBook.Size = new System.Drawing.Size(63, 54);
            this.BtnBorrowNewBook.TabIndex = 4;
            this.BtnBorrowNewBook.Click += new System.EventHandler(this.BtnBorrowNewBook_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 30);
            this.label3.TabIndex = 14;
            this.label3.Text = "Filter By";
            // 
            // LblRecords
            // 
            this.LblRecords.AutoSize = true;
            this.LblRecords.Location = new System.Drawing.Point(118, 707);
            this.LblRecords.Name = "LblRecords";
            this.LblRecords.Size = new System.Drawing.Size(0, 30);
            this.LblRecords.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 707);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 30);
            this.label1.TabIndex = 15;
            this.label1.Text = "Records:";
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Image = global::WindowsFormsApp1.Properties.Resources.Close_32;
            this.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClose.Location = new System.Drawing.Point(805, 689);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(150, 64);
            this.BtnClose.TabIndex = 17;
            this.BtnClose.Text = "Close";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApp1.Properties.Resources.Borrow_Book_512;
            this.pictureBox4.Location = new System.Drawing.Point(347, 64);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(266, 152);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(281, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(420, 48);
            this.label2.TabIndex = 18;
            this.label2.Text = "Borrowed Book Copies";
            // 
            // TxtFilter
            // 
            this.TxtFilter.Location = new System.Drawing.Point(289, 235);
            this.TxtFilter.MaxLength = 7;
            this.TxtFilter.Name = "TxtFilter";
            this.TxtFilter.Size = new System.Drawing.Size(157, 35);
            this.TxtFilter.TabIndex = 21;
            this.TxtFilter.TextChanged += new System.EventHandler(this.TxtFilter_TextChanged);
            this.TxtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFilter_KeyPress);
            // 
            // ManageBorrowedBookCopiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 758);
            this.Controls.Add(this.TxtFilter);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.LblRecords);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DgvBorrowedBookCopies);
            this.Controls.Add(this.CbFilterBy);
            this.Controls.Add(this.BtnBorrowNewBook);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ManageBorrowedBookCopiesForm";
            this.Text = "Manage Borrowed Book Copies";
            this.Load += new System.EventHandler(this.ManageBorrowedBookCopiesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvBorrowedBookCopies)).EndInit();
            this.CmsBookCopies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView DgvBorrowedBookCopies;
        private System.Windows.Forms.ComboBox CbFilterBy;
        private System.Windows.Forms.Button BtnBorrowNewBook;
        private System.Windows.Forms.ContextMenuStrip CmsBookCopies;
        private System.Windows.Forms.ToolStripMenuItem ViewBookCardInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewBorrowMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ReturnBorrowedBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LostBookReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DamageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProccessFinePaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddNewCopyToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblRecords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private WindowsFormsApp1.TextCustomFilterControl TxtFilter;
    }
}