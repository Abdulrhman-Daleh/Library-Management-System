namespace LibrarySystem.BookCopies.Controls
{
    partial class FindBookCopyWithFilterControl
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
            this.BtnFindBookCopy = new System.Windows.Forms.Button();
            this.BtnAddNewBookCopy = new System.Windows.Forms.Button();
            this.TxtFilter = new System.Windows.Forms.TextBox();
            this.CbFilterBy = new System.Windows.Forms.ComboBox();
            this.ViewBookCopyCardControl = new LibrarySystem.BookCopies.Controls.ViewBookCopyCardControl();
            this.GbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbFilter
            // 
            this.GbFilter.Controls.Add(this.label1);
            this.GbFilter.Controls.Add(this.BtnFindBookCopy);
            this.GbFilter.Controls.Add(this.BtnAddNewBookCopy);
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
            this.label1.Location = new System.Drawing.Point(14, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Find By:";
            // 
            // BtnFindBookCopy
            // 
            this.BtnFindBookCopy.Image = global::WindowsFormsApp1.Properties.Resources.View_32;
            this.BtnFindBookCopy.Location = new System.Drawing.Point(465, 29);
            this.BtnFindBookCopy.Margin = new System.Windows.Forms.Padding(4);
            this.BtnFindBookCopy.Name = "BtnFindBookCopy";
            this.BtnFindBookCopy.Size = new System.Drawing.Size(72, 57);
            this.BtnFindBookCopy.TabIndex = 0;
            this.BtnFindBookCopy.Click += new System.EventHandler(this.BtnFindBookCopy_Click);
            // 
            // BtnAddNewBookCopy
            // 
            this.BtnAddNewBookCopy.Image = global::WindowsFormsApp1.Properties.Resources.Book_Copy_32;
            this.BtnAddNewBookCopy.Location = new System.Drawing.Point(545, 29);
            this.BtnAddNewBookCopy.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAddNewBookCopy.Name = "BtnAddNewBookCopy";
            this.BtnAddNewBookCopy.Size = new System.Drawing.Size(72, 57);
            this.BtnAddNewBookCopy.TabIndex = 1;
            this.BtnAddNewBookCopy.Click += new System.EventHandler(this.BtnAddNewBookCopy_Click);
            // 
            // TxtFilter
            // 
            this.TxtFilter.Location = new System.Drawing.Point(271, 43);
            this.TxtFilter.Margin = new System.Windows.Forms.Padding(4);
            this.TxtFilter.Name = "TxtFilter";
            this.TxtFilter.Size = new System.Drawing.Size(186, 30);
            this.TxtFilter.TabIndex = 2;
            this.TxtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFilter_KeyPress);
            // 
            // CbFilterBy
            // 
            this.CbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbFilterBy.Items.AddRange(new object[] {
            "Book Copy ID",
            "Original Book ID"});
            this.CbFilterBy.Location = new System.Drawing.Point(89, 42);
            this.CbFilterBy.Margin = new System.Windows.Forms.Padding(4);
            this.CbFilterBy.Name = "CbFilterBy";
            this.CbFilterBy.Size = new System.Drawing.Size(174, 31);
            this.CbFilterBy.TabIndex = 3;
            this.CbFilterBy.SelectedIndexChanged += new System.EventHandler(this.CbFilterBy_SelectedIndexChanged);
            // 
            // ViewBookCopyCardControl
            // 
            this.ViewBookCopyCardControl.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ViewBookCopyCardControl.Location = new System.Drawing.Point(0, 124);
            this.ViewBookCopyCardControl.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.ViewBookCopyCardControl.Name = "ViewBookCopyCardControl";
            this.ViewBookCopyCardControl.Size = new System.Drawing.Size(625, 159);
            this.ViewBookCopyCardControl.TabIndex = 1;
            // 
            // FindBookCopyWithFilterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GbFilter);
            this.Controls.Add(this.ViewBookCopyCardControl);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FindBookCopyWithFilterControl";
            this.Size = new System.Drawing.Size(625, 283);
            this.GbFilter.ResumeLayout(false);
            this.GbFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.GroupBox GbFilter;
        private System.Windows.Forms.Button BtnFindBookCopy;
        private System.Windows.Forms.Button BtnAddNewBookCopy;
        private System.Windows.Forms.TextBox TxtFilter;
        private System.Windows.Forms.ComboBox CbFilterBy;
        private LibrarySystem.BookCopies.Controls.ViewBookCopyCardControl ViewBookCopyCardControl;
        private System.Windows.Forms.Label label1;
    }
}