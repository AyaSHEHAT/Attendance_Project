using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Xsl;

namespace AttendanceManagementSystem.User_Controls
{
    public partial class UserControlTeacherReport : UserControl
    {

        XDocument xml;
        XDocument doc = XDocument.Load(@"E:\ITI-PD&BI\XML\XML-Project\Old2-Attendance_Project\XML files\Data.xml");
        //private string URL_XML_FILE = @"E:\ITI-PD&BI\XML\XML-Project\Attendance_Project\XML files\Data.xml";
        List<User> Users = new List<User>();
        public UserControlTeacherReport()
        {
            InitializeComponent();
            // Search for all courses
            var courses = doc.Root
                             .Element("Courses")
                             .Elements("course")
                             .ToList();

            if (courses.Any())
            {
                foreach (var course in courses)
                {
                    string courseId = course.Element("cID")?.Value;
                    string courseName = course.Element("cName")?.Value;
                    comboBoxCourses.Items.Add($"{courseId} - {courseName}");
                }

                comboBoxCourses.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("No Courses found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /* public void loadCourses()
         {
             // Check if a course is selected in the comboBox

             if (comboBoxCourses.SelectedIndex >= 0)
             {

                 // Get the selected course from comboBoxCourses
                 string selectedCourse = comboBoxCourses.SelectedItem.ToString();
                 MessageBox.Show($"{selectedCourse}", "", MessageBoxButtons.OK, MessageBoxIcon.Question);
                 // Extract the course ID from the selectedCourse string
                 string courseName = selectedCourse.Split('-')[1].Trim();
                 MessageBox.Show($"{courseName}", "", MessageBoxButtons.OK, MessageBoxIcon.Question);

                 // Apply XSLT transformation with the selected course ID
                 applyXsltTransformation(courseName);
             }
             else
             {
                 MessageBox.Show("Please select a course.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
         }*/

        /*private void applyXsltTransformation(string courseName)
        {
            // Load the XSLT file
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load("E:\\ITI-PD&BI\\XML\\XML-Project\\Old2-Attendance_Project\\XML files\\courseAndStudent.xslt");

            // Load the XML input document
            XDocument xml = XDocument.Load(URL_XML_FILE);

            // Create a writer for the output
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true; // Optional: Indent the output for readability

            // Create a StringBuilder to store the transformed XML
            StringBuilder transformedXml = new StringBuilder();

            // Define parameters for the XSLT transformation
            XsltArgumentList arguments = new XsltArgumentList();
            arguments.AddParam("selectedCourseName", "", courseName);

            // Perform the transformation with parameters
            using (XmlWriter writer = XmlWriter.Create(transformedXml, settings))
            {
                xslt.Transform(xml.CreateReader(), arguments, writer);
            }

            // Display the transformed XML in dataGridViewCourse
            dataGridViewCourse.DataSource = transformedXml.ToString();
        MessageBox.Show($"{dataGridViewCourse.DataSource}", "", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }*/

        private void dumyFun()
        {
            string selectedCourse = comboBoxCourses.SelectedItem.ToString();
            string courseName = selectedCourse.Split('-')[1].Trim();
            XslCompiledTransform transform = new XslCompiledTransform();
            transform.Load(@"E:\ITI-PD&BI\XML\XML-Project\Old2-Attendance_Project\XML files\courseAndStudent.xslt");

            XsltArgumentList xsltArgs = new XsltArgumentList();
            xsltArgs.AddParam("selectedCourseName", "", courseName);

            using (StringWriter writer = new StringWriter())
            {
                transform.Transform(doc.CreateReader(), xsltArgs, writer);
                string transformedXml = writer.ToString();

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("id", typeof(int));
                dataTable.Columns.Add("name", typeof(string));

                using (XmlReader reader = XmlReader.Create(new StringReader(transformedXml)))
                {
                    MessageBox.Show($"{reader.NameTable}:, {reader.Name}:, {reader.Value}:, {reader.ValueType}");
                    while (reader.ReadToFollowing("id"))
                    {
                        DataRow row = dataTable.NewRow();
                        row["id"] = int.Parse(reader.GetAttribute("id"));
                        row["name"] = reader.GetAttribute("name");
                        dataTable.Rows.Add(row);
                    }
                }

                dataGridViewCourse.DataSource = dataTable;
            }
          
        }

        public void xmlOperation(string file)
        {
            Users.Clear();
            try
            {
                xml = XDocument.Load(file);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading information: " + ex.Message);
            }

            foreach (XElement courseElement in xml.Descendants("user"))
            {
                int userid =int.Parse( courseElement.Element("id").Value);
                string username = courseElement.Element("name").Value;
                string email = courseElement.Element("email").Value;
                string pass = courseElement.Element("userPass").Value;
                string address = courseElement.Element("address").Value;

                string role = courseElement.Element("role").Value;
                Users.Add(new User(userid, username, email, pass, "+20123456789", address, role));

            }


        }

        private void comboBoxCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            //loadCourses();  
            dumyFun();
        }

        private void dataGridViewCourse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
