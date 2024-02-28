using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagementSystem
{
    internal class Student : User
    {
        public List<Course> Courses { get; set; }
        public Student(int id, string name, string email, string password, string phone, string address, string role) 
        {
            Courses = new List<Course>();
            role = "Student";
        }
    }
}
