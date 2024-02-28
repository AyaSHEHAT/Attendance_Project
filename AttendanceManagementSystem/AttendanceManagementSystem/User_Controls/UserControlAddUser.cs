﻿using System;
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
        List<Teacher> teachersList = new List<Teacher>();
        List<Student> studentsList = new List<Student>();

        List<XElement> teachers;
        // DataTable dt;
        string teacherName;


        public UserControlAddUser()
        {
            InitializeComponent();

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
        }
        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            int numericValue;
            string role;
            string EmailRegx = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            string PassRegex = @"^[A-Za-z0-9]{8,}$";
            if (textBoxUserName.Text.Trim()==string.Empty || int.TryParse(textBoxUserName.Text, out numericValue))
            {
                MessageBox.Show("Enter a valid Name and must not be a number", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (textBoxUserID.Text.Trim()==string.Empty)
            {
                MessageBox.Show("Enter a valid User ID", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (textBoxEmail.Text.Trim()==string.Empty || Regex.IsMatch(textBoxEmail.Text.Trim(),EmailRegx)==false)
            {
                MessageBox.Show("Enter a vailid email. ex: example@example.com", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (textBoxUserPass.Text.Trim()==string.Empty || Regex.IsMatch(textBoxUserPass.Text.Trim(), PassRegex)==false)
            {
                MessageBox.Show("Enter a vailid password that must be 8 characters or more and has small and capital letters and digits", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (textBoxUserAddress.Text.Trim()==string.Empty)
            {
                MessageBox.Show("you must add Address", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (radioBtnStudent.Checked==false && radioBtnTeacher.Checked==false)
            {
                MessageBox.Show("You must choose the Role Of the user", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                if (radioBtnStudent.Checked)
                {
                    role="student";
                }
                else { role="teacher"; }
                XElement usersElement = doc.Root.Element("Users");
                XElement newUserElement = new XElement("user",
                    new XElement("id", textBoxUserID.Text),
                    new XElement("name", textBoxUserName.Text),
                    new XElement("age", numericUpDownAge.Value),
                    new XElement("email", textBoxEmail.Text),
                    new XElement("address", textBoxUserAddress.Text),
                     new XElement("userPass", textBoxUserPass.Text),
                    new XElement("role", role)
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
            teachersList.Clear();
            try
            {
                xml = XDocument.Load(file);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading information: " + ex.Message);
            }

            
            foreach (XElement userElement in xml.Descendants("user"))
            {
                string Id = userElement.Element("id").Value;
                string Name = userElement.Element("name").Value;
                string Email = userElement.Element("email").Value;
                string Pass = userElement.Element("userPass").Value;
                string Age = userElement.Element("age").Value;
                string Address = userElement.Element("address").Value;
                string Role = userElement.Element("role").Value;




                usersList.Add(new User
                {
                    Id = Id,
                    Name = Name,
                    Email = Email,
                    Password = Pass,
                    Age=Age,
                    Address = Address,
                    Role=Role


                });

            }

        }

        public void loadUsers()
        {

            xmlOperation(URL_XML_FILE);
          

            dataGridViewUser.DataError += dataGridViewUser_DataError;
            dataGridViewUser.DataSource = null;
            dataGridViewUser.Rows.Clear();

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
    }
}
