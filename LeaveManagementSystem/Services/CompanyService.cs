using LeaveManagementSystem.Enums;
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

        public Employee? GetEmployee(int id)
        {
            if (company.Employee.TryGetValue(id, out Employee? employee))
            {
                return employee;
            }

            Console.WriteLine($"❌ No employee found with ID: {id}");
            return null;
        }
        public LeaveRequest GetLeaveRequest(int id)
        {
            var Request = company.LeaveRequests.FirstOrDefault(l => l.Id == id);
            if (Request == null)
            {
                Console.WriteLine("Leave Request not found");
                return null;
            }
            return Request;
        }
        public List<Department> ViewDepartments() => company.Departments?.ToList() ?? new List<Department>();

        public List<Employee> ViewEmployees() => company.Employee?.Values?.ToList() ?? new List<Employee>();

        public List<LeaveRequest> ViewLeaveRequests() => company.LeaveRequests?.ToList() ?? new List<LeaveRequest>();
        public List<LeaveRequest> ViewAcceptedLeaveRequests() => company.LeaveRequests?.Where(l=>l.State==LeaveStatues.Approved)?.ToList() ?? new List<LeaveRequest>();
        public List<LeaveRequest> ViewRejectedLeaveRequests() => company.LeaveRequests?.Where(l => l.State == LeaveStatues.Rejected)?.ToList() ?? new List<LeaveRequest>();

      
    }
}
