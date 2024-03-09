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
using System.Drawing.Drawing2D;

namespace AttendanceManagementSystem.User_Controls
{
    public partial class UserControlAddCourse : UserControl
    {
         XDocument xml;
        XDocument doc = XDocument.Load(@"../../../../XML files\Data.xml");
        private string URL_XML_FILE = @"../../../../XML files\Data.xml";
       // List<Course> courses = new List<Course>();
        List<XElement> teachers;

      
        string teacherName;

        public User_Controls.UserControlSettings userControlSetting;
        public UserControlAddCourse()
        {
            InitializeComponent();
         
           userControlSetting = new User_Controls.UserControlSettings();
            // subscribe on event change date format
          
            userControlSetting.DateFormatChanged += UserControl1_DateFormatChanged;

            //call loadcourse to load data from xml file and save it in courses object
            loadCourses();

            // Search for all users with role "teacher"
             teachers = doc.Root
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
                    boxTeacher.Items.Add($"{teacherName}");
                }

                // Set initial selected item if needed
                comboBoxTeacher.SelectedIndex = -1;
                //comboBoxTeacher.Enabled = false; // Disable the ComboBox to prevent user selection
            }
            else
            {
                MessageBox.Show("No teachers found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
       
       
        public void ClearTextBox()
        {
            textBoxCrsName.Clear();
            textBoxCrsId.Clear();
            comboBoxTeacher.SelectedIndex = 0;
            numericUpDownSessionNumber.Value = 1;
            dateStartDate.Value = DateTime.Now;

        }

        public string selectedDateFormat = "dd/mm/yy";

        private void UserControl1_DateFormatChanged(object sender, string selectedDateFormat)
        {
            
            SettingsManager settings = SettingsManager.Instance;
           
            // Update the selected date format
            this.selectedDateFormat = selectedDateFormat;
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

               

               
                DateTime date = DateTime.Parse(courseElement.Element("startDate").Value);
               // DateTime date = DateTime.Parse(formattedDate);
                string formattedDate = date.ToString(selectedDateFormat);

                // Get the first session element
                /*XElement firstSession = courseElement.Element("sessions").Elements("session").FirstOrDefault();
                if (firstSession != null)
                {
                    DateTime date1 = DateTime.Parse(firstSession.Element("date").Value);*/
                // string teacherName;
                teachers = doc.Root
                            .Element("Users")
                            .Elements("user")
                            .Where(u => u.Element("role")?.Value == "teacher")
                            .ToList();

                if (teachers != null)
                {
                    foreach (var teacher in teachers)
                    {
                        string teacherId1 = teacher.Element("id")?.Value;
                        if (teacherId == teacherId1)
                        {
                            teacherName = teacher.Element("name")?.Value;
                            break;
                         }

                    }


                    courses.Add(new Course
                    {
                        CourseId = courseId,
                        CourseName = courseName,
                        Sessions = sessions,
                        Date = date,
                        Teacher = teacherName,

                    });

                }
                else
                {
                    MessageBox.Show("No teachers found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

        }

        public void loadCourses ()
        {

            xmlOperation(URL_XML_FILE);
            dataGridViewCourse.AutoGenerateColumns = false;

            dataGridViewCourse.DataError += dataGridViewCourse_DataError;
            dataGridViewCourse.DataSource = null;
            dataGridViewCourse.Rows.Clear();
            dataGridViewCourse.DataSource = courses;

            // dataGridViewCourse.Columns[5].Visible = false;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void tabPageSearch_Enter(object sender, EventArgs e)
        {
            SettingsManager settings = SettingsManager.Instance;
            if (settings.DarkModeEnabled)
            {

                // Set dark mode for DataGridView
                dataGridViewCourse.DefaultCellStyle.BackColor = Color.DarkGray;
                dataGridViewCourse.DefaultCellStyle.ForeColor = Color.White;
                dataGridViewCourse.DefaultCellStyle.SelectionBackColor = Color.DarkGray;
                dataGridViewCourse.DefaultCellStyle.SelectionForeColor = Color.White;
                dataGridViewCourse.BackgroundColor = Color.Gray; // Set background color to gray
                dataGridViewCourse.GridColor = Color.Gray;
                dataGridViewCourse.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                dataGridViewCourse.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridViewCourse.RowHeadersDefaultCellStyle.BackColor = Color.Black;
                dataGridViewCourse.RowHeadersDefaultCellStyle.ForeColor = Color.White;



            }
            else
            {

                dataGridViewCourse.DefaultCellStyle.BackColor = SystemColors.Window;
                dataGridViewCourse.DefaultCellStyle.ForeColor = SystemColors.ControlText;
                dataGridViewCourse.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
                dataGridViewCourse.DefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
                dataGridViewCourse.BackgroundColor = SystemColors.Control;
                dataGridViewCourse.GridColor = SystemColors.ControlDarkDark;
                dataGridViewCourse.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.Control;
                dataGridViewCourse.ColumnHeadersDefaultCellStyle.ForeColor = SystemColors.ControlText;
                dataGridViewCourse.RowHeadersDefaultCellStyle.BackColor = SystemColors.Control;
                dataGridViewCourse.RowHeadersDefaultCellStyle.ForeColor = SystemColors.ControlText;

            }


            lblTotalCourse.Text =dataGridViewCourse.Rows.Count.ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim().ToLower();
          

            var filteredCourses = courses.Where(course => course.CourseName.ToLower().Contains(searchText)).ToList();
           

            dataGridViewCourse.DataSource = filteredCourses;
            lblTotalCourse.Text = dataGridViewCourse.Rows.Count.ToString();


        }


        private void tabPageSearch_Leave(object sender, EventArgs e)
        {

            txtSearch.Clear();
           
        }
        string x;

        private void dataGridViewCourse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewCourse.Rows[e.RowIndex];
                x = row.Cells[0].Value.ToString();

                txtCourseId.Text = row.Cells[0].Value.ToString();
                txtCourseName.Text = row.Cells[1].Value.ToString();
                upDownSession.Value= (int)row.Cells[2].Value;
                if(row.Cells[4].Value != null)
                {
                    boxTeacher.Text = row.Cells[4].Value.ToString();
                }
                
               
                //dateStartDate.Value = Convert.ToDateTime(row.Cells[3].Value);


            }
        }
        string tname;
        string tname1;
       

        private void btnUbdate_Click(object sender, EventArgs e)
        {
            int numericValue;

            XElement courseElement = xml.Descendants("course").FirstOrDefault(p => p.Element("cID").Value == x);
            if (courseElement != null)
            {
                  if (txtCourseId.Text.Trim() == string.Empty || txtCourseId.Text != courseElement.Element("cID").Value)
                {
                    MessageBox.Show("Can not be change id", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                else if (txtCourseName.Text.Trim() == string.Empty || int.TryParse(textBoxCrsName.Text, out numericValue))
                {
                    MessageBox.Show("Enter a valid Course name and must not be a number", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
               
                else if (boxTeacher.SelectedIndex == -1)
                {
                    MessageBox.Show("Assign the course to specific Teacher", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    courseElement.Element("cName").Value = txtCourseName.Text;
                    courseElement.Element("totalsessionNum").Value = upDownSession.Text;
                    tname1 = boxTeacher.Text;

                    teachers = doc.Root
                                .Element("Users")
                                .Elements("user")
                                .Where(u => u.Element("role")?.Value == "teacher")
                                .ToList();

                    if (teachers != null)
                    {

                        foreach (var teacher in teachers)
                        {
                            tname = teacher.Element("name")?.Value;
                            if (tname1 == tname)
                            {
                                if (teacher.Element("id")?.Value != null)
                                {
                                    courseElement.Element("teacher").Element("teachId").Value = teacher.Element("id")?.Value;

                                    break;
                                }
                                else
                                {
                                    courseElement.Element("teacher").Element("teachId").Value = "8456";
                                }

                            }
                        }
                    }

                    courseElement.Element("startDate").Value = dateStartDate.Text;
                    xml.Save(URL_XML_FILE);
                    MessageBox.Show("Course Upate Successfully", "Update course", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    loadCourses();
                    tabControlAddClass.SelectedTab = tabPageSearch;

                }

               

                        //courseElement.Element("teacher").Element("teachId").Value = boxTeacher.Text;
                

            }
            else
            {
                MessageBox.Show("First select row from table", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tabControlAddClass.SelectedTab = tabPageSearch;

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            XElement courseElement = xml.Descendants("course").FirstOrDefault(p => p.Element("cID").Value == txtCourseId.Text);
            if (courseElement != null)
            {
                DialogResult dialogResult = MessageBox.Show("Are you want to delete this course ?", "Delete course" ,MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    courseElement.Remove();
                    xml.Save(URL_XML_FILE);
                    MessageBox.Show("Course Deleted Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    try
                    {
                        loadCourses();
                        tabControlAddClass.SelectedTab = tabPageSearch;


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading information: " + ex.Message);

                    }


                }

            }
            else
            {
                MessageBox.Show("First select row from table", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tabControlAddClass.SelectedTab = tabPageSearch;

            }
        }
       
        private void buttonAdd_Click(object sender, EventArgs e)
        {
                int numericValue;
            /*if (textBoxCrsName.Text.Trim()==string.Empty && comboBoxTeacher.SelectedIndex == -1 && textBoxCrsId.Text.Trim()==string.Empty)
            {
                MessageBox.Show("first fill all required", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ///<summary>
                ///here i check if course name entered string or no
                ///</summary>

            }*/

            if (textBoxCrsName.Text.Trim()==string.Empty || int.TryParse(textBoxCrsName.Text, out numericValue))
                {
                    MessageBox.Show("Enter a valid Course name and must not be a number", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            else if (textBoxCrsId.Text.Trim()==string.Empty)
                {
                    MessageBox.Show("Enter a valid Course ID", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (comboBoxTeacher.SelectedIndex == -1)
                {
                    MessageBox.Show("Assign the course to specific Teacher", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else 
            {
                var existingCourseIDs = xml.Descendants("course").Select(course => course.Element("cID").Value);

                // Check if the new course ID already exists
                if (existingCourseIDs.Contains(textBoxCrsId.Text))
                {
                    MessageBox.Show("Course ID already exists. Please enter a different ID.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                XElement coursesElement = doc.Root.Element("Courses");

                XElement newCourseElement = new XElement("course",
                    new XElement("cID", textBoxCrsId.Text),
                    new XElement("cName", textBoxCrsName.Text),
                    new XElement("totalsessionNum", numericUpDownSessionNumber.Value),
                    new XElement("startDate",  dateStartDate.Value.ToString("yyyy-MM-dd")),
                    // new XElement("sessions",null),
                    new XElement("teacher",
                        new XElement("teachId", comboBoxTeacher.SelectedItem.ToString().Split('-')[0].Trim())
                    )
                );
                coursesElement.Add(newCourseElement);
                doc.Save(@"../../../../XML files\Data.xml");
                MessageBox.Show("Course Added Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTextBox();
            }
            loadCourses();
           

        }

        private void tabPageAddClass_Leave(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void dataGridViewCourse_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tabControlAddClass.SelectedTab = tabPage1;
        }

        private void dataGridViewCourse_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
            e.Cancel = false;
        }

        private void tabPage1_Leave(object sender, EventArgs e)
        {
            ClearTextBox1();
        }

        private void ClearTextBox1()
        {
            txtCourseName.Clear();
            txtCourseId.Clear();
            boxTeacher.SelectedIndex = 0;
            upDownSession.Value = 1;
            dateStartDate.Value = DateTime.Now;
        }

        private void tabPageAddClass_Enter(object sender, EventArgs e)
        {
            SettingsManager settings = SettingsManager.Instance;
            if (settings.DarkModeEnabled)
            {

                tabPageAddClass.BackColor = Color.Gray;
                tabPageSearch.BackColor = Color.Gray;
                tabPage1.BackColor = Color.Gray;
                tabPageSearch.ForeColor = Color.Black;
                
            }
            else
            {

                tabPageAddClass.BackColor = Color.White;
                tabPageSearch.BackColor = Color.White;      
                tabPage1.BackColor = Color.White;
                
            }
            
        }


       
    }
}

