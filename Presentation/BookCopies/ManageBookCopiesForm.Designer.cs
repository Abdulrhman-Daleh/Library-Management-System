namespace LibrarySystem.BookCopies
{
    partial class ManageBookCopiesForm
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
            this.DgvBookCopies = new System.Windows.Forms.DataGridView();
            this.CmsBookCopies = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BorrowBookCopyMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ReturnBorrowedBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LostBookReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DamageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewBookCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewOriginalbookitem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CbFilterBy = new System.Windows.Forms.ComboBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnAddNewCopy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LblRecords = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtFilter = new WindowsFormsApp1.TextCustomFilterControl();

            ((System.ComponentModel.ISupportInitialize)(this.DgvBookCopies)).BeginInit();
            this.CmsBookCopies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();

            // 
            // DgvBookCopies
            // 
            this.DgvBookCopies.AllowUserToAddRows = false;
            this.DgvBookCopies.AllowUserToDeleteRows = false;
            this.DgvBookCopies.BackgroundColor = System.Drawing.Color.White;
            this.DgvBookCopies.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBookCopies.ContextMenuStrip = this.CmsBookCopies;
            this.DgvBookCopies.Location = new System.Drawing.Point(13, 282);
            this.DgvBookCopies.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvBookCopies.Name = "DgvBookCopies";
            this.DgvBookCopies.ReadOnly = true;
            this.DgvBookCopies.RowHeadersWidth = 51;
            this.DgvBookCopies.Size = new System.Drawing.Size(960, 438);
            this.DgvBookCopies.TabIndex = 0;
            this.DgvBookCopies.CellDoubleClick +=
                new System.Windows.Forms.DataGridViewCellEventHandler(
                    this.DgvBookCopies_CellDoubleClick);

            // 
            // CmsBookCopies
            // 
            this.CmsBookCopies.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CmsBookCopies.Items.AddRange(
                new System.Windows.Forms.ToolStripItem[]
                {
                    this.BorrowBookCopyMenuItem1,
                    this.ReturnBorrowedBookToolStripMenuItem,
                    this.LostBookReportToolStripMenuItem,
                    this.DamageToolStripMenuItem,
                    this.ViewBookCopyToolStripMenuItem,
                    this.ViewOriginalbookitem,
                    this.AddNewCopyToolStripMenuItem,
                    this.UpdateToolStripMenuItem,
                    this.DeleteToolStripMenuItem
                });

            this.CmsBookCopies.Name = "CmsBookCopies";
            this.CmsBookCopies.Size = new System.Drawing.Size(241, 374);
            this.CmsBookCopies.Opening +=
                new System.ComponentModel.CancelEventHandler(
                    this.CmsBookCopies_Opening);

            // 
            // BorrowBookCopyMenuItem1
            // 
            this.BorrowBookCopyMenuItem1.Image =
                global::WindowsFormsApp1.Properties.Resources.Borrow_Book_32;
            this.BorrowBookCopyMenuItem1.ImageScaling =
                System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BorrowBookCopyMenuItem1.Name = "BorrowBookCopyMenuItem1";
            this.BorrowBookCopyMenuItem1.Size = new System.Drawing.Size(240, 38);
            this.BorrowBookCopyMenuItem1.Text = "Borrow Book";
            this.BorrowBookCopyMenuItem1.Click +=
                new System.EventHandler(
                    this.BorrowBookCopyMenuItem1_Click);

            // 
            // ReturnBorrowedBookToolStripMenuItem
            // 
            this.ReturnBorrowedBookToolStripMenuItem.Image =
                global::WindowsFormsApp1.Properties.Resources.Return_Book_32;
            this.ReturnBorrowedBookToolStripMenuItem.ImageScaling =
                System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ReturnBorrowedBookToolStripMenuItem.Name =
                "ReturnBorrowedBookToolStripMenuItem";
            this.ReturnBorrowedBookToolStripMenuItem.Size =
                new System.Drawing.Size(240, 38);
            this.ReturnBorrowedBookToolStripMenuItem.Text = "Return";
            this.ReturnBorrowedBookToolStripMenuItem.Click +=
                new System.EventHandler(
                    this.ReturnBorrowedBookToolStripMenuItem_Click);

            // 
            // LostBookReportToolStripMenuItem
            // 
            this.LostBookReportToolStripMenuItem.Image =
                global::WindowsFormsApp1.Properties.Resources.Lost_Book_32;
            this.LostBookReportToolStripMenuItem.ImageScaling =
                System.Windows.Forms.ToolStripItemImageScaling.None;
            this.LostBookReportToolStripMenuItem.Name =
                "LostBookReportToolStripMenuItem";
            this.LostBookReportToolStripMenuItem.Size =
                new System.Drawing.Size(240, 38);
            this.LostBookReportToolStripMenuItem.Text = "Lost";
            this.LostBookReportToolStripMenuItem.Click +=
                new System.EventHandler(
                    this.LostBookReportToolStripMenuItem_Click);

            // 
            // DamageToolStripMenuItem
            // 
            this.DamageToolStripMenuItem.Image =
                global::WindowsFormsApp1.Properties.Resources.Damaged_Book_32;
            this.DamageToolStripMenuItem.ImageScaling =
                System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DamageToolStripMenuItem.Name = "DamageToolStripMenuItem";
            this.DamageToolStripMenuItem.Size =
                new System.Drawing.Size(240, 38);
            this.DamageToolStripMenuItem.Text = "Damage";
            this.DamageToolStripMenuItem.Click +=
                new System.EventHandler(
                    this.DamageToolStripMenuItem_Click);

            // 
            // ViewBookCopyToolStripMenuItem
            // 
            this.ViewBookCopyToolStripMenuItem.Image =
                global::WindowsFormsApp1.Properties.Resources.Book_Copy_32;
            this.ViewBookCopyToolStripMenuItem.ImageScaling =
                System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ViewBookCopyToolStripMenuItem.Name =
                "ViewBookCopyToolStripMenuItem";
            this.ViewBookCopyToolStripMenuItem.Size =
                new System.Drawing.Size(240, 38);
            this.ViewBookCopyToolStripMenuItem.Text = "View Copy";
            this.ViewBookCopyToolStripMenuItem.Click +=
                new System.EventHandler(
                    this.ViewUserInfoToolStripMenuItem_Click);

            // 
            // ViewOriginalbookitem
            // 
            this.ViewOriginalbookitem.Image =
                global::WindowsFormsApp1.Properties.Resources.View_32;
            this.ViewOriginalbookitem.ImageScaling =
                System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ViewOriginalbookitem.Name = "ViewOriginalbookitem";
            this.ViewOriginalbookitem.Size =
                new System.Drawing.Size(240, 38);
            this.ViewOriginalbookitem.Text = "View Original Book";
            this.ViewOriginalbookitem.Click +=
                new System.EventHandler(
                    this.ViewOriginalbookitem_Click);

            // 
            // AddNewCopyToolStripMenuItem
            // 
            this.AddNewCopyToolStripMenuItem.Image =
                global::WindowsFormsApp1.Properties.Resources.Add_Book_32;
            this.AddNewCopyToolStripMenuItem.ImageScaling =
                System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddNewCopyToolStripMenuItem.Name =
                "AddNewCopyToolStripMenuItem";
            this.AddNewCopyToolStripMenuItem.Size =
                new System.Drawing.Size(240, 38);
            this.AddNewCopyToolStripMenuItem.Text = "Add New Copy";
            this.AddNewCopyToolStripMenuItem.Click +=
                new System.EventHandler(
                    this.AddNewCopyToolStripMenuItem_Click);

            // 
            // UpdateToolStripMenuItem
            // 
            this.UpdateToolStripMenuItem.Image =
                global::WindowsFormsApp1.Properties.Resources.Update_Book_32_png;
            this.UpdateToolStripMenuItem.ImageScaling =
                System.Windows.Forms.ToolStripItemImageScaling.None;
            this.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem";
            this.UpdateToolStripMenuItem.Size =
                new System.Drawing.Size(240, 38);
            this.UpdateToolStripMenuItem.Text = "Update";
            this.UpdateToolStripMenuItem.Click +=
                new System.EventHandler(
                    this.UpdateToolStripMenuItem_Click);

            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Image =
                global::WindowsFormsApp1.Properties.Resources.Delete_Book_32;
            this.DeleteToolStripMenuItem.ImageScaling =
                System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size =
                new System.Drawing.Size(240, 38);
            this.DeleteToolStripMenuItem.Text = "Delete";
            this.DeleteToolStripMenuItem.Click +=
                new System.EventHandler(
                    this.DeleteToolStripMenuItem_Click);

            // 
            // CbFilterBy
            // 
            this.CbFilterBy.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.CbFilterBy.Items.AddRange(
                new object[]
                {
                    "None",
                    "BookCopyID",
                    "BookID",
                    "StatusID",
                    "ConditionID"
                });

            this.CbFilterBy.Location = new System.Drawing.Point(114, 235);
            this.CbFilterBy.Margin =
                new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbFilterBy.Name = "CbFilterBy";
            this.CbFilterBy.Size = new System.Drawing.Size(178, 37);
            this.CbFilterBy.TabIndex = 1;
            this.CbFilterBy.SelectedIndexChanged +=
                new System.EventHandler(
                    this.CbFilterBy_SelectedIndexChanged);
            this.CbFilterBy.KeyPress +=
                new System.Windows.Forms.KeyPressEventHandler(
                    this.CbFilterBy_KeyPress);

            // 
            // pictureBox4
            // 
            this.pictureBox4.Image =
                global::WindowsFormsApp1.Properties.Resources.Books_512;
            this.pictureBox4.Location = new System.Drawing.Point(344, 64);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(266, 152);
            this.pictureBox4.SizeMode =
                System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;

            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font(
                "Microsoft Tai Le",
                22.2F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point,
                ((byte)(0)));

            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(311, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(387, 48);
            this.label2.TabIndex = 23;
            this.label2.Text = "Manage Book Copies";

            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult =
                System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Image =
                global::WindowsFormsApp1.Properties.Resources.Close_32;
            this.BtnClose.ImageAlign =
                System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClose.Location = new System.Drawing.Point(822, 731);
            this.BtnClose.Margin =
                new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(150, 64);
            this.BtnClose.TabIndex = 25;
            this.BtnClose.Text = "Close";
            this.BtnClose.Click +=
                new System.EventHandler(this.BtnClose_Click);

            // 
            // BtnAddNewCopy
            // 
            this.BtnAddNewCopy.Image =
                global::WindowsFormsApp1.Properties.Resources.Book_64;
            this.BtnAddNewCopy.Location = new System.Drawing.Point(895, 199);
            this.BtnAddNewCopy.Margin =
                new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAddNewCopy.Name = "BtnAddNewCopy";
            this.BtnAddNewCopy.Size = new System.Drawing.Size(77, 73);
            this.BtnAddNewCopy.TabIndex = 26;
            this.BtnAddNewCopy.Click +=
                new System.EventHandler(this.BtnAddNewCopy_Click);

            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 30);
            this.label3.TabIndex = 27;
            this.label3.Text = "Filter By";

            // 
            // LblRecords
            // 
            this.LblRecords.AutoSize = true;
            this.LblRecords.Location = new System.Drawing.Point(119, 749);
            this.LblRecords.Name = "LblRecords";
            this.LblRecords.Size = new System.Drawing.Size(0, 30);
            this.LblRecords.TabIndex = 29;

            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 749);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 30);
            this.label4.TabIndex = 28;
            this.label4.Text = "Records:";

            // 
            // TxtFilter
            // 
            this.TxtFilter.Location = new System.Drawing.Point(299, 238);
            this.TxtFilter.MaxLength = 7;
            this.TxtFilter.Name = "TxtFilter";
            this.TxtFilter.Size = new System.Drawing.Size(182, 35);
            this.TxtFilter.TabIndex = 31;
            this.TxtFilter.TextChanged +=
                new System.EventHandler(this.TxtFilter_TextChanged);
            this.TxtFilter.KeyPress +=
                new System.Windows.Forms.KeyPressEventHandler(
                    this.TxtFilter_KeyPress);

            // 
            // ManageBookCopiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 803);

            this.Controls.Add(this.TxtFilter);
            this.Controls.Add(this.LblRecords);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnAddNewCopy);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DgvBookCopies);
            this.Controls.Add(this.CbFilterBy);

            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ManageBookCopiesForm";
            this.Text = "Manage Book Copies";
            this.Load +=
                new System.EventHandler(this.ManageBookCopiesForm_Load);

            ((System.ComponentModel.ISupportInitialize)(this.DgvBookCopies)).EndInit();
            this.CmsBookCopies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView DgvBookCopies;
        private System.Windows.Forms.ComboBox CbFilterBy;
        private System.Windows.Forms.ContextMenuStrip CmsBookCopies;

        private System.Windows.Forms.ToolStripMenuItem ViewBookCopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewOriginalbookitem;
        private System.Windows.Forms.ToolStripMenuItem UpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddNewCopyToolStripMenuItem;

        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnAddNewCopy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblRecords;
        private System.Windows.Forms.Label label4;

        private WindowsFormsApp1.TextCustomFilterControl TxtFilter;

        private System.Windows.Forms.ToolStripMenuItem DamageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LostBookReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReturnBorrowedBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BorrowBookCopyMenuItem1;
    }
}