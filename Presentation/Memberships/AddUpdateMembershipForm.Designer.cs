namespace LibrarySystem.Memberships
{
    partial class AddUpdateMembershipForm
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
            this.LblTitle = new System.Windows.Forms.Label();
            this.LblMembershipTypeId = new System.Windows.Forms.Label();
            this.TxtMembershipTypeName = new System.Windows.Forms.TextBox();
            this.NudMembershipFees = new System.Windows.Forms.NumericUpDown();
            this.NudBorrowLimit = new System.Windows.Forms.NumericUpDown();
            this.LblName = new System.Windows.Forms.Label();
            this.LblFees = new System.Windows.Forms.Label();
            this.LblBorrowLimit = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.NudMembershipFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudBorrowLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.LblTitle.ForeColor = System.Drawing.Color.Red;
            this.LblTitle.Location = new System.Drawing.Point(130, 32);
            this.LblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(438, 46);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Add Membership Type";
            // 
            // LblMembershipTypeId
            // 
            this.LblMembershipTypeId.AutoSize = true;
            this.LblMembershipTypeId.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMembershipTypeId.ForeColor = System.Drawing.Color.Red;
            this.LblMembershipTypeId.Location = new System.Drawing.Point(262, 291);
            this.LblMembershipTypeId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblMembershipTypeId.Name = "LblMembershipTypeId";
            this.LblMembershipTypeId.Size = new System.Drawing.Size(55, 33);
            this.LblMembershipTypeId.TabIndex = 1;
            this.LblMembershipTypeId.Text = "[??]";
            // 
            // TxtMembershipTypeName
            // 
            this.TxtMembershipTypeName.Location = new System.Drawing.Point(262, 354);
            this.TxtMembershipTypeName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtMembershipTypeName.Name = "TxtMembershipTypeName";
            this.TxtMembershipTypeName.Size = new System.Drawing.Size(180, 35);
            this.TxtMembershipTypeName.TabIndex = 3;
            this.TxtMembershipTypeName.Validating += new System.ComponentModel.CancelEventHandler(this.TxtMembershipTypeName_Validating);
            // 
            // NudMembershipFees
            // 
            this.NudMembershipFees.DecimalPlaces = 2;
            this.NudMembershipFees.Location = new System.Drawing.Point(262, 418);
            this.NudMembershipFees.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NudMembershipFees.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NudMembershipFees.Name = "NudMembershipFees";
            this.NudMembershipFees.Size = new System.Drawing.Size(180, 35);
            this.NudMembershipFees.TabIndex = 5;
            // 
            // NudBorrowLimit
            // 
            this.NudBorrowLimit.Location = new System.Drawing.Point(262, 479);
            this.NudBorrowLimit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NudBorrowLimit.Name = "NudBorrowLimit";
            this.NudBorrowLimit.Size = new System.Drawing.Size(180, 35);
            this.NudBorrowLimit.TabIndex = 7;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(121, 356);
            this.LblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(79, 30);
            this.LblName.TabIndex = 2;
            this.LblName.Text = "Name:";
            // 
            // LblFees
            // 
            this.LblFees.AutoSize = true;
            this.LblFees.Location = new System.Drawing.Point(137, 420);
            this.LblFees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblFees.Name = "LblFees";
            this.LblFees.Size = new System.Drawing.Size(63, 30);
            this.LblFees.TabIndex = 4;
            this.LblFees.Text = "Fees:";
            // 
            // LblBorrowLimit
            // 
            this.LblBorrowLimit.AutoSize = true;
            this.LblBorrowLimit.Location = new System.Drawing.Point(53, 481);
            this.LblBorrowLimit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblBorrowLimit.Name = "LblBorrowLimit";
            this.LblBorrowLimit.Size = new System.Drawing.Size(147, 30);
            this.LblBorrowLimit.TabIndex = 6;
            this.LblBorrowLimit.Text = "Borrow Limit:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 292);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApp1.Properties.Resources.Limit_32;
            this.pictureBox4.Location = new System.Drawing.Point(207, 475);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(48, 43);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.Fine_32;
            this.pictureBox3.Location = new System.Drawing.Point(207, 414);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 43);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.Membership_32;
            this.pictureBox2.Location = new System.Drawing.Point(207, 350);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Membership_32;
            this.pictureBox1.Location = new System.Drawing.Point(207, 286);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // BtnSave
            // 
            this.BtnSave.Image = global::WindowsFormsApp1.Properties.Resources.Save_32;
            this.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSave.Location = new System.Drawing.Point(361, 574);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(150, 64);
            this.BtnSave.TabIndex = 15;
            this.BtnSave.Text = "Save";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Image = global::WindowsFormsApp1.Properties.Resources.Close_32;
            this.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClose.Location = new System.Drawing.Point(520, 574);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(150, 64);
            this.BtnClose.TabIndex = 16;
            this.BtnClose.Text = "Close";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::WindowsFormsApp1.Properties.Resources.Membership_512;
            this.pictureBox6.Location = new System.Drawing.Point(225, 81);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(217, 181);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 26;
            this.pictureBox6.TabStop = false;
            // 
            // AddUpdateMembershipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 651);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.LblMembershipTypeId);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.TxtMembershipTypeName);
            this.Controls.Add(this.LblFees);
            this.Controls.Add(this.NudMembershipFees);
            this.Controls.Add(this.LblBorrowLimit);
            this.Controls.Add(this.NudBorrowLimit);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddUpdateMembershipForm";
            this.Text = "Add/Update Membership Type";
            this.Load += new System.EventHandler(this.AddUpdateMembershipForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NudMembershipFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudBorrowLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblMembershipTypeId;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TxtMembershipTypeName;
        private System.Windows.Forms.Label LblFees;
        private System.Windows.Forms.NumericUpDown NudMembershipFees;
        private System.Windows.Forms.Label LblBorrowLimit;
        private System.Windows.Forms.NumericUpDown NudBorrowLimit;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}