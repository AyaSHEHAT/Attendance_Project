using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagementSystem
{
    internal class Course
    {
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public DateTime Date {  get; set; }
        public string AttendanceStatus { get; set; }



        public Course(string code, string name , DateTime date , string status)
        {
            CourseCode = code;
            CourseName = name;
            Date = date;
            AttendanceStatus = status;
        }
    }
}
