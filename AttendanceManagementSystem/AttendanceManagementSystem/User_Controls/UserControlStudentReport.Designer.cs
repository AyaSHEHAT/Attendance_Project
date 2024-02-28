namespace AttendanceManagementSystem.User_Controls
{
    partial class UserControlStudentReport
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
            this.dataGridViewCourse = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxDate = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxCourses = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonExcel = new System.Windows.Forms.Button();
            this.buttonPdf = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourse)).BeginInit();
            this.SuspendLayout();
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
            this.Column1,
            this.StdName,
            this.Column3,
            this.Column5,
            this.Column4});
            this.dataGridViewCourse.Location = new System.Drawing.Point(81, 224);
            this.dataGridViewCourse.Name = "dataGridViewCourse";
            this.dataGridViewCourse.ReadOnly = true;
            this.dataGridViewCourse.RowHeadersWidth = 51;
            this.dataGridViewCourse.ShowRowErrors = false;
            this.dataGridViewCourse.Size = new System.Drawing.Size(743, 300);
            this.dataGridViewCourse.TabIndex = 20;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "StdId";
            this.Column1.HeaderText = "Student Id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // StdName
            // 
            this.StdName.DataPropertyName = "StdName";
            this.StdName.HeaderText = "Student Name";
            this.StdName.MinimumWidth = 6;
            this.StdName.Name = "StdName";
            this.StdName.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Date";
            this.Column3.HeaderText = "Date";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "CName";
            this.Column5.HeaderText = "Course Name";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Status";
            this.Column4.HeaderText = "Status";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // comboBoxDate
            // 
            this.comboBoxDate.BackColor = System.Drawing.Color.White;
            this.comboBoxDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxDate.FormattingEnabled = true;
            this.comboBoxDate.Location = new System.Drawing.Point(554, 171);
            this.comboBoxDate.Name = "comboBoxDate";
            this.comboBoxDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxDate.Size = new System.Drawing.Size(270, 24);
            this.comboBoxDate.TabIndex = 19;
            this.comboBoxDate.SelectedIndexChanged += new System.EventHandler(this.comboBoxDate_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Location = new System.Drawing.Point(554, 208);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 2);
            this.panel2.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(550, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Date:";
            // 
            // comboBoxCourses
            // 
            this.comboBoxCourses.BackColor = System.Drawing.Color.White;
            this.comboBoxCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCourses.FormattingEnabled = true;
            this.comboBoxCourses.Location = new System.Drawing.Point(81, 171);
            this.comboBoxCourses.Name = "comboBoxCourses";
            this.comboBoxCourses.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxCourses.Size = new System.Drawing.Size(270, 24);
            this.comboBoxCourses.TabIndex = 16;
            this.comboBoxCourses.SelectedIndexChanged += new System.EventHandler(this.comboBoxCourses_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(81, 208);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 2);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Course Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 27);
            this.label2.TabIndex = 15;
            this.label2.Text = "Report";
            // 
            // buttonExcel
            // 
            this.buttonExcel.BackColor = System.Drawing.Color.Indigo;
            this.buttonExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExcel.Image = global::AttendanceManagementSystem.Properties.Resources.excel_new;
            this.buttonExcel.Location = new System.Drawing.Point(906, 483);
            this.buttonExcel.Name = "buttonExcel";
            this.buttonExcel.Size = new System.Drawing.Size(61, 41);
            this.buttonExcel.TabIndex = 23;
            this.buttonExcel.UseVisualStyleBackColor = false;
            this.buttonExcel.Click += new System.EventHandler(this.buttonExcel_Click);
            // 
            // buttonPdf
            // 
            this.buttonPdf.BackColor = System.Drawing.Color.Indigo;
            this.buttonPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPdf.Image = global::AttendanceManagementSystem.Properties.Resources.icons8_export_pdf_24;
            this.buttonPdf.Location = new System.Drawing.Point(906, 407);
            this.buttonPdf.Name = "buttonPdf";
            this.buttonPdf.Size = new System.Drawing.Size(61, 41);
            this.buttonPdf.TabIndex = 22;
            this.buttonPdf.UseVisualStyleBackColor = false;
            this.buttonPdf.Click += new System.EventHandler(this.buttonPdf_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.Indigo;
            this.buttonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrint.Image = global::AttendanceManagementSystem.Properties.Resources.printer;
            this.buttonPrint.Location = new System.Drawing.Point(885, 79);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(61, 41);
            this.buttonPrint.TabIndex = 21;
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // UserControlStudentReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridViewCourse);
            this.Controls.Add(this.comboBoxDate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxCourses);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonExcel);
            this.Controls.Add(this.buttonPdf);
            this.Controls.Add(this.buttonPrint);
            this.Name = "UserControlStudentReport";
            this.Size = new System.Drawing.Size(1107, 604);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ComboBox comboBoxDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxCourses;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonExcel;
        private System.Windows.Forms.Button buttonPdf;
        private System.Windows.Forms.Button buttonPrint;
    }
}
