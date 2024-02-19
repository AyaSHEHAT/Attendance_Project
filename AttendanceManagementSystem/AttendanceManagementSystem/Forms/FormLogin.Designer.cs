namespace AttendanceManagementSystem.Forms
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.pictureBoxError = new System.Windows.Forms.PictureBox();
            this.labelError = new System.Windows.Forms.Label();
            this.pictureBoxShow = new System.Windows.Forms.PictureBox();
            this.pictureBoxHide = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxUserId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxMinimize = new System.Windows.Forms.PictureBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.textBoxPassword);
            this.groupBox1.Controls.Add(this.pictureBoxError);
            this.groupBox1.Controls.Add(this.labelError);
            this.groupBox1.Controls.Add(this.pictureBoxShow);
            this.groupBox1.Controls.Add(this.pictureBoxHide);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonLogin);
            this.groupBox1.Controls.Add(this.textBoxUserId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.groupBox1.Location = new System.Drawing.Point(107, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 376);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(95, 177);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(241, 24);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPassword_KeyPress);
            this.textBoxPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxPassword_KeyUp);
            // 
            // pictureBoxError
            // 
            this.pictureBoxError.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxError.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxError.Image = global::AttendanceManagementSystem.Properties.Resources.important;
            this.pictureBoxError.Location = new System.Drawing.Point(93, 215);
            this.pictureBoxError.Name = "pictureBoxError";
            this.pictureBoxError.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxError.TabIndex = 2;
            this.pictureBoxError.TabStop = false;
            this.pictureBoxError.Click += new System.EventHandler(this.pictureBoxError_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelError.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.labelError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.labelError.Location = new System.Drawing.Point(131, 219);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(187, 19);
            this.labelError.TabIndex = 5;
            this.labelError.Text = "Invalid User Id or Password";
            // 
            // pictureBoxShow
            // 
            this.pictureBoxShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxShow.Image = global::AttendanceManagementSystem.Properties.Resources.eye_1_;
            this.pictureBoxShow.Location = new System.Drawing.Point(335, 177);
            this.pictureBoxShow.Name = "pictureBoxShow";
            this.pictureBoxShow.Size = new System.Drawing.Size(25, 24);
            this.pictureBoxShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxShow.TabIndex = 4;
            this.pictureBoxShow.TabStop = false;
            this.pictureBoxShow.Click += new System.EventHandler(this.pictureBoxShow_Click);
            this.pictureBoxShow.MouseHover += new System.EventHandler(this.pictureBoxShow_MouseHover);
            // 
            // pictureBoxHide
            // 
            this.pictureBoxHide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxHide.Image = global::AttendanceManagementSystem.Properties.Resources.hide;
            this.pictureBoxHide.Location = new System.Drawing.Point(335, 177);
            this.pictureBoxHide.Name = "pictureBoxHide";
            this.pictureBoxHide.Size = new System.Drawing.Size(25, 24);
            this.pictureBoxHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHide.TabIndex = 2;
            this.pictureBoxHide.TabStop = false;
            this.pictureBoxHide.Click += new System.EventHandler(this.pictureBocHide_Click);
            this.pictureBoxHide.MouseHover += new System.EventHandler(this.pictureBoxHide_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(92, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(93, 290);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(265, 38);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxUserId
            // 
            this.textBoxUserId.Location = new System.Drawing.Point(95, 92);
            this.textBoxUserId.Name = "textBoxUserId";
            this.textBoxUserId.Size = new System.Drawing.Size(265, 24);
            this.textBoxUserId.TabIndex = 1;
            this.textBoxUserId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBoxUserId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUserId_KeyPress);
            this.textBoxUserId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxUserId_KeyUP);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(92, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "USER ID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(722, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 508);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = global::AttendanceManagementSystem.Properties.Resources.group_colored1;
            this.pictureBox1.Location = new System.Drawing.Point(840, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxMinimize
            // 
            this.pictureBoxMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMinimize.Image = global::AttendanceManagementSystem.Properties.Resources.images__1_;
            this.pictureBoxMinimize.Location = new System.Drawing.Point(1073, 21);
            this.pictureBoxMinimize.Name = "pictureBoxMinimize";
            this.pictureBoxMinimize.Size = new System.Drawing.Size(31, 31);
            this.pictureBoxMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMinimize.TabIndex = 1;
            this.pictureBoxMinimize.TabStop = false;
            this.pictureBoxMinimize.Click += new System.EventHandler(this.pictureBoxMinimize_Click);
            this.pictureBoxMinimize.MouseHover += new System.EventHandler(this.pictureBoxMinimize_MouseHover);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxClose.Image = global::AttendanceManagementSystem.Properties.Resources.images1;
            this.pictureBoxClose.Location = new System.Drawing.Point(1121, 21);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(31, 31);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 0;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBoxClose.MouseHover += new System.EventHandler(this.pictureBoxClose_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(126)))));
            this.label3.Location = new System.Drawing.Point(789, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(326, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Attendance Managment System";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxMinimize);
            this.Controls.Add(this.pictureBoxClose);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.PictureBox pictureBoxMinimize;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxUserId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxHide;
        private System.Windows.Forms.PictureBox pictureBoxShow;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.PictureBox pictureBoxError;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip;
    }
}