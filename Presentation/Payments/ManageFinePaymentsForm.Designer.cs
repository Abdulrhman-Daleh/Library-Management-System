namespace LibrarySystem.FinePayments
{
    partial class ManageFinePaymentsForm
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
            this.DgvFinePayments = new System.Windows.Forms.DataGridView();
            this.CmsFinePayment = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ViewRenewInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CbFilterBy = new System.Windows.Forms.ComboBox();
            this.LblRecords = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtFilter = new WindowsFormsApp1.TextCustomFilterControl();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFinePayments)).BeginInit();
            this.CmsFinePayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvFinePayments
            // 
            this.DgvFinePayments.AllowUserToAddRows = false;
            this.DgvFinePayments.AllowUserToDeleteRows = false;
            this.DgvFinePayments.AllowUserToOrderColumns = true;
            this.DgvFinePayments.BackgroundColor = System.Drawing.Color.White;
            this.DgvFinePayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFinePayments.ContextMenuStrip = this.CmsFinePayment;
            this.DgvFinePayments.Location = new System.Drawing.Point(13, 319);
            this.DgvFinePayments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvFinePayments.Name = "DgvFinePayments";
            this.DgvFinePayments.ReadOnly = true;
            this.DgvFinePayments.RowHeadersWidth = 51;
            this.DgvFinePayments.Size = new System.Drawing.Size(906, 291);
            this.DgvFinePayments.TabIndex = 0;
            this.DgvFinePayments.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFinePayments_CellDoubleClick);
            // 
            // CmsFinePayment
            // 
            this.CmsFinePayment.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CmsFinePayment.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewRenewInfoToolStripMenuItem});
            this.CmsFinePayment.Name = "CmsFinePayment";
            this.CmsFinePayment.Size = new System.Drawing.Size(204, 42);
            this.CmsFinePayment.Opening += new System.ComponentModel.CancelEventHandler(this.CmsFinePayment_Opening);
            // 
            // ViewRenewInfoToolStripMenuItem
            // 
            this.ViewRenewInfoToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.View_32;
            this.ViewRenewInfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ViewRenewInfoToolStripMenuItem.Name = "ViewRenewInfoToolStripMenuItem";
            this.ViewRenewInfoToolStripMenuItem.Size = new System.Drawing.Size(203, 38);
            this.ViewRenewInfoToolStripMenuItem.Text = "View Payment";
            this.ViewRenewInfoToolStripMenuItem.Click += new System.EventHandler(this.ViewRenewInfoToolStripMenuItem_Click);
            // 
            // CbFilterBy
            // 
            this.CbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbFilterBy.Items.AddRange(new object[] {
            "None",
            "PaymentID",
            "FineID"});
            this.CbFilterBy.Location = new System.Drawing.Point(114, 274);
            this.CbFilterBy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbFilterBy.Name = "CbFilterBy";
            this.CbFilterBy.Size = new System.Drawing.Size(178, 37);
            this.CbFilterBy.TabIndex = 1;
            this.CbFilterBy.SelectedIndexChanged += new System.EventHandler(this.CbFilterBy_SelectedIndexChanged);
            this.CbFilterBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbFilterBy_KeyPress);
            // 
            // LblRecords
            // 
            this.LblRecords.AutoSize = true;
            this.LblRecords.Location = new System.Drawing.Point(123, 634);
            this.LblRecords.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblRecords.Name = "LblRecords";
            this.LblRecords.Size = new System.Drawing.Size(0, 30);
            this.LblRecords.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 634);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 30);
            this.label1.TabIndex = 11;
            this.label1.Text = "Records:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(239, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(421, 48);
            this.label2.TabIndex = 19;
            this.label2.Text = "Manage Fine Payments";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 30);
            this.label3.TabIndex = 22;
            this.label3.Text = "Filter By";
            // 
            // BtnClose
            // 
            this.BtnClose.Image = global::WindowsFormsApp1.Properties.Resources.Close_32;
            this.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClose.Location = new System.Drawing.Point(770, 621);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(150, 54);
            this.BtnClose.TabIndex = 21;
            this.BtnClose.Text = "Close";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Payment_512;
            this.pictureBox1.Location = new System.Drawing.Point(324, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // TxtFilter
            // 
            this.TxtFilter.Location = new System.Drawing.Point(299, 274);
            this.TxtFilter.MaxLength = 7;
            this.TxtFilter.Name = "TxtFilter";
            this.TxtFilter.Size = new System.Drawing.Size(171, 35);
            this.TxtFilter.TabIndex = 24;
            this.TxtFilter.TextChanged += new System.EventHandler(this.TxtFilter_TextChanged);
            this.TxtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFilter_KeyPress);
            // 
            // ManageFinePaymentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 684);
            this.Controls.Add(this.TxtFilter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblRecords);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvFinePayments);
            this.Controls.Add(this.CbFilterBy);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ManageFinePaymentsForm";
            this.Text = "Manage Fine Payments";
            this.Load += new System.EventHandler(this.ManageFinePaymentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvFinePayments)).EndInit();
            this.CmsFinePayment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView DgvFinePayments;
        private System.Windows.Forms.ComboBox CbFilterBy;
        private System.Windows.Forms.ContextMenuStrip CmsFinePayment;
        private System.Windows.Forms.ToolStripMenuItem ViewRenewInfoToolStripMenuItem;
        private System.Windows.Forms.Label LblRecords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label label3;
        private WindowsFormsApp1.TextCustomFilterControl TxtFilter;
    }
}