using LeaveManagementSystem.Models;
using LeaveManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LeaveManagementSystem.UI
{
    public static class AdminFlow
    {
        public static void AdminFlowMethod(int choice)
        {
           
            Company company = Company.Instance;
            CompanyService companyService = new CompanyService();
            int Empid;
            bool flag;
            //Console.WriteLine("1. Add Employee");
            //Console.WriteLine("2. Remove Employee");
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Not Working Yet");
                    //Employee employee = new Employee() { };
                    //companyService.AddEmployee(employee);
                    // Add Employee
                    break;
                case 2:
                    Console.WriteLine("Not Working Yet");
                    //companyService.RemoveEmployee(employee.id);
                    // Remove Employee
                    break;
                case 3:
                    // View Employees
                    var Emps = companyService.ViewEmployees();
                    if (Emps.Count == 0)
                    {
                        Console.WriteLine("No Employees Found");
                        break;
                    }
                    foreach (var emp in Emps)
                    {
                        Console.WriteLine(emp);
                    }
                    break;
                case 4:
                    // View Specific Employee
                    do
                    {
                        Console.WriteLine("Enter Employee Id");
                        flag = int.TryParse(Console.ReadLine(), out Empid);
                    } while (!flag || Empid < 1);
                    Console.WriteLine(companyService.GetEmployee(Empid));
                    break;
                case 5:
                    // View Department
                    var Depts = companyService.ViewDepartments();
                    if (Depts.Count == 0)
                    {
                        Console.WriteLine("No Departments Found");
                        break;
                    }
                    foreach (var dept in Depts)
                    {
                        Console.WriteLine(dept);
                    }

                    break;
                case 6:
                    // View Leave Requests
                   var requests = companyService.ViewLeaveRequests();
                    if (requests.Count == 0)
                    {
                        Console.WriteLine("No Leave Requests Found");
                        break;
                    }
                    foreach (var req in requests)
                    {
                        Console.WriteLine(req);
                    }
                    break;
                case 7:
                    // View Accepted Leave Requests
                    var Arequests = companyService.ViewAcceptedLeaveRequests();
                    if (Arequests.Count == 0)
                    {
                        Console.WriteLine("No Leave Requests Found");
                        break;
                    }
                    foreach (var req in Arequests)
                    {
                        Console.WriteLine(req);
                    }

                    break;
                case 8:
                    // View Rejected Leave Requests
                    var Rrequests = companyService.ViewRejectedLeaveRequests();
                    if (Rrequests.Count == 0)
                    {
                        Console.WriteLine("No Leave Requests Found");
                        break;
                    }
                    foreach (var req in Rrequests)
                    {
                        Console.WriteLine(req);
                    }
                    break;
            }
        }
    }
}
