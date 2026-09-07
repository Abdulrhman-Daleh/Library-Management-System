namespace LibrarySystem.People.Controls
{
    partial class FindPersonWithFilterControl
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
            this.personCardControl = new LibrarySystem.People.PersonCardControl();
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
            this.GbFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.GbFilter.Location = new System.Drawing.Point(0, 0);
            this.GbFilter.Margin = new System.Windows.Forms.Padding(4);
            this.GbFilter.Name = "GbFilter";
            this.GbFilter.Padding = new System.Windows.Forms.Padding(4);
            this.GbFilter.Size = new System.Drawing.Size(557, 127);
            this.GbFilter.TabIndex = 0;
            this.GbFilter.TabStop = false;
            this.GbFilter.Text = "Filter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Find By:";
            // 
            // BtnFind
            // 
            this.BtnFind.Image = global::WindowsFormsApp1.Properties.Resources.Find_Person_32;
            this.BtnFind.Location = new System.Drawing.Point(353, 62);
            this.BtnFind.Margin = new System.Windows.Forms.Padding(4);
            this.BtnFind.Name = "BtnFind";
            this.BtnFind.Size = new System.Drawing.Size(74, 57);
            this.BtnFind.TabIndex = 0;
            this.BtnFind.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // BtnAddNew
            // 
            this.BtnAddNew.Image = global::WindowsFormsApp1.Properties.Resources.Add_Person;
            this.BtnAddNew.Location = new System.Drawing.Point(435, 62);
            this.BtnAddNew.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAddNew.Name = "BtnAddNew";
            this.BtnAddNew.Size = new System.Drawing.Size(74, 57);
            this.BtnAddNew.TabIndex = 1;
            this.BtnAddNew.Click += new System.EventHandler(this.BtnAddNew_Click);
            // 
            // TxtFilterBy
            // 
            this.TxtFilterBy.Location = new System.Drawing.Point(306, 27);
            this.TxtFilterBy.Margin = new System.Windows.Forms.Padding(4);
            this.TxtFilterBy.Name = "TxtFilterBy";
            this.TxtFilterBy.Size = new System.Drawing.Size(203, 30);
            this.TxtFilterBy.TabIndex = 2;
            this.TxtFilterBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFilterBy_KeyPress);
            // 
            // CbFilters
            // 
            this.CbFilters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbFilters.Items.AddRange(new object[] {
            "Person ID",
            "National No"});
            this.CbFilters.Location = new System.Drawing.Point(124, 26);
            this.CbFilters.Margin = new System.Windows.Forms.Padding(4);
            this.CbFilters.Name = "CbFilters";
            this.CbFilters.Size = new System.Drawing.Size(174, 31);
            this.CbFilters.TabIndex = 3;
            this.CbFilters.SelectedIndexChanged += new System.EventHandler(this.CbFilters_SelectedIndexChanged);
            this.CbFilters.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbFilters_KeyPress);
            // 
            // personCardControl
            // 
            this.personCardControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.personCardControl.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.personCardControl.Location = new System.Drawing.Point(0, 130);
            this.personCardControl.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.personCardControl.Name = "personCardControl";
            this.personCardControl.Size = new System.Drawing.Size(557, 349);
            this.personCardControl.TabIndex = 1;
            // 
            // FindPersonWithFilterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.personCardControl);
            this.Controls.Add(this.GbFilter);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FindPersonWithFilterControl";
            this.Size = new System.Drawing.Size(557, 479);
            this.Load += new System.EventHandler(this.FindPersonWithFilterControl_Load);
            this.GbFilter.ResumeLayout(false);
            this.GbFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.GroupBox GbFilter;
        private System.Windows.Forms.Button BtnFind;
        private System.Windows.Forms.Button BtnAddNew;
        private System.Windows.Forms.TextBox TxtFilterBy;
        private System.Windows.Forms.ComboBox CbFilters;
        private PersonCardControl personCardControl;
        private System.Windows.Forms.Label label1;
    }
}