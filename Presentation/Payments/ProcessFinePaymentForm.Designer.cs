namespace LibrarySystem.FinePayments
{
    partial class ProcessFinePaymentForm
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtPayAmount = new WindowsFormsApp1.TextCustomFilterControl();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.BtnPay = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.viewFineCardControl = new LibrarySystem.BorrowFines.Controls.ViewFineCardControl();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.TxtPayAmount);
            this.GroupBox1.Controls.Add(this.pictureBox2);
            this.GroupBox1.Controls.Add(this.label1);
            this.GroupBox1.Controls.Add(this.pictureBox1);
            this.GroupBox1.Controls.Add(this.label5);
            this.GroupBox1.Controls.Add(this.CbPaymentMethod);
            this.GroupBox1.Location = new System.Drawing.Point(13, 409);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox1.Size = new System.Drawing.Size(781, 218);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Payment";
            // 
            // TxtPayAmount
            // 
            this.TxtPayAmount.Location = new System.Drawing.Point(300, 129);
            this.TxtPayAmount.MaxLength = 8;
            this.TxtPayAmount.Name = "TxtPayAmount";
            this.TxtPayAmount.Size = new System.Drawing.Size(151, 35);
            this.TxtPayAmount.TabIndex = 35;
            this.TxtPayAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPayAmount_KeyPress);
            this.TxtPayAmount.Validating += new System.ComponentModel.CancelEventHandler(this.TxtPayAmount_Validating);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.Payment_Method_32;
            this.pictureBox2.Location = new System.Drawing.Point(245, 125);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 30);
            this.label1.TabIndex = 33;
            this.label1.Text = "Pay Amount:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Fine_32;
            this.pictureBox1.Location = new System.Drawing.Point(245, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 30);
            this.label5.TabIndex = 31;
            this.label5.Text = "Payment Methods:";
            // 
            // CbPaymentMethod
            // 
            this.CbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbPaymentMethod.Items.AddRange(new object[] {
            "Cash",
            "Card",
            "Online"});
            this.CbPaymentMethod.Location = new System.Drawing.Point(300, 59);
            this.CbPaymentMethod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbPaymentMethod.Name = "CbPaymentMethod";
            this.CbPaymentMethod.Size = new System.Drawing.Size(151, 37);
            this.CbPaymentMethod.TabIndex = 1;
            // 
            // BtnPay
            // 
            this.BtnPay.Image = global::WindowsFormsApp1.Properties.Resources.Payment_ID_32;
            this.BtnPay.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPay.Location = new System.Drawing.Point(620, 647);
            this.BtnPay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnPay.Name = "BtnPay";
            this.BtnPay.Size = new System.Drawing.Size(180, 63);
            this.BtnPay.TabIndex = 1;
            this.BtnPay.Text = "Pay";
            this.BtnPay.UseVisualStyleBackColor = true;
            this.BtnPay.Click += new System.EventHandler(this.BtnPay_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // viewFineCardControl
            // 
            this.viewFineCardControl.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.viewFineCardControl.Location = new System.Drawing.Point(13, 222);
            this.viewFineCardControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viewFineCardControl.Name = "viewFineCardControl";
            this.viewFineCardControl.Size = new System.Drawing.Size(781, 188);
            this.viewFineCardControl.TabIndex = 2;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApp1.Properties.Resources.Fines_512;
            this.pictureBox4.Location = new System.Drawing.Point(297, 65);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(226, 152);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(214, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(396, 48);
            this.label2.TabIndex = 17;
            this.label2.Text = "Process Fine Payment";
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Image = global::WindowsFormsApp1.Properties.Resources.Close_32;
            this.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClose.Location = new System.Drawing.Point(461, 648);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(150, 64);
            this.BtnClose.TabIndex = 19;
            this.BtnClose.Text = "Close";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // ProcessFinePaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 726);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.viewFineCardControl);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.BtnPay);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProcessFinePaymentForm";
            this.Text = "Process Payment";
            this.Load += new System.EventHandler(this.ProcessFinePaymentForm_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.ComboBox CbPaymentMethod;
        private System.Windows.Forms.Button BtnPay;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private BorrowFines.Controls.ViewFineCardControl viewFineCardControl;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private WindowsFormsApp1.TextCustomFilterControl TxtPayAmount;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnClose;
    }
}