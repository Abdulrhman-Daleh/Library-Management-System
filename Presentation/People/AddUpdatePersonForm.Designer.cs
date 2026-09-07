namespace LibrarySystem.People
{
    partial class AddUpdatePersonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUpdatePersonForm));
            this.LblTitle = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.RbFemale = new System.Windows.Forms.RadioButton();
            this.RbMale = new System.Windows.Forms.RadioButton();
            this.MsbPhone = new System.Windows.Forms.MaskedTextBox();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtNationalNo = new System.Windows.Forms.TextBox();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.TxtThird = new System.Windows.Forms.TextBox();
            this.TxtSecond = new System.Windows.Forms.TextBox();
            this.DtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.TxtFirstname = new System.Windows.Forms.TextBox();
            this.GbPersonInfo = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblPersonId = new System.Windows.Forms.Label();
            this.LnkSelectImage = new System.Windows.Forms.LinkLabel();
            this.LnkRemove = new System.Windows.Forms.LinkLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PbPersonImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.GbPersonInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbPersonImage)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.LblTitle.ForeColor = System.Drawing.Color.Red;
            this.LblTitle.Location = new System.Drawing.Point(425, 34);
            this.LblTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(334, 46);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Add New Person";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Person ID";
            // 
            // RbFemale
            // 
            this.RbFemale.Location = new System.Drawing.Point(440, 257);
            this.RbFemale.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.RbFemale.Name = "RbFemale";
            this.RbFemale.Size = new System.Drawing.Size(115, 37);
            this.RbFemale.TabIndex = 10;
            this.RbFemale.Text = "Female";
            this.RbFemale.CheckedChanged += new System.EventHandler(this.RbFemale_CheckedChanged);
            // 
            // RbMale
            // 
            this.RbMale.Checked = true;
            this.RbMale.Location = new System.Drawing.Point(619, 257);
            this.RbMale.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.RbMale.Name = "RbMale";
            this.RbMale.Size = new System.Drawing.Size(95, 37);
            this.RbMale.TabIndex = 9;
            this.RbMale.TabStop = true;
            this.RbMale.Text = "Male";
            this.RbMale.CheckedChanged += new System.EventHandler(this.RbMale_CheckedChanged);
            // 
            // MsbPhone
            // 
            this.MsbPhone.Location = new System.Drawing.Point(198, 257);
            this.MsbPhone.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MsbPhone.Mask = "(999) 000-0000";
            this.MsbPhone.Name = "MsbPhone";
            this.MsbPhone.Size = new System.Drawing.Size(165, 35);
            this.MsbPhone.TabIndex = 7;
            this.MsbPhone.Validating += new System.ComponentModel.CancelEventHandler(this.MsbPhone_Validating);
            // 
            // TxtAddress
            // 
            this.TxtAddress.Location = new System.Drawing.Point(402, 323);
            this.TxtAddress.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TxtAddress.Multiline = true;
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(385, 114);
            this.TxtAddress.TabIndex = 6;
            this.TxtAddress.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateRequiredField);
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(655, 190);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(132, 35);
            this.TxtEmail.TabIndex = 5;
            this.TxtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.TxtEmail_Validating);
            // 
            // TxtNationalNo
            // 
            this.TxtNationalNo.Location = new System.Drawing.Point(460, 193);
            this.TxtNationalNo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TxtNationalNo.Name = "TxtNationalNo";
            this.TxtNationalNo.Size = new System.Drawing.Size(54, 35);
            this.TxtNationalNo.TabIndex = 4;
            this.TxtNationalNo.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNationalNo_Validating);
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(93, 191);
            this.TxtLastName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(165, 35);
            this.TxtLastName.TabIndex = 3;
            this.TxtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateRequiredField);
            // 
            // TxtThird
            // 
            this.TxtThird.Location = new System.Drawing.Point(663, 121);
            this.TxtThird.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TxtThird.Name = "TxtThird";
            this.TxtThird.Size = new System.Drawing.Size(124, 35);
            this.TxtThird.TabIndex = 2;
            this.TxtThird.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateRequiredField);
            // 
            // TxtSecond
            // 
            this.TxtSecond.Location = new System.Drawing.Point(403, 121);
            this.TxtSecond.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TxtSecond.Name = "TxtSecond";
            this.TxtSecond.Size = new System.Drawing.Size(165, 35);
            this.TxtSecond.TabIndex = 1;
            this.TxtSecond.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateRequiredField);
            // 
            // DtpDateOfBirth
            // 
            this.DtpDateOfBirth.Location = new System.Drawing.Point(67, 377);
            this.DtpDateOfBirth.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.DtpDateOfBirth.Name = "DtpDateOfBirth";
            this.DtpDateOfBirth.Size = new System.Drawing.Size(259, 35);
            this.DtpDateOfBirth.TabIndex = 8;
            // 
            // TxtFirstname
            // 
            this.TxtFirstname.Location = new System.Drawing.Point(131, 121);
            this.TxtFirstname.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TxtFirstname.Name = "TxtFirstname";
            this.TxtFirstname.Size = new System.Drawing.Size(165, 35);
            this.TxtFirstname.TabIndex = 0;
            this.TxtFirstname.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateRequiredField);
            // 
            // GbPersonInfo
            // 
            this.GbPersonInfo.Controls.Add(this.pictureBox9);
            this.GbPersonInfo.Controls.Add(this.label10);
            this.GbPersonInfo.Controls.Add(this.label9);
            this.GbPersonInfo.Controls.Add(this.label8);
            this.GbPersonInfo.Controls.Add(this.label7);
            this.GbPersonInfo.Controls.Add(this.label6);
            this.GbPersonInfo.Controls.Add(this.pictureBox8);
            this.GbPersonInfo.Controls.Add(this.pictureBox7);
            this.GbPersonInfo.Controls.Add(this.pictureBox6);
            this.GbPersonInfo.Controls.Add(this.pictureBox5);
            this.GbPersonInfo.Controls.Add(this.pictureBox4);
            this.GbPersonInfo.Controls.Add(this.pictureBox3);
            this.GbPersonInfo.Controls.Add(this.pictureBox2);
            this.GbPersonInfo.Controls.Add(this.label5);
            this.GbPersonInfo.Controls.Add(this.label4);
            this.GbPersonInfo.Controls.Add(this.label3);
            this.GbPersonInfo.Controls.Add(this.pictureBox1);
            this.GbPersonInfo.Controls.Add(this.label2);
            this.GbPersonInfo.Controls.Add(this.LblPersonId);
            this.GbPersonInfo.Controls.Add(this.LnkSelectImage);
            this.GbPersonInfo.Controls.Add(this.LnkRemove);
            this.GbPersonInfo.Controls.Add(this.RbFemale);
            this.GbPersonInfo.Controls.Add(this.RbMale);
            this.GbPersonInfo.Controls.Add(this.DtpDateOfBirth);
            this.GbPersonInfo.Controls.Add(this.MsbPhone);
            this.GbPersonInfo.Controls.Add(this.PbPersonImage);
            this.GbPersonInfo.Controls.Add(this.TxtAddress);
            this.GbPersonInfo.Controls.Add(this.TxtEmail);
            this.GbPersonInfo.Controls.Add(this.TxtNationalNo);
            this.GbPersonInfo.Controls.Add(this.TxtLastName);
            this.GbPersonInfo.Controls.Add(this.TxtThird);
            this.GbPersonInfo.Controls.Add(this.TxtSecond);
            this.GbPersonInfo.Controls.Add(this.TxtFirstname);
            this.GbPersonInfo.Controls.Add(this.label1);
            this.GbPersonInfo.Location = new System.Drawing.Point(23, 106);
            this.GbPersonInfo.Name = "GbPersonInfo";
            this.GbPersonInfo.Size = new System.Drawing.Size(1059, 455);
            this.GbPersonInfo.TabIndex = 6;
            this.GbPersonInfo.TabStop = false;
            this.GbPersonInfo.Text = "Personal Information";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(262, 326);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 30);
            this.label10.TabIndex = 30;
            this.label10.Text = "Address:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 341);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 30);
            this.label9.TabIndex = 29;
            this.label9.Text = "Date Of Birth:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 260);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 30);
            this.label8.TabIndex = 28;
            this.label8.Text = "Phone No.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(538, 196);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 30);
            this.label7.TabIndex = 27;
            this.label7.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(266, 193);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 30);
            this.label6.TabIndex = 26;
            this.label6.Text = "National No.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 195);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 30);
            this.label5.TabIndex = 18;
            this.label5.Text = "Last";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(588, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 30);
            this.label4.TabIndex = 17;
            this.label4.Text = "Third";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 30);
            this.label3.TabIndex = 16;
            this.label3.Text = "Second";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 30);
            this.label2.TabIndex = 14;
            this.label2.Text = "First";
            // 
            // LblPersonId
            // 
            this.LblPersonId.AutoSize = true;
            this.LblPersonId.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPersonId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblPersonId.Location = new System.Drawing.Point(197, 41);
            this.LblPersonId.Name = "LblPersonId";
            this.LblPersonId.Size = new System.Drawing.Size(61, 43);
            this.LblPersonId.TabIndex = 13;
            this.LblPersonId.Text = "???";
            // 
            // LnkSelectImage
            // 
            this.LnkSelectImage.AutoSize = true;
            this.LnkSelectImage.Location = new System.Drawing.Point(870, 328);
            this.LnkSelectImage.Name = "LnkSelectImage";
            this.LnkSelectImage.Size = new System.Drawing.Size(126, 30);
            this.LnkSelectImage.TabIndex = 7;
            this.LnkSelectImage.TabStop = true;
            this.LnkSelectImage.Text = "Add Image";
            this.LnkSelectImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkSelectImage_LinkClicked);
            // 
            // LnkRemove
            // 
            this.LnkRemove.AutoSize = true;
            this.LnkRemove.Location = new System.Drawing.Point(852, 373);
            this.LnkRemove.Name = "LnkRemove";
            this.LnkRemove.Size = new System.Drawing.Size(165, 30);
            this.LnkRemove.TabIndex = 8;
            this.LnkRemove.TabStop = true;
            this.LnkRemove.Text = "Remove Image";
            this.LnkRemove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkRemove_LinkClicked);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BtnSave
            // 
            this.BtnSave.Image = global::WindowsFormsApp1.Properties.Resources.Save_32;
            this.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSave.Location = new System.Drawing.Point(773, 576);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(150, 64);
            this.BtnSave.TabIndex = 4;
            this.BtnSave.Text = "Save";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Image = global::WindowsFormsApp1.Properties.Resources.Close_32;
            this.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClose.Location = new System.Drawing.Point(932, 576);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(150, 64);
            this.BtnClose.TabIndex = 5;
            this.BtnClose.Text = "Close";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::WindowsFormsApp1.Properties.Resources.ID_32;
            this.pictureBox9.Location = new System.Drawing.Point(152, 44);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(33, 37);
            this.pictureBox9.TabIndex = 31;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::WindowsFormsApp1.Properties.Resources.Address_32;
            this.pictureBox8.Location = new System.Drawing.Point(362, 323);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(33, 37);
            this.pictureBox8.TabIndex = 25;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::WindowsFormsApp1.Properties.Resources.Person_32;
            this.pictureBox7.Location = new System.Drawing.Point(573, 257);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(33, 37);
            this.pictureBox7.TabIndex = 24;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::WindowsFormsApp1.Properties.Resources.Female_32;
            this.pictureBox6.Location = new System.Drawing.Point(399, 257);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(33, 37);
            this.pictureBox6.TabIndex = 23;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::WindowsFormsApp1.Properties.Resources.Calendar_32;
            this.pictureBox5.Location = new System.Drawing.Point(26, 377);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(33, 37);
            this.pictureBox5.TabIndex = 22;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApp1.Properties.Resources.Phone_32;
            this.pictureBox4.Location = new System.Drawing.Point(157, 257);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(33, 37);
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.NationalNo_32;
            this.pictureBox3.Location = new System.Drawing.Point(419, 193);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 37);
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.Email_32;
            this.pictureBox2.Location = new System.Drawing.Point(616, 190);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 37);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Person_32;
            this.pictureBox1.Location = new System.Drawing.Point(90, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 37);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // PbPersonImage
            // 
            this.PbPersonImage.Image = ((System.Drawing.Image)(resources.GetObject("PbPersonImage.Image")));
            this.PbPersonImage.Location = new System.Drawing.Point(828, 83);
            this.PbPersonImage.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.PbPersonImage.Name = "PbPersonImage";
            this.PbPersonImage.Size = new System.Drawing.Size(211, 231);
            this.PbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbPersonImage.TabIndex = 11;
            this.PbPersonImage.TabStop = false;
            // 
            // AddUpdatePersonForm
            // 
            this.AcceptButton = this.BtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnClose;
            this.ClientSize = new System.Drawing.Size(1100, 655);
            this.Controls.Add(this.GbPersonInfo);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.LblTitle);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "AddUpdatePersonForm";
            this.Text = "Add/Update Person";
            this.Load += new System.EventHandler(this.AddUpdatePersonForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.GbPersonInfo.ResumeLayout(false);
            this.GbPersonInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbPersonImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtFirstname;
        private System.Windows.Forms.TextBox TxtSecond;
        private System.Windows.Forms.TextBox TxtThird;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.TextBox TxtNationalNo;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.MaskedTextBox MsbPhone;
        private System.Windows.Forms.DateTimePicker DtpDateOfBirth;
        private System.Windows.Forms.RadioButton RbMale;
        private System.Windows.Forms.RadioButton RbFemale;
        private System.Windows.Forms.PictureBox PbPersonImage;
        private System.Windows.Forms.GroupBox GbPersonInfo;
        private System.Windows.Forms.LinkLabel LnkRemove;
        private System.Windows.Forms.LinkLabel LnkSelectImage;
        private System.Windows.Forms.Label LblPersonId;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox9;
    }
}