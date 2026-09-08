namespace LibrarySystem.LibraryPolicies
{
    partial class AddUpdatePolicyForm
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
            this.LblPolicyId = new System.Windows.Forms.Label();
            this.NudFeesPerLateDay = new System.Windows.Forms.NumericUpDown();
            this.NudGracePeriodDays = new System.Windows.Forms.NumericUpDown();
            this.NudLostBookMultiplier = new System.Windows.Forms.NumericUpDown();
            this.DtpEffectiveFrom = new System.Windows.Forms.DateTimePicker();
            this.DtpEffectiveTo = new System.Windows.Forms.DateTimePicker();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.NudFeesPerLateDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudGracePeriodDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudLostBookMultiplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.LblTitle.ForeColor = System.Drawing.Color.Red;
            this.LblTitle.Location = new System.Drawing.Point(255, 19);
            this.LblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(221, 46);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Add Policy";
            // 
            // LblPolicyId
            // 
            this.LblPolicyId.AutoSize = true;
            this.LblPolicyId.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPolicyId.ForeColor = System.Drawing.Color.Red;
            this.LblPolicyId.Location = new System.Drawing.Point(215, 294);
            this.LblPolicyId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPolicyId.Name = "LblPolicyId";
            this.LblPolicyId.Size = new System.Drawing.Size(66, 33);
            this.LblPolicyId.TabIndex = 1;
            this.LblPolicyId.Text = "[Not Set]";
            // 
            // NudFeesPerLateDay
            // 
            this.NudFeesPerLateDay.DecimalPlaces = 2;
            this.NudFeesPerLateDay.Location = new System.Drawing.Point(296, 379);
            this.NudFeesPerLateDay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NudFeesPerLateDay.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NudFeesPerLateDay.Name = "NudFeesPerLateDay";
            this.NudFeesPerLateDay.Size = new System.Drawing.Size(180, 35);
            this.NudFeesPerLateDay.TabIndex = 2;
            this.NudFeesPerLateDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudFeesPerLateDay.Validating += new System.ComponentModel.CancelEventHandler(this.NudFeesPerLateDay_Validating);
            // 
            // NudGracePeriodDays
            // 
            this.NudGracePeriodDays.Location = new System.Drawing.Point(296, 455);
            this.NudGracePeriodDays.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NudGracePeriodDays.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.NudGracePeriodDays.Name = "NudGracePeriodDays";
            this.NudGracePeriodDays.Size = new System.Drawing.Size(180, 35);
            this.NudGracePeriodDays.TabIndex = 3;
            // 
            // NudLostBookMultiplier
            // 
            this.NudLostBookMultiplier.DecimalPlaces = 2;
            this.NudLostBookMultiplier.Location = new System.Drawing.Point(296, 527);
            this.NudLostBookMultiplier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NudLostBookMultiplier.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NudLostBookMultiplier.Name = "NudLostBookMultiplier";
            this.NudLostBookMultiplier.Size = new System.Drawing.Size(180, 35);
            this.NudLostBookMultiplier.TabIndex = 4;
            this.NudLostBookMultiplier.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DtpEffectiveFrom
            // 
            this.DtpEffectiveFrom.Location = new System.Drawing.Point(296, 600);
            this.DtpEffectiveFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DtpEffectiveFrom.Name = "DtpEffectiveFrom";
            this.DtpEffectiveFrom.Size = new System.Drawing.Size(298, 35);
            this.DtpEffectiveFrom.TabIndex = 5;
            this.DtpEffectiveFrom.Validating += new System.ComponentModel.CancelEventHandler(this.DtpEffectiveTo_Validating);
            // 
            // DtpEffectiveTo
            // 
            this.DtpEffectiveTo.Location = new System.Drawing.Point(296, 671);
            this.DtpEffectiveTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DtpEffectiveTo.Name = "DtpEffectiveTo";
            this.DtpEffectiveTo.Size = new System.Drawing.Size(298, 35);
            this.DtpEffectiveTo.TabIndex = 6;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 294);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 30);
            this.label1.TabIndex = 27;
            this.label1.Text = "Policy ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 381);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 30);
            this.label2.TabIndex = 28;
            this.label2.Text = "Fees Per Late  Day:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 456);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 30);
            this.label3.TabIndex = 29;
            this.label3.Text = "Grace Days:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 527);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 30);
            this.label4.TabIndex = 30;
            this.label4.Text = "Lost Multipliyer:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 599);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 30);
            this.label5.TabIndex = 31;
            this.label5.Text = "Effective From:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 672);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 30);
            this.label6.TabIndex = 32;
            this.label6.Text = "Effective To:";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::WindowsFormsApp1.Properties.Resources.Calendar_32;
            this.pictureBox6.Location = new System.Drawing.Point(241, 592);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(48, 43);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 26;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::WindowsFormsApp1.Properties.Resources.Calendar_32;
            this.pictureBox5.Location = new System.Drawing.Point(241, 667);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(48, 43);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 25;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApp1.Properties.Resources.Fine_32;
            this.pictureBox4.Location = new System.Drawing.Point(241, 375);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(48, 43);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.Policy_32;
            this.pictureBox3.Location = new System.Drawing.Point(156, 288);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 43);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Limit_32;
            this.pictureBox1.Location = new System.Drawing.Point(241, 447);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.multiply_32;
            this.pictureBox2.Location = new System.Drawing.Point(241, 519);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // BtnSave
            // 
            this.BtnSave.Image = global::WindowsFormsApp1.Properties.Resources.Save_32;
            this.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSave.Location = new System.Drawing.Point(423, 752);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(150, 64);
            this.BtnSave.TabIndex = 33;
            this.BtnSave.Text = "Save";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Image = global::WindowsFormsApp1.Properties.Resources.Close_32;
            this.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClose.Location = new System.Drawing.Point(582, 752);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(150, 64);
            this.BtnClose.TabIndex = 34;
            this.BtnClose.Text = "Close";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::WindowsFormsApp1.Properties.Resources.Policies_512;
            this.pictureBox7.Location = new System.Drawing.Point(261, 77);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(215, 189);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 35;
            this.pictureBox7.TabStop = false;
            // 
            // AddUpdatePolicyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 831);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.LblPolicyId);
            this.Controls.Add(this.NudFeesPerLateDay);
            this.Controls.Add(this.NudGracePeriodDays);
            this.Controls.Add(this.NudLostBookMultiplier);
            this.Controls.Add(this.DtpEffectiveFrom);
            this.Controls.Add(this.DtpEffectiveTo);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddUpdatePolicyForm";
            this.Text = "Add/Update Policy";
            this.Load += new System.EventHandler(this.AddUpdatePolicyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NudFeesPerLateDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudGracePeriodDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudLostBookMultiplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblPolicyId;
        private System.Windows.Forms.NumericUpDown NudFeesPerLateDay;
        private System.Windows.Forms.NumericUpDown NudGracePeriodDays;
        private System.Windows.Forms.NumericUpDown NudLostBookMultiplier;
        private System.Windows.Forms.DateTimePicker DtpEffectiveFrom;
        private System.Windows.Forms.DateTimePicker DtpEffectiveTo;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnClose;
    }
}