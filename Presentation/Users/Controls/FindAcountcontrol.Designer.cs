namespace LibrarySystem.Users.Controls
{
    partial class FindAcountcontrol
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
            this.GbFilter = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnFind = new System.Windows.Forms.Button();
            this.BtnAddNew = new System.Windows.Forms.Button();
            this.TxtFilterBy = new System.Windows.Forms.TextBox();
            this.CbFilters = new System.Windows.Forms.ComboBox();
            this.accountControl = new LibrarySystem.Users.Controls.ViewUserCardControl.AccountControl();
            this.GbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbFilter
            // 
            this.GbFilter.Controls.Add(this.label1);
            this.GbFilter.Controls.Add(this.BtnFind);
            this.GbFilter.Controls.Add(this.BtnAddNew);
            this.GbFilter.Controls.Add(this.TxtFilterBy);
            this.GbFilter.Controls.Add(this.CbFilters);
            this.GbFilter.Location = new System.Drawing.Point(0, 0);
            this.GbFilter.Margin = new System.Windows.Forms.Padding(4);
            this.GbFilter.Name = "GbFilter";
            this.GbFilter.Padding = new System.Windows.Forms.Padding(4);
            this.GbFilter.Size = new System.Drawing.Size(481, 124);
            this.GbFilter.TabIndex = 0;
            this.GbFilter.TabStop = false;
            this.GbFilter.Text = "Filter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Find By:";
            // 
            // BtnFind
            // 
            this.BtnFind.Image = global::WindowsFormsApp1.Properties.Resources.View_32;
            this.BtnFind.Location = new System.Drawing.Point(298, 61);
            this.BtnFind.Margin = new System.Windows.Forms.Padding(4);
            this.BtnFind.Name = "BtnFind";
            this.BtnFind.Size = new System.Drawing.Size(74, 57);
            this.BtnFind.TabIndex = 3;
            this.BtnFind.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // BtnAddNew
            // 
            this.BtnAddNew.Image = global::WindowsFormsApp1.Properties.Resources.Add_Person;
            this.BtnAddNew.Location = new System.Drawing.Point(380, 61);
            this.BtnAddNew.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAddNew.Name = "BtnAddNew";
            this.BtnAddNew.Size = new System.Drawing.Size(74, 57);
            this.BtnAddNew.TabIndex = 4;
            this.BtnAddNew.Click += new System.EventHandler(this.BtnAddNew_Click);
            // 
            // TxtFilterBy
            // 
            this.TxtFilterBy.Location = new System.Drawing.Point(268, 23);
            this.TxtFilterBy.Margin = new System.Windows.Forms.Padding(4);
            this.TxtFilterBy.Name = "TxtFilterBy";
            this.TxtFilterBy.Size = new System.Drawing.Size(186, 30);
            this.TxtFilterBy.TabIndex = 2;
            this.TxtFilterBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFilterBy_KeyPress);
            // 
            // CbFilters
            // 
            this.CbFilters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbFilters.Items.AddRange(new object[] {
            "Person ID",
            "User ID"});
            this.CbFilters.Location = new System.Drawing.Point(130, 23);
            this.CbFilters.Margin = new System.Windows.Forms.Padding(4);
            this.CbFilters.Name = "CbFilters";
            this.CbFilters.Size = new System.Drawing.Size(124, 31);
            this.CbFilters.TabIndex = 1;
            this.CbFilters.SelectedIndexChanged += new System.EventHandler(this.CbFilters_SelectedIndexChanged);
            this.CbFilters.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbFilters_KeyPress);
            // 
            // accountControl
            // 
            this.accountControl.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.accountControl.Location = new System.Drawing.Point(5, 122);
            this.accountControl.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.accountControl.Name = "accountControl";
            this.accountControl.Size = new System.Drawing.Size(476, 222);
            this.accountControl.TabIndex = 1;
            // 
            // FindAcountcontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.accountControl);
            this.Controls.Add(this.GbFilter);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FindAcountcontrol";
            this.Size = new System.Drawing.Size(489, 348);
            this.GbFilter.ResumeLayout(false);
            this.GbFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.GroupBox GbFilter;
        private System.Windows.Forms.TextBox TxtFilterBy;
        private System.Windows.Forms.ComboBox CbFilters;
        private System.Windows.Forms.Button BtnFind;
        private System.Windows.Forms.Button BtnAddNew;
        private System.Windows.Forms.Label label1;
        private ViewUserCardControl.AccountControl accountControl;
    }
}