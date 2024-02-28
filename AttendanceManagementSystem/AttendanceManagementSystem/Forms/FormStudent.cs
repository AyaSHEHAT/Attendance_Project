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
    
    public partial class FormStudent : Form
    {
        //public string Username="Aya", Role="student";
    //public string Username = "Asmaa", Role = "teacher";
    public string Username = "Nada", Role = "admin";
        public FormStudent()
        {
            InitializeComponent();
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

        private void buttonReport_Click(object sender, EventArgs e)
        {

        }

        private void FormStudent_Load(object sender, EventArgs e)
        {
            labelUsername.Text = Username;
        }
    }
}
