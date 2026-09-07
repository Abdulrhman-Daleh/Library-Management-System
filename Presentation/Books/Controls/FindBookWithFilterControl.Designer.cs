namespace LibrarySystem.Books.Controls
{
    partial class FindBookWithFilterControl
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
            this.GbFilter = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnFindBook = new System.Windows.Forms.Button();
            this.BtnAddNewBook = new System.Windows.Forms.Button();
            this.TxtFilter = new System.Windows.Forms.TextBox();
            this.CbFilterBy = new System.Windows.Forms.ComboBox();
            this.ViewBookCardControl = new LibrarySystem.Books.Controls.ViewBookCardControl();
            this.GbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbFilter
            // 
            this.GbFilter.Controls.Add(this.label1);
            this.GbFilter.Controls.Add(this.BtnFindBook);
            this.GbFilter.Controls.Add(this.BtnAddNewBook);
            this.GbFilter.Controls.Add(this.TxtFilter);
            this.GbFilter.Controls.Add(this.CbFilterBy);
            this.GbFilter.Location = new System.Drawing.Point(0, 0);
            this.GbFilter.Margin = new System.Windows.Forms.Padding(4);
            this.GbFilter.Name = "GbFilter";
            this.GbFilter.Padding = new System.Windows.Forms.Padding(4);
            this.GbFilter.Size = new System.Drawing.Size(625, 115);
            this.GbFilter.TabIndex = 0;
            this.GbFilter.TabStop = false;
            this.GbFilter.Text = "Filter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 58;
            this.label1.Text = "Find By:";
            // 
            // BtnFindBook
            // 
            this.BtnFindBook.Image = global::WindowsFormsApp1.Properties.Resources.View_32;
            this.BtnFindBook.Location = new System.Drawing.Point(470, 31);
            this.BtnFindBook.Margin = new System.Windows.Forms.Padding(4);
            this.BtnFindBook.Name = "BtnFindBook";
            this.BtnFindBook.Size = new System.Drawing.Size(63, 60);
            this.BtnFindBook.TabIndex = 0;
            this.BtnFindBook.Click += new System.EventHandler(this.BtnFindBook_Click);
            // 
            // BtnAddNewBook
            // 
            this.BtnAddNewBook.Image = global::WindowsFormsApp1.Properties.Resources.Book_32;
            this.BtnAddNewBook.Location = new System.Drawing.Point(541, 31);
            this.BtnAddNewBook.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAddNewBook.Name = "BtnAddNewBook";
            this.BtnAddNewBook.Size = new System.Drawing.Size(63, 60);
            this.BtnAddNewBook.TabIndex = 1;
            this.BtnAddNewBook.Click += new System.EventHandler(this.BtnAddNewBook_Click);
            // 
            // TxtFilter
            // 
            this.TxtFilter.Location = new System.Drawing.Point(279, 47);
            this.TxtFilter.Margin = new System.Windows.Forms.Padding(4);
            this.TxtFilter.Name = "TxtFilter";
            this.TxtFilter.Size = new System.Drawing.Size(161, 30);
            this.TxtFilter.TabIndex = 2;
            this.TxtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFilter_KeyPress);
            // 
            // CbFilterBy
            // 
            this.CbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbFilterBy.Items.AddRange(new object[] {
            "Book ID",
            "Category ID"});
            this.CbFilterBy.Location = new System.Drawing.Point(121, 47);
            this.CbFilterBy.Margin = new System.Windows.Forms.Padding(4);
            this.CbFilterBy.Name = "CbFilterBy";
            this.CbFilterBy.Size = new System.Drawing.Size(149, 31);
            this.CbFilterBy.TabIndex = 3;
            this.CbFilterBy.SelectedIndexChanged += new System.EventHandler(this.CbFilterBy_SelectedIndexChanged);
            this.CbFilterBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbFilterBy_KeyPress);
            // 
            // ViewBookCardControl
            // 
            this.ViewBookCardControl.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ViewBookCardControl.Location = new System.Drawing.Point(0, 124);
            this.ViewBookCardControl.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.ViewBookCardControl.Name = "ViewBookCardControl";
            this.ViewBookCardControl.Size = new System.Drawing.Size(625, 194);
            this.ViewBookCardControl.TabIndex = 1;
            // 
            // FindBookWithFilterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GbFilter);
            this.Controls.Add(this.ViewBookCardControl);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FindBookWithFilterControl";
            this.Size = new System.Drawing.Size(625, 322);
            this.GbFilter.ResumeLayout(false);
            this.GbFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.GroupBox GbFilter;
        private System.Windows.Forms.Button BtnFindBook;
        private System.Windows.Forms.Button BtnAddNewBook;
        private System.Windows.Forms.TextBox TxtFilter;
        private System.Windows.Forms.ComboBox CbFilterBy;
        private LibrarySystem.Books.Controls.ViewBookCardControl ViewBookCardControl;
        private System.Windows.Forms.Label label1;
    }
}