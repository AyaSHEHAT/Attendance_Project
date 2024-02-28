using iTextSharp.text.pdf;
using iTextSharp.text;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Xsl;
using System.Xml;

namespace AttendanceManagementSystem.User_Controls
{
    public partial class UserControlStudentReport : UserControl
    {


        int userId = 800159561;
        XDocument doc = XDocument.Load(@"../../../../XML files\Data.xml");
        public UserControlStudentReport()
        {
            InitializeComponent();

            var courses = doc.Root
                             .Element("Courses")
                             .Elements("course")
                             .Where(c => c.Element("users").Element("user").Element("id")?.Value == userId.ToString()) // Filter by teachId
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
            System.Drawing.Rectangle bounds = e.MarginBounds;

            // Create a bitmap to hold the content of the DataGridView
            Bitmap bitmap = new Bitmap(dataGridViewCourse.Width, dataGridViewCourse.Height);

            // Draw the DataGridView to the bitmap
            dataGridViewCourse.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0, 0, dataGridViewCourse.Width, dataGridViewCourse.Height));

            // Draw the bitmap to the printer device
            e.Graphics.DrawImage(bitmap, bounds);
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();

            printDocument.PrintPage += PrintDocument_PrintPage;
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }
        private int GenerateRandomNumber()
        {
            // Generate a random number
            Random rnd = new Random();
            return rnd.Next(1000, 9999); // Generate a random number between 1000 and 9999
        }

        private void ExportToPdf(int randomNumber)
        {
            string fileName = $"../../../../Reports\\AttendanceReport_{randomNumber}.pdf";

            Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
            PdfWriter.GetInstance(pdfDoc, new FileStream(fileName, FileMode.Create));

            pdfDoc.Open();

            pdfDoc.Add(new Paragraph("Attendance Report"));
            PdfPTable pdfTable = new PdfPTable(dataGridViewCourse.Columns.Count);
            foreach (DataGridViewColumn column in dataGridViewCourse.Columns)
            {
                pdfTable.AddCell(column.HeaderText);
            }
            foreach (DataGridViewRow row in dataGridViewCourse.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable.AddCell(cell.Value.ToString());
                }
            }
            pdfDoc.Add(pdfTable);

            pdfDoc.Close();

            MessageBox.Show($"Attendance report exported as PDF successfully!\n in location '{fileName}'", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ExportToExcel(int randomNumber)
        {
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Attendance Report");

                for (int i = 0; i < dataGridViewCourse.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1].Value = dataGridViewCourse.Columns[i].HeaderText;
                }
                for (int i = 0; i < dataGridViewCourse.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridViewCourse.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1].Value = dataGridViewCourse.Rows[i].Cells[j].Value;
                    }
                }

                FileInfo excelFile = new FileInfo($"../../../../Reports\\AttendanceReport_{randomNumber}.xlsx");
                excelPackage.SaveAs(excelFile);

                MessageBox.Show($"Attendance report exported as Excel successfully! \n in location '{excelFile.FullName}'", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }




        private void buttonPdf_Click(object sender, EventArgs e)
        {
            ExportToPdf(GenerateRandomNumber());
        }

        private void buttonExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel(GenerateRandomNumber());

        }
    }
}
