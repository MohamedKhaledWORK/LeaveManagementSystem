using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagementSystem.UI
{
    public static class ProgramMenu
    {
       public static void DisplayMenu()
        {
            Console.WriteLine("Welcome to the Leave Management System");
            Console.WriteLine("1. Admin");
            Console.WriteLine("2. Manager");
            Console.WriteLine("3. Employee");
            Console.WriteLine("4. Exit");
        }
        public static void AdminMenu()
        {
            Console.WriteLine("Welcome to Admin Dashboard");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Remove Employee");
            Console.WriteLine("3. View EmployeeS");
            Console.WriteLine("4. View Specific Employee ");
            Console.WriteLine("5. View Department");
            Console.WriteLine("6. View Leave Requests");
            Console.WriteLine("7. View Accepted Leave Requests");
            Console.WriteLine("8. View Rejected Leave Requests");
            Console.WriteLine("9. Back");
        }
        public static void EmployeeMenu()
        {
            Console.WriteLine("Welcome to Employee Dashboard");
            Console.WriteLine("1. Submit Leave Requests");
            Console.WriteLine("2. Back");
        }
        public static void ManagerMenu()
        {
            Console.WriteLine("Welcome to Manager Dashboard");
            Console.WriteLine("1. View Leave Requests");
            Console.WriteLine("2. Submit Leave Requests");
            Console.WriteLine("3. Back");
        }
    }
}
