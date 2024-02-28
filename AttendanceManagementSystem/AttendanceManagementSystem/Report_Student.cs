using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagementSystem
{
    internal class Report_Student
    {
        public string Date { get; set; }
        public string SessionNum { get; set; }
        public string Status { get; set; }

        public Report_Student ( string sessNum, string date, string stat)
        {
          
            SessionNum = sessNum;
            Date=date;
            Status = stat;

        }

    
    }
}
