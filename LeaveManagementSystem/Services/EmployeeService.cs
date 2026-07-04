using LeaveManagementSystem.Interfaces;
using LeaveManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagementSystem.Services
{
    public class EmployeeService : IEmployee
    {
        Company company = Company.Instance;

        public bool RequestLeave(LeaveRequest leaveRequest)
        {
            if (leaveRequest == null)
            {
                Console.WriteLine("Invalid data");
                return false;
            }
            if (leaveRequest.Employee == null)
            {
                Console.WriteLine("Invalid Employee data");
                return false;
            }

            company.LeaveRequests.Add(leaveRequest);
            Console.WriteLine("Request Submitted");
            return true;
        }

    }
}
