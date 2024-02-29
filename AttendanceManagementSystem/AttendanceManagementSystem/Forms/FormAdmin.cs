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


        public string Username= User.currentUserName, Role=User.currentRole;
     
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
            userControlAdminReport1.Visible= false;



        }

        
        public FormAdmin()
        {
            InitializeComponent();
            timerDtaeAndTime.Start();
            userControlSetting.ChangeFormColorEvent += settingControl_ChangeFormColorEvent;
            userControlSetting.DateFormatChanged += UserControl1_DateFormatChanged;
        }

        //date format 
        private void UserControl1_DateFormatChanged(object sender, string selectedDateFormat)
        {
            // Call the method in UserControl2 to update the date format
            userControlAddCourse.UserControl1_DateFormatChanged(sender, selectedDateFormat);
        }


        private void settingControl_ChangeFormColorEvent(object sender, Color newColor)
        {
            
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
                userControlAddCourse.BackColor = Color.Gray;
              
               
                userControlAddCourse.ForeColor = Color.White;
                
                userControlAddUser1.BackColor = Color.Gray;
                userControlAddUser1.ForeColor = Color.White;
                userControlDashboard1.BackColor = Color.Gray;
                userControlDashboard1.ForeColor = Color.White;
                
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
                userControlAddCourse.BackColor = Color.White;
                userControlAddCourse.ForeColor = SystemColors.ControlText;
                userControlAddUser1.BackColor = Color.White;
                userControlAddUser1.ForeColor = SystemColors.ControlText;
                userControlDashboard1.BackColor = Color.White;
                userControlDashboard1.ForeColor = SystemColors.ControlText;

            }
            
        }
        /*private void settingControl_ChangeFormColorEvent2(object sender, Color newColor)
        {
            
                this.BackColor = Color.DarkGray; 
                this.ForeColor = Color.White; 
                panelBack.BackColor = newColor;
                panelBack.ForeColor = Color.White;
                panel1.BackColor = Color.DarkGray;
                

        }*/

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonDashboard);
            //userControlDashboard1.Count();
            userControlDashboard1.Visible= true;
            userControlAddCourse.Visible= false;
            userControlAddUser1.Visible= false; 
            userControlSetting.Visible = false;
            userControlAdminReport1.Visible= false;


        }

        private void buttonAddCourse_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonAddCourse);
            userControlDashboard1.Visible= false;
            userControlAddCourse.Visible= true;
            userControlAddUser1.Visible= false;
            userControlSetting.Visible = false;
            userControlAdminReport1.Visible= false;


        }



        private void buttonAddStd_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonAddStd);
            userControlDashboard1.Visible= false;
            userControlAddCourse.Visible= false;
            userControlAddUser1.Visible= true; 
            userControlSetting.Visible= false;
            userControlAdminReport1.Visible= false;

        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonReport);
            userControlDashboard1.Visible= false;
            userControlAddCourse.Visible= false;
            userControlAddUser1.Visible= false;
            userControlSetting.Visible= false;
            userControlAdminReport1.Visible= true;
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

        private void Log(string message)
        {
            // Log the message to a file or display it in the application
            // You can implement your own logging mechanism here
            Console.WriteLine(message);
        }



    }
}



