namespace AttendanceManagementSystem.Forms
{
    partial class FormTeacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTeacher));
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonReport = new System.Windows.Forms.Button();
            this.buttonAttendance = new System.Windows.Forms.Button();
            this.timerDtaeAndTime = new System.Windows.Forms.Timer(this.components);
            this.panelBack = new System.Windows.Forms.Panel();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.labelUsername = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.btnStTch = new System.Windows.Forms.Button();
            this.userControlAttendance1 = new AttendanceManagementSystem.User_Controls.UserControlAttendance();
            this.userControlSetting = new AttendanceManagementSystem.User_Controls.UserControlSettings();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Indigo;
            this.panel4.Controls.Add(this.panelSlide);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 180);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 540);
            this.panel4.TabIndex = 0;
            // 
            // panelSlide
            // 
            this.panelSlide.BackColor = System.Drawing.Color.White;
            this.panelSlide.Location = new System.Drawing.Point(0, 0);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(12, 75);
            this.panelSlide.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Indigo;
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
            this.label2.Location = new System.Drawing.Point(102, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Attendance Management ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AttendanceManagementSystem.Properties.Resources.group2;
            this.pictureBox1.Location = new System.Drawing.Point(82, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.btnStTch);
            this.panel1.Controls.Add(this.buttonReport);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.buttonAttendance);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 720);
            this.panel1.TabIndex = 4;
            // 
            // buttonReport
            // 
            this.buttonReport.FlatAppearance.BorderSize = 0;
            this.buttonReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReport.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReport.ForeColor = System.Drawing.Color.White;
            this.buttonReport.Image = global::AttendanceManagementSystem.Properties.Resources.report;
            this.buttonReport.Location = new System.Drawing.Point(12, 261);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(260, 75);
            this.buttonReport.TabIndex = 0;
            this.buttonReport.Text = "        Report";
            this.buttonReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // buttonAttendance
            // 
            this.buttonAttendance.FlatAppearance.BorderSize = 0;
            this.buttonAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAttendance.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAttendance.ForeColor = System.Drawing.Color.White;
            this.buttonAttendance.Image = global::AttendanceManagementSystem.Properties.Resources.attendance_list1;
            this.buttonAttendance.Location = new System.Drawing.Point(12, 180);
            this.buttonAttendance.Name = "buttonAttendance";
            this.buttonAttendance.Size = new System.Drawing.Size(260, 75);
            this.buttonAttendance.TabIndex = 1;
            this.buttonAttendance.Text = "        Attendance";
            this.buttonAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAttendance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAttendance.UseVisualStyleBackColor = true;
            this.buttonAttendance.Click += new System.EventHandler(this.buttonAttendance_Click);
            // 
            // timerDtaeAndTime
            // 
            this.timerDtaeAndTime.Tick += new System.EventHandler(this.timerDtaeAndTime_Tick);
            // 
            // panelBack
            // 
            this.panelBack.BackColor = System.Drawing.Color.White;
            this.panelBack.Controls.Add(this.buttonMinimize);
            this.panelBack.Controls.Add(this.buttonLogout);
            this.panelBack.Controls.Add(this.labelUsername);
            this.panelBack.Controls.Add(this.label4);
            this.panelBack.Controls.Add(this.labelTime);
            this.panelBack.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBack.Location = new System.Drawing.Point(280, 0);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(981, 180);
            this.panelBack.TabIndex = 7;
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
            this.buttonMinimize.Location = new System.Drawing.Point(808, 34);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(52, 35);
            this.buttonMinimize.TabIndex = 0;
            this.buttonMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.Indigo;
            this.buttonLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.Color.White;
            this.buttonLogout.Location = new System.Drawing.Point(862, 34);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(78, 35);
            this.buttonLogout.TabIndex = 0;
            this.buttonLogout.Text = "Log out";
            this.buttonLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.Indigo;
            this.labelUsername.Location = new System.Drawing.Point(685, 38);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(28, 19);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "{?}";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(569, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 19);
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
            this.labelTime.Size = new System.Drawing.Size(28, 19);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "{?}";
            // 
            // btnStTch
            // 
            this.btnStTch.FlatAppearance.BorderSize = 0;
            this.btnStTch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStTch.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStTch.ForeColor = System.Drawing.Color.White;
            this.btnStTch.Image = global::AttendanceManagementSystem.Properties.Resources.attendance_list1;
            this.btnStTch.Location = new System.Drawing.Point(10, 323);
            this.btnStTch.Name = "btnStTch";
            this.btnStTch.Size = new System.Drawing.Size(260, 75);
            this.btnStTch.TabIndex = 2;
            this.btnStTch.Text = "       Settings";
            this.btnStTch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStTch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStTch.UseVisualStyleBackColor = true;
            this.btnStTch.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // userControlAttendance1
            // 
            this.userControlAttendance1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlAttendance1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.userControlAttendance1.Location = new System.Drawing.Point(280, 180);
            this.userControlAttendance1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlAttendance1.Name = "userControlAttendance1";
            this.userControlAttendance1.Size = new System.Drawing.Size(981, 540);
            this.userControlAttendance1.TabIndex = 8;
            // 
            // userControlSetting
            // 
            this.userControlSetting.BackColor = System.Drawing.Color.White;
            this.userControlSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlSetting.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlSetting.Location = new System.Drawing.Point(280, 0);
            this.userControlSetting.Margin = new System.Windows.Forms.Padding(5);
            this.userControlSetting.Name = "userControlSetting";
            this.userControlSetting.Size = new System.Drawing.Size(981, 720);
            this.userControlSetting.TabIndex = 6;
            this.userControlSetting.Visible = false;
            // 
            // FormTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1261, 720);
            this.Controls.Add(this.userControlAttendance1);
            this.Controls.Add(this.panelBack);
            this.Controls.Add(this.userControlSetting);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormTeacher_Load);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelBack.ResumeLayout(false);
            this.panelBack.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private User_Controls.UserControlSettings userControlSetting;
        private System.Windows.Forms.Button buttonAttendance;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timerDtaeAndTime;
        private System.Windows.Forms.Panel panelBack;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTime;
        private User_Controls.UserControlTeacherReport userControlTeacherReport1;
        private User_Controls.UserControlTeacherReport userControlTeacherReport2;
        private User_Controls.UserControlAttendance userControlAttendance1;
        private System.Windows.Forms.Button btnStTch;
    }
}