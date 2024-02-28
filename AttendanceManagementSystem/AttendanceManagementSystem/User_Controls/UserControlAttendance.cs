using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace AttendanceManagementSystem.User_Controls
{
    public partial class tabPageMarkAttendance : UserControl
    {
        public List<string> listofCourse = new List<string>();

        public tabPageMarkAttendance()
        {
            InitializeComponent();
            LoadClassNames();
        }



        private void LoadClassNames()
        {
            string xmlFilePath = @"../../../../XML files/Data.xml";

            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(xmlFilePath);

                // Construct XPath expression to select courses taught by the specified teacher ID
                string xpathExpression = $"//course[teacher/teachId='{User.currentUser}']";

                XmlNodeList courseNodes = xmlDocument.SelectNodes(xpathExpression);
                if (courseNodes != null)
                {
                    foreach (XmlNode course in courseNodes)
                    {
                        string className = course.SelectSingleNode("cName").InnerText;
                        Teacher.courseName = className;
                        listofCourse.Add(className);
                        // comboBoxClass.Items.Add(className);
                    }
                    Console.WriteLine($"{Teacher.courseName}");
                    comboBoxClass.DataSource = listofCourse;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading XML data: " + ex.Message);
            }
        }



        private void tabPageMarkAttendance_Load(object sender, EventArgs e)
        {

        }

        private void tabPageAttendance_Click(object sender, EventArgs e)
        {

        }
    }
}
