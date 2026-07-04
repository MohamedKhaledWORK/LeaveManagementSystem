using LeaveManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagementSystem.Interfaces
{
    public interface ICompany
    {
        public List<Employee> ViewEmployees();
        public List<Department> ViewDepartments();
        public List<LeaveRequest> ViewLeaveRequests();
        public bool AddEmployee(Employee employee);
        public bool RemoveEmployee(Employee employee);
        public Employee GetEmployee(int id);

    }
}
