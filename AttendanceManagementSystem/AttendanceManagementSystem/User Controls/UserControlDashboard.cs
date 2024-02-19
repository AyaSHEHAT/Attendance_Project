using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace AttendanceManagementSystem.User_Controls
{
    public partial class UserControlDashboard : UserControl
    {
        private XDocument xml = XDocument.Load(@"../../../../XML files\Data.xml");
        public UserControlDashboard()
        {
            InitializeComponent();
        }
        public int Count(string type)
        {
            int count = 0;
            if (type =="student" || type =="teacher") 
            {

                count = (from user in xml.Root.Descendants("user")
                         where (string)user.Element("role") == type
                         select user).Count();
            }
            else
            {
                count = xml.Root
                   .Descendants("course")
                   .Count();
            }
            return count;
        }

        private void UserControlDashboard_Load(object sender, EventArgs e)
        {
            labelTotalTeachers.Text =Count("teacher").ToString();
            labelTotalCourses.Text =Count("course").ToString();
            labelTotalStudents.Text =Count("student").ToString();
        }
    }
}
