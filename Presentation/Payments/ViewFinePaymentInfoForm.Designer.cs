namespace LibrarySystem.FinePayments
{
    partial class ViewFinePaymentInfoForm
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
            this.LblTitle = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.viewPaymentControl1 = new WindowsFormsApp1.LibraryPolicies.Controls.ViewPaymentControl();
            this.relationlControl1 = new WindowsFormsApp1.Members.Controls.RelationlControl();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.LblTitle.ForeColor = System.Drawing.Color.Red;
            this.LblTitle.Location = new System.Drawing.Point(206, 21);
            this.LblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(266, 46);
            this.LblTitle.TabIndex = 37;
            this.LblTitle.Text = "Payment Info";
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Image = global::WindowsFormsApp1.Properties.Resources.Close_32;
            this.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClose.Location = new System.Drawing.Point(504, 633);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(150, 64);
            this.BtnClose.TabIndex = 35;
            this.BtnClose.Text = "Close";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // viewPaymentControl1
            // 
            this.viewPaymentControl1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.viewPaymentControl1.Location = new System.Drawing.Point(13, 71);
            this.viewPaymentControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.viewPaymentControl1.Name = "viewPaymentControl1";
            this.viewPaymentControl1.Size = new System.Drawing.Size(472, 242);
            this.viewPaymentControl1.TabIndex = 39;
            // 
            // relationlControl1
            // 
            this.relationlControl1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.relationlControl1.Location = new System.Drawing.Point(13, 321);
            this.relationlControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.relationlControl1.Name = "relationlControl1";
            this.relationlControl1.Size = new System.Drawing.Size(640, 302);
            this.relationlControl1.TabIndex = 40;
            // 
            // ViewFinePaymentInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 708);
            this.Controls.Add(this.relationlControl1);
            this.Controls.Add(this.viewPaymentControl1);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.BtnClose);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewFinePaymentInfoForm";
            this.Text = "Payment Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label LblTitle;
        private WindowsFormsApp1.LibraryPolicies.Controls.ViewPaymentControl viewPaymentControl1;
        private WindowsFormsApp1.Members.Controls.RelationlControl relationlControl1;
    }
}