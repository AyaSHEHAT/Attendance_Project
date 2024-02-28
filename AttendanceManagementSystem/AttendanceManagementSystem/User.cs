using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagementSystem
{
    internal class User
    {
        public String Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Age { get; set; }
        public string Address { get; set; }
        public string Role { get; set; }
        public static string currentUser { get; set; }
        public static string currentRole { get; set; }

        public User(string id, string name, string email, string password, string age, string address, string role)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
            Age = age;
            Address = address;
            Role = role;

        }
    }
}
