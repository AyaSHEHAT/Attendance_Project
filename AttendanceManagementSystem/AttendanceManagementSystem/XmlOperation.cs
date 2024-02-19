using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace AttendanceManagementSystem
{
    internal class XmlOperation
    {
        public static void printData()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("C:\\Users\\Saber\\Desktop\\Attendance_Project\\XML files\\Data.xml");

            XmlNodeList userList = xmlDoc.SelectNodes("//Users/user"); 

            foreach (XmlNode userNode in userList)
            {
                int Id = int.Parse(userNode.SelectSingleNode("id").InnerText);
                string name = userNode.SelectSingleNode("name").InnerText;
                string email = userNode.SelectSingleNode("email").InnerText;
                string address = userNode.SelectSingleNode("address").InnerText;
                string password = userNode.SelectSingleNode("userPass").InnerText;
                string role = userNode.SelectSingleNode("role").InnerText;

                Console.WriteLine($"ID: {Id}, Name: {name}, Email: {email}, Address: {address}, Role: {role}");
            }
        }

    }
}
