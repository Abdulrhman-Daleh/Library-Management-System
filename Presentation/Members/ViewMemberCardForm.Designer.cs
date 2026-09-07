namespace LibrarySystem.Members
{
    partial class ViewMemberCardForm
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
            this.memberCardControl = new LibrarySystem.Members.Controls.MemberCardControl();
            this.label2 = new System.Windows.Forms.Label();
            this.personCardControl1 = new LibrarySystem.People.PersonCardControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LnkRenew = new System.Windows.Forms.LinkLabel();
            this.statsControl1 = new WindowsFormsApp1.BorrowingBookCopy.Controls.StatsControl();
            this.BtnClose = new System.Windows.Forms.Button();
            this.msOptions = new System.Windows.Forms.MenuStrip();
            this.moreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowHisoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.msOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // memberCardControl
            // 
            this.memberCardControl.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.memberCardControl.Location = new System.Drawing.Point(14, 515);
            this.memberCardControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.memberCardControl.Name = "memberCardControl";
            this.memberCardControl.Size = new System.Drawing.Size(680, 305);
            this.memberCardControl.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(213, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 48);
            this.label2.TabIndex = 20;
            this.label2.Text = "View Member";
            // 
            // personCardControl1
            // 
            this.personCardControl1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.personCardControl1.Location = new System.Drawing.Point(14, 170);
            this.personCardControl1.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.personCardControl1.Name = "personCardControl1";
            this.personCardControl1.Size = new System.Drawing.Size(684, 349);
            this.personCardControl1.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LnkRenew);
            this.groupBox1.Controls.Add(this.msOptions);
            this.groupBox1.Location = new System.Drawing.Point(14, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(690, 100);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions";
            // 
            // LnkRenew
            // 
            this.LnkRenew.AutoSize = true;
            this.LnkRenew.Location = new System.Drawing.Point(37, 38);
            this.LnkRenew.Name = "LnkRenew";
            this.LnkRenew.Size = new System.Drawing.Size(81, 30);
            this.LnkRenew.TabIndex = 1;
            this.LnkRenew.TabStop = true;
            this.LnkRenew.Text = "Renew";
            this.LnkRenew.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkRenew_LinkClicked);
            // 
            // statsControl1
            // 
            this.statsControl1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.statsControl1.Location = new System.Drawing.Point(14, 832);
            this.statsControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.statsControl1.Name = "statsControl1";
            this.statsControl1.Size = new System.Drawing.Size(648, 139);
            this.statsControl1.TabIndex = 23;
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Image = global::WindowsFormsApp1.Properties.Resources.Close_32;
            this.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClose.Location = new System.Drawing.Point(548, 985);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(150, 64);
            this.BtnClose.TabIndex = 19;
            this.BtnClose.Text = "Close";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // msOptions
            // 
            this.msOptions.Dock = System.Windows.Forms.DockStyle.None;
            this.msOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moreToolStripMenuItem});
            this.msOptions.Location = new System.Drawing.Point(394, 38);
            this.msOptions.Name = "msOptions";
            this.msOptions.Size = new System.Drawing.Size(104, 40);
            this.msOptions.TabIndex = 24;
            this.msOptions.Text = "menuStrip1";
            // 
            // moreToolStripMenuItem
            // 
            this.moreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personProfileToolStripMenuItem,
            this.userAccountToolStripMenuItem,
            this.borrowHisoryToolStripMenuItem,
            this.finToolStripMenuItem});
            this.moreToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.more;
            this.moreToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.moreToolStripMenuItem.Name = "moreToolStripMenuItem";
            this.moreToolStripMenuItem.Size = new System.Drawing.Size(96, 36);
            this.moreToolStripMenuItem.Text = "More";
            // 
            // personProfileToolStripMenuItem
            // 
            this.personProfileToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Person_32;
            this.personProfileToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.personProfileToolStripMenuItem.Name = "personProfileToolStripMenuItem";
            this.personProfileToolStripMenuItem.Size = new System.Drawing.Size(262, 38);
            this.personProfileToolStripMenuItem.Text = "Person Profile";
            this.personProfileToolStripMenuItem.Click += new System.EventHandler(this.personProfileToolStripMenuItem_Click);
            // 
            // userAccountToolStripMenuItem
            // 
            this.userAccountToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Permisson_32;
            this.userAccountToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.userAccountToolStripMenuItem.Name = "userAccountToolStripMenuItem";
            this.userAccountToolStripMenuItem.Size = new System.Drawing.Size(262, 38);
            this.userAccountToolStripMenuItem.Text = "User Account";
            this.userAccountToolStripMenuItem.Click += new System.EventHandler(this.userAccountToolStripMenuItem_Click);
            // 
            // borrowHisoryToolStripMenuItem
            // 
            this.borrowHisoryToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Borrow_Book_32;
            this.borrowHisoryToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.borrowHisoryToolStripMenuItem.Name = "borrowHisoryToolStripMenuItem";
            this.borrowHisoryToolStripMenuItem.Size = new System.Drawing.Size(262, 38);
            this.borrowHisoryToolStripMenuItem.Text = "Borrow History";
            this.borrowHisoryToolStripMenuItem.Click += new System.EventHandler(this.borrowHisoryToolStripMenuItem_Click);
            // 
            // finToolStripMenuItem
            // 
            this.finToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Money_Bag_32;
            this.finToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.finToolStripMenuItem.Name = "finToolStripMenuItem";
            this.finToolStripMenuItem.Size = new System.Drawing.Size(262, 38);
            this.finToolStripMenuItem.Text = "Fines && Payments";
            this.finToolStripMenuItem.Click += new System.EventHandler(this.finToolStripMenuItem_Click);
            // 
            // ViewMemberCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(707, 1064);
            this.Controls.Add(this.statsControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.personCardControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.memberCardControl);
            this.MainMenuStrip = this.msOptions;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewMemberCardForm";
            this.Text = "Member Card";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.msOptions.ResumeLayout(false);
            this.msOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private Controls.MemberCardControl memberCardControl;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label label2;
        private People.PersonCardControl personCardControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel LnkRenew;
        private WindowsFormsApp1.BorrowingBookCopy.Controls.StatsControl statsControl1;
        private System.Windows.Forms.MenuStrip msOptions;
        private System.Windows.Forms.ToolStripMenuItem moreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowHisoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finToolStripMenuItem;
    }
}