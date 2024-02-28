namespace AttendanceManagementSystem.User_Controls
{
    partial class UserControlAddUser
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
            this.tabControlAddUser = new System.Windows.Forms.TabControl();
            this.tabPageAdduser = new System.Windows.Forms.TabPage();
            this.panelRole = new System.Windows.Forms.Panel();
            this.radioBtnStudent = new System.Windows.Forms.RadioButton();
            this.radioBtnTeacher = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxUserAddress = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBoxUserID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxUserPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageSearch = new System.Windows.Forms.TabPage();
            this.tabPageUpdateandDelete = new System.Windows.Forms.TabPage();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownAge = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControlAddUser.SuspendLayout();
            this.tabPageAdduser.SuspendLayout();
            this.panelRole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlAddUser
            // 
            this.tabControlAddUser.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlAddUser.Controls.Add(this.tabPageAdduser);
            this.tabControlAddUser.Controls.Add(this.tabPageSearch);
            this.tabControlAddUser.Controls.Add(this.tabPageUpdateandDelete);
            this.tabControlAddUser.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabControlAddUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAddUser.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlAddUser.Location = new System.Drawing.Point(0, 0);
            this.tabControlAddUser.Name = "tabControlAddUser";
            this.tabControlAddUser.SelectedIndex = 0;
            this.tabControlAddUser.Size = new System.Drawing.Size(942, 501);
            this.tabControlAddUser.TabIndex = 0;
            this.tabControlAddUser.Leave += new System.EventHandler(this.tabControlAddUser_Leave);
            // 
            // tabPageAdduser
            // 
            this.tabPageAdduser.BackColor = System.Drawing.Color.White;
            this.tabPageAdduser.Controls.Add(this.panel3);
            this.tabPageAdduser.Controls.Add(this.numericUpDownAge);
            this.tabPageAdduser.Controls.Add(this.label8);
            this.tabPageAdduser.Controls.Add(this.panelRole);
            this.tabPageAdduser.Controls.Add(this.label4);
            this.tabPageAdduser.Controls.Add(this.textBoxUserAddress);
            this.tabPageAdduser.Controls.Add(this.panel6);
            this.tabPageAdduser.Controls.Add(this.panel5);
            this.tabPageAdduser.Controls.Add(this.textBoxUserID);
            this.tabPageAdduser.Controls.Add(this.label7);
            this.tabPageAdduser.Controls.Add(this.textBoxEmail);
            this.tabPageAdduser.Controls.Add(this.panel4);
            this.tabPageAdduser.Controls.Add(this.buttonAdd);
            this.tabPageAdduser.Controls.Add(this.label6);
            this.tabPageAdduser.Controls.Add(this.label5);
            this.tabPageAdduser.Controls.Add(this.panel2);
            this.tabPageAdduser.Controls.Add(this.textBoxUserPass);
            this.tabPageAdduser.Controls.Add(this.label3);
            this.tabPageAdduser.Controls.Add(this.panel1);
            this.tabPageAdduser.Controls.Add(this.textBoxUserName);
            this.tabPageAdduser.Controls.Add(this.label1);
            this.tabPageAdduser.Controls.Add(this.label2);
            this.tabPageAdduser.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageAdduser.Location = new System.Drawing.Point(4, 4);
            this.tabPageAdduser.Name = "tabPageAdduser";
            this.tabPageAdduser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdduser.Size = new System.Drawing.Size(934, 467);
            this.tabPageAdduser.TabIndex = 0;
            this.tabPageAdduser.Text = "Add User";
            this.tabPageAdduser.Click += new System.EventHandler(this.tabPageAdduser_Click);
            // 
            // panelRole
            // 
            this.panelRole.BackColor = System.Drawing.Color.White;
            this.panelRole.Controls.Add(this.radioBtnStudent);
            this.panelRole.Controls.Add(this.radioBtnTeacher);
            this.panelRole.Location = new System.Drawing.Point(591, 278);
            this.panelRole.Name = "panelRole";
            this.panelRole.Size = new System.Drawing.Size(200, 100);
            this.panelRole.TabIndex = 6;
            // 
            // radioBtnStudent
            // 
            this.radioBtnStudent.AutoSize = true;
            this.radioBtnStudent.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnStudent.Location = new System.Drawing.Point(22, 56);
            this.radioBtnStudent.Name = "radioBtnStudent";
            this.radioBtnStudent.Size = new System.Drawing.Size(89, 23);
            this.radioBtnStudent.TabIndex = 1;
            this.radioBtnStudent.TabStop = true;
            this.radioBtnStudent.Text = "Student";
            this.radioBtnStudent.UseVisualStyleBackColor = true;
            this.radioBtnStudent.CheckedChanged += new System.EventHandler(this.radioBtnStudent_CheckedChanged);
            // 
            // radioBtnTeacher
            // 
            this.radioBtnTeacher.AutoSize = true;
            this.radioBtnTeacher.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnTeacher.Location = new System.Drawing.Point(22, 22);
            this.radioBtnTeacher.Name = "radioBtnTeacher";
            this.radioBtnTeacher.Size = new System.Drawing.Size(96, 23);
            this.radioBtnTeacher.TabIndex = 0;
            this.radioBtnTeacher.TabStop = true;
            this.radioBtnTeacher.Text = "Teacher";
            this.radioBtnTeacher.UseVisualStyleBackColor = true;
            this.radioBtnTeacher.CheckedChanged += new System.EventHandler(this.radioBtnTeacher_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(535, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Role:";
            // 
            // textBoxUserAddress
            // 
            this.textBoxUserAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUserAddress.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserAddress.Location = new System.Drawing.Point(112, 330);
            this.textBoxUserAddress.Name = "textBoxUserAddress";
            this.textBoxUserAddress.Size = new System.Drawing.Size(270, 21);
            this.textBoxUserAddress.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightGray;
            this.panel6.Location = new System.Drawing.Point(112, 357);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(270, 2);
            this.panel6.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightGray;
            this.panel5.Location = new System.Drawing.Point(539, 178);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(270, 2);
            this.panel5.TabIndex = 0;
            // 
            // textBoxUserID
            // 
            this.textBoxUserID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUserID.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserID.Location = new System.Drawing.Point(539, 151);
            this.textBoxUserID.Name = "textBoxUserID";
            this.textBoxUserID.Size = new System.Drawing.Size(270, 21);
            this.textBoxUserID.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(535, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "ID:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmail.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(112, 243);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(270, 21);
            this.textBoxEmail.TabIndex = 3;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Location = new System.Drawing.Point(112, 270);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(270, 2);
            this.panel4.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Indigo;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(551, 411);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(114, 37);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(108, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(109, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Address:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Location = new System.Drawing.Point(539, 270);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 2);
            this.panel2.TabIndex = 0;
            // 
            // textBoxUserPass
            // 
            this.textBoxUserPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUserPass.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserPass.Location = new System.Drawing.Point(539, 243);
            this.textBoxUserPass.Name = "textBoxUserPass";
            this.textBoxUserPass.Size = new System.Drawing.Size(270, 21);
            this.textBoxUserPass.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(535, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(112, 178);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 2);
            this.panel1.TabIndex = 0;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUserName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserName.Location = new System.Drawing.Point(112, 151);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(270, 21);
            this.textBoxUserName.TabIndex = 1;
            this.textBoxUserName.TextChanged += new System.EventHandler(this.textBoxUserName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Add User";
            // 
            // tabPageSearch
            // 
            this.tabPageSearch.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearch.Name = "tabPageSearch";
            this.tabPageSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearch.Size = new System.Drawing.Size(934, 467);
            this.tabPageSearch.TabIndex = 1;
            this.tabPageSearch.Text = "Search";
            this.tabPageSearch.UseVisualStyleBackColor = true;
            this.tabPageSearch.Click += new System.EventHandler(this.tabPageSearch_Click);
            // 
            // tabPageUpdateandDelete
            // 
            this.tabPageUpdateandDelete.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageUpdateandDelete.Location = new System.Drawing.Point(4, 4);
            this.tabPageUpdateandDelete.Name = "tabPageUpdateandDelete";
            this.tabPageUpdateandDelete.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdateandDelete.Size = new System.Drawing.Size(934, 467);
            this.tabPageUpdateandDelete.TabIndex = 2;
            this.tabPageUpdateandDelete.Text = "Update and delete";
            this.tabPageUpdateandDelete.UseVisualStyleBackColor = true;
            this.tabPageUpdateandDelete.Click += new System.EventHandler(this.tabPageUpdateandDelete_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(109, 386);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 19);
            this.label8.TabIndex = 9;
            this.label8.Text = "Age:";
            // 
            // numericUpDownAge
            // 
            this.numericUpDownAge.Location = new System.Drawing.Point(113, 411);
            this.numericUpDownAge.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numericUpDownAge.Minimum = new decimal(new int[] {
            19,
            0,
            0,
            0});
            this.numericUpDownAge.Name = "numericUpDownAge";
            this.numericUpDownAge.Size = new System.Drawing.Size(267, 28);
            this.numericUpDownAge.TabIndex = 10;
            this.numericUpDownAge.Value = new decimal(new int[] {
            19,
            0,
            0,
            0});
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Location = new System.Drawing.Point(113, 445);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(270, 2);
            this.panel3.TabIndex = 11;
            // 
            // UserControlAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlAddUser);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlAddUser";
            this.Size = new System.Drawing.Size(942, 501);
            this.tabControlAddUser.ResumeLayout(false);
            this.tabPageAdduser.ResumeLayout(false);
            this.tabPageAdduser.PerformLayout();
            this.panelRole.ResumeLayout(false);
            this.panelRole.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAddUser;
        private System.Windows.Forms.TabPage tabPageAdduser;
        private System.Windows.Forms.TabPage tabPageSearch;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxUserPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBoxUserID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxUserAddress;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioBtnStudent;
        private System.Windows.Forms.RadioButton radioBtnTeacher;
        private System.Windows.Forms.Panel panelRole;
        private System.Windows.Forms.TabPage tabPageUpdateandDelete;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown numericUpDownAge;
        private System.Windows.Forms.Label label8;
    }
}
