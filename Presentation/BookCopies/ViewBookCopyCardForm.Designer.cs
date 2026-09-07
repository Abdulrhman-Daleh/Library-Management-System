namespace LibrarySystem.BookCopies
{
    partial class ViewBookCopyCardForm
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
            this.LnkAddCopy = new System.Windows.Forms.LinkLabel();
            this.LnkUpdate = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.relationlControl1 = new WindowsFormsApp1.Members.Controls.RelationlControl();
            this.viewBookCopyCardControl = new LibrarySystem.BookCopies.Controls.ViewBookCopyCardControl();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LnkAddCopy);
            this.groupBox2.Controls.Add(this.LnkUpdate);
            this.groupBox2.Location = new System.Drawing.Point(12, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(647, 100);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actions";
            // 
            // LnkAddCopy
            // 
            this.LnkAddCopy.AutoSize = true;
            this.LnkAddCopy.Location = new System.Drawing.Point(114, 48);
            this.LnkAddCopy.Name = "LnkAddCopy";
            this.LnkAddCopy.Size = new System.Drawing.Size(114, 30);
            this.LnkAddCopy.TabIndex = 5;
            this.LnkAddCopy.TabStop = true;
            this.LnkAddCopy.Text = "Add Copy";
            this.LnkAddCopy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkAddCopy_LinkClicked);
            // 
            // LnkUpdate
            // 
            this.LnkUpdate.AutoSize = true;
            this.LnkUpdate.Location = new System.Drawing.Point(42, 48);
            this.LnkUpdate.Name = "LnkUpdate";
            this.LnkUpdate.Size = new System.Drawing.Size(53, 30);
            this.LnkUpdate.TabIndex = 4;
            this.LnkUpdate.TabStop = true;
            this.LnkUpdate.Text = "Edit";
            this.LnkUpdate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkUpdate_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(188, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 48);
            this.label2.TabIndex = 13;
            this.label2.Text = "View Book Copy";
            // 
            // BtnClose
            // 
            this.BtnClose.Image = global::WindowsFormsApp1.Properties.Resources.Close_32;
            this.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClose.Location = new System.Drawing.Point(509, 645);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(150, 54);
            this.BtnClose.TabIndex = 12;
            this.BtnClose.Text = "Close";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // relationlControl1
            // 
            this.relationlControl1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.relationlControl1.Location = new System.Drawing.Point(12, 333);
            this.relationlControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.relationlControl1.Name = "relationlControl1";
            this.relationlControl1.Size = new System.Drawing.Size(650, 302);
            this.relationlControl1.TabIndex = 44;
            // 
            // viewBookCopyCardControl
            // 
            this.viewBookCopyCardControl.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.viewBookCopyCardControl.Location = new System.Drawing.Point(14, 172);
            this.viewBookCopyCardControl.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.viewBookCopyCardControl.Name = "viewBookCopyCardControl";
            this.viewBookCopyCardControl.Size = new System.Drawing.Size(616, 151);
            this.viewBookCopyCardControl.TabIndex = 45;
            // 
            // ViewBookCopyCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 711);
            this.Controls.Add(this.viewBookCopyCardControl);
            this.Controls.Add(this.relationlControl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnClose);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewBookCopyCardForm";
            this.Text = "Book Copy Card";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel LnkAddCopy;
        private System.Windows.Forms.LinkLabel LnkUpdate;
        private WindowsFormsApp1.Members.Controls.RelationlControl relationlControl1;
        private Controls.ViewBookCopyCardControl viewBookCopyCardControl;
    }
}