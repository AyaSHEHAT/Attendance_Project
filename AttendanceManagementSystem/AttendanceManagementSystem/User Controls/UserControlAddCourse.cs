using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace AttendanceManagementSystem.User_Controls
{
    public partial class UserControlAddCourse : UserControl
    {
         XDocument xml;
        private string URL_XML_FILE = @"../../../../XML files\Data.xml";
        List<Course> courses = new List<Course>();
        DataTable dt;

        public UserControlAddCourse()
        {
            InitializeComponent();
            XDocument doc = XDocument.Load(@"C:\Users\Saber\Desktop\Attendance_Project\XML files\Data.xml");

            // Search for all users with role "teacher"
            var teachers = doc.Root
                             .Element("Users")
                             .Elements("user")
                             .Where(u => u.Element("role")?.Value == "teacher")
                             .ToList();

            if (teachers.Any())
            {
                foreach (var teacher in teachers)
                {
                    string teacherId = teacher.Element("id")?.Value;
                    string teacherName = teacher.Element("name")?.Value;

                    // Display teacher ID and name
                    comboBoxTeacher.Items.Add($"{teacherId} - {teacherName}");
                }

                // Set initial selected item if needed
                comboBoxTeacher.SelectedIndex = 0;
                //comboBoxTeacher.Enabled = false; // Disable the ComboBox to prevent user selection
            }
            else
            {
                MessageBox.Show("No teachers found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void xmlOperation(string file)
        {
            courses.Clear();
            try
            {
                xml = XDocument.Load(file);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading information: " + ex.Message);
            }
           

            foreach (XElement courseElement in xml.Descendants("course"))
            {
                string courseId = courseElement.Element("cID").Value;
                string courseName = courseElement.Element("cName").Value;
                int sessions = int.Parse(courseElement.Element("totalsessionNum").Value);
                string teacherId = courseElement.Element("teacher").Element("teachId").Value;

                // Get the first session element
                XElement firstSession = courseElement.Element("sessions").Elements("session").FirstOrDefault();
                if (firstSession != null)
                {
                    DateTime date = DateTime.Parse(firstSession.Element("date").Value);

                    
                        courses.Add(new Course
                        {
                            CourseId = courseId,
                            CourseName = courseName,
                            Sessions = sessions,
                            Date = date,
                            Teacher = teacherId,
                            
                        });

                       
                    
                }
            }


        }

        public void loadCourses ()
        {
            
            xmlOperation(URL_XML_FILE);
            dataGridViewCourse.DataSource = courses;
            dataGridViewCourse.Columns[5].Visible = false;

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void tabPageSearch_Enter(object sender, EventArgs e)
        {
           

            lblTotalCourse.Text =dataGridViewCourse.Rows.Count.ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim().ToLower();
          

            var filteredCourses = courses.Where(course => course.CourseName.ToLower().Contains(searchText)).ToList();
            // Bind the filtered data to the DataGridView
            //courses= filteredCourses;

            dataGridViewCourse.DataSource = filteredCourses;
            

        }


        private void tabPageSearch_Leave(object sender, EventArgs e)
        {

            txtSearch.Clear();
           
        }

        private void dataGridViewCourse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
             DataGridViewRow row = dataGridViewCourse.Rows[e.RowIndex];
                txtCourseId.Text = row.Cells[0].Value.ToString();
                txtCourseName.Text = row.Cells[1].Value.ToString();
                upDownSession.Value= (int)row.Cells[2].Value;
                boxTeacher.Text = row.Cells[4].Value.ToString();
              //  dateStartDate.Value = Convert.ToDateTime(row.Cells[3].Value);


            }
        }

        private void btnUbdate_Click(object sender, EventArgs e)
        {
            XElement courseElement = xml.Descendants("course").FirstOrDefault(p => p.Element("cID").Value == txtCourseId.Text);
            if (courseElement != null)
            {
                courseElement.Element("cName").Value = txtCourseName.Text;
                courseElement.Element("totalsessionNum").Value = upDownSession.Text;
                courseElement.Element("teacher").Element("teachId").Value = boxTeacher.Text;
                courseElement.Element("sessions").Elements("session").FirstOrDefault().Element("date").Value = dateStartDate.Text;
                xml.Save(URL_XML_FILE);

                loadCourses();

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            XElement courseElement = xml.Descendants("course").FirstOrDefault(p => p.Element("cID").Value == txtCourseId.Text);
            if (courseElement != null)
            {
                courseElement.Remove();
                xml.Save(URL_XML_FILE);

                loadCourses();

            }
           
        }
    }
}
