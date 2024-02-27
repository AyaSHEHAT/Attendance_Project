using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagementSystem
{
    internal class Report_teacher
    {
        public int StdId { get; set; }
        public string StdName { get; set; }
        public string Date { get; set; }
        public string CName { get; set; }
        public string Status { get; set; }

        public Report_teacher(int id, string name,string date,string cname, string stat)
        {
            StdId = id;
            StdName = name;
            Date=date;
            CName = cname;
            Status = stat;

        }

        public Report_teacher()
        {
        }
    }
}
