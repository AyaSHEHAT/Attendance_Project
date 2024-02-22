using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AttendanceManagementSystem.User_Controls
{
    public partial class UserControlAddUser : UserControl
    {
        XDocument doc = XDocument.Load(@"../../../../XML files\Data.xml");

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
            string role;
            string EmailRegx = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            string PassRegex = @"^[A-Za-z0-9]{8,}$";
            if (textBoxUserName.Text.Trim()==string.Empty || int.TryParse(textBoxUserName.Text, out numericValue))
            {
                MessageBox.Show("Enter a valid Course name and must not be a number", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (textBoxUserID.Text.Trim()==string.Empty)
            {
                MessageBox.Show("Enter a valid Course ID", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (textBoxEmail.Text.Trim()==string.Empty || Regex.IsMatch(textBoxEmail.Text.Trim(),EmailRegx))
            {
                MessageBox.Show("Enter a vailid email. ex: example@example.com", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (textBoxUserPass.Text.Trim()==string.Empty || Regex.IsMatch(textBoxUserPass.Text.Trim(), PassRegex))
            {
                MessageBox.Show("Enter a vailid password that must be 8 characters or more and has small and capital letters and digits", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (textBoxUserAddress.Text.Trim()==string.Empty)
            {
                MessageBox.Show("you must add Address", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (radioBtnStudent.Checked==false && radioBtnTeacher.Checked==false)
            {
                MessageBox.Show("You must choose the Role Of the user", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                if (radioBtnStudent.Checked)
                {
                    role="student";
                }
                else { role="teacher"; }
                XElement usersElement = doc.Root.Element("Users");
                XElement newUserElement = new XElement("user",
                    new XElement("id", textBoxUserID.Text),
                    new XElement("name", textBoxUserName.Text),
                    new XElement("email", textBoxEmail.Text),
                    new XElement("address", textBoxUserAddress.Text),
                     new XElement("userPass", textBoxUserPass.Text),
                    new XElement("role", role)
                );
                usersElement.Add(newUserElement);
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
