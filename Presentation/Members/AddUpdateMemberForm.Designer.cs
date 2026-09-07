namespace LibrarySystem.Members
{
    partial class AddUpdateMemberForm
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
            this.TbLinkUser = new System.Windows.Forms.TabPage();
            this.findUserByFilterControl = new LibrarySystem.Users.Controls.FindAcountcontrol();
            this.BtnNext = new System.Windows.Forms.Button();
            this.tpAddMember = new System.Windows.Forms.TabPage();
            this.BtnPrevious = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblMemberId = new System.Windows.Forms.Label();
            this.CbMembershipTypes = new System.Windows.Forms.ComboBox();
            this.LblMembershipTypeFees = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.TbPages.SuspendLayout();
            this.TbLinkUser.SuspendLayout();
            this.tpAddMember.SuspendLayout();
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
            this.LblTitle.Location = new System.Drawing.Point(133, 13);
            this.LblTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(257, 46);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Add Member";
            // 
            // TbPages
            // 
            this.TbPages.Controls.Add(this.TbLinkUser);
            this.TbPages.Controls.Add(this.tpAddMember);
            this.TbPages.Location = new System.Drawing.Point(14, 209);
            this.TbPages.Margin = new System.Windows.Forms.Padding(5);
            this.TbPages.Name = "TbPages";
            this.TbPages.SelectedIndex = 0;
            this.TbPages.Size = new System.Drawing.Size(497, 493);
            this.TbPages.TabIndex = 1;
            // 
            // TbLinkUser
            // 
            this.TbLinkUser.Controls.Add(this.findUserByFilterControl);
            this.TbLinkUser.Controls.Add(this.BtnNext);
            this.TbLinkUser.Location = new System.Drawing.Point(4, 38);
            this.TbLinkUser.Margin = new System.Windows.Forms.Padding(5);
            this.TbLinkUser.Name = "TbLinkUser";
            this.TbLinkUser.Size = new System.Drawing.Size(489, 451);
            this.TbLinkUser.TabIndex = 0;
            this.TbLinkUser.Text = "Select User";
            // 
            // findUserByFilterControl
            // 
            this.findUserByFilterControl.EnableSearchSection = false;
            this.findUserByFilterControl.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.findUserByFilterControl.Location = new System.Drawing.Point(5, 6);
            this.findUserByFilterControl.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.findUserByFilterControl.Name = "findUserByFilterControl";
            this.findUserByFilterControl.Size = new System.Drawing.Size(479, 357);
            this.findUserByFilterControl.TabIndex = 10;
            // 
            // BtnNext
            // 
            this.BtnNext.Image = global::WindowsFormsApp1.Properties.Resources.Next_32;
            this.BtnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNext.Location = new System.Drawing.Point(322, 374);
            this.BtnNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(150, 64);
            this.BtnNext.TabIndex = 9;
            this.BtnNext.Text = "Next";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // tpAddMember
            // 
            this.tpAddMember.Controls.Add(this.BtnPrevious);
            this.tpAddMember.Controls.Add(this.pictureBox3);
            this.tpAddMember.Controls.Add(this.pictureBox2);
            this.tpAddMember.Controls.Add(this.pictureBox1);
            this.tpAddMember.Controls.Add(this.label3);
            this.tpAddMember.Controls.Add(this.label2);
            this.tpAddMember.Controls.Add(this.label1);
            this.tpAddMember.Controls.Add(this.LblMemberId);
            this.tpAddMember.Controls.Add(this.CbMembershipTypes);
            this.tpAddMember.Controls.Add(this.LblMembershipTypeFees);
            this.tpAddMember.Enabled = false;
            this.tpAddMember.Location = new System.Drawing.Point(4, 38);
            this.tpAddMember.Margin = new System.Windows.Forms.Padding(5);
            this.tpAddMember.Name = "tpAddMember";
            this.tpAddMember.Size = new System.Drawing.Size(489, 451);
            this.tpAddMember.TabIndex = 1;
            this.tpAddMember.Text = "Member Details";
            // 
            // BtnPrevious
            // 
            this.BtnPrevious.Image = global::WindowsFormsApp1.Properties.Resources.Previous_32;
            this.BtnPrevious.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPrevious.Location = new System.Drawing.Point(289, 367);
            this.BtnPrevious.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnPrevious.Name = "BtnPrevious";
            this.BtnPrevious.Size = new System.Drawing.Size(192, 68);
            this.BtnPrevious.TabIndex = 10;
            this.BtnPrevious.Text = "Previous";
            this.BtnPrevious.UseVisualStyleBackColor = true;
            this.BtnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.Fine_32;
            this.pictureBox3.Location = new System.Drawing.Point(289, 209);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 35);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.Membership_32;
            this.pictureBox2.Location = new System.Drawing.Point(226, 148);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 35);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.ID_32;
            this.pictureBox1.Location = new System.Drawing.Point(159, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 35);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 209);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Membership Type Fees:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Membership Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Member ID:";
            // 
            // LblMemberId
            // 
            this.LblMemberId.AutoSize = true;
            this.LblMemberId.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMemberId.ForeColor = System.Drawing.Color.Red;
            this.LblMemberId.Location = new System.Drawing.Point(205, 49);
            this.LblMemberId.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblMemberId.Name = "LblMemberId";
            this.LblMemberId.Size = new System.Drawing.Size(59, 29);
            this.LblMemberId.TabIndex = 0;
            this.LblMemberId.Text = "[???]";
            // 
            // CbMembershipTypes
            // 
            this.CbMembershipTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbMembershipTypes.Location = new System.Drawing.Point(269, 148);
            this.CbMembershipTypes.Margin = new System.Windows.Forms.Padding(5);
            this.CbMembershipTypes.Name = "CbMembershipTypes";
            this.CbMembershipTypes.Size = new System.Drawing.Size(167, 37);
            this.CbMembershipTypes.TabIndex = 1;
            this.CbMembershipTypes.SelectedIndexChanged += new System.EventHandler(this.CbMembershipTypes_SelectedIndexChanged);
            this.CbMembershipTypes.Validating += new System.ComponentModel.CancelEventHandler(this.CbMembershipTypes_Validating);
            // 
            // LblMembershipTypeFees
            // 
            this.LblMembershipTypeFees.AutoSize = true;
            this.LblMembershipTypeFees.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMembershipTypeFees.ForeColor = System.Drawing.Color.Red;
            this.LblMembershipTypeFees.Location = new System.Drawing.Point(335, 209);
            this.LblMembershipTypeFees.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblMembershipTypeFees.Name = "LblMembershipTypeFees";
            this.LblMembershipTypeFees.Size = new System.Drawing.Size(68, 29);
            this.LblMembershipTypeFees.TabIndex = 2;
            this.LblMembershipTypeFees.Text = "[$$$]";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApp1.Properties.Resources.Add_512;
            this.pictureBox4.Location = new System.Drawing.Point(131, 62);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(259, 139);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // BtnSave
            // 
            this.BtnSave.Image = global::WindowsFormsApp1.Properties.Resources.Save_32;
            this.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSave.Location = new System.Drawing.Point(357, 709);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(150, 64);
            this.BtnSave.TabIndex = 8;
            this.BtnSave.Text = "Save";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Image = global::WindowsFormsApp1.Properties.Resources.Close_32;
            this.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClose.Location = new System.Drawing.Point(197, 709);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(150, 64);
            this.BtnClose.TabIndex = 9;
            this.BtnClose.Text = "Close";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // AddUpdateMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 788);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.TbPages);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddUpdateMemberForm";
            this.Text = "Add/Update Member";
            this.Load += new System.EventHandler(this.AddUpdateMemberForm_Load);
            this.TbPages.ResumeLayout(false);
            this.TbLinkUser.ResumeLayout(false);
            this.tpAddMember.ResumeLayout(false);
            this.tpAddMember.PerformLayout();
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
        private System.Windows.Forms.TabPage TbLinkUser;
        private System.Windows.Forms.TabPage tpAddMember;
        private System.Windows.Forms.Label LblMemberId;
        private System.Windows.Forms.ComboBox CbMembershipTypes;
        private System.Windows.Forms.Label LblMembershipTypeFees;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnPrevious;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Users.Controls.FindAcountcontrol findUserByFilterControl;
    }
}