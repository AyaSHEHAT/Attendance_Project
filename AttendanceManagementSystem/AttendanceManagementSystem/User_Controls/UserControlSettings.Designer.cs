namespace AttendanceManagementSystem.User_Controls
{
    partial class UserControlSettings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxDark = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxlan = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxDate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Settings";
            // 
            // checkBoxDark
            // 
            this.checkBoxDark.AutoSize = true;
            this.checkBoxDark.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDark.Location = new System.Drawing.Point(178, 163);
            this.checkBoxDark.Name = "checkBoxDark";
            this.checkBoxDark.Size = new System.Drawing.Size(56, 20);
            this.checkBoxDark.TabIndex = 2;
            this.checkBoxDark.Text = "Dark";
            this.checkBoxDark.UseVisualStyleBackColor = true;
            this.checkBoxDark.CheckedChanged += new System.EventHandler(this.checkBoxDark_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Theme:";
            // 
            // comboBoxlan
            // 
            this.comboBoxlan.AutoCompleteCustomSource.AddRange(new string[] {
            "English",
            "Arabic"});
            this.comboBoxlan.BackColor = System.Drawing.Color.White;
            this.comboBoxlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxlan.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxlan.FormattingEnabled = true;
            this.comboBoxlan.Location = new System.Drawing.Point(178, 233);
            this.comboBoxlan.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxlan.Name = "comboBoxlan";
            this.comboBoxlan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxlan.Size = new System.Drawing.Size(141, 22);
            this.comboBoxlan.TabIndex = 18;
            this.comboBoxlan.Text = "English";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 233);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Language";
            // 
            // comboBoxDate
            // 
            this.comboBoxDate.AutoCompleteCustomSource.AddRange(new string[] {
            "English",
            "Arabic"});
            this.comboBoxDate.BackColor = System.Drawing.Color.White;
            this.comboBoxDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDate.FormattingEnabled = true;
            this.comboBoxDate.Items.AddRange(new object[] {
            "dd/MM/yyyy",
            "MM/dd/yyyy",
            "yyyy-MM-dd"});
            this.comboBoxDate.Location = new System.Drawing.Point(178, 314);
            this.comboBoxDate.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxDate.Name = "comboBoxDate";
            this.comboBoxDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxDate.Size = new System.Drawing.Size(141, 24);
            this.comboBoxDate.TabIndex = 20;
            this.comboBoxDate.Text = "dd/MM/yyyy";
            this.comboBoxDate.SelectedIndexChanged += new System.EventHandler(this.comboBoxDate_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 314);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Date formate";
            // 
            // UserControlSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.checkBoxDark);
            this.Controls.Add(this.comboBoxDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxlan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlSettings";
            this.Size = new System.Drawing.Size(934, 469);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxlan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxDark;
    }
}
