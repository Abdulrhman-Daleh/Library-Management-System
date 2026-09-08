namespace LibrarySystem.Categories
{
    partial class AddUpdateCategoryForm
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
            this.LblCategoryId = new System.Windows.Forms.Label();
            this.GbCategoryInfo = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCategoryName = new System.Windows.Forms.TextBox();
            this.TxtCategoryDescription = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.GbCategoryInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.LblTitle.ForeColor = System.Drawing.Color.Red;
            this.LblTitle.Location = new System.Drawing.Point(183, 15);
            this.LblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(276, 46);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Add Category";
            // 
            // LblCategoryId
            // 
            this.LblCategoryId.AutoSize = true;
            this.LblCategoryId.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCategoryId.ForeColor = System.Drawing.Color.Red;
            this.LblCategoryId.Location = new System.Drawing.Point(212, 235);
            this.LblCategoryId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCategoryId.Name = "LblCategoryId";
            this.LblCategoryId.Size = new System.Drawing.Size(83, 35);
            this.LblCategoryId.TabIndex = 1;
            this.LblCategoryId.Text = "[Not Set]";
            // 
            // GbCategoryInfo
            // 
            this.GbCategoryInfo.Controls.Add(this.pictureBox2);
            this.GbCategoryInfo.Controls.Add(this.pictureBox1);
            this.GbCategoryInfo.Controls.Add(this.label3);
            this.GbCategoryInfo.Controls.Add(this.label2);
            this.GbCategoryInfo.Controls.Add(this.TxtCategoryName);
            this.GbCategoryInfo.Controls.Add(this.TxtCategoryDescription);
            this.GbCategoryInfo.Location = new System.Drawing.Point(13, 290);
            this.GbCategoryInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GbCategoryInfo.Name = "GbCategoryInfo";
            this.GbCategoryInfo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GbCategoryInfo.Size = new System.Drawing.Size(600, 234);
            this.GbCategoryInfo.TabIndex = 2;
            this.GbCategoryInfo.TabStop = false;
            this.GbCategoryInfo.Text = "Category Information";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.Reason_32;
            this.pictureBox2.Location = new System.Drawing.Point(234, 119);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Category_32;
            this.pictureBox1.Location = new System.Drawing.Point(230, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Category Name:";
            // 
            // TxtCategoryName
            // 
            this.TxtCategoryName.Location = new System.Drawing.Point(295, 53);
            this.TxtCategoryName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCategoryName.Name = "TxtCategoryName";
            this.TxtCategoryName.Size = new System.Drawing.Size(246, 35);
            this.TxtCategoryName.TabIndex = 0;
            this.TxtCategoryName.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCategoryName_Validating);
            // 
            // TxtCategoryDescription
            // 
            this.TxtCategoryDescription.Location = new System.Drawing.Point(295, 119);
            this.TxtCategoryDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCategoryDescription.Multiline = true;
            this.TxtCategoryDescription.Name = "TxtCategoryDescription";
            this.TxtCategoryDescription.Size = new System.Drawing.Size(246, 90);
            this.TxtCategoryDescription.TabIndex = 1;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 235);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Category ID:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.ID_32;
            this.pictureBox3.Location = new System.Drawing.Point(156, 227);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 43);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApp1.Properties.Resources.Book_Categories_512;
            this.pictureBox4.Location = new System.Drawing.Point(211, 71);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(235, 134);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 26;
            this.pictureBox4.TabStop = false;
            // 
            // BtnSave
            // 
            this.BtnSave.Image = global::WindowsFormsApp1.Properties.Resources.Save_32;
            this.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSave.Location = new System.Drawing.Point(463, 535);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(150, 64);
            this.BtnSave.TabIndex = 27;
            this.BtnSave.Text = "Save";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Image = global::WindowsFormsApp1.Properties.Resources.Close_32;
            this.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClose.Location = new System.Drawing.Point(303, 535);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(150, 64);
            this.BtnClose.TabIndex = 28;
            this.BtnClose.Text = "Close";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // AddUpdateCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 605);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.LblCategoryId);
            this.Controls.Add(this.GbCategoryInfo);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddUpdateCategoryForm";
            this.Text = "Add/Update Category";
            this.Load += new System.EventHandler(this.AddUpdateCategoryForm_Load);
            this.GbCategoryInfo.ResumeLayout(false);
            this.GbCategoryInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblCategoryId;
        private System.Windows.Forms.GroupBox GbCategoryInfo;
        private System.Windows.Forms.TextBox TxtCategoryName;
        private System.Windows.Forms.TextBox TxtCategoryDescription;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnClose;
    }
}