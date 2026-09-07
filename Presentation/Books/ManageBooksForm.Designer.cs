namespace LibrarySystem.Books
{
    partial class ManageBooksForm
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
            this.DgvBooks = new System.Windows.Forms.DataGridView();
            this.CmsBooks = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ViewUserInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewCopiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CbFilterBy = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblRecords = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnAddBook = new System.Windows.Forms.Button();
            this.TxtFilter = new WindowsFormsApp1.TextCustomFilterControl();

            ((System.ComponentModel.ISupportInitialize)(this.DgvBooks)).BeginInit();
            this.CmsBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();

            // 
            // DgvBooks
            // 
            this.DgvBooks.AllowUserToAddRows = false;
            this.DgvBooks.AllowUserToDeleteRows = false;
            this.DgvBooks.AllowUserToOrderColumns = true;
            this.DgvBooks.BackgroundColor = System.Drawing.Color.White;
            this.DgvBooks.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBooks.ContextMenuStrip = this.CmsBooks;
            this.DgvBooks.Location = new System.Drawing.Point(13, 296);
            this.DgvBooks.Margin =
                new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvBooks.Name = "DgvBooks";
            this.DgvBooks.ReadOnly = true;
            this.DgvBooks.RowHeadersWidth = 51;
            this.DgvBooks.Size = new System.Drawing.Size(751, 390);
            this.DgvBooks.TabIndex = 0;
            this.DgvBooks.CellDoubleClick +=
                new System.Windows.Forms.DataGridViewCellEventHandler(
                    this.DgvBooks_CellDoubleClick);

            // 
            // CmsBooks
            // 
            this.CmsBooks.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CmsBooks.Items.AddRange(
                new System.Windows.Forms.ToolStripItem[]
                {
                    this.ViewUserInfoToolStripMenuItem,
                    this.ViewCopiesToolStripMenuItem,
                    this.UpdateToolStripMenuItem,
                    this.DeleteToolStripMenuItem,
                    this.AddNewPersonToolStripMenuItem
                });

            this.CmsBooks.Name = "CmsBooks";
            this.CmsBooks.Size = new System.Drawing.Size(189, 194);
            this.CmsBooks.Opening +=
                new System.ComponentModel.CancelEventHandler(
                    this.CmsBooks_Opening);

            // 
            // ViewUserInfoToolStripMenuItem
            // 
            this.ViewUserInfoToolStripMenuItem.Image =
                global::WindowsFormsApp1.Properties.Resources.View_32;
            this.ViewUserInfoToolStripMenuItem.ImageScaling =
                System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ViewUserInfoToolStripMenuItem.Name =
                "ViewUserInfoToolStripMenuItem";
            this.ViewUserInfoToolStripMenuItem.Size =
                new System.Drawing.Size(188, 38);
            this.ViewUserInfoToolStripMenuItem.Text = "View Book";
            this.ViewUserInfoToolStripMenuItem.Click +=
                new System.EventHandler(
                    this.ViewUserInfoToolStripMenuItem_Click);

            // 
            // ViewCopiesToolStripMenuItem
            // 
            this.ViewCopiesToolStripMenuItem.Image =
                global::WindowsFormsApp1.Properties.Resources.Book_Copy_32;
            this.ViewCopiesToolStripMenuItem.ImageScaling =
                System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ViewCopiesToolStripMenuItem.Name =
                "ViewCopiesToolStripMenuItem";
            this.ViewCopiesToolStripMenuItem.Size =
                new System.Drawing.Size(188, 38);
            this.ViewCopiesToolStripMenuItem.Text = "View Copies";
            this.ViewCopiesToolStripMenuItem.Click +=
                new System.EventHandler(
                    this.ViewCopiesToolStripMenuItem_Click);

            // 
            // UpdateToolStripMenuItem
            // 
            this.UpdateToolStripMenuItem.Image =
                global::WindowsFormsApp1.Properties.Resources.Update_Book_32_png;
            this.UpdateToolStripMenuItem.ImageScaling =
                System.Windows.Forms.ToolStripItemImageScaling.None;
            this.UpdateToolStripMenuItem.Name =
                "UpdateToolStripMenuItem";
            this.UpdateToolStripMenuItem.Size =
                new System.Drawing.Size(188, 38);
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
            this.DeleteToolStripMenuItem.Name =
                "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size =
                new System.Drawing.Size(188, 38);
            this.DeleteToolStripMenuItem.Text = "Delete";
            this.DeleteToolStripMenuItem.Click +=
                new System.EventHandler(
                    this.DeleteToolStripMenuItem_Click);

            // 
            // AddNewPersonToolStripMenuItem
            // 
            this.AddNewPersonToolStripMenuItem.Image =
                global::WindowsFormsApp1.Properties.Resources.Add_Book_32;
            this.AddNewPersonToolStripMenuItem.ImageScaling =
                System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddNewPersonToolStripMenuItem.Name =
                "AddNewPersonToolStripMenuItem";
            this.AddNewPersonToolStripMenuItem.Size =
                new System.Drawing.Size(188, 38);
            this.AddNewPersonToolStripMenuItem.Text = "Add New";
            this.AddNewPersonToolStripMenuItem.Click +=
                new System.EventHandler(
                    this.AddNewPersonToolStripMenuItem_Click);

            // 
            // CbFilterBy
            // 
            this.CbFilterBy.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.CbFilterBy.Items.AddRange(
                new object[]
                {
                    "None",
                    "BookID",
                    "ISBN",
                    "Author Name"
                });

            this.CbFilterBy.Location = new System.Drawing.Point(111, 250);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 30);
            this.label3.TabIndex = 21;
            this.label3.Text = "Filter By";

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
            this.label2.Location = new System.Drawing.Point(259, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 48);
            this.label2.TabIndex = 19;
            this.label2.Text = "Manage Books";

            // 
            // LblRecords
            // 
            this.LblRecords.AutoSize = true;
            this.LblRecords.Location = new System.Drawing.Point(118, 715);
            this.LblRecords.Name = "LblRecords";
            this.LblRecords.Size = new System.Drawing.Size(0, 30);
            this.LblRecords.TabIndex = 18;

            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 715);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 30);
            this.label4.TabIndex = 17;
            this.label4.Text = "Records:";

            // 
            // pictureBox4
            // 
            this.pictureBox4.Image =
                global::WindowsFormsApp1.Properties.Resources.Books_512;
            this.pictureBox4.Location = new System.Drawing.Point(267, 68);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(266, 152);
            this.pictureBox4.SizeMode =
                System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 22;
            this.pictureBox4.TabStop = false;

            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult =
                System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Image =
                global::WindowsFormsApp1.Properties.Resources.Close_32;
            this.BtnClose.ImageAlign =
                System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClose.Location = new System.Drawing.Point(614, 695);
            this.BtnClose.Margin =
                new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(150, 64);
            this.BtnClose.TabIndex = 20;
            this.BtnClose.Text = "Close";
            this.BtnClose.Click +=
                new System.EventHandler(this.BtnClose_Click);

            // 
            // BtnAddBook
            // 
            this.BtnAddBook.Image =
                global::WindowsFormsApp1.Properties.Resources.Book_64;
            this.BtnAddBook.Location = new System.Drawing.Point(687, 209);
            this.BtnAddBook.Margin =
                new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAddBook.Name = "BtnAddBook";
            this.BtnAddBook.Size = new System.Drawing.Size(77, 73);
            this.BtnAddBook.TabIndex = 16;
            this.BtnAddBook.Click +=
                new System.EventHandler(this.BtnAddBook_Click);

            // 
            // TxtFilter
            // 
            this.TxtFilter.Location = new System.Drawing.Point(296, 253);
            this.TxtFilter.MaxLength = 7;
            this.TxtFilter.Name = "TxtFilter";
            this.TxtFilter.Size = new System.Drawing.Size(170, 35);
            this.TxtFilter.TabIndex = 24;
            this.TxtFilter.TextChanged +=
                new System.EventHandler(this.TxtFilter_TextChanged);
            this.TxtFilter.KeyPress +=
                new System.Windows.Forms.KeyPressEventHandler(
                    this.TxtFilter_KeyPress);

            // 
            // ManageBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 774);

            this.Controls.Add(this.TxtFilter);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblRecords);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnAddBook);
            this.Controls.Add(this.DgvBooks);
            this.Controls.Add(this.CbFilterBy);

            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ManageBooksForm";
            this.Text = "Manage Books";

            ((System.ComponentModel.ISupportInitialize)(this.DgvBooks)).EndInit();
            this.CmsBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView DgvBooks;
        private System.Windows.Forms.ComboBox CbFilterBy;
        private System.Windows.Forms.ContextMenuStrip CmsBooks;

        private System.Windows.Forms.ToolStripMenuItem ViewUserInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewCopiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddNewPersonToolStripMenuItem;

        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblRecords;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnAddBook;
        private WindowsFormsApp1.TextCustomFilterControl TxtFilter;
    }
}