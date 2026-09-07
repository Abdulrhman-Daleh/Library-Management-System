namespace WindowsFormsApp1.LibraryPolicies
{
    partial class ViewPolicyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        { 
            this.policyCardControl1 = new WindowsFormsApp1.LibraryPolicies.Controls.PolicyCardControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LinkEdit = new System.Windows.Forms.LinkLabel();
            this.BtnClose = new System.Windows.Forms.Button();
            this.LblTitle = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // policyCardControl1
            // 
            this.policyCardControl1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.policyCardControl1.Location = new System.Drawing.Point(13, 165);
            this.policyCardControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.policyCardControl1.Name = "policyCardControl1";
            this.policyCardControl1.Size = new System.Drawing.Size(524, 361);
            this.policyCardControl1.TabIndex = 46;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LinkEdit);
            this.groupBox2.Location = new System.Drawing.Point(13, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(524, 100);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actions";
            // 
            // LinkEdit
            // 
            this.LinkEdit.AutoSize = true;
            this.LinkEdit.Location = new System.Drawing.Point(32, 46);
            this.LinkEdit.Name = "LinkEdit";
            this.LinkEdit.Size = new System.Drawing.Size(53, 30);
            this.LinkEdit.TabIndex = 0;
            this.LinkEdit.TabStop = true;
            this.LinkEdit.Text = "Edit";
            this.LinkEdit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkEdit_LinkClicked);
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Image = global::WindowsFormsApp1.Properties.Resources.Close_32;
            this.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClose.Location = new System.Drawing.Point(378, 536);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(150, 64);
            this.BtnClose.TabIndex = 48;
            this.BtnClose.Text = "Close";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.LblTitle.ForeColor = System.Drawing.Color.Red;
            this.LblTitle.Location = new System.Drawing.Point(157, 9);
            this.LblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(217, 46);
            this.LblTitle.TabIndex = 44;
            this.LblTitle.Text = "Policy Info";
            // 
            // ViewPolicyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 605);
            this.Controls.Add(this.policyCardControl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.LblTitle);
            this.Name = "ViewPolicyForm";
            this.Text = "Policy Card";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.PolicyCardControl policyCardControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel LinkEdit;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label LblTitle;
    }
}