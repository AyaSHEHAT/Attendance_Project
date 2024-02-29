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
    public partial class UserControlAttendance : UserControl
    {
        public List<string> listofCourse = new List<string>();

        public UserControlAttendance()
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

        private void dataGridViewAttendance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserControlAttendance_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewAttendance_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is a checkbox cell
            if (dataGridViewAttendance.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
            {
                // Hide the row
                dataGridViewAttendance.Rows[e.RowIndex].Visible = false;

                // Retrieve student ID
                string studentID = dataGridViewAttendance.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                bool Atteend = Convert.ToBoolean(dataGridViewAttendance.Rows[e.RowIndex].Cells["attended"].Value);
                string theDate = dateTimePickerDate.Value.ToString("MM/dd/yyyy");
                string cname = comboBoxClass.SelectedItem.ToString();

                // Retrieve checkbox value
                var res = Atteend ? "attended" : "absent";
                // You can now use studentID and attended in your further processing
                //MessageBox.Show($"Student with ID {studentID} , {(Atteend ? "attended" : "was absent")} , {theDate}, in course {cname}.");
                writeStudentAttendance(studentID, res, cname, theDate);
            }
        }

        private void writeStudentAttendance(string id, string status, string courseName, string date)
        {
            XDocument doc = XDocument.Load("../../../../XML files/Data.xml");
            // Get the date you want to check
            DateTime sessionDate = DateTime.Parse(date);
            string dateOnly = $"{sessionDate.Month}-{sessionDate.Day}-{sessionDate.Year}"; // Format as "MM-DD-YYYY"

            // Query to find sessions with the given date
            var sessions = from session in doc.Descendants("session")
                           where (string)session.Element("date") == dateOnly
                           select session;

            // Check if any sessions exist with the given date
            if (sessions.Any())
            {
                // Session exists, find the first one (assuming there's only one session per date)
                var session = sessions.First();

                // Add a new student element with the provided id and status
                session.Element("students").Add(
                    new XElement("student",
                        new XElement("stdId", id),
                        new XElement("status", status)
                    )
                );

                // Update the XML file
                doc.Save("../../../../XML files/Data.xml");

                Console.WriteLine($"Student attendance updated for session on {dateOnly}");
            }
            else
            {
                // Session does not exist, create a new session
                var courses = doc.Descendants("course");
                var course = courses.FirstOrDefault(c => (string)c.Element("cName") == courseName);
                if (course != null)
                {
                    // Course exists, add a new session
                    course.Element("sessions").Add(
                        new XElement("session",
                            new XElement("date", dateOnly),
                            new XElement("sessionNum", GetNextSessionNumber(course)),
                            new XElement("students",
                                new XElement("student",
                                    new XElement("stdId", id),
                                    new XElement("status", status)
                                )
                            )
                        )
                    );

                    // Update the XML file
                    doc.Save("../../../../XML files/Data.xml");

                    Console.WriteLine($"New session created for {courseName} on {dateOnly}");
                }
                else
                {
                    Console.WriteLine($"Course '{courseName}' not found.");
                }

            }
        }

        private int GetNextSessionNumber(XElement course)
        {
            // Get the count of existing sessions and add 1
            return course.Elements("sessions").Elements("session").Count() + 1;
        }

        private void comboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewAttendance.Rows.Clear();
            // Load the XML file 
            XDocument doc = XDocument.Load("../../../../XML files/Data.xml");

            string x = comboBoxClass.SelectedItem?.ToString(); // Using SelectedValue

            // Find the XML course
            var usersWithCSharpCourse = from user in doc.Descendants("user")
                                        where user.Descendants("courseName").Any(course => course.Value == x)
                                        select new
                                        {
                                            Id = (string)user.Element("id"),
                                            Name = (string)user.Element("name"),
                                            Email = (string)user.Element("email"),
                                            Address = (string)user.Element("address"),
                                            UserPass = (string)user.Element("userPass"),
                                            Role = (string)user.Element("role")
                                        };

            // Display the results
            foreach (var user in usersWithCSharpCourse)
            {
                int rowIndex = dataGridViewAttendance.Rows.Add(user.Id, user.Name, user.Email);
                //dataGridViewAttendance.Rows[rowIndex].Cells["AttendanceColumn"].Value = (studentNode.SelectSingleNode("status").InnerText == "Present");
            }
        }
    }
}
