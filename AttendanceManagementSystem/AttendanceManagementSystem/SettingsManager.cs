using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagementSystem
{
    public class SettingsManager
    {
        public event EventHandler<string> DateFormatChanged;
        private static SettingsManager instance;
        public int f = 0;

        public bool DarkModeEnabled { get; private set; }

        private SettingsManager()
        {
            // Initialize default settings
            DarkModeEnabled = false;
        }

        public static SettingsManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SettingsManager();
                }
                return instance;
            }
        }

        // Method to toggle dark mode
        public void ToggleDarkMode()
        {
            DarkModeEnabled = !DarkModeEnabled;
        }
    }

}
