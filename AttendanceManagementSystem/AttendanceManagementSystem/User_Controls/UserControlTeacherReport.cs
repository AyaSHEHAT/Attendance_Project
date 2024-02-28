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
        XDocument doc = XDocument.Load(@"E:\ITI-PD&BI\XML\XML-Project\Attendance_Project\Attendance_Project\XML files\Data.xml");
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

        public void loadCourses()
        {

            if (comboBoxCourses.SelectedIndex >= 0)
            {
                comboBoxDate.Items.Clear();

                string selectedCourse = comboBoxCourses.SelectedItem.ToString();
                string courseName = selectedCourse.Split('-')[1].Trim();

                var courseElement = doc.Root
                                        .Element("Courses")
                                        .Elements("course")
                                        .FirstOrDefault(c => c.Element("cName").Value == courseName);

                if (courseElement != null)
                {
                    var dates = courseElement.Descendants("date").Select(d => d.Value).ToList();

                    if (dates.Any())
                    {
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


        private void applyXsltTransformation(string courseName, string selectedDate)
        {
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load(@"../../../../XML files/courseAndStudent.xslt");

            using (XmlWriter writer = XmlWriter.Create(@"C:\Reports\TransformedAttendance.html"))
            {
                XsltArgumentList arguments = new XsltArgumentList();
                arguments.AddParam("selectedCourseName", "", courseName);
                arguments.AddParam("selectedDate", "", selectedDate);

                xslt.Transform(doc.CreateReader(), arguments, writer);
            }

            string transformedXml = File.ReadAllText(@"C:\Reports\TransformedAttendance.html");
            XDocument transformedDoc = XDocument.Load(@"C:\Reports\TransformedAttendance.html");
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

            dataGridViewCourse.DataSource = students;

            MessageBox.Show(transformedXml, "Transformed HTML Content", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void comboBoxCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadCourses();
        }

        private void comboBoxDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDate.SelectedIndex >= 0)
            {
                string selectedCourse = comboBoxCourses.SelectedItem.ToString();
                string courseName = selectedCourse.Split('-')[1].Trim();
                string selectedDate = comboBoxDate.SelectedItem.ToString();
                applyXsltTransformation(courseName, selectedDate);
            }
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
