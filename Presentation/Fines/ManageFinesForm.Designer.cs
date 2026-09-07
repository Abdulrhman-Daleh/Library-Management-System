namespace LibrarySystem.BorrowFinePayments
{
    partial class ManageFinesForm
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
            this.DgvFines = new System.Windows.Forms.DataGridView();
            this.CmsBorrowFines = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ViewFineMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProccessFinePaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LblTitle = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.LblRecords = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFines)).BeginInit();
            this.CmsBorrowFines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvFines
            // 
            this.DgvFines.AllowUserToAddRows = false;
            this.DgvFines.AllowUserToDeleteRows = false;
            this.DgvFines.AllowUserToOrderColumns = true;
            this.DgvFines.BackgroundColor = System.Drawing.Color.White;
            this.DgvFines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFines.ContextMenuStrip = this.CmsBorrowFines;
            this.DgvFines.Location = new System.Drawing.Point(13, 245);
            this.DgvFines.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvFines.Name = "DgvFines";
            this.DgvFines.ReadOnly = true;
            this.DgvFines.RowHeadersWidth = 51;
            this.DgvFines.Size = new System.Drawing.Size(946, 385);
            this.DgvFines.TabIndex = 0;
            this.DgvFines.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFines_CellDoubleClick);
            // 
            // CmsBorrowFines
            // 
            this.CmsBorrowFines.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CmsBorrowFines.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewFineMenuItem,
            this.ProccessFinePaymentToolStripMenuItem});
            this.CmsBorrowFines.Name = "CmsBorrowFines";
            this.CmsBorrowFines.Size = new System.Drawing.Size(227, 108);
            this.CmsBorrowFines.Opening += new System.ComponentModel.CancelEventHandler(this.CmsBorrowFines_Opening);
            // 
            // ViewFineMenuItem
            // 
            this.ViewFineMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.View_32;
            this.ViewFineMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ViewFineMenuItem.Name = "ViewFineMenuItem";
            this.ViewFineMenuItem.Size = new System.Drawing.Size(226, 38);
            this.ViewFineMenuItem.Text = "View Fine";
            this.ViewFineMenuItem.Click += new System.EventHandler(this.ViewFineMenuItem_Click);
            // 
            // ProccessFinePaymentToolStripMenuItem
            // 
            this.ProccessFinePaymentToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Payment_Method_32;
            this.ProccessFinePaymentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ProccessFinePaymentToolStripMenuItem.Name = "ProccessFinePaymentToolStripMenuItem";
            this.ProccessFinePaymentToolStripMenuItem.Size = new System.Drawing.Size(226, 38);
            this.ProccessFinePaymentToolStripMenuItem.Text = "Process Payment";
            this.ProccessFinePaymentToolStripMenuItem.Click += new System.EventHandler(this.ProccessFinePaymentToolStripMenuItem_Click);
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.LblTitle.ForeColor = System.Drawing.Color.Red;
            this.LblTitle.Location = new System.Drawing.Point(323, 9);
            this.LblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(283, 46);
            this.LblTitle.TabIndex = 39;
            this.LblTitle.Text = "Manage Fines";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::WindowsFormsApp1.Properties.Resources.Payment_512;
            this.pictureBox6.Location = new System.Drawing.Point(342, 58);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(233, 179);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 38;
            this.pictureBox6.TabStop = false;
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Image = global::WindowsFormsApp1.Properties.Resources.Close_32;
            this.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClose.Location = new System.Drawing.Point(809, 641);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(150, 64);
            this.BtnClose.TabIndex = 40;
            this.BtnClose.Text = "Close";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // LblRecords
            // 
            this.LblRecords.AutoSize = true;
            this.LblRecords.Location = new System.Drawing.Point(123, 659);
            this.LblRecords.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblRecords.Name = "LblRecords";
            this.LblRecords.Size = new System.Drawing.Size(0, 30);
            this.LblRecords.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 659);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 30);
            this.label2.TabIndex = 41;
            this.label2.Text = "Records:";
            // 
            // ManageFinesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 713);
            this.Controls.Add(this.LblRecords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.DgvFines);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ManageFinesForm";
            this.Text = "Manage Fines";
            this.Load += new System.EventHandler(this.ManageFinesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvFines)).EndInit();
            this.CmsBorrowFines.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView DgvFines;
        private System.Windows.Forms.ContextMenuStrip CmsBorrowFines;
        private System.Windows.Forms.ToolStripMenuItem ViewFineMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProccessFinePaymentToolStripMenuItem;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label LblRecords;
        private System.Windows.Forms.Label label2;
    }
}