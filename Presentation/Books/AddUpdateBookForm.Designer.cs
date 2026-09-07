namespace LibrarySystem.Books
{
    partial class AddUpdateBookForm
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
            this.LblBookId = new System.Windows.Forms.Label();
            this.GbCategoryInfo = new System.Windows.Forms.GroupBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtIsbn = new System.Windows.Forms.TextBox();
            this.TxtAuthor = new System.Windows.Forms.TextBox();
            this.CbCategories = new System.Windows.Forms.ComboBox();
            this.DtpPublicationDate = new System.Windows.Forms.DateTimePicker();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.GbCategoryInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.LblTitle.ForeColor = System.Drawing.Color.Red;
            this.LblTitle.Location = new System.Drawing.Point(187, 14);
            this.LblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(298, 46);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Add New Book";
            // 
            // LblBookId
            // 
            this.LblBookId.AutoSize = true;
            this.LblBookId.Location = new System.Drawing.Point(166, 219);
            this.LblBookId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblBookId.Name = "LblBookId";
            this.LblBookId.Size = new System.Drawing.Size(67, 30);
            this.LblBookId.TabIndex = 1;
            this.LblBookId.Text = "[????]";
            // 
            // GbCategoryInfo
            // 
            this.GbCategoryInfo.Controls.Add(this.pictureBox5);
            this.GbCategoryInfo.Controls.Add(this.pictureBox4);
            this.GbCategoryInfo.Controls.Add(this.pictureBox3);
            this.GbCategoryInfo.Controls.Add(this.pictureBox1);
            this.GbCategoryInfo.Controls.Add(this.label5);
            this.GbCategoryInfo.Controls.Add(this.label4);
            this.GbCategoryInfo.Controls.Add(this.label3);
            this.GbCategoryInfo.Controls.Add(this.label2);
            this.GbCategoryInfo.Controls.Add(this.TxtIsbn);
            this.GbCategoryInfo.Controls.Add(this.TxtAuthor);
            this.GbCategoryInfo.Controls.Add(this.CbCategories);
            this.GbCategoryInfo.Controls.Add(this.DtpPublicationDate);
            this.GbCategoryInfo.Location = new System.Drawing.Point(13, 273);
            this.GbCategoryInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GbCategoryInfo.Name = "GbCategoryInfo";
            this.GbCategoryInfo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GbCategoryInfo.Size = new System.Drawing.Size(614, 351);
            this.GbCategoryInfo.TabIndex = 2;
            this.GbCategoryInfo.TabStop = false;
            this.GbCategoryInfo.Text = "Book Information";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::WindowsFormsApp1.Properties.Resources.Calendar_32;
            this.pictureBox5.Location = new System.Drawing.Point(220, 268);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(48, 39);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 67;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApp1.Properties.Resources.Category_32;
            this.pictureBox4.Location = new System.Drawing.Point(220, 199);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(48, 39);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 66;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.Person_32;
            this.pictureBox3.Location = new System.Drawing.Point(220, 127);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 39);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 65;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.ISBN_32;
            this.pictureBox1.Location = new System.Drawing.Point(212, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 272);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 30);
            this.label5.TabIndex = 9;
            this.label5.Text = "Publication Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 205);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "Category Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Author:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "ISBN:";
            // 
            // TxtIsbn
            // 
            this.TxtIsbn.Location = new System.Drawing.Point(266, 54);
            this.TxtIsbn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtIsbn.MaxLength = 20;
            this.TxtIsbn.Name = "TxtIsbn";
            this.TxtIsbn.Size = new System.Drawing.Size(206, 35);
            this.TxtIsbn.TabIndex = 0;
            this.TxtIsbn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIsbn_KeyPress);
            this.TxtIsbn.Validating += new System.ComponentModel.CancelEventHandler(this.TxtIsbn_Validating);
            // 
            // TxtAuthor
            // 
            this.TxtAuthor.Location = new System.Drawing.Point(266, 127);
            this.TxtAuthor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtAuthor.MaxLength = 30;
            this.TxtAuthor.Name = "TxtAuthor";
            this.TxtAuthor.Size = new System.Drawing.Size(206, 35);
            this.TxtAuthor.TabIndex = 1;
            this.TxtAuthor.Validating += new System.ComponentModel.CancelEventHandler(this.TxtAuthor_Validating);
            // 
            // CbCategories
            // 
            this.CbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbCategories.Location = new System.Drawing.Point(266, 199);
            this.CbCategories.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbCategories.Name = "CbCategories";
            this.CbCategories.Size = new System.Drawing.Size(206, 37);
            this.CbCategories.TabIndex = 2;
            // 
            // DtpPublicationDate
            // 
            this.DtpPublicationDate.Location = new System.Drawing.Point(266, 272);
            this.DtpPublicationDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DtpPublicationDate.Name = "DtpPublicationDate";
            this.DtpPublicationDate.Size = new System.Drawing.Size(298, 35);
            this.DtpPublicationDate.TabIndex = 3;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 219);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Book ID:";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::WindowsFormsApp1.Properties.Resources.Add_Book_512;
            this.pictureBox6.Location = new System.Drawing.Point(225, 63);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(204, 141);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 64;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.ID_32;
            this.pictureBox2.Location = new System.Drawing.Point(111, 213);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 63;
            this.pictureBox2.TabStop = false;
            // 
            // BtnSave
            // 
            this.BtnSave.Image = global::WindowsFormsApp1.Properties.Resources.Save_32;
            this.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSave.Location = new System.Drawing.Point(477, 635);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(150, 64);
            this.BtnSave.TabIndex = 65;
            this.BtnSave.Text = "Save";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Image = global::WindowsFormsApp1.Properties.Resources.Close_32;
            this.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClose.Location = new System.Drawing.Point(317, 635);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(150, 64);
            this.BtnClose.TabIndex = 66;
            this.BtnClose.Text = "Close";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // AddUpdateBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 714);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.LblBookId);
            this.Controls.Add(this.GbCategoryInfo);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddUpdateBookForm";
            this.Text = "Add/Update Book";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddUpdateBookForm_FormClosing);
            this.Load += new System.EventHandler(this.AddUpdateBookForm_Load);
            this.GbCategoryInfo.ResumeLayout(false);
            this.GbCategoryInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblBookId;
        private System.Windows.Forms.GroupBox GbCategoryInfo;
        private System.Windows.Forms.TextBox TxtIsbn;
        private System.Windows.Forms.TextBox TxtAuthor;
        private System.Windows.Forms.ComboBox CbCategories;
        private System.Windows.Forms.DateTimePicker DtpPublicationDate;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnClose;
    }
}