using iTextSharp.xmp.impl;
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
        public void ClearTextBox2()
        {
            txtName2.Clear();
            txtId2.Clear();
            txtPassword.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
           
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

            }
            else
            {
                if (radioBtnStudent.Checked)
                {
                    role = "student";
                }
                else { role = "teacher"; }
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
            usersList.Clear();
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


            var filteredUsers = usersList.Where(user => user.Name.ToLower().Contains(searchText)).ToList();


            dataGridViewUser.DataSource = filteredUsers;
            txtTotalUser.Text = dataGridViewUser.Rows.Count.ToString();

        }

        private void tabPageSearch2_Leave(object sender, EventArgs e)
        {
            txtSearch2.Clear();
        }

        private void dataGridViewUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewUser.Rows[e.RowIndex];
                txtId2.Text = row.Cells[7].Value.ToString();
                txtName2.Text = row.Cells[8].Value.ToString();
                txtEmail.Text = row.Cells[9].Value.ToString();
                txtPassword.Text = row.Cells[10].Value.ToString();
                upDownAge.Text = row.Cells[11].Value.ToString();
                txtAddress.Text = row.Cells[12].Value.ToString();


              /* string role= row.Cells[13].Value.ToString();

                if (role== "student")
                {
                    rdoStudent.Checked = true;
                }
                else if (role== "teacher")
                {
                    rdoStudent.Checked = true;


                }*/
                
                // admin

            }
        }
        private void btnUbdate_Click(object sender, EventArgs e)
        {
            int numericValue;

            XElement userElement = xml.Descendants("user").FirstOrDefault(p => p.Element("id").Value == txtId2.Text);
            if (userElement != null)
            {
                if (txtId2.Text.Trim() == "" || txtId2.Text != userElement.Element("id").Value)
                {
                    MessageBox.Show("Can not be change id", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                
                string EmailRegx = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                string PassRegex = @"^[A-Za-z0-9]{8,}$";
                if (txtName2.Text.Trim() == string.Empty || int.TryParse(txtName2.Text, out numericValue))
                {
                    MessageBox.Show("Enter a valid Name and must not be a number", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                
                else if (txtEmail.Text.Trim() == string.Empty || Regex.IsMatch(txtEmail.Text.Trim(), EmailRegx) == false)
                {
                    MessageBox.Show("Enter a vailid email. ex: example@example.com", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (txtPassword.Text.Trim() == string.Empty || Regex.IsMatch(txtPassword.Text.Trim(), PassRegex) == false)
                {
                    MessageBox.Show("Enter a vailid password that must be 8 characters or more and has small and capital letters and digits", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (txtAddress.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("you must add Address", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
               
                else
                {
                    userElement.Element("name").Value = txtName2.Text;
                    userElement.Element("age").Value = upDownAge.Text;
                    userElement.Element("email").Value = txtEmail.Text;
                    userElement.Element("address").Value = txtAddress.Text;
                    userElement.Element("userPass").Value = txtPassword.Text;

                    
                    xml.Save(URL_XML_FILE);
                   
                    MessageBox.Show("User Upate Successfully", "Update User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    loadUsers();
                    tabControlAddUser.SelectedTab = tabPageSearch2;

                }



                //courseElement.Element("teacher").Element("teachId").Value = boxTeacher.Text;


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
    }

        
    }
