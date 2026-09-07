namespace LibrarySystem.Books
{
    partial class ViewBookCardForm
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
            this.BtnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LnkAddBook = new System.Windows.Forms.LinkLabel();
            this.LnkUpdateBook = new System.Windows.Forms.LinkLabel();
            this.viewBookCardControl1 = new LibrarySystem.Books.Controls.ViewBookCardControl();
            this.relationlControl1 = new WindowsFormsApp1.Members.Controls.RelationlControl();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Image = global::WindowsFormsApp1.Properties.Resources.Close_32;
            this.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClose.Location = new System.Drawing.Point(556, 687);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(150, 64);
            this.BtnClose.TabIndex = 13;
            this.BtnClose.Text = "Close";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(257, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 48);
            this.label2.TabIndex = 14;
            this.label2.Text = "View Book";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LnkAddBook);
            this.groupBox2.Controls.Add(this.LnkUpdateBook);
            this.groupBox2.Location = new System.Drawing.Point(17, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(689, 100);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actions";
            // 
            // LnkAddBook
            // 
            this.LnkAddBook.AutoSize = true;
            this.LnkAddBook.Location = new System.Drawing.Point(114, 48);
            this.LnkAddBook.Name = "LnkAddBook";
            this.LnkAddBook.Size = new System.Drawing.Size(114, 30);
            this.LnkAddBook.TabIndex = 5;
            this.LnkAddBook.TabStop = true;
            this.LnkAddBook.Text = "Add Copy";
            this.LnkAddBook.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkAddBook_LinkClicked);
            // 
            // LnkUpdateBook
            // 
            this.LnkUpdateBook.AutoSize = true;
            this.LnkUpdateBook.Location = new System.Drawing.Point(42, 48);
            this.LnkUpdateBook.Name = "LnkUpdateBook";
            this.LnkUpdateBook.Size = new System.Drawing.Size(53, 30);
            this.LnkUpdateBook.TabIndex = 4;
            this.LnkUpdateBook.TabStop = true;
            this.LnkUpdateBook.Text = "Edit";
            this.LnkUpdateBook.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkUpdateBook_LinkClicked);
            // 
            // viewBookCardControl1
            // 
            this.viewBookCardControl1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.viewBookCardControl1.Location = new System.Drawing.Point(17, 169);
            this.viewBookCardControl1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.viewBookCardControl1.Name = "viewBookCardControl1";
            this.viewBookCardControl1.Size = new System.Drawing.Size(689, 212);
            this.viewBookCardControl1.TabIndex = 42;
            // 
            // relationlControl1
            // 
            this.relationlControl1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.relationlControl1.Location = new System.Drawing.Point(17, 391);
            this.relationlControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.relationlControl1.Name = "relationlControl1";
            this.relationlControl1.Size = new System.Drawing.Size(682, 302);
            this.relationlControl1.TabIndex = 43;
            // 
            // ViewBookCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 766);
            this.Controls.Add(this.relationlControl1);
            this.Controls.Add(this.viewBookCardControl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnClose);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewBookCardForm";
            this.Text = "Book Card";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel LnkAddBook;
        private System.Windows.Forms.LinkLabel LnkUpdateBook;
        private Controls.ViewBookCardControl viewBookCardControl1;
        private WindowsFormsApp1.Members.Controls.RelationlControl relationlControl1;
    }
}