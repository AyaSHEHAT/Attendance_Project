﻿using iTextSharp.xmp.impl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AttendanceManagementSystem.User_Controls
{
    public partial class UserControlAddUser : UserControl
    {
        XDocument xml;
        private string URL_XML_FILE = @"../../../../XML files\Data.xml";

        XDocument doc = XDocument.Load(@"../../../../XML files\Data.xml");

        List<User> usersList = new List<User>();
        

        List<XElement> courses;
        List<XElement> listOfCourses;
       // List<Course> coursesUpdate = new List<Course>();

        string teacherName;
        List<User> filtere;


        public UserControlAddUser()
        {
            InitializeComponent();


            courses = doc.Root
                             .Element("Courses")
                             .Elements("course")
                             .ToList();

            if (courses.Any())
            {
                foreach (var course in courses)
                {
                    string courseName = course.Element("cName")?.Value; // Get the course name

                    if (!string.IsNullOrEmpty(courseName))
                    {
                        // Add the course name to the checkedListBoxCourses
                        checkedListBoxCourses.Items.Add(courseName);
                        checkedListBoxCoursesUbdate.Items.Add(courseName);

                    }
                }


            }
            //call loadUsers to load data from xml file and save it in courses object
            loadUsers();
               

        }

        public void ClearTextBox()
        {
            textBoxUserName.Clear();
            textBoxUserID.Clear();
            textBoxUserPass.Clear();
            textBoxEmail.Clear();
            textBoxUserAddress.Clear();
            radioBtnStudent.Checked = false;
            radioBtnTeacher.Checked = false;
            checkedListBoxCourses.SelectedIndices.Clear();
        }
        public void ClearTextBox2()
        {
            txtName2.Clear();
            txtId2.Clear();
            txtPassword.Clear();
            txtEmail.Clear();
            txtAddress.Clear();

            checkedListBoxCoursesUbdate.Items.Clear();

        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            int numericValue;
            string role;
            string EmailRegx = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            string PassRegex = @"^[A-Za-z0-9]{8,}$";
            if (textBoxUserName.Text.Trim() == string.Empty || int.TryParse(textBoxUserName.Text, out numericValue))
            {
                MessageBox.Show("Enter a valid Name and must not be a number", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (textBoxUserID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter a valid User ID", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (textBoxEmail.Text.Trim() == string.Empty || Regex.IsMatch(textBoxEmail.Text.Trim(), EmailRegx) == false)
            {
                MessageBox.Show("Enter a vailid email. ex: example@example.com", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (textBoxUserPass.Text.Trim() == string.Empty || Regex.IsMatch(textBoxUserPass.Text.Trim(), PassRegex) == false)
            {
                MessageBox.Show("Enter a vailid password that must be 8 characters or more and has small and capital letters and digits", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (textBoxUserAddress.Text.Trim() == string.Empty)
            {
                MessageBox.Show("you must add Address", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (radioBtnStudent.Checked == false && radioBtnTeacher.Checked == false)
            {
                MessageBox.Show("You must choose the Role Of the user", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }else if (checkedListBoxCourses.CheckedItems.Count==0)
            {
                MessageBox.Show("You must choose at least one course", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                var existingUserIDs = xml.Descendants("user").Select(course => course.Element("id").Value);

                // Check if the new course ID already exists
                if (existingUserIDs.Contains(textBoxUserID.Text))
                {
                    MessageBox.Show("User ID already exists. Please enter a different ID.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (radioBtnStudent.Checked)
                {
                    role = "student";
                }
                else { role = "teacher"; }
                XElement listOfCourses = new XElement("listOfCourses");
                foreach (var cname in checkedListBoxCourses.CheckedItems)
                {
                    XElement courseNameElement = new XElement("courseName", cname.ToString());
                    listOfCourses.Add(courseNameElement);
                }
                XElement usersElement = doc.Root.Element("Users");
                XElement newUserElement = new XElement("user",
                    new XElement("id", textBoxUserID.Text),
                    new XElement("name", textBoxUserName.Text),
                    new XElement("age", numericUpDownAge.Value),
                    new XElement("email", textBoxEmail.Text),
                    new XElement("address", textBoxUserAddress.Text),
                     new XElement("userPass", textBoxUserPass.Text),
                    new XElement("role", role),
                   listOfCourses
                );
                usersElement.Add(newUserElement);
                doc.Save(@"../../../../XML files\Data.xml");
                MessageBox.Show("User Added Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTextBox();
            }
            loadUsers();

        }

        private void tabControlAddUser_Leave(object sender, EventArgs e)
        {
            ClearTextBox();
        }



        //  show date in grid view
        public void xmlOperation(string file)
        {
            usersList.Clear();
            try
            {
                xml = XDocument.Load(file);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading information: " + ex.Message);
            }

            //users
            foreach (XElement userElement in xml.Descendants("user"))
            {
                string Id = userElement.Element("id").Value;
                string Name = userElement.Element("name").Value;
                string Email = userElement.Element("email").Value;
                string Pass = userElement.Element("userPass").Value;
                string Age = userElement.Element("age").Value;
                string Address = userElement.Element("address").Value;
                string Role = userElement.Element("role").Value;

               
                
                usersList.Add(new User(
                    Id, Name, Email, Pass, Age, Address, Role
                    ));

            }

        }

                public void loadUsers()
                {

                    xmlOperation(URL_XML_FILE);
                   // dataGridViewUser.AutoGenerateColumns = false;


                    dataGridViewUser.DataError += dataGridViewUser_DataError;
                    dataGridViewUser.DataSource = null;
                    dataGridViewUser.Rows.Clear();
                    dataGridViewUser.Columns.Clear();

                    dataGridViewUser.Columns.Add("Id", "ID");
                    dataGridViewUser.Columns.Add("Name", "Name");
                    dataGridViewUser.Columns.Add("Email", "Email");
                    dataGridViewUser.Columns.Add("Password", "Password");
                    dataGridViewUser.Columns.Add("Age", "Age");
                    dataGridViewUser.Columns.Add("Address", "Address");
                    dataGridViewUser.Columns.Add("Role", "Role");
                    dataGridViewUser.Columns[0].Visible = false;
                    dataGridViewUser.Columns[1].Visible = false;
                    dataGridViewUser.Columns[2].Visible = false;
                    dataGridViewUser.Columns[3].Visible = false;
                    dataGridViewUser.Columns[4].Visible = false;
                    dataGridViewUser.Columns[5].Visible = false;
                    dataGridViewUser.Columns[6].Visible = false;



                    dataGridViewUser.DataSource = usersList;

                }

        private void dataGridViewUser_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
            e.Cancel = false;
        }

        private void tabPageSearch2_Click(object sender, EventArgs e)
        {
            txtTotalUser.Text = dataGridViewUser.Rows.Count.ToString();

        }

        private void tabPageSearch2_Enter(object sender, EventArgs e)
        {
            txtTotalUser.Text = dataGridViewUser.Rows.Count.ToString();
        }

        private void txtSearch2_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch2.Text.Trim().ToLower();

            // Check if filtere list is not null
            if (filtere != null && filtere.Any())
            {
                var filteredUsers = filtere.Where(user => user.Name.ToLower().Contains(searchText)).ToList();
                dataGridViewUser.DataSource = filteredUsers;
                txtTotalUser.Text = filteredUsers.Count.ToString();
            }
            else
            {
                var filteredUsers = usersList.Where(user => user.Name.ToLower().Contains(searchText)).ToList();
                dataGridViewUser.DataSource = filteredUsers;
                txtTotalUser.Text = filteredUsers.Count.ToString();
            }
        }


        private void tabPageSearch2_Leave(object sender, EventArgs e)
        {
            txtSearch2.Clear();
        }
        string IdUser;
        private void dataGridViewUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewUser.Rows[e.RowIndex];
                IdUser = row.Cells[7].Value.ToString();
                txtId2.Text = row.Cells[7].Value.ToString();
                txtName2.Text = row.Cells[8].Value.ToString();
                txtEmail.Text = row.Cells[9].Value.ToString();
                txtPassword.Text = row.Cells[10].Value.ToString();
                upDownAge.Text = row.Cells[11].Value.ToString();
                txtAddress.Text = row.Cells[12].Value.ToString();


                checkedListBoxCoursesUbdate.Items.Clear();

                // Get the user's courses
                courses = doc.Root
                            .Element("Courses")
                            .Elements("course")
                            .ToList();

                if (courses.Any())
                {
                    foreach (var course in courses)
                    {
                        string courseName = course.Element("cName")?.Value; // Get the course name

                        if (!string.IsNullOrEmpty(courseName))
                        {
                            // Add the course name to the checkedListBoxCourses
                           
                            checkedListBoxCoursesUbdate.Items.Add(courseName);

                        }
                    }


                }
                XElement userElement =xml.Root.Element("Users");
               XElement user = userElement.Elements("user").FirstOrDefault(u => u.Element("id").Value == IdUser);
      
                if (user != null)
                {
                    if (user.Element("listOfCourses").Elements("courseName") != null)
                    {
                        var listOfCourses = user.Element("listOfCourses").Elements("courseName").ToList();
                        foreach (var course in listOfCourses)
                        {
                           /// Console.WriteLine("Course: " + course.Value);
                            int index = checkedListBoxCoursesUbdate.Items.IndexOf(course.Value);

                           // Console.WriteLine("Index: " + index);
                            if (index != -1)
                            {
                                checkedListBoxCoursesUbdate.SetItemChecked(index, true);

                            }
                        }

                    }
                    
                }

      
            }
        }


        private void btnUbdate_Click(object sender, EventArgs e)
        {
            int numericValue;

            XElement userElement = xml.Descendants("user").FirstOrDefault(p => p.Element("id").Value == IdUser);
            if (userElement != null)
            {
                string EmailRegx = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                string PassRegex = @"^[A-Za-z0-9]{8,}$";

                if (txtId2.Text.Trim() == "" || txtId2.Text != userElement.Element("id").Value)
                {
                    MessageBox.Show("Can not change id", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtName2.Text.Trim() == string.Empty || int.TryParse(txtName2.Text, out numericValue))
                {
                    MessageBox.Show("Enter a valid Name and must not be a number", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtEmail.Text.Trim() == string.Empty || Regex.IsMatch(txtEmail.Text.Trim(), EmailRegx) == false)
                {
                    MessageBox.Show("Enter a valid email. ex: example@example.com", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtPassword.Text.Trim() == string.Empty || Regex.IsMatch(txtPassword.Text.Trim(), PassRegex) == false)
                {
                    MessageBox.Show("Enter a valid password that must be 8 characters or more and has small and capital letters and digits", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtAddress.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("You must add Address", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    userElement.Element("name").Value = txtName2.Text;
                    userElement.Element("age").Value = upDownAge.Text;
                    userElement.Element("email").Value = txtEmail.Text;
                    userElement.Element("address").Value = txtAddress.Text;
                    userElement.Element("userPass").Value = txtPassword.Text;

                    // Clear existing courses
                    userElement.Element("listOfCourses").Elements("courseName").Remove();

                    // Add newly checked courses
                    foreach (string courseName in checkedListBoxCoursesUbdate.CheckedItems)
                    {
                        userElement.Element("listOfCourses").Add(new XElement("courseName", courseName));
                    }

                    xml.Save(URL_XML_FILE);

                    MessageBox.Show("User Updated Successfully", "Update User", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    loadUsers();
                    tabControlAddUser.SelectedTab = tabPageSearch2;
                }
            }
            else
            {
                MessageBox.Show("First select row from table", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tabControlAddUser.SelectedTab = tabPageSearch2;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            XElement userElement = xml.Descendants("user").FirstOrDefault(p => p.Element("id").Value == txtId2.Text);
            if (userElement != null)
            {
                DialogResult dialogResult = MessageBox.Show("Are you want to delete this user ?", "Delete user", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    userElement.Remove();
                    xml.Save(URL_XML_FILE);
                    MessageBox.Show("user Deleted Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    try
                    {
                        loadUsers();
                        tabControlAddUser.SelectedTab = tabPageSearch2;


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
                tabControlAddUser.SelectedTab = tabPageSearch2;

            }
        }

        private void tabPageUpdateandDelete2_Leave(object sender, EventArgs e)
        {
            ClearTextBox2();

        }

        private void dataGridViewUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tabControlAddUser.SelectedTab = tabPageUpdateandDelete2;
        }
           

        private void comboBoxusers_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboBoxusers.SelectedIndex ==1)
            {
                 filtere = usersList.Where(user => user.Role.ToLower().Contains("teacher")).ToList();


                dataGridViewUser.DataSource = filtere;
                txtTotalUser.Text = dataGridViewUser.Rows.Count.ToString();
            }
            else if (comboBoxusers.SelectedIndex == 2)
            {
                 filtere = usersList.Where(user => user.Role.ToLower().Contains("student")).ToList();


                dataGridViewUser.DataSource = filtere;
                txtTotalUser.Text = dataGridViewUser.Rows.Count.ToString();
            }
            else
            {
                //call loadUsers to load data from xml file and save it in courses object
                loadUsers();
                txtTotalUser.Text = dataGridViewUser.Rows.Count.ToString();
            }
        }

       

        private void tabPageAdduser_Enter(object sender, EventArgs e)
        {
            SettingsManager settings = SettingsManager.Instance;
            if (settings.DarkModeEnabled)
            {

                tabPageAdduser.BackColor = Color.Gray;
                tabPageSearch2.BackColor = Color.Gray;
                tabPageUpdateandDelete2.BackColor = Color.Gray;
                tabPageSearch2.ForeColor = Color.Black;

            }
            else
            {

                tabPageAdduser.BackColor = Color.White;
                tabPageSearch2.BackColor = Color.White;
                tabPageUpdateandDelete2.BackColor = Color.White;

            }
        }
    }

        
    }
