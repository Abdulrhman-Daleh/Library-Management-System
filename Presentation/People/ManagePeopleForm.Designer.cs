namespace LibrarySystem.People
{
    partial class ManagePeopleForm
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
            this.DgvPeople = new System.Windows.Forms.DataGridView();
            this.CmsPeople = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ViewPersonInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CbFilterBy = new System.Windows.Forms.ComboBox();
            this.CbGender = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblRecords = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAddPerson = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtFilter = new WindowsFormsApp1.TextCustomFilterControl();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPeople)).BeginInit();
            this.CmsPeople.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvPeople
            // 
            this.DgvPeople.AllowUserToAddRows = false;
            this.DgvPeople.AllowUserToDeleteRows = false;
            this.DgvPeople.AllowUserToOrderColumns = true;
            this.DgvPeople.BackgroundColor = System.Drawing.Color.White;
            this.DgvPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPeople.ContextMenuStrip = this.CmsPeople;
            this.DgvPeople.Location = new System.Drawing.Point(14, 296);
            this.DgvPeople.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.DgvPeople.Name = "DgvPeople";
            this.DgvPeople.ReadOnly = true;
            this.DgvPeople.RowHeadersWidth = 51;
            this.DgvPeople.Size = new System.Drawing.Size(1074, 455);
            this.DgvPeople.TabIndex = 0;
            this.DgvPeople.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPeople_CellDoubleClick);
            // 
            // CmsPeople
            // 
            this.CmsPeople.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CmsPeople.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewPersonInfoToolStripMenuItem,
            this.AddNewPersonToolStripMenuItem,
            this.UpdateToolStripMenuItem,
            this.DeleteToolStripMenuItem,
            this.CallToolStripMenuItem,
            this.SendEmailToolStripMenuItem});
            this.CmsPeople.Name = "CmsPeople";
            this.CmsPeople.Size = new System.Drawing.Size(224, 232);
            this.CmsPeople.Opening += new System.ComponentModel.CancelEventHandler(this.CmsPeople_Opening);
            // 
            // ViewPersonInfoToolStripMenuItem
            // 
            this.ViewPersonInfoToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.View_32;
            this.ViewPersonInfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ViewPersonInfoToolStripMenuItem.Name = "ViewPersonInfoToolStripMenuItem";
            this.ViewPersonInfoToolStripMenuItem.Size = new System.Drawing.Size(223, 38);
            this.ViewPersonInfoToolStripMenuItem.Text = "View Person Info";
            this.ViewPersonInfoToolStripMenuItem.Click += new System.EventHandler(this.ViewPersonInfoToolStripMenuItem_Click);
            // 
            // AddNewPersonToolStripMenuItem
            // 
            this.AddNewPersonToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Add_Person;
            this.AddNewPersonToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddNewPersonToolStripMenuItem.Name = "AddNewPersonToolStripMenuItem";
            this.AddNewPersonToolStripMenuItem.Size = new System.Drawing.Size(223, 38);
            this.AddNewPersonToolStripMenuItem.Text = "Add New Person";
            this.AddNewPersonToolStripMenuItem.Click += new System.EventHandler(this.AddNewPersonToolStripMenuItem_Click);
            // 
            // UpdateToolStripMenuItem
            // 
            this.UpdateToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Update_32;
            this.UpdateToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem";
            this.UpdateToolStripMenuItem.Size = new System.Drawing.Size(223, 38);
            this.UpdateToolStripMenuItem.Text = "Update";
            this.UpdateToolStripMenuItem.Click += new System.EventHandler(this.UpdateToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Delete_32;
            this.DeleteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(223, 38);
            this.DeleteToolStripMenuItem.Text = "Delete";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // CallToolStripMenuItem
            // 
            this.CallToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Phone_32;
            this.CallToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CallToolStripMenuItem.Name = "CallToolStripMenuItem";
            this.CallToolStripMenuItem.Size = new System.Drawing.Size(223, 38);
            this.CallToolStripMenuItem.Text = "Call";
            this.CallToolStripMenuItem.Click += new System.EventHandler(this.CallToolStripMenuItem_Click);
            // 
            // SendEmailToolStripMenuItem
            // 
            this.SendEmailToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Email_32;
            this.SendEmailToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SendEmailToolStripMenuItem.Name = "SendEmailToolStripMenuItem";
            this.SendEmailToolStripMenuItem.Size = new System.Drawing.Size(223, 38);
            this.SendEmailToolStripMenuItem.Text = "Send Email";
            this.SendEmailToolStripMenuItem.Click += new System.EventHandler(this.SendEmailToolStripMenuItem_Click);
            // 
            // CbFilterBy
            // 
            this.CbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbFilterBy.Items.AddRange(new object[] {
            "None",
            "PersonID",
            "FirstName",
            "LastName",
            "Gender"});
            this.CbFilterBy.Location = new System.Drawing.Point(118, 247);
            this.CbFilterBy.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.CbFilterBy.Name = "CbFilterBy";
            this.CbFilterBy.Size = new System.Drawing.Size(178, 37);
            this.CbFilterBy.TabIndex = 1;
            this.CbFilterBy.SelectedIndexChanged += new System.EventHandler(this.CbFilterBy_SelectedIndexChanged);
            this.CbFilterBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbFilterBy_KeyPress);
            // 
            // CbGender
            // 
            this.CbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbGender.Items.AddRange(new object[] {
            "All",
            "Male",
            "Female"});
            this.CbGender.Location = new System.Drawing.Point(306, 252);
            this.CbGender.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.CbGender.Name = "CbGender";
            this.CbGender.Size = new System.Drawing.Size(103, 37);
            this.CbGender.TabIndex = 3;
            this.CbGender.SelectedIndexChanged += new System.EventHandler(this.CbGender_SelectedIndexChanged);
            this.CbGender.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbGender_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 775);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Records:";
            // 
            // LblRecords
            // 
            this.LblRecords.AutoSize = true;
            this.LblRecords.Location = new System.Drawing.Point(118, 775);
            this.LblRecords.Name = "LblRecords";
            this.LblRecords.Size = new System.Drawing.Size(0, 30);
            this.LblRecords.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(424, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 48);
            this.label2.TabIndex = 9;
            this.label2.Text = "Manage People";
            // 
            // BtnAddPerson
            // 
            this.BtnAddPerson.Image = global::WindowsFormsApp1.Properties.Resources.Add_Person;
            this.BtnAddPerson.Location = new System.Drawing.Point(1026, 230);
            this.BtnAddPerson.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnAddPerson.Name = "BtnAddPerson";
            this.BtnAddPerson.Size = new System.Drawing.Size(61, 54);
            this.BtnAddPerson.TabIndex = 5;
            this.BtnAddPerson.Click += new System.EventHandler(this.BtnAddPerson_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Image = global::WindowsFormsApp1.Properties.Resources.Close_32;
            this.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClose.Location = new System.Drawing.Point(938, 763);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(150, 54);
            this.BtnClose.TabIndex = 6;
            this.BtnClose.Text = "Close";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 30);
            this.label3.TabIndex = 10;
            this.label3.Text = "Filter By";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.People_512;
            this.pictureBox1.Location = new System.Drawing.Point(441, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // TxtFilter
            // 
            this.TxtFilter.Location = new System.Drawing.Point(304, 252);
            this.TxtFilter.MaxLength = 20;
            this.TxtFilter.Name = "TxtFilter";
            this.TxtFilter.Size = new System.Drawing.Size(185, 35);
            this.TxtFilter.TabIndex = 24;
            this.TxtFilter.TextChanged += new System.EventHandler(this.TxtFilter_TextChanged);
            this.TxtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFilter_KeyPress);
            // 
            // ManagePeopleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 828);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblRecords);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbGender);
            this.Controls.Add(this.DgvPeople);
            this.Controls.Add(this.CbFilterBy);
            this.Controls.Add(this.BtnAddPerson);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.TxtFilter);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "ManagePeopleForm";
            this.Text = "Manage People";
            this.Load += new System.EventHandler(this.ManagePeopleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPeople)).EndInit();
            this.CmsPeople.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView DgvPeople;
        private System.Windows.Forms.ComboBox CbFilterBy;
        private System.Windows.Forms.ComboBox CbGender;
        private System.Windows.Forms.Button BtnAddPerson;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.ContextMenuStrip CmsPeople;
        private System.Windows.Forms.ToolStripMenuItem ViewPersonInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddNewPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SendEmailToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblRecords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private WindowsFormsApp1.TextCustomFilterControl TxtFilter;
    }
}