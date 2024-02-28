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
        public Student(string id, string name, string email, string password, string phone, string address, string role) : base(id, name, email, password, phone, address, "Student")
        {
            Courses = new List<Course>();
        }
    }
}