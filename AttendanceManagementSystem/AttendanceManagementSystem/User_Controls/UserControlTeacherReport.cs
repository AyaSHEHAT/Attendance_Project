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
using System.Drawing.Printing;


namespace AttendanceManagementSystem.User_Controls
{
    public partial class UserControlTeacherReport : UserControl
    {
        XDocument doc = XDocument.Load(@"../../../../XML files/Data.xml");
        List<Report_teacher> Students = new List<Report_teacher>();
        public UserControlTeacherReport()
        {
            InitializeComponent();
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
                comboBoxDate.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("No Courses found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void comboBoxCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadCourses();
           
        }

        public void loadCourses()
        {
           
            // Check if a course is selected in the comboBox
            if (comboBoxCourses.SelectedIndex >= 0)
            {
                // Clear comboBoxDate before populating it
                comboBoxDate.Items.Clear();

                string selectedCourse = comboBoxCourses.SelectedItem.ToString();
                string courseName = selectedCourse.Split('-')[1].Trim();

                var courseElement = doc.Root
                                        .Element("Courses")
                                        .Elements("course")
                                        .FirstOrDefault(c => c.Element("cName").Value == courseName);

                if (courseElement != null)
                {
                    // Get all dates for the sessions of the selected course
                    var dates = courseElement.Descendants("date").Select(d => d.Value).ToList();

                    if (dates.Any())
                    {
                        // Populate comboBoxDate with the dates
                        foreach (var date in dates)
                        {
                            comboBoxDate.Items.Add(date);
                        }

                        comboBoxDate.SelectedIndex = -1; // Select the first date by default
                    }
                    else
                    {
                        MessageBox.Show("No sessions found for the selected course.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Selected course not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a course.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void comboBoxDate_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            if (comboBoxDate.SelectedIndex >= 0)
            {
                // Get the selected course name from comboBoxCourses
                string selectedCourse = comboBoxCourses.SelectedItem.ToString();
                string courseName = selectedCourse.Split('-')[1].Trim();

                // Get the selected date from comboBoxDate
                string selectedDate = comboBoxDate.SelectedItem.ToString();

                // Perform XSLT transformation and load data into dataGridViewCourse
                applyXsltTransformation(courseName, selectedDate);
            }
        }

        private void applyXsltTransformation(string courseName, string selectedDate)
        {
            // Load the XSLT file
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load(@"../../../../XML files/courseAndStudent.xslt");

            // Create a writer for the output file
            using (XmlWriter writer = XmlWriter.Create(@"C:\Reports\TransformedAttendance.html"))
            {
                // Define parameters for the XSLT transformation
                XsltArgumentList arguments = new XsltArgumentList();
                arguments.AddParam("selectedCourseName", "", courseName);
                arguments.AddParam("selectedDate", "", selectedDate);

                // Perform the transformation with parameters, writing directly to the file
                xslt.Transform(doc.CreateReader(), arguments, writer);
            }

            // Load the transformed HTML file into a string for display in a MessageBox
            string transformedXml = File.ReadAllText(@"C:\Reports\TransformedAttendance.html");

            // Parse the transformed HTML content into an XDocument to extract student data
            XDocument transformedDoc = XDocument.Load(@"C:\Reports\TransformedAttendance.html");

            // Extract student data from the transformed HTML
            var students = transformedDoc.Root.Descendants("tr")
                                             .Skip(1) // Skip the header row
                                             .Select(tr => new Report_teacher
                                             {
                                                 StdId = int.Parse(tr.Elements("td").First().Value),
                                                 StdName = tr.Elements("td").Skip(1).First().Value,
                                                 Date = tr.Elements("td").Skip(2).First().Value,
                                                 CName = tr.Elements("td").Skip(3).First().Value,
                                                 Status = tr.Elements("td").Skip(4).First().Value
                                             }).ToList();

            // Populate the DataGridView with the student data
            dataGridViewCourse.DataSource = students;

            // Show a MessageBox with the transformed HTML content
            MessageBox.Show(transformedXml, "Transformed HTML Content", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Define the bounds for printing
            Rectangle bounds = e.MarginBounds;

            // Create a bitmap to hold the content of the DataGridView
            Bitmap bitmap = new Bitmap(dataGridViewCourse.Width, dataGridViewCourse.Height);

            // Draw the DataGridView to the bitmap
            dataGridViewCourse.DrawToBitmap(bitmap, new Rectangle(0, 0, dataGridViewCourse.Width, dataGridViewCourse.Height));

            // Draw the bitmap to the printer device
            e.Graphics.DrawImage(bitmap, bounds);
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();

            // Set up event handlers for printing
            printDocument.PrintPage += PrintDocument_PrintPage;

            // Show print dialog to configure printing options
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                // Print the document
                printDocument.Print();
            }
        }
    }
}
