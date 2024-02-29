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
        public event ChangeFormColorEventHandler ChangeFormColorEvent;
        public UserControlSettings()
        {
            InitializeComponent();
            
        }

        private void UpdateUIForDarkMode()
        {
            SettingsManager settings = SettingsManager.Instance;
            if (settings.DarkModeEnabled)
            {
                // Set dark mode colors and styles
                this.BackColor = Color.Gray;
                this.ForeColor = Color.White;
                checkBoxDark.ForeColor = System.Drawing.Color.Indigo;
                // Update other UI elements as needed
            }
            else
            {
                // Set light mode colors and styles
                this.BackColor = Color.White;
                this.ForeColor = SystemColors.ControlText;
                checkBoxDark.ForeColor = SystemColors.ControlText;
                // Update other UI elements as needed
            }
        }
        

       

        private void checkBoxDark_CheckedChanged(object sender, EventArgs e)
        {
            SettingsManager.Instance.ToggleDarkMode();
            UpdateUIForDarkMode();
            ChangeFormColorEvent?.Invoke(this, Color.Red);
        }
    }
}
