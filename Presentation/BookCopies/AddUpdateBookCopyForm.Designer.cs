namespace LibrarySystem.BookCopies
{
    partial class AddUpdateBookCopyForm
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
            this.TbPages = new System.Windows.Forms.TabControl();
            this.TpSelectBook = new System.Windows.Forms.TabPage();
            this.BtnNext = new System.Windows.Forms.Button();
            this.FindBookWithFilterControl = new LibrarySystem.Books.Controls.FindBookWithFilterControl();
            this.TpAddACopy = new System.Windows.Forms.TabPage();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnPrevious = new System.Windows.Forms.Button();
            this.LblBookCopyId = new System.Windows.Forms.Label();
            this.LblBookId = new System.Windows.Forms.Label();
            this.CbStatus = new System.Windows.Forms.ComboBox();
            this.CbCondition = new System.Windows.Forms.ComboBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.TbPages.SuspendLayout();
            this.TpSelectBook.SuspendLayout();
            this.TpAddACopy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.LblTitle.ForeColor = System.Drawing.Color.Red;
            this.LblTitle.Location = new System.Drawing.Point(203, 20);
            this.LblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(313, 46);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Add Book Copy";
            // 
            // TbPages
            // 
            this.TbPages.Controls.Add(this.TpSelectBook);
            this.TbPages.Controls.Add(this.TpAddACopy);
            this.TbPages.Location = new System.Drawing.Point(13, 229);
            this.TbPages.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TbPages.Name = "TbPages";
            this.TbPages.SelectedIndex = 0;
            this.TbPages.Size = new System.Drawing.Size(668, 465);
            this.TbPages.TabIndex = 1;
            // 
            // TpSelectBook
            // 
            this.TpSelectBook.Controls.Add(this.BtnNext);
            this.TpSelectBook.Controls.Add(this.FindBookWithFilterControl);
            this.TpSelectBook.Location = new System.Drawing.Point(4, 38);
            this.TpSelectBook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TpSelectBook.Name = "TpSelectBook";
            this.TpSelectBook.Size = new System.Drawing.Size(660, 423);
            this.TpSelectBook.TabIndex = 0;
            this.TpSelectBook.Text = "Select Book";
            // 
            // BtnNext
            // 
            this.BtnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNext.Location = new System.Drawing.Point(496, 345);
            this.BtnNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(150, 64);
            this.BtnNext.TabIndex = 11;
            this.BtnNext.Text = "Next";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // FindBookWithFilterControl
            // 
            this.FindBookWithFilterControl.AllowSearchSection = false;
            this.FindBookWithFilterControl.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FindBookWithFilterControl.Location = new System.Drawing.Point(15, 18);
            this.FindBookWithFilterControl.Margin = new System.Windows.Forms.Padding(8, 11, 8, 11);
            this.FindBookWithFilterControl.Name = "FindBookWithFilterControl";
            this.FindBookWithFilterControl.Size = new System.Drawing.Size(631, 311);
            this.FindBookWithFilterControl.TabIndex = 0;
            // 
            // TpAddACopy
            // 
            this.TpAddACopy.Controls.Add(this.TxtPrice);
            this.TpAddACopy.Controls.Add(this.pictureBox6);
            this.TpAddACopy.Controls.Add(this.pictureBox5);
            this.TpAddACopy.Controls.Add(this.pictureBox3);
            this.TpAddACopy.Controls.Add(this.pictureBox2);
            this.TpAddACopy.Controls.Add(this.pictureBox1);
            this.TpAddACopy.Controls.Add(this.label5);
            this.TpAddACopy.Controls.Add(this.label3);
            this.TpAddACopy.Controls.Add(this.label4);
            this.TpAddACopy.Controls.Add(this.label1);
            this.TpAddACopy.Controls.Add(this.label2);
            this.TpAddACopy.Controls.Add(this.BtnPrevious);
            this.TpAddACopy.Controls.Add(this.LblBookCopyId);
            this.TpAddACopy.Controls.Add(this.LblBookId);
            this.TpAddACopy.Controls.Add(this.CbStatus);
            this.TpAddACopy.Controls.Add(this.CbCondition);
            this.TpAddACopy.Enabled = false;
            this.TpAddACopy.Location = new System.Drawing.Point(4, 38);
            this.TpAddACopy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TpAddACopy.Name = "TpAddACopy";
            this.TpAddACopy.Size = new System.Drawing.Size(660, 423);
            this.TpAddACopy.TabIndex = 1;
            this.TpAddACopy.Text = "Copy Details";
            // 
            // TxtPrice
            // 
            this.TxtPrice.Location = new System.Drawing.Point(274, 147);
            this.TxtPrice.MaxLength = 4;
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(100, 35);
            this.TxtPrice.TabIndex = 32;
            this.TxtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrice_KeyPress);
            this.TxtPrice.Validating += new System.ComponentModel.CancelEventHandler(this.TxtPrice_Validating);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::WindowsFormsApp1.Properties.Resources.Status_32;
            this.pictureBox6.Location = new System.Drawing.Point(208, 264);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(52, 44);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 29;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::WindowsFormsApp1.Properties.Resources.Status_32;
            this.pictureBox5.Location = new System.Drawing.Point(208, 198);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(52, 44);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 28;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.Money_Bag_32;
            this.pictureBox3.Location = new System.Drawing.Point(208, 140);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(52, 44);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.Book_32;
            this.pictureBox2.Location = new System.Drawing.Point(208, 90);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Book_Copy_32;
            this.pictureBox1.Location = new System.Drawing.Point(208, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 271);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 30);
            this.label5.TabIndex = 14;
            this.label5.Text = "Copy Condition:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 30);
            this.label3.TabIndex = 12;
            this.label3.Text = "Copy Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 205);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 30);
            this.label4.TabIndex = 13;
            this.label4.Text = "Copy Status:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Copy ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 30);
            this.label2.TabIndex = 11;
            this.label2.Text = "Book ID:";
            // 
            // BtnPrevious
            // 
            this.BtnPrevious.Image = global::WindowsFormsApp1.Properties.Resources.Previous_32;
            this.BtnPrevious.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPrevious.Location = new System.Drawing.Point(452, 332);
            this.BtnPrevious.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnPrevious.Name = "BtnPrevious";
            this.BtnPrevious.Size = new System.Drawing.Size(192, 68);
            this.BtnPrevious.TabIndex = 9;
            this.BtnPrevious.Text = "Previous";
            this.BtnPrevious.UseVisualStyleBackColor = true;
            this.BtnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // LblBookCopyId
            // 
            this.LblBookCopyId.AutoSize = true;
            this.LblBookCopyId.Location = new System.Drawing.Point(269, 42);
            this.LblBookCopyId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblBookCopyId.Name = "LblBookCopyId";
            this.LblBookCopyId.Size = new System.Drawing.Size(67, 30);
            this.LblBookCopyId.TabIndex = 0;
            this.LblBookCopyId.Text = "[Not Set]";
            // 
            // LblBookId
            // 
            this.LblBookId.AutoSize = true;
            this.LblBookId.Location = new System.Drawing.Point(269, 97);
            this.LblBookId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblBookId.Name = "LblBookId";
            this.LblBookId.Size = new System.Drawing.Size(67, 30);
            this.LblBookId.TabIndex = 1;
            this.LblBookId.Text = "[Not Set]";
            // 
            // CbStatus
            // 
            this.CbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbStatus.Items.AddRange(new object[] {
            "Available",
            "Not Available",
            "Checked Out",
            "On Hold",
            "In Library Use Only"});
            this.CbStatus.Location = new System.Drawing.Point(271, 202);
            this.CbStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbStatus.Name = "CbStatus";
            this.CbStatus.Size = new System.Drawing.Size(164, 37);
            this.CbStatus.TabIndex = 3;
            // 
            // CbCondition
            // 
            this.CbCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbCondition.Items.AddRange(new object[] {
            "As New",
            "Fine",
            "Near Fine",
            "Very Good",
            "Good",
            "Fair",
            "Poor"});
            this.CbCondition.Location = new System.Drawing.Point(271, 268);
            this.CbCondition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbCondition.Name = "CbCondition";
            this.CbCondition.Size = new System.Drawing.Size(164, 37);
            this.CbCondition.TabIndex = 4;
            this.CbCondition.Validating += new System.ComponentModel.CancelEventHandler(this.CbCondition_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApp1.Properties.Resources.Book_Copies_512;
            this.pictureBox4.Location = new System.Drawing.Point(216, 69);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(266, 152);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // BtnSave
            // 
            this.BtnSave.Image = global::WindowsFormsApp1.Properties.Resources.Save_32;
            this.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSave.Location = new System.Drawing.Point(531, 705);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(150, 64);
            this.BtnSave.TabIndex = 9;
            this.BtnSave.Text = "Save";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Image = global::WindowsFormsApp1.Properties.Resources.Close_32;
            this.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClose.Location = new System.Drawing.Point(371, 705);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(150, 64);
            this.BtnClose.TabIndex = 10;
            this.BtnClose.Text = "Close";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // AddUpdateBookCopyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 778);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.TbPages);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddUpdateBookCopyForm";
            this.Text = "Add/Update Book Copy";
            this.Load += new System.EventHandler(this.AddUpdateBookCopyForm_Load);
            this.TbPages.ResumeLayout(false);
            this.TpSelectBook.ResumeLayout(false);
            this.TpAddACopy.ResumeLayout(false);
            this.TpAddACopy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.TabControl TbPages;
        private System.Windows.Forms.TabPage TpSelectBook;
        private System.Windows.Forms.TabPage TpAddACopy;
        private LibrarySystem.Books.Controls.FindBookWithFilterControl FindBookWithFilterControl;
        private System.Windows.Forms.Label LblBookCopyId;
        private System.Windows.Forms.Label LblBookId;
        private System.Windows.Forms.ComboBox CbStatus;
        private System.Windows.Forms.ComboBox CbCondition;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnPrevious;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtPrice;
    }

}