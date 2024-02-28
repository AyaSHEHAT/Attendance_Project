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


        int userId = 800151254;
        XDocument doc = XDocument.Load(@"E:\ITI-PD&BI\XML\XML-Project\Attendance_Project\Attendance_Project\XML files\Data.xml");
        public UserControlStudentReport()
        {
            InitializeComponent();

           LoadCourses();
        }
        public void LoadCourses()
        {
            var studentCourses = doc.Root
                                    .Elements("Users")
                                    .Elements("user")
                                    .Where(user => (Int64)user.Element("id") == userId && (string)user.Element("role") == "student")
                                    .Elements("listOfCourses")
                                    .Elements("courseName")
                                    .Select(courseName => (string)courseName)
                                    .ToList();

            if (studentCourses.Any())
            {
                comboBoxCourses.Items.AddRange(studentCourses.ToArray());
                comboBoxCourses.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("No Courses found for the student.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void applyXsltTransformation(string courseName, int userId)
        {
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load(@"../../../../XML files\StudentReport.xslt");
            using (XmlWriter writer = XmlWriter.Create(@"C:\Reports\StudentReport.html", new XmlWriterSettings { ConformanceLevel = ConformanceLevel.Auto }))
            {
                XsltArgumentList arguments = new XsltArgumentList();
                arguments.AddParam("selectedCourseName", "", courseName);
                arguments.AddParam("userID", "", userId.ToString());

                xslt.Transform(doc.CreateReader(), arguments, writer);
            }


            string transformedXml = File.ReadAllText(@"C:\Reports\StudentReport.html");

            XDocument transformedDoc = XDocument.Load(@"C:\Reports\StudentReport.html");
            var students = transformedDoc.Root.Descendants("tr")
                                  .Skip(1) // Skip the header row
                                  .Select(tr => new Report_Student(
                                          tr.Elements("td").Skip(0).FirstOrDefault()?.Value ?? "", // Use null conditional operator and null-coalescing operator
                                          tr.Elements("td").Skip(1).FirstOrDefault()?.Value ?? "",
                                          tr.Elements("td").Skip(2).FirstOrDefault()?.Value ?? ""
                                    )).ToList();

            dataGridViewCourse.DataSource = students;

        }

        private void comboBoxCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCourses.SelectedIndex >= 0)
            {
                dataGridViewCourse.Rows.Clear();
                string selectedCourse = comboBoxCourses.SelectedItem.ToString();
                applyXsltTransformation(selectedCourse, userId);
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
            string fileName = $"../../../../Reports\\AttendanceReportforStudent{userId}_{randomNumber}.pdf";

            Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
            PdfWriter.GetInstance(pdfDoc, new FileStream(fileName, FileMode.Create));

            pdfDoc.Open();

            pdfDoc.Add(new Paragraph($"Attendance Report of student {userId}"));
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
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add($"Attendance Report of student {userId}");

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

                FileInfo excelFile = new FileInfo($"../../../../Reports\\AttendanceReportforStudent{userId}_{randomNumber}.xlsx");
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
