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
            this.tabPageSearch = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCrsId = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxCrsName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxTeacher = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.numericUpDownSessionNumber = new System.Windows.Forms.NumericUpDown();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControlAddClass.SuspendLayout();
            this.tabPageAddClass.SuspendLayout();
            this.tabPageSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSessionNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlAddClass
            // 
            this.tabControlAddClass.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlAddClass.Controls.Add(this.tabPageAddClass);
            this.tabControlAddClass.Controls.Add(this.tabPageSearch);
            this.tabControlAddClass.Controls.Add(this.tabPage1);
            this.tabControlAddClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAddClass.Location = new System.Drawing.Point(0, 0);
            this.tabControlAddClass.Name = "tabControlAddClass";
            this.tabControlAddClass.SelectedIndex = 0;
            this.tabControlAddClass.Size = new System.Drawing.Size(942, 501);
            this.tabControlAddClass.TabIndex = 0;
            // 
            // tabPageAddClass
            // 
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
            this.tabPageAddClass.Size = new System.Drawing.Size(934, 465);
            this.tabPageAddClass.TabIndex = 0;
            this.tabPageAddClass.Text = "Add Class";
            this.tabPageAddClass.UseVisualStyleBackColor = true;
            // 
            // tabPageSearch
            // 
            this.tabPageSearch.Controls.Add(this.pictureBox1);
            this.tabPageSearch.Controls.Add(this.panel4);
            this.tabPageSearch.Controls.Add(this.textBox1);
            this.tabPageSearch.Controls.Add(this.label7);
            this.tabPageSearch.Controls.Add(this.label8);
            this.tabPageSearch.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearch.Name = "tabPageSearch";
            this.tabPageSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearch.Size = new System.Drawing.Size(934, 465);
            this.tabPageSearch.TabIndex = 1;
            this.tabPageSearch.Text = "Search";
            this.tabPageSearch.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Add Course";
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
            // textBoxCrsId
            // 
            this.textBoxCrsId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCrsId.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCrsId.Location = new System.Drawing.Point(115, 151);
            this.textBoxCrsId.Name = "textBoxCrsId";
            this.textBoxCrsId.Size = new System.Drawing.Size(270, 21);
            this.textBoxCrsId.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(115, 178);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 2);
            this.panel1.TabIndex = 0;
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
            // comboBoxTeacher
            // 
            this.comboBoxTeacher.BackColor = System.Drawing.Color.White;
            this.comboBoxTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTeacher.FormattingEnabled = true;
            this.comboBoxTeacher.Location = new System.Drawing.Point(115, 236);
            this.comboBoxTeacher.Name = "comboBoxTeacher";
            this.comboBoxTeacher.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxTeacher.Size = new System.Drawing.Size(270, 31);
            this.comboBoxTeacher.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Location = new System.Drawing.Point(116, 265);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(270, 2);
            this.panel3.TabIndex = 0;
            // 
            // numericUpDownSessionNumber
            // 
            this.numericUpDownSessionNumber.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownSessionNumber.Location = new System.Drawing.Point(557, 239);
            this.numericUpDownSessionNumber.Name = "numericUpDownSessionNumber";
            this.numericUpDownSessionNumber.Size = new System.Drawing.Size(266, 28);
            this.numericUpDownSessionNumber.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(115, 333);
            this.dateTimePickerStartDate.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerStartDate.MinDate = new System.DateTime(2024, 2, 19, 0, 0, 0, 0);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(270, 28);
            this.dateTimePickerStartDate.TabIndex = 5;
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
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(934, 465);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Update and Delete";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Location = new System.Drawing.Point(112, 178);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(270, 2);
            this.panel4.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(112, 151);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(270, 21);
            this.textBox1.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(109, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 19);
            this.label7.TabIndex = 3;
            this.label7.Text = "Course ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Indigo;
            this.label8.Location = new System.Drawing.Point(4, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 23);
            this.label8.TabIndex = 4;
            this.label8.Text = "Search Class";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AttendanceManagementSystem.Properties.Resources.magnify;
            this.pictureBox1.Location = new System.Drawing.Point(357, 147);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
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
            this.tabPageSearch.ResumeLayout(false);
            this.tabPageSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSessionNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabControl tabControlAddClass;
        private System.Windows.Forms.TabPage tabPageAddClass;
        private System.Windows.Forms.TabPage tabPageSearch;
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
