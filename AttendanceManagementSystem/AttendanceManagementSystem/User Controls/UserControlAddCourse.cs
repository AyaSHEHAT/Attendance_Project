using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace AttendanceManagementSystem.User_Controls
{
    public partial class UserControlAddCourse : UserControl
    {
        public UserControlAddCourse()
        {
            InitializeComponent();
            XDocument doc = XDocument.Load(@"C:\Users\Saber\Desktop\Attendance_Project\XML files\Data.xml");

            // Search for all users with role "teacher"
            var teachers = doc.Root
                             .Element("Users")
                             .Elements("user")
                             .Where(u => u.Element("role")?.Value == "teacher")
                             .ToList();

            if (teachers.Any())
            {
                foreach (var teacher in teachers)
                {
                    string teacherId = teacher.Element("id")?.Value;
                    string teacherName = teacher.Element("name")?.Value;

                    // Display teacher ID and name
                    comboBoxTeacher.Items.Add($"{teacherId} - {teacherName}");
                }

                // Set initial selected item if needed
                comboBoxTeacher.SelectedIndex = 0;
                //comboBoxTeacher.Enabled = false; // Disable the ComboBox to prevent user selection
            }
            else
            {
                MessageBox.Show("No teachers found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
