using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceManagementSystem.User_Controls
{
    public delegate void ChangeFormColorEventHandler(object sender, Color newColor);

    public partial class UserControlSettings : UserControl
    {
        public UserControlSettings()
        {
            InitializeComponent();
            radioBtnLight.Checked = true;
        }

        private void UpdateUIForDarkMode()
        {
            SettingsManager settings = SettingsManager.Instance;
            if (settings.DarkModeEnabled)
            {
                // Set dark mode colors and styles
                this.BackColor = Color.Black;
                this.ForeColor = Color.White;
                // Update other UI elements as needed
            }
            else
            {
                // Set light mode colors and styles
                this.BackColor = SystemColors.Control;
                this.ForeColor = SystemColors.ControlText;
                // Update other UI elements as needed
            }
        }
        private void radioBtnark_CheckedChanged(object sender, EventArgs e)
        {
            /*SettingsManager.Instance.ToggleDarkMode();
            UpdateUIForDarkMode();*/
            this.BackColor = Color.Black;
            this.ForeColor = Color.White;
           

        }

        private void radioBtnLight_CheckedChanged(object sender, EventArgs e)
        {
             this.BackColor = Color.White;
                this.ForeColor = Color.Black;
        }
    }
}
