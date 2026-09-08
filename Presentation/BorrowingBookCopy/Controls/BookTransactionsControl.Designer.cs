namespace LibrarySystem.BorrowingBookCopy.Controls
{
    partial class BookTransactionsControl
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
            this.TcPages = new System.Windows.Forms.TabControl();
            this.TpSelectBookCopy = new System.Windows.Forms.TabPage();
            this.BtnNext = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LblBorrowID = new System.Windows.Forms.Label();
            this.findBookCopyWithFilterControl = new LibrarySystem.BookCopies.Controls.FindBookCopyWithFilterControl();
            this.TpBorrowBookCopy = new System.Windows.Forms.TabPage();
            this.borrowBookControl = new LibrarySystem.BorrowingBookCopy.Controls.BorrowBookControl();
            this.BtnPrevious = new System.Windows.Forms.Button();
            this.GpDamaged = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CbCondition = new System.Windows.Forms.ComboBox();
            this.TcPages.SuspendLayout();
            this.TpSelectBookCopy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TpBorrowBookCopy.SuspendLayout();
            this.GpDamaged.SuspendLayout();
            this.SuspendLayout();
            // 
            // TcPages
            // 
            this.TcPages.Controls.Add(this.TpSelectBookCopy);
            this.TcPages.Controls.Add(this.TpBorrowBookCopy);
            this.TcPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TcPages.Location = new System.Drawing.Point(0, 0);
            this.TcPages.Margin = new System.Windows.Forms.Padding(4);
            this.TcPages.Name = "TcPages";
            this.TcPages.SelectedIndex = 0;
            this.TcPages.Size = new System.Drawing.Size(671, 445);
            this.TcPages.TabIndex = 0;
            // 
            // TpSelectBookCopy
            // 
            this.TpSelectBookCopy.Controls.Add(this.BtnNext);
            this.TpSelectBookCopy.Controls.Add(this.pictureBox1);
            this.TpSelectBookCopy.Controls.Add(this.label2);
            this.TpSelectBookCopy.Controls.Add(this.LblBorrowID);
            this.TpSelectBookCopy.Controls.Add(this.findBookCopyWithFilterControl);
            this.TpSelectBookCopy.Location = new System.Drawing.Point(4, 32);
            this.TpSelectBookCopy.Margin = new System.Windows.Forms.Padding(4);
            this.TpSelectBookCopy.Name = "TpSelectBookCopy";
            this.TpSelectBookCopy.Size = new System.Drawing.Size(663, 409);
            this.TpSelectBookCopy.TabIndex = 0;
            this.TpSelectBookCopy.Text = "Select Copy";
            // 
            // BtnNext
            // 
            this.BtnNext.Image = global::WindowsFormsApp1.Properties.Resources.Next_32;
            this.BtnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNext.Location = new System.Drawing.Point(500, 340);
            this.BtnNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(150, 64);
            this.BtnNext.TabIndex = 63;
            this.BtnNext.Text = "Next";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Book_Copy_32;
            this.pictureBox1.Location = new System.Drawing.Point(113, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 23);
            this.label2.TabIndex = 61;
            this.label2.Text = "Borrow ID";
            // 
            // LblBorrowID
            // 
            this.LblBorrowID.AutoSize = true;
            this.LblBorrowID.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBorrowID.ForeColor = System.Drawing.Color.Red;
            this.LblBorrowID.Location = new System.Drawing.Point(164, 25);
            this.LblBorrowID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblBorrowID.Name = "LblBorrowID";
            this.LblBorrowID.Size = new System.Drawing.Size(69, 29);
            this.LblBorrowID.TabIndex = 60;
            this.LblBorrowID.Text = "[Not Set]";
            // 
            // findBookCopyWithFilterControl
            // 
            this.findBookCopyWithFilterControl.EnableSearchSection = false;
            this.findBookCopyWithFilterControl.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.findBookCopyWithFilterControl.Location = new System.Drawing.Point(19, 75);
            this.findBookCopyWithFilterControl.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.findBookCopyWithFilterControl.Name = "findBookCopyWithFilterControl";
            this.findBookCopyWithFilterControl.Size = new System.Drawing.Size(631, 267);
            this.findBookCopyWithFilterControl.TabIndex = 2;
            // 
            // TpBorrowBookCopy
            // 
            this.TpBorrowBookCopy.Controls.Add(this.borrowBookControl);
            this.TpBorrowBookCopy.Controls.Add(this.BtnPrevious);
            this.TpBorrowBookCopy.Controls.Add(this.GpDamaged);
            this.TpBorrowBookCopy.Enabled = false;
            this.TpBorrowBookCopy.Location = new System.Drawing.Point(4, 32);
            this.TpBorrowBookCopy.Margin = new System.Windows.Forms.Padding(4);
            this.TpBorrowBookCopy.Name = "TpBorrowBookCopy";
            this.TpBorrowBookCopy.Size = new System.Drawing.Size(663, 409);
            this.TpBorrowBookCopy.TabIndex = 1;
            this.TpBorrowBookCopy.Text = "Borrow Details";
            // 
            // borrowBookControl
            // 
            this.borrowBookControl.ChangeBorrowStatus = BusinessLogic.BorrowTransaction.StatusType.Borrow;
            this.borrowBookControl.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.borrowBookControl.Location = new System.Drawing.Point(16, 16);
            this.borrowBookControl.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.borrowBookControl.Name = "borrowBookControl";
            this.borrowBookControl.Size = new System.Drawing.Size(625, 278);
            this.borrowBookControl.TabIndex = 12;
            // 
            // BtnPrevious
            // 
            this.BtnPrevious.Image = global::WindowsFormsApp1.Properties.Resources.Previous_32;
            this.BtnPrevious.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPrevious.Location = new System.Drawing.Point(467, 337);
            this.BtnPrevious.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnPrevious.Name = "BtnPrevious";
            this.BtnPrevious.Size = new System.Drawing.Size(192, 68);
            this.BtnPrevious.TabIndex = 11;
            this.BtnPrevious.Text = "Previous";
            this.BtnPrevious.UseVisualStyleBackColor = true;
            this.BtnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // GpDamaged
            // 
            this.GpDamaged.Controls.Add(this.label1);
            this.GpDamaged.Controls.Add(this.CbCondition);
            this.GpDamaged.Location = new System.Drawing.Point(16, 320);
            this.GpDamaged.Margin = new System.Windows.Forms.Padding(4);
            this.GpDamaged.Name = "GpDamaged";
            this.GpDamaged.Padding = new System.Windows.Forms.Padding(4);
            this.GpDamaged.Size = new System.Drawing.Size(406, 86);
            this.GpDamaged.TabIndex = 0;
            this.GpDamaged.TabStop = false;
            this.GpDamaged.Text = "New Condition";
            this.GpDamaged.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 23);
            this.label1.TabIndex = 62;
            this.label1.Text = "Book Condition";
            // 
            // CbCondition
            // 
            this.CbCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbCondition.Items.AddRange(new object[] {
            "AsNew",
            "Fine",
            "NearFine",
            "VeryGood",
            "Good",
            "Fair",
            "Poor"});
            this.CbCondition.Location = new System.Drawing.Point(165, 37);
            this.CbCondition.Margin = new System.Windows.Forms.Padding(4);
            this.CbCondition.Name = "CbCondition";
            this.CbCondition.Size = new System.Drawing.Size(186, 31);
            this.CbCondition.TabIndex = 0;
            this.CbCondition.SelectedIndexChanged += new System.EventHandler(this.CbCondition_SelectedIndexChanged);
            // 
            // BookTransactionsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TcPages);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "BookTransactionsControl";
            this.Size = new System.Drawing.Size(671, 445);
            this.TcPages.ResumeLayout(false);
            this.TpSelectBookCopy.ResumeLayout(false);
            this.TpSelectBookCopy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TpBorrowBookCopy.ResumeLayout(false);
            this.GpDamaged.ResumeLayout(false);
            this.GpDamaged.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TabControl TcPages;
        private System.Windows.Forms.TabPage TpSelectBookCopy;
        private System.Windows.Forms.TabPage TpBorrowBookCopy;
        private System.Windows.Forms.GroupBox GpDamaged;
        private System.Windows.Forms.ComboBox CbCondition;
        private BookCopies.Controls.FindBookCopyWithFilterControl findBookCopyWithFilterControl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblBorrowID;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnPrevious;
        private System.Windows.Forms.Label label1;
        private BorrowBookControl borrowBookControl;
    }
}