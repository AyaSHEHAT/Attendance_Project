using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
