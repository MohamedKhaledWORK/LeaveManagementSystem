using LeaveManagementSystem.Interfaces;
using LeaveManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagementSystem.Services
{
    public class CompanyService : ICompany
    {
        Company company = Company.Instance;
        public bool AddEmployee(Employee employee)
        {
            if(employee == null)
            {
                Console.WriteLine("Invalid employee data");
                return false;
            }
            company.Employee.Add(employee.id, employee);
            Console.WriteLine($"Employee {employee.Name} added successfully!");
            return true;
        }
        public bool RemoveEmployee(Employee employee)
        {
            if (employee == null)
            {
                Console.WriteLine("Invalid employee data");
                return false;
            }
            string name= employee.Name;
            company.Employee.Remove(employee.id);
            Console.WriteLine($"Employee {name} Removed successfully!");
            return true;
        }

        public Employee GetEmployee(int id)
        {
          return company.Employee[id];
        }


        public List<Department> ViewDepartments() => company.Departments.ToList();

        public List<Employee> ViewEmployees() => company.Employee.Values.ToList();

        public List<LeaveRequest> ViewLeaveRequests() => company.LeaveRequests.ToList();
    }
}
