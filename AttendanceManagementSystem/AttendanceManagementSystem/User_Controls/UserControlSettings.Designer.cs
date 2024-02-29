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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlSettings));
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
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Name = "label2";
            // 
            // checkBoxDark
            // 
            resources.ApplyResources(this.checkBoxDark, "checkBoxDark");
            this.checkBoxDark.Name = "checkBoxDark";
            this.checkBoxDark.UseVisualStyleBackColor = true;
            this.checkBoxDark.CheckedChanged += new System.EventHandler(this.checkBoxDark_CheckedChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // comboBoxlan
            // 
            resources.ApplyResources(this.comboBoxlan, "comboBoxlan");
            this.comboBoxlan.AutoCompleteCustomSource.AddRange(new string[] {
            resources.GetString("comboBoxlan.AutoCompleteCustomSource"),
            resources.GetString("comboBoxlan.AutoCompleteCustomSource1")});
            this.comboBoxlan.BackColor = System.Drawing.Color.White;
            this.comboBoxlan.FormattingEnabled = true;
            this.comboBoxlan.Items.AddRange(new object[] {
            resources.GetString("comboBoxlan.Items"),
            resources.GetString("comboBoxlan.Items1")});
            this.comboBoxlan.Name = "comboBoxlan";
            this.comboBoxlan.SelectedIndexChanged += new System.EventHandler(this.comboBoxlan_SelectedIndexChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // comboBoxDate
            // 
            resources.ApplyResources(this.comboBoxDate, "comboBoxDate");
            this.comboBoxDate.AutoCompleteCustomSource.AddRange(new string[] {
            resources.GetString("comboBoxDate.AutoCompleteCustomSource"),
            resources.GetString("comboBoxDate.AutoCompleteCustomSource1")});
            this.comboBoxDate.BackColor = System.Drawing.Color.White;
            this.comboBoxDate.FormattingEnabled = true;
            this.comboBoxDate.Items.AddRange(new object[] {
            resources.GetString("comboBoxDate.Items"),
            resources.GetString("comboBoxDate.Items1"),
            resources.GetString("comboBoxDate.Items2")});
            this.comboBoxDate.Name = "comboBoxDate";
            this.comboBoxDate.SelectedIndexChanged += new System.EventHandler(this.comboBoxDate_SelectedIndexChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // UserControlSettings
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.checkBoxDark);
            this.Controls.Add(this.comboBoxDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxlan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "UserControlSettings";
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
