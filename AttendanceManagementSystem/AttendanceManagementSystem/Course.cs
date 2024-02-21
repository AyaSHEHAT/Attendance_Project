using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagementSystem
{
    internal class Course
    {
        public string CourseId { get; set; }
        public string CourseName { get; set; }
        public int Sessions { get; set; }
        public DateTime Date {  get; set; }
        public string Teacher { get; set; }
        public string AttendanceStatus { get; set; }



       /* public Course(string Id, string name , DateTime startDate , int sessions ,string teacher ,string status)
        {
            CourseId = Id;
            CourseName = name;
            Date = startDate;
            Sessions = sessions;
            Teacher = teacher;
            AttendanceStatus = status;
        }*/
    }
}
