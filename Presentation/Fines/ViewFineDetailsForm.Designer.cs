namespace LibrarySystem.BorrowFines
{
    partial class ViewFineDetailsForm
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
            this.ViewFineCardControl = new LibrarySystem.BorrowFines.Controls.ViewFineCardControl();
            this.BtnClose = new System.Windows.Forms.Button();
            this.LblTitle = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LnkPayments = new System.Windows.Forms.LinkLabel();
            this.relationlControl1 = new WindowsFormsApp1.Members.Controls.RelationlControl();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ViewFineCardControl
            // 
            this.ViewFineCardControl.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ViewFineCardControl.Location = new System.Drawing.Point(18, 174);
            this.ViewFineCardControl.Margin = new System.Windows.Forms.Padding(8, 11, 8, 11);
            this.ViewFineCardControl.Name = "ViewFineCardControl";
            this.ViewFineCardControl.Size = new System.Drawing.Size(772, 183);
            this.ViewFineCardControl.TabIndex = 0;
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Image = global::WindowsFormsApp1.Properties.Resources.Close_32;
            this.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClose.Location = new System.Drawing.Point(656, 675);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(150, 64);
            this.BtnClose.TabIndex = 41;
            this.BtnClose.Text = "Close";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.LblTitle.ForeColor = System.Drawing.Color.Red;
            this.LblTitle.Location = new System.Drawing.Point(252, 11);
            this.LblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(286, 46);
            this.LblTitle.TabIndex = 43;
            this.LblTitle.Text = "View Fine Info";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LnkPayments);
            this.groupBox2.Location = new System.Drawing.Point(18, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(772, 100);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actions";
            // 
            // LnkPayments
            // 
            this.LnkPayments.AutoSize = true;
            this.LnkPayments.Location = new System.Drawing.Point(38, 48);
            this.LnkPayments.Name = "LnkPayments";
            this.LnkPayments.Size = new System.Drawing.Size(180, 30);
            this.LnkPayments.TabIndex = 5;
            this.LnkPayments.TabStop = true;
            this.LnkPayments.Text = "Record Payment";
            this.LnkPayments.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkPayments_LinkClicked);
            // 
            // relationlControl1
            // 
            this.relationlControl1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.relationlControl1.Location = new System.Drawing.Point(18, 372);
            this.relationlControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.relationlControl1.Name = "relationlControl1";
            this.relationlControl1.Size = new System.Drawing.Size(688, 302);
            this.relationlControl1.TabIndex = 45;
            // 
            // ViewFineDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 742);
            this.Controls.Add(this.relationlControl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.ViewFineCardControl);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewFineDetailsForm";
            this.Text = "Fine Details";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private LibrarySystem.BorrowFines.Controls.ViewFineCardControl ViewFineCardControl;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel LnkPayments;
        private WindowsFormsApp1.Members.Controls.RelationlControl relationlControl1;
    }
}