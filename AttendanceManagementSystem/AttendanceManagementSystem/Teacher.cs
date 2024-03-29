﻿



﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagementSystem
{
    internal class Teacher : User
    {
        public List<Course> CoursesTeaching { get; set; }

        public static string courseName { get; set; }

        public Teacher(string id, string name, string email, string password, string phone, string address, string role) : base(id, name, email, password, phone, address, "Teacher")
        {
            CoursesTeaching = new List<Course>();
            role = "Teacher";
        }
    }
}