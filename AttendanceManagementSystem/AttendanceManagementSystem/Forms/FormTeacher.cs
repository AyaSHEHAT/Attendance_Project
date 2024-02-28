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
        //public string Username="Aya", Role="student";
        //public string Username = "Asmaa", Role = "teacher";
        public string Username = "Nada", Role = "admin";
        public FormTeacher()
        {
            InitializeComponent();
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
            userControlTeacherReport1.Visible= true;
        }

        private void buttonAttendance_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonAttendance);

            userControlTeacherReport1.Visible= false;

        }

        private void FormTeacher_Load(object sender, EventArgs e)
        {
            labelUsername.Text = Username;
        }
        private void MoveSidePanel(Control button)
        {
            panelSlide.Location=new Point(button.Location.X - button.Location.X, button.Location.Y - 180);
        }
    }
}
