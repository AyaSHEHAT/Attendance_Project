using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace AttendanceManagementSystem.Forms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            pictureBoxError.Hide();
            pictureBoxHide.Hide();
            labelError.Hide();
            textBoxPassword.UseSystemPasswordChar = true;
            pictureBoxShow.Show();
            pictureBoxHide.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var pass = textBoxPassword.Text;
            var id = textBoxUserId.Text;
            if (validateUserInput(out string _role,in pass,in id))
            {
                if (_role == "admin")
                {
                    this.Hide();
                    FormAdmin adminForm = new FormAdmin();
                    adminForm.Text = "Hello, World for Admin";
                    adminForm.ShowDialog();
                }else if(_role == "teacher")
                {
                    this.Hide();
                    FormTeacher teacherForm= new FormTeacher();
                    teacherForm.Text = "Hello, World for Teacher";
                    teacherForm.ShowDialog();
                }
                else
                {
                    this.Hide();
                    FormStudent studentForm = new FormStudent();
                    studentForm.Text = "Hello, World for Student";
                    studentForm.ShowDialog();
                }
            }
            else
            {
                labelError.Show();
                pictureBoxError.Show();
                textBoxPassword.Text = string.Empty;
                textBoxUserId.Text = string.Empty;
            }
            //login logic here 
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxHide_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxHide, "Hide password");
        }

        private void pictureBoxShow_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxShow, "Show password");
        }
        private void pictureBoxShow_Click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = false;
            pictureBoxShow.Hide();
            pictureBoxHide.Show();
        }

        private void pictureBocHide_Click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = true;
            pictureBoxShow.Show();
            pictureBoxHide.Hide();

        }

        private void pictureBoxError_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxClose_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxClose, "Close");
        }

        private void pictureBoxMinimize_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxMinimize, "Minimize");
        }

        private void textBoxUserId_KeyUP(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void textBoxUserId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SelectNextControl(ActiveControl, true, true, true, true);
                e.Handled = true;
            }
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                buttonLogin.PerformClick();
                e.Handled = true;
            }
        }

        private void textBoxPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }


        private static bool validateUserInput(out string _role,in string _pass,in string _id)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(@"../../../../XML files\Data.xml");

            XmlNodeList userList = xmlDoc.SelectNodes("//Users/user");
           
            foreach (XmlNode userNode in userList)
            {
                string Id = userNode.SelectSingleNode("id").InnerText.ToString();
                string password = userNode.SelectSingleNode("userPass").InnerText;
                if (( _pass == password) && (_id == Id))
                    {
                        _role = userNode.SelectSingleNode("role").InnerText;
                        User.currentUser = Id;
                        User.currentRole = _role;
                    return true;
                    }
            }
            _role = null;
            return false;

        }
    }
}
