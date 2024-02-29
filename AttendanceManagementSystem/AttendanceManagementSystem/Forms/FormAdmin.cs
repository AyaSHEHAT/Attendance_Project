using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace AttendanceManagementSystem
{
    public partial class FormAdmin : Form
    {
        private const string DatabaseFilePath = @"../../../../XML files\\Data.xml";
        private const string BackupFolderPath = @"../../../../Backup_Folder";
        private System.Threading.Timer backupTimer; // Keep a reference to the timer


        //public string Username="Aya", Role="student";
        //public string Username = "Asmaa", Role = "teacher";
        public string Username = "Nada", Role = "admin";
       
        //formMain.Username=textBoxName.Text;
        //formMain.Role=Check;

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            
           
                 DialogResult dialogResult = MessageBox.Show("Are you want to log out?","Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                 if (dialogResult==DialogResult.Yes)
                 { 
                     timerDtaeAndTime.Stop();
                     Close(); 
                 }
               

            }

        private void FormMain_Load(object sender, EventArgs e)
        {
            ScheduleBackup();
            //panelExpand.Hide();
            //panelExpand.Visible = false;
            labelUsername.Text = Username;
            //labelRole.Text = Role;
            if (Role =="student")
            {
                buttonDashboard.Hide();
                buttonAddCourse.Hide();
                buttonAddStd.Hide();
                buttonAttendance.Hide();
            }else if(Role =="teacher")
            {
                buttonDashboard.Hide();
                buttonAddCourse.Hide();
                buttonAddStd.Hide();
                buttonAttendance.Show();
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

        private void buttonAttendance_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonAttendance);
            userControlDashboard1.Visible= false;
            userControlAddCourse.Visible= false;
            userControlAddUser1.Visible= false;
            userControlSetting.Visible = true;

           
        }
        public FormAdmin()
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
            userControlSetting.Visible = false;

        }

        private void buttonAddCourse_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonAddCourse);
            userControlDashboard1.Visible= false;
            userControlAddCourse.Visible= true;
            userControlAddUser1.Visible= false;
            userControlSetting.Visible = false;

        }



        private void buttonAddStd_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonAddStd);
            userControlDashboard1.Visible= false;
            userControlAddCourse.Visible= false;
            userControlAddUser1.Visible= true; 
            userControlSetting.Visible= false;
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonReport);
            userControlDashboard1.Visible= false;
            userControlAddCourse.Visible= false;
            userControlAddUser1.Visible= false;
            userControlSetting.Visible= false;
        }

        private void MoveSidePanel(Control button)
        {
            panelSlide.Location=new Point(button.Location.X - button.Location.X,button.Location.Y - 180);
        }


        private void ScheduleBackup()
        {
            // Schedule the backup task every 5 seconds
            var delay = TimeSpan.FromSeconds(60);

            // Schedule the backup task
            var timer = new System.Threading.Timer(BackupDatabase, null, delay, TimeSpan.FromSeconds(60));
        }

        private void BackupDatabase(object state)
        {
            try
            {
                // Create the backup folder if it doesn't exist
                if (!Directory.Exists(BackupFolderPath))
                {
                    Directory.CreateDirectory(BackupFolderPath);
                    Log("Backup folder created: " + BackupFolderPath);
                }

                // Generate backup file name with timestamp
                var backupFileName = $"backup_{DateTime.Now:yyyyMMddHHmmss}.xml";
                var backupFilePath = Path.Combine(BackupFolderPath, backupFileName);

                // Copy the database file to the backup folder
                File.Copy(DatabaseFilePath, backupFilePath);

                // Log backup success
                Log("Backup created: " + backupFileName);
            }
            catch (Exception ex)
            {
                // Log backup error
                Log("Backup error: " + ex.Message);
            }
        }


        //private void BackupDatabase(object state)
        //{
        //    try
        //    {
        //        // Create the backup folder if it doesn't exist
        //        if (!Directory.Exists(BackupFolderPath))
        //        {
        //            Directory.CreateDirectory(BackupFolderPath);
        //        }

        //        // Generate backup file name with timestamp
        //        var backupFileName = $"backup_{DateTime.Now:yyyyMMddHHmmss}.xml";
        //        var backupFilePath = Path.Combine(BackupFolderPath, backupFileName);

        //        // Copy the database file to the backup folder
        //        File.Copy(DatabaseFilePath, backupFilePath);

        //        // Log backup success
        //        Log("Backup created: " + backupFileName);
        //    }
        //    catch (Exception ex)
        //    {
        //        // Log backup error
        //        Log("Backup error: " + ex.Message);
        //    }
        //}

        private void Log(string message)
        {
            // Log the message to a file or display it in the application
            // You can implement your own logging mechanism here
            Console.WriteLine(message);
        }

    }
}
