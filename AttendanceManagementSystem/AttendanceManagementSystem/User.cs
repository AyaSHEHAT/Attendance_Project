using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagementSystem
{
    internal class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Role { get; set; }
        public static string currentUser { get; set; }
        public static string currentRole { get; set; }

        public User(int id , string name , string email , string password , string phone , string address , string role)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
            Phone = phone;
            Address = address;
            Role = role;
            
        }
    }
}
