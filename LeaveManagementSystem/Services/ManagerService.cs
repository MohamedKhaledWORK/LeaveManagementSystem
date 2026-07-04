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
    public class ManagerService : EmployeeService , IManager
    {

        Company company = Company.Instance;
        public bool ApproveLeave(int id )
        {
            LeaveRequest? leaveRequest = company?.LeaveRequests?.FirstOrDefault(l => l.Id == id);    // ! = I know it's not null
            if(leaveRequest == null )
            { 
                Console.WriteLine("Leave Request not found");
                return false;
            }
            leaveRequest.State = LeaveStatues.Approved;
            Console.WriteLine("Leave Request Accepted");
            return true;
        }

        public bool RejectLeave(int id)
        {

            var leaveRequest = company?.LeaveRequests?.FirstOrDefault(l => l.Id == id);    // ! = I know it's not null
            if (leaveRequest == null)
            {
                Console.WriteLine("Leave Request not found");
                return false;
            }
            leaveRequest.State = LeaveStatues.Rejected;
            Console.WriteLine("Leave Request Rejected");
            return true;
        }

    }
}
