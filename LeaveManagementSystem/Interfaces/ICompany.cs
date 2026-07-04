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
        public void ViewEmployees();
        public void ViewDepartments();
        public void ViewLeaveRequests();
        public void AddEmployee(Employee employee);
        public void RemoveEmployee(Employee employee);
        public Employee GetEmployee(int id);

    }
}
