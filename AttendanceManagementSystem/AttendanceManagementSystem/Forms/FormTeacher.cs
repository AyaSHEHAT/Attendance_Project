using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace AttendanceManagementSystem
{
    public partial class FormTeacher: Form
    {
        //public string Username="Aya", Role="student";
        public string Username = "Asmaa", Role = "teacher";
        //public string Username = "Nada", Role = "admin";
       
        //formMain.Username=textBoxName.Text;
        //formMain.Role=Check;

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            //Close();
            DialogResult dialogResult = MessageBox.Show("Are you want to log out?","Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult==DialogResult.Yes)
            { 
                timerDtaeAndTime.Stop();
                Close(); 
            }
            /*else
                panelExpand.Hide();*/

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //panelExpand.Hide();
            //panelExpand.Visible = false;
            labelUsername.Text = Username;
            //labelRole.Text = Role;
           
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            //panelExpand.Hide();
            WindowState=FormWindowState.Minimized;
        }

        private void timerDtaeAndTime_Tick(object sender, EventArgs e)
        {
            DateTime Now = DateTime.Now;
            labelTime.Text=Now.ToString("f");
        }

        private void buttonAttendance_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonAttendance);
            userControlDashboard1.Visible= false;
            userControlAddCourse.Visible= false;
            userControlAddUser1.Visible= false;
            userControlTeacherReport1.Visible= false;

          /*  userControlAddCourse1.Visible= false;
            userControlAddUser2.Visible= false;
            userControlDashboard11.Visible= false;*/
        }
        public FormTeacher()
        {
            InitializeComponent();
            timerDtaeAndTime.Start();
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonDashboard);
            //userControlDashboard1.Count();
            userControlDashboard1.Visible= true;
            userControlAddCourse.Visible= false;
            userControlAddUser1.Visible= false;
            userControlTeacherReport1.Visible= false;

           /* userControlAddCourse1.Visible= false;
            userControlAddUser2.Visible= false;
            userControlDashboard11.Visible= true;*/
        }

        /*  private void buttonAddCourse_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonAddCourse);
            userControlDashboard1.Visible= false;
            userControlAddCourse.Visible= true;
            userControlAddUser1.Visible= false;

          userControlAddCourse1.Visible= true;
            userControlAddUser2.Visible= false;
            userControlDashboard11.Visible= false;
        }*/

        

       /* private void buttonAddStd_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonAddStd);
            userControlDashboard1.Visible= false;
            userControlAddCourse.Visible= false;
            userControlAddUser1.Visible= true;
            userControlAddCourse1.Visible= false;
            userControlAddUser2.Visible= true;
            userControlDashboard11.Visible= false;
        }*/

        private void buttonReport_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonReport);
            userControlDashboard1.Visible= false;
            userControlAddCourse.Visible= false;
            userControlAddUser1.Visible= false;
            userControlTeacherReport1.Visible= true;
            /*userControlAddCourse1.Visible= false;
            userControlAddUser2.Visible= false;
            userControlDashboard11.Visible= false;*/
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelSlide_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelUsername_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void labelTime_Click(object sender, EventArgs e)
        {

        }

        private void userControlAddCourse1_Load(object sender, EventArgs e)
        {

        }

        private void userControlDashboard11_Load(object sender, EventArgs e)
        {

        }

        private void userControlAddCourse_Load(object sender, EventArgs e)
        {

        }

        private void userControlDashboard1_Load(object sender, EventArgs e)
        {

        }

        private void userControlAddUser1_Load(object sender, EventArgs e)
        {

        }

        private void panelBack_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MoveSidePanel(Control button)
        {
            panelSlide.Location=new Point(button.Location.X - button.Location.X,button.Location.Y - 180);
        }
    }
}
