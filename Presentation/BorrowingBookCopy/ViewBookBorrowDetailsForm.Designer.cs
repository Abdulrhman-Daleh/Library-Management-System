namespace LibrarySystem.BorrowingBookCopy
{
    partial class ViewBookBorrowDetailsForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LnkMarkLostBook = new System.Windows.Forms.LinkLabel();
            this.LnkReturnBook = new System.Windows.Forms.LinkLabel();
            this.LinkMore = new System.Windows.Forms.LinkLabel();
            this.BtnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.viewBorrowDetailsControl1 = new LibrarySystem.BorrowingBookCopy.Controls.ViewBorrowDetailsControl();
            this.relationlControl1 = new WindowsFormsApp1.Members.Controls.RelationlControl();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LnkMarkLostBook);
            this.groupBox2.Controls.Add(this.LnkReturnBook);
            this.groupBox2.Controls.Add(this.LinkMore);
            this.groupBox2.Location = new System.Drawing.Point(12, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(752, 100);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actions";
            // 
            // LnkMarkLostBook
            // 
            this.LnkMarkLostBook.AutoSize = true;
            this.LnkMarkLostBook.Location = new System.Drawing.Point(156, 48);
            this.LnkMarkLostBook.Name = "LnkMarkLostBook";
            this.LnkMarkLostBook.Size = new System.Drawing.Size(113, 30);
            this.LnkMarkLostBook.TabIndex = 5;
            this.LnkMarkLostBook.TabStop = true;
            this.LnkMarkLostBook.Text = "Mark Lost";
            this.LnkMarkLostBook.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkMarkLostBook_LinkClicked);
            // 
            // LnkReturnBook
            // 
            this.LnkReturnBook.AutoSize = true;
            this.LnkReturnBook.Location = new System.Drawing.Point(42, 48);
            this.LnkReturnBook.Name = "LnkReturnBook";
            this.LnkReturnBook.Size = new System.Drawing.Size(81, 30);
            this.LnkReturnBook.TabIndex = 4;
            this.LnkReturnBook.TabStop = true;
            this.LnkReturnBook.Text = "Return";
            this.LnkReturnBook.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkReturnBook_LinkClicked);
            // 
            // LinkMore
            // 
            this.LinkMore.AutoSize = true;
            this.LinkMore.Location = new System.Drawing.Point(658, 48);
            this.LinkMore.Name = "LinkMore";
            this.LinkMore.Size = new System.Drawing.Size(67, 30);
            this.LinkMore.TabIndex = 3;
            this.LinkMore.TabStop = true;
            this.LinkMore.Text = "More";
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Image = global::WindowsFormsApp1.Properties.Resources.Close_32;
            this.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClose.Location = new System.Drawing.Point(612, 699);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(150, 64);
            this.BtnClose.TabIndex = 24;
            this.BtnClose.Text = "Close";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(134, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(532, 48);
            this.label2.TabIndex = 22;
            this.label2.Text = "View Book Borrowing Details";
            // 
            // viewBorrowDetailsControl1
            // 
            this.viewBorrowDetailsControl1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.viewBorrowDetailsControl1.Location = new System.Drawing.Point(12, 191);
            this.viewBorrowDetailsControl1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.viewBorrowDetailsControl1.Name = "viewBorrowDetailsControl1";
            this.viewBorrowDetailsControl1.Size = new System.Drawing.Size(750, 201);
            this.viewBorrowDetailsControl1.TabIndex = 41;
            // 
            // relationlControl1
            // 
            this.relationlControl1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.relationlControl1.Location = new System.Drawing.Point(13, 387);
            this.relationlControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.relationlControl1.Name = "relationlControl1";
            this.relationlControl1.Size = new System.Drawing.Size(683, 302);
            this.relationlControl1.TabIndex = 42;
            // 
            // ViewBookBorrowDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 768);
            this.Controls.Add(this.relationlControl1);
            this.Controls.Add(this.viewBorrowDetailsControl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewBookBorrowDetailsForm";
            this.Text = "Borrow Details";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel LnkMarkLostBook;
        private System.Windows.Forms.LinkLabel LnkReturnBook;
        private System.Windows.Forms.LinkLabel LinkMore;
        private Controls.ViewBorrowDetailsControl viewBorrowDetailsControl1;
        private WindowsFormsApp1.Members.Controls.RelationlControl relationlControl1;
    }
}