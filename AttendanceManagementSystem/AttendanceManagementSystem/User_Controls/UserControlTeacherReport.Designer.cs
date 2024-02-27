namespace AttendanceManagementSystem.User_Controls
{
    partial class UserControlTeacherReport
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
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBoxCourses = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewCourse = new System.Windows.Forms.DataGridView();
            this.stdId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxDate = new System.Windows.Forms.ComboBox();
            this.buttonPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Indigo;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 27);
            this.label8.TabIndex = 8;
            this.label8.Text = "Student Report :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(639, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Date:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Location = new System.Drawing.Point(88, 142);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(270, 2);
            this.panel3.TabIndex = 11;
            // 
            // comboBoxCourses
            // 
            this.comboBoxCourses.BackColor = System.Drawing.Color.White;
            this.comboBoxCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCourses.FormattingEnabled = true;
            this.comboBoxCourses.Location = new System.Drawing.Point(87, 113);
            this.comboBoxCourses.Name = "comboBoxCourses";
            this.comboBoxCourses.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxCourses.Size = new System.Drawing.Size(270, 24);
            this.comboBoxCourses.TabIndex = 13;
            this.comboBoxCourses.SelectedIndexChanged += new System.EventHandler(this.comboBoxCourses_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Course :";
            // 
            // dataGridViewCourse
            // 
            this.dataGridViewCourse.AllowUserToAddRows = false;
            this.dataGridViewCourse.AllowUserToDeleteRows = false;
            this.dataGridViewCourse.AllowUserToResizeColumns = false;
            this.dataGridViewCourse.AllowUserToResizeRows = false;
            this.dataGridViewCourse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCourse.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCourse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCourse.ColumnHeadersHeight = 30;
            this.dataGridViewCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewCourse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stdId,
            this.StdName,
            this.crsName,
            this.date,
            this.status});
            this.dataGridViewCourse.Location = new System.Drawing.Point(86, 175);
            this.dataGridViewCourse.Name = "dataGridViewCourse";
            this.dataGridViewCourse.ReadOnly = true;
            this.dataGridViewCourse.RowHeadersWidth = 51;
            this.dataGridViewCourse.ShowRowErrors = false;
            this.dataGridViewCourse.Size = new System.Drawing.Size(826, 360);
            this.dataGridViewCourse.TabIndex = 15;
            // 
            // stdId
            // 
            this.stdId.DataPropertyName = "StdId";
            this.stdId.HeaderText = "Student Id";
            this.stdId.MinimumWidth = 6;
            this.stdId.Name = "stdId";
            this.stdId.ReadOnly = true;
            // 
            // StdName
            // 
            this.StdName.DataPropertyName = "StdName";
            this.StdName.HeaderText = "Student Name";
            this.StdName.MinimumWidth = 6;
            this.StdName.Name = "StdName";
            this.StdName.ReadOnly = true;
            // 
            // crsName
            // 
            this.crsName.DataPropertyName = "CName";
            this.crsName.HeaderText = "Course Name";
            this.crsName.MinimumWidth = 6;
            this.crsName.Name = "crsName";
            this.crsName.ReadOnly = true;
            // 
            // date
            // 
            this.date.DataPropertyName = "Date";
            this.date.HeaderText = "Date";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // status
            // 
            this.status.DataPropertyName = "Status";
            this.status.HeaderText = "Status";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(643, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 2);
            this.panel1.TabIndex = 16;
            // 
            // comboBoxDate
            // 
            this.comboBoxDate.BackColor = System.Drawing.Color.White;
            this.comboBoxDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBoxDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxDate.FormattingEnabled = true;
            this.comboBoxDate.Location = new System.Drawing.Point(642, 113);
            this.comboBoxDate.Name = "comboBoxDate";
            this.comboBoxDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxDate.Size = new System.Drawing.Size(270, 24);
            this.comboBoxDate.TabIndex = 17;
            this.comboBoxDate.SelectedIndexChanged += new System.EventHandler(this.comboBoxDate_SelectedIndexChanged_1);
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.Indigo;
            this.buttonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrint.ForeColor = System.Drawing.Color.Indigo;
            this.buttonPrint.Image = global::AttendanceManagementSystem.Properties.Resources.printer;
            this.buttonPrint.Location = new System.Drawing.Point(934, 6);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(49, 36);
            this.buttonPrint.TabIndex = 18;
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // UserControlTeacherReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBoxDate);
            this.Controls.Add(this.dataGridViewCourse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.comboBoxCourses);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Name = "UserControlTeacherReport";
            this.Size = new System.Drawing.Size(1031, 538);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBoxCourses;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewCourse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn crsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.Button buttonPrint;
    }
}
