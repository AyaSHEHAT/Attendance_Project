namespace AttendanceManagementSystem.User_Controls
{
    partial class UserControlAttendance
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
            this.tabPageMarkAttendance = new System.Windows.Forms.TabPage();
            this.dataGridViewAttendance = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attended = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageMarkAttendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttendance)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageMarkAttendance
            // 
            this.tabPageMarkAttendance.Controls.Add(this.dataGridViewAttendance);
            this.tabPageMarkAttendance.Controls.Add(this.label12);
            this.tabPageMarkAttendance.Controls.Add(this.dateTimePickerDate);
            this.tabPageMarkAttendance.Controls.Add(this.panel3);
            this.tabPageMarkAttendance.Controls.Add(this.comboBoxClass);
            this.tabPageMarkAttendance.Controls.Add(this.label4);
            this.tabPageMarkAttendance.Controls.Add(this.label2);
            this.tabPageMarkAttendance.Location = new System.Drawing.Point(4, 4);
            this.tabPageMarkAttendance.Name = "tabPageMarkAttendance";
            this.tabPageMarkAttendance.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMarkAttendance.Size = new System.Drawing.Size(934, 471);
            this.tabPageMarkAttendance.TabIndex = 0;
            this.tabPageMarkAttendance.Text = "Mark Attendance";
            this.tabPageMarkAttendance.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAttendance
            // 
            this.dataGridViewAttendance.AllowUserToAddRows = false;
            this.dataGridViewAttendance.AllowUserToDeleteRows = false;
            this.dataGridViewAttendance.AllowUserToResizeColumns = false;
            this.dataGridViewAttendance.AllowUserToResizeRows = false;
            this.dataGridViewAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAttendance.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewAttendance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewAttendance.ColumnHeadersHeight = 30;
            this.dataGridViewAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewAttendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CourseName,
            this.Column3,
            this.attended,
            this.Column4});
            this.dataGridViewAttendance.Location = new System.Drawing.Point(31, 131);
            this.dataGridViewAttendance.Name = "dataGridViewAttendance";
            this.dataGridViewAttendance.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewAttendance.ShowRowErrors = false;
            this.dataGridViewAttendance.Size = new System.Drawing.Size(872, 318);
            this.dataGridViewAttendance.TabIndex = 0;
            this.dataGridViewAttendance.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAttendance_CellContentClick_1);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Student Id";
            this.ID.Name = "ID";
            // 
            // CourseName
            // 
            this.CourseName.DataPropertyName = "CourseName";
            this.CourseName.HeaderText = "Student Name";
            this.CourseName.Name = "CourseName";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Sessions";
            this.Column3.HeaderText = "Email";
            this.Column3.Name = "Column3";
            // 
            // attended
            // 
            this.attended.DataPropertyName = "attended";
            this.attended.FillWeight = 50F;
            this.attended.HeaderText = "Attended";
            this.attended.Name = "attended";
            this.attended.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.attended.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "absent";
            this.Column4.FillWeight = 50F;
            this.Column4.HeaderText = "Absent";
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(78, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Session Date";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerDate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDate.Location = new System.Drawing.Point(81, 77);
            this.dateTimePickerDate.MaxDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerDate.MinDate = new System.DateTime(2024, 2, 19, 0, 0, 0, 0);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(270, 24);
            this.dateTimePickerDate.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Location = new System.Drawing.Point(549, 99);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(270, 2);
            this.panel3.TabIndex = 0;
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.BackColor = System.Drawing.Color.White;
            this.comboBoxClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Location = new System.Drawing.Point(549, 73);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxClass.Size = new System.Drawing.Size(270, 25);
            this.comboBoxClass.TabIndex = 0;
            this.comboBoxClass.SelectedIndexChanged += new System.EventHandler(this.comboBoxClass_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(546, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Course Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mark Attendance";
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl1.Controls.Add(this.tabPageMarkAttendance);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(942, 501);
            this.tabControl1.TabIndex = 1;
            // 
            // UserControlAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserControlAttendance";
            this.Size = new System.Drawing.Size(942, 501);
            this.Load += new System.EventHandler(this.tabPageMarkAttendance_Load);
            this.tabPageMarkAttendance.ResumeLayout(false);
            this.tabPageMarkAttendance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttendance)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageMarkAttendance;
        private System.Windows.Forms.DataGridView dataGridViewAttendance;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn attended;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBoxClass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
    }
}
