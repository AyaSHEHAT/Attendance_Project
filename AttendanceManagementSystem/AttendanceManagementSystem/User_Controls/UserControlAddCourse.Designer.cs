namespace AttendanceManagementSystem.User_Controls
{
    partial class UserControlAddCourse
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
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControlAddClass = new System.Windows.Forms.TabControl();
            this.tabPageAddClass = new System.Windows.Forms.TabPage();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownSessionNumber = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBoxTeacher = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxCrsName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxCrsId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageSearch = new System.Windows.Forms.TabPage();
            this.lblTotalCourse = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridViewCourse = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUbdate = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dateStartDate = new System.Windows.Forms.DateTimePicker();
            this.upDownSession = new System.Windows.Forms.NumericUpDown();
            this.panel5 = new System.Windows.Forms.Panel();
            this.boxTeacher = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtCourseId = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControlAddClass.SuspendLayout();
            this.tabPageAddClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSessionNumber)).BeginInit();
            this.tabPageSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownSession)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlAddClass
            // 
            this.tabControlAddClass.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlAddClass.Controls.Add(this.tabPageAddClass);
            this.tabControlAddClass.Controls.Add(this.tabPageSearch);
            this.tabControlAddClass.Controls.Add(this.tabPage1);
            this.tabControlAddClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAddClass.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlAddClass.Location = new System.Drawing.Point(0, 0);
            this.tabControlAddClass.Name = "tabControlAddClass";
            this.tabControlAddClass.SelectedIndex = 0;
            this.tabControlAddClass.Size = new System.Drawing.Size(942, 501);
            this.tabControlAddClass.TabIndex = 0;
            // 
            // tabPageAddClass
            // 
            this.tabPageAddClass.BackColor = System.Drawing.Color.White;
            this.tabPageAddClass.Controls.Add(this.buttonAdd);
            this.tabPageAddClass.Controls.Add(this.label6);
            this.tabPageAddClass.Controls.Add(this.label5);
            this.tabPageAddClass.Controls.Add(this.dateTimePickerStartDate);
            this.tabPageAddClass.Controls.Add(this.numericUpDownSessionNumber);
            this.tabPageAddClass.Controls.Add(this.panel3);
            this.tabPageAddClass.Controls.Add(this.comboBoxTeacher);
            this.tabPageAddClass.Controls.Add(this.label4);
            this.tabPageAddClass.Controls.Add(this.panel2);
            this.tabPageAddClass.Controls.Add(this.textBoxCrsName);
            this.tabPageAddClass.Controls.Add(this.label3);
            this.tabPageAddClass.Controls.Add(this.panel1);
            this.tabPageAddClass.Controls.Add(this.textBoxCrsId);
            this.tabPageAddClass.Controls.Add(this.label1);
            this.tabPageAddClass.Controls.Add(this.label2);
            this.tabPageAddClass.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddClass.Name = "tabPageAddClass";
            this.tabPageAddClass.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddClass.Size = new System.Drawing.Size(934, 467);
            this.tabPageAddClass.TabIndex = 0;
            this.tabPageAddClass.Text = "Add Class";
            this.tabPageAddClass.Enter += new System.EventHandler(this.tabPageAddClass_Enter);
            this.tabPageAddClass.Leave += new System.EventHandler(this.tabPageAddClass_Leave);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Indigo;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(557, 317);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(114, 37);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(553, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "No. of Session:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(112, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Start Date:";
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(115, 333);
            this.dateTimePickerStartDate.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerStartDate.MinDate = new System.DateTime(2024, 2, 22, 12, 18, 21, 0);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(270, 28);
            this.dateTimePickerStartDate.TabIndex = 5;
            this.dateTimePickerStartDate.Value = new System.DateTime(2024, 2, 22, 12, 18, 21, 0);
            // 
            // numericUpDownSessionNumber
            // 
            this.numericUpDownSessionNumber.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownSessionNumber.Location = new System.Drawing.Point(557, 239);
            this.numericUpDownSessionNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSessionNumber.Name = "numericUpDownSessionNumber";
            this.numericUpDownSessionNumber.Size = new System.Drawing.Size(266, 28);
            this.numericUpDownSessionNumber.TabIndex = 4;
            this.numericUpDownSessionNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Location = new System.Drawing.Point(116, 265);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(270, 2);
            this.panel3.TabIndex = 0;
            // 
            // comboBoxTeacher
            // 
            this.comboBoxTeacher.BackColor = System.Drawing.Color.White;
            this.comboBoxTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTeacher.FormattingEnabled = true;
            this.comboBoxTeacher.Location = new System.Drawing.Point(115, 236);
            this.comboBoxTeacher.Name = "comboBoxTeacher";
            this.comboBoxTeacher.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxTeacher.Size = new System.Drawing.Size(270, 29);
            this.comboBoxTeacher.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(111, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Assign to Teacher:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Location = new System.Drawing.Point(557, 178);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 2);
            this.panel2.TabIndex = 0;
            // 
            // textBoxCrsName
            // 
            this.textBoxCrsName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCrsName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCrsName.Location = new System.Drawing.Point(557, 151);
            this.textBoxCrsName.Name = "textBoxCrsName";
            this.textBoxCrsName.Size = new System.Drawing.Size(270, 21);
            this.textBoxCrsName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(553, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Course Name:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(115, 178);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 2);
            this.panel1.TabIndex = 0;
            // 
            // textBoxCrsId
            // 
            this.textBoxCrsId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCrsId.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCrsId.Location = new System.Drawing.Point(115, 151);
            this.textBoxCrsId.Name = "textBoxCrsId";
            this.textBoxCrsId.Size = new System.Drawing.Size(270, 21);
            this.textBoxCrsId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Add Course";
            // 
            // tabPageSearch
            // 
            this.tabPageSearch.BackColor = System.Drawing.Color.White;
            this.tabPageSearch.Controls.Add(this.lblTotalCourse);
            this.tabPageSearch.Controls.Add(this.label9);
            this.tabPageSearch.Controls.Add(this.dataGridViewCourse);
            this.tabPageSearch.Controls.Add(this.pictureBox1);
            this.tabPageSearch.Controls.Add(this.panel4);
            this.tabPageSearch.Controls.Add(this.txtSearch);
            this.tabPageSearch.Controls.Add(this.label7);
            this.tabPageSearch.Controls.Add(this.label8);
            this.tabPageSearch.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearch.Name = "tabPageSearch";
            this.tabPageSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearch.Size = new System.Drawing.Size(934, 467);
            this.tabPageSearch.TabIndex = 1;
            this.tabPageSearch.Text = "Search course";
            this.tabPageSearch.Enter += new System.EventHandler(this.tabPageSearch_Enter);
            this.tabPageSearch.Leave += new System.EventHandler(this.tabPageSearch_Leave);
            // 
            // lblTotalCourse
            // 
            this.lblTotalCourse.AutoSize = true;
            this.lblTotalCourse.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCourse.Location = new System.Drawing.Point(844, 447);
            this.lblTotalCourse.Name = "lblTotalCourse";
            this.lblTotalCourse.Size = new System.Drawing.Size(35, 23);
            this.lblTotalCourse.TabIndex = 9;
            this.lblTotalCourse.Text = "(?)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(737, 449);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "Total Courses:";
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
            this.CourseName,
            this.Column3,
            this.Column5,
            this.Column4});
            this.dataGridViewCourse.Location = new System.Drawing.Point(31, 131);
            this.dataGridViewCourse.Name = "dataGridViewCourse";
            this.dataGridViewCourse.ReadOnly = true;
            this.dataGridViewCourse.RowHeadersWidth = 51;
            this.dataGridViewCourse.ShowRowErrors = false;
            this.dataGridViewCourse.Size = new System.Drawing.Size(872, 318);
            this.dataGridViewCourse.TabIndex = 7;
            this.dataGridViewCourse.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCourse_CellClick);
            this.dataGridViewCourse.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCourse_CellDoubleClick);
            this.dataGridViewCourse.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewCourse_DataError);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CourseId";
            this.Column1.HeaderText = "Course Id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // CourseName
            // 
            this.CourseName.DataPropertyName = "CourseName";
            this.CourseName.HeaderText = "Course Name";
            this.CourseName.MinimumWidth = 6;
            this.CourseName.Name = "CourseName";
            this.CourseName.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Sessions";
            this.Column3.HeaderText = "No. of Sessions";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Date";
            this.Column5.HeaderText = "Start Date";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Teacher";
            this.Column4.HeaderText = "Teacher ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pictureBox1.Image = global::AttendanceManagementSystem.Properties.Resources.magnify;
            this.pictureBox1.Location = new System.Drawing.Point(398, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Location = new System.Drawing.Point(153, 104);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(270, 2);
            this.panel4.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(153, 77);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(270, 21);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(150, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 19);
            this.label7.TabIndex = 3;
            this.label7.Text = "Course Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Indigo;
            this.label8.Location = new System.Drawing.Point(4, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 27);
            this.label8.TabIndex = 4;
            this.label8.Text = "Search :";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.btnUbdate);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.dateStartDate);
            this.tabPage1.Controls.Add(this.upDownSession);
            this.tabPage1.Controls.Add(this.panel5);
            this.tabPage1.Controls.Add(this.boxTeacher);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.panel6);
            this.tabPage1.Controls.Add(this.txtCourseName);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.panel7);
            this.tabPage1.Controls.Add(this.txtCourseId);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(934, 467);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Update and Delete";
            this.tabPage1.Leave += new System.EventHandler(this.tabPage1_Leave);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.Firebrick;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(709, 318);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(114, 37);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUbdate
            // 
            this.btnUbdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUbdate.BackColor = System.Drawing.Color.Indigo;
            this.btnUbdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUbdate.FlatAppearance.BorderSize = 0;
            this.btnUbdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUbdate.ForeColor = System.Drawing.Color.White;
            this.btnUbdate.Location = new System.Drawing.Point(557, 318);
            this.btnUbdate.Name = "btnUbdate";
            this.btnUbdate.Size = new System.Drawing.Size(114, 37);
            this.btnUbdate.TabIndex = 21;
            this.btnUbdate.Text = "Update";
            this.btnUbdate.UseVisualStyleBackColor = false;
            this.btnUbdate.Click += new System.EventHandler(this.btnUbdate_Click);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(553, 215);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 19);
            this.label11.TabIndex = 7;
            this.label11.Text = "No. of Session:";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(112, 303);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 19);
            this.label12.TabIndex = 8;
            this.label12.Text = "Start Date:";
            // 
            // dateStartDate
            // 
            this.dateStartDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateStartDate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateStartDate.Location = new System.Drawing.Point(115, 334);
            this.dateStartDate.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.dateStartDate.MinDate = new System.DateTime(2024, 2, 19, 0, 0, 0, 0);
            this.dateStartDate.Name = "dateStartDate";
            this.dateStartDate.Size = new System.Drawing.Size(270, 28);
            this.dateStartDate.TabIndex = 20;
            // 
            // upDownSession
            // 
            this.upDownSession.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.upDownSession.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upDownSession.Location = new System.Drawing.Point(557, 240);
            this.upDownSession.Name = "upDownSession";
            this.upDownSession.Size = new System.Drawing.Size(266, 28);
            this.upDownSession.TabIndex = 19;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.BackColor = System.Drawing.Color.LightGray;
            this.panel5.Location = new System.Drawing.Point(116, 266);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(270, 2);
            this.panel5.TabIndex = 9;
            // 
            // boxTeacher
            // 
            this.boxTeacher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boxTeacher.BackColor = System.Drawing.Color.White;
            this.boxTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boxTeacher.FormattingEnabled = true;
            this.boxTeacher.Location = new System.Drawing.Point(115, 237);
            this.boxTeacher.Name = "boxTeacher";
            this.boxTeacher.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boxTeacher.Size = new System.Drawing.Size(270, 29);
            this.boxTeacher.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(111, 215);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(159, 19);
            this.label13.TabIndex = 10;
            this.label13.Text = "Assign to Teacher:";
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.BackColor = System.Drawing.Color.LightGray;
            this.panel6.Location = new System.Drawing.Point(557, 179);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(270, 2);
            this.panel6.TabIndex = 11;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCourseName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCourseName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseName.Location = new System.Drawing.Point(557, 152);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(270, 21);
            this.txtCourseName.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(553, 123);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(128, 19);
            this.label14.TabIndex = 12;
            this.label14.Text = "Course Name:";
            // 
            // panel7
            // 
            this.panel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel7.BackColor = System.Drawing.Color.LightGray;
            this.panel7.Location = new System.Drawing.Point(115, 179);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(270, 2);
            this.panel7.TabIndex = 13;
            // 
            // txtCourseId
            // 
            this.txtCourseId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCourseId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCourseId.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseId.Location = new System.Drawing.Point(115, 152);
            this.txtCourseId.Name = "txtCourseId";
            this.txtCourseId.Size = new System.Drawing.Size(270, 21);
            this.txtCourseId.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(112, 123);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 19);
            this.label15.TabIndex = 14;
            this.label15.Text = "Course ID:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Indigo;
            this.label16.Location = new System.Drawing.Point(6, 3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(309, 27);
            this.label16.TabIndex = 15;
            this.label16.Text = "Update and Delete Course";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // UserControlAddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlAddClass);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlAddCourse";
            this.Size = new System.Drawing.Size(942, 501);
            this.tabControlAddClass.ResumeLayout(false);
            this.tabPageAddClass.ResumeLayout(false);
            this.tabPageAddClass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSessionNumber)).EndInit();
            this.tabPageSearch.ResumeLayout(false);
            this.tabPageSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownSession)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.TabControl tabControlAddClass;
        public System.Windows.Forms.TabPage tabPageAddClass;
        public System.Windows.Forms.TabPage tabPageSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxCrsId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxCrsName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxTeacher;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown numericUpDownSessionNumber;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewCourse;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTotalCourse;
        private System.Windows.Forms.Button btnUbdate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateStartDate;
        private System.Windows.Forms.NumericUpDown upDownSession;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox boxTeacher;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtCourseId;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
