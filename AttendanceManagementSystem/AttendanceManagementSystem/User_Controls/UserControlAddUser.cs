using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AttendanceManagementSystem.User_Controls
{
    public partial class UserControlAddUser : UserControl
    {
        XDocument doc = XDocument.Load(@"E:\ITI-PD&BI\XML\XML-Project\Attendance_Project\XML files\Data.xml");

        public UserControlAddUser()
        {
            InitializeComponent();
        }
        public void ClearTextBox()
        {
            textBoxUserName.Clear();
            textBoxUserID.Clear();
            textBoxUserPass.Clear();
            textBoxEmail.Clear();
            textBoxUserAddress.Clear();
            radioBtnStudent.Checked = false;
            radioBtnTeacher.Checked = false;    
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int numericValue;
            if (textBoxUserName.Text.Trim()==string.Empty || int.TryParse(textBoxUserName.Text, out numericValue))
            {
                MessageBox.Show("Enter a valid Course name and must not be a number", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (textBoxUserID.Text.Trim()==string.Empty)
            {
                MessageBox.Show("Enter a valid Course ID", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (comboBoxTeacher.SelectedIndex == -1)
            {
                MessageBox.Show("Assign the course to specific Teacher", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                XElement coursesElement = doc.Root.Element("Courses");
                XElement newCourseElement = new XElement("course",
                    new XElement("cID", textBoxCrsId.Text),
                    new XElement("cName", textBoxCrsName.Text),
                    new XElement("totalsessionNum", numericUpDownSessionNumber.Value),
                    new XElement("startDate", dateStartDate.Value.ToString("yyyy-MM-dd")),
                    // new XElement("sessions",null),
                    new XElement("teacher",
                        new XElement("teachId", comboBoxTeacher.SelectedItem.ToString().Split('-')[0].Trim())
                    )
                );
                coursesElement.Add(newCourseElement);
                doc.Save(@"E:\ITI-PD&BI\XML\XML-Project\Attendance_Project\XML files\Data.xml");
                MessageBox.Show("Course Added Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTextBox();
            }

        }

        private void tabControlAddUser_Leave(object sender, EventArgs e)
        {
            ClearTextBox();
        }
    }
}
