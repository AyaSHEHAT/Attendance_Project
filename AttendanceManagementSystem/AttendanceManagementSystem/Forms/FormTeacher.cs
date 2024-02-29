using AttendanceManagementSystem.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AttendanceManagementSystem.Forms
{
    public partial class FormTeacher : Form
    {
       
        public string Username=User.currentUserName;
        public FormTeacher()
        {
            InitializeComponent();
            userControlSetting.ChangeFormColorEvent += settingControl_ChangeFormColorEvent;

        }

        // dark mode 

        private void settingControl_ChangeFormColorEvent(object sender, Color newColor)
        {
            TabPage tabPage = userControlAttendance1.tabPageMarkAttendance;


            SettingsManager settings = SettingsManager.Instance;
            if (settings.DarkModeEnabled)
            {


                panel1.BackColor = Color.DarkGray;
                panel1.ForeColor = Color.White;
                panel2.BackColor = Color.DarkGray;
                panel2.ForeColor = Color.White;
                panelBack.BackColor = Color.Gray;
                panelBack.ForeColor = Color.White;
                panelSlide.BackColor = Color.Gray;
                panel4.BackColor = Color.DarkGray;
                //panelSlide.ForeColor = Color.White;
                userControlAttendance1.BackColor = Color.Gray;


                userControlAttendance1.ForeColor = Color.White;
                //userControlTeacherReport1.BackColor = Color.Gray;
                //userControlTeacherReport1.ForeColor = Color.White;

                tabPage.BackColor = Color.Gray;
                /* user.BackColor = Color.Black;
                 userControlAddCourse.ForeColor = Color.White;*/


            }
            else
            {

                panel1.BackColor = System.Drawing.Color.Indigo;
                panel1.ForeColor = SystemColors.ControlText;
                panel2.BackColor = System.Drawing.Color.Indigo;
                panel2.ForeColor = SystemColors.ControlText;
                panelBack.BackColor = Color.White;
                panelBack.ForeColor = Color.Black;
                panelSlide.BackColor = System.Drawing.Color.White;
                panel4.BackColor = System.Drawing.Color.Indigo;
                // panelSlide.ForeColor = Color.White;
                userControlAttendance1.BackColor = Color.White;
                userControlAttendance1.ForeColor = SystemColors.ControlText;
                //userControlTeacherReport1.BackColor = Color.white;
                //userControlTeacherReport1.ForeColor = SystemColors.ControlText;
                tabPage.BackColor = Color.White;

            }

        }


        private void timerDtaeAndTime_Tick(object sender, EventArgs e)
        {
            DateTime Now = DateTime.Now;
            labelTime.Text=Now.ToString("f");
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            //panelExpand.Hide();
            WindowState=FormWindowState.Minimized;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult==DialogResult.Yes)
            {
                timerDtaeAndTime.Stop();
                Close();
            }
     
        }
        private void buttonReport_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonReport);
            //userControlTeacherReport1.Visible= true;
            userControlTeacherReport2.Visible= true;
        }

        private void buttonAttendance_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonAttendance);
            userControlAttendance1.Visible= true;
            //userControlTeacherReport1.Visible= false;
            //userControlTeacherReport2.Visible= false;


        }

        private void FormTeacher_Load(object sender, EventArgs e)
        {
            labelUsername.Text = Username;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MoveSidePanel(btnStTch);
            userControlAttendance1.Visible = false;
            //userControlTeacherReport1.Visible= false;
           // userControlTeacherReport2.Visible = false;
            userControlSetting.Visible = true;
        }

        private void MoveSidePanel(Control button)
        {
            panelSlide.Location=new Point(button.Location.X - button.Location.X, button.Location.Y - 180);
        }
    }
}
