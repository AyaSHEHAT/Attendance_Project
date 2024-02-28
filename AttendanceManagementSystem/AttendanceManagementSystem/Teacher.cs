using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagementSystem
{
    internal class Teacher : User
    {
        public List<Course> CoursesTeaching { get; set; }
        public Teacher(int id, string name, string email, string password, string phone, string address, string role) 
        {
            CoursesTeaching = new List<Course>();
            role = "Teacher";
        }
    }
}
