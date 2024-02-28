using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagementSystem
{
    internal class Admin : User
    {
        public Admin(string id, string name, string email, string password, string phone, string address, string role) : base(id, name, email, password, phone, address, "Admin")
        {
        }
    }
}
