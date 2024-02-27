namespace AttendanceManagementSystem.Forms
{
    partial class FormStudent
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
            this.components = new System.ComponentModel.Container();
            this.timerDtaeAndTime = new System.Windows.Forms.Timer(this.components);
            this.labelUsername = new System.Windows.Forms.Label();
            this.buttonReport = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.panelBack = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelBack.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.Indigo;
            this.labelUsername.Location = new System.Drawing.Point(685, 38);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(35, 23);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "{?}";
            // 
            // buttonReport
            // 
            this.buttonReport.FlatAppearance.BorderSize = 0;
            this.buttonReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReport.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReport.ForeColor = System.Drawing.Color.White;
            this.buttonReport.Image = global::AttendanceManagementSystem.Properties.Resources.report;
            this.buttonReport.Location = new System.Drawing.Point(9, 180);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(271, 63);
            this.buttonReport.TabIndex = 0;
            this.buttonReport.Text = "        Report";
            this.buttonReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonReport.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panelSlide);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 180);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(8, 610);
            this.panel4.TabIndex = 0;
            // 
            // panelSlide
            // 
            this.panelSlide.BackColor = System.Drawing.Color.White;
            this.panelSlide.Location = new System.Drawing.Point(0, 0);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(10, 63);
            this.panelSlide.TabIndex = 0;
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.Indigo;
            this.buttonLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.Color.White;
            this.buttonLogout.Location = new System.Drawing.Point(900, 34);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(78, 35);
            this.buttonLogout.TabIndex = 0;
            this.buttonLogout.Text = "Log out";
            this.buttonLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLogout.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 180);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(85, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Attendance Management ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AttendanceManagementSystem.Properties.Resources.group2;
            this.pictureBox1.Location = new System.Drawing.Point(89, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.BackColor = System.Drawing.Color.Indigo;
            this.buttonMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinimize.ForeColor = System.Drawing.Color.White;
            this.buttonMinimize.Image = global::AttendanceManagementSystem.Properties.Resources.minus_sign;
            this.buttonMinimize.Location = new System.Drawing.Point(842, 34);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(52, 35);
            this.buttonMinimize.TabIndex = 0;
            this.buttonMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMinimize.UseVisualStyleBackColor = false;
            // 
            // panelBack
            // 
            this.panelBack.Controls.Add(this.buttonMinimize);
            this.panelBack.Controls.Add(this.buttonLogout);
            this.panelBack.Controls.Add(this.labelUsername);
            this.panelBack.Controls.Add(this.label4);
            this.panelBack.Controls.Add(this.labelTime);
            this.panelBack.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBack.Location = new System.Drawing.Point(280, 0);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(1277, 180);
            this.panelBack.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(569, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Welcome:";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.Indigo;
            this.labelTime.Location = new System.Drawing.Point(24, 38);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(35, 23);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "{?}";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.buttonReport);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 790);
            this.panel1.TabIndex = 2;
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1557, 790);
            this.Controls.Add(this.panelBack);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormStudent";
            this.Text = "FormStudent";
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelBack.ResumeLayout(false);
            this.panelBack.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerDtaeAndTime;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Panel panelBack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Panel panel1;
    }
}