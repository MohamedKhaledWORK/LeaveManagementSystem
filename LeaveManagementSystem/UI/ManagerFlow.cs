using LeaveManagementSystem.Enums;
using LeaveManagementSystem.Models;
using LeaveManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagementSystem.UI
{
    public static class ManagerFlow
    {
        public static int idcounter = 1;
        public static void ManagerFlowMethod(int choice)
        {
            Company company = Company.Instance;
            ManagerService managerService = new ManagerService();
            CompanyService companyService = new CompanyService();
            int id , choice2;
            bool flag;
            switch (choice)
            {
              
                case 1:
                    // View Leave Requests
                    var leaveRequests = companyService.ViewLeaveRequests();
                    if (leaveRequests.Count == 0)
                    {
                        Console.WriteLine("No Leave Requests Found");
                        break;
                    }
                    foreach (var req in leaveRequests)
                    {
                        Console.WriteLine(req);
                    }

                    do {
                        Console.WriteLine("Choose Request Number");
                        flag = int.TryParse(Console.ReadLine(), out id);
                    } while (!flag || id < 1);
                    var req = companyService.GetLeaveRequest(id);
                    if (req == null)
                    {
                        Console.WriteLine("Leave Request not found");
                        break;
                    }
                    Console.WriteLine(companyService.GetLeaveRequest(id));
                   
                    do
                    {
                        Console.WriteLine("Do you want to Accept (1) Or Reject (2) it");
                        flag = int.TryParse(Console.ReadLine(), out choice2);
                    } while (!flag || choice2 < 1 || choice2 > 2);
                    if (choice2 == 1)
                    {
                        managerService.ApproveLeave(id);
                    }
                    else
                    {
                        managerService.RejectLeave(id);
                    }
                    break;
                case 2:
                    // Submit Leave Requests
                    Console.WriteLine("Enter Employee Id");
                    int Empid;
                    do
                    {
                        flag = int.TryParse(Console.ReadLine(), out Empid);
                    } while (!flag || Empid < 1);
                    Employee employee = companyService.GetEmployee(Empid);
                    if (employee == null)
                    {
                        Console.WriteLine("Employee not found");
                        break;
                    }
                    Console.WriteLine("Enter Start Date (yyyy-MM-dd)");
                    DateOnly startDate;
                    do
                    {
                        flag = DateOnly.TryParse(Console.ReadLine()?.Trim(), out startDate);
                    } while (!flag || startDate < DateOnly.FromDateTime(DateTime.Today));
                    Console.WriteLine("Enter End Date (yyyy-MM-dd)");
                    DateOnly endDate;
                    do
                    {
                        flag = DateOnly.TryParse(Console.ReadLine()?.Trim(), out endDate);
                    } while (!flag || endDate < startDate);
                    LeaveRequest leaveRequest = new LeaveRequest()
                    {
                        Id = idcounter++,
                        Employee = employee,
                        StartDate = startDate,
                        EndDate = endDate,
                        State = LeaveStatues.Pending,
                        Reason = "Personal"
                        
                    };
                    managerService.RequestLeave(leaveRequest);
                    break;
            }

        }
    }
}
