using LeaveManagementSystem.Enums;
using LeaveManagementSystem.Models;
using LeaveManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagementSystem.UI
{
    public static class EmployeeFlow
    {

        public static void EmployeeFlowMethod(int choice)
        {
            bool flag;
            EmployeeService employeeService = new EmployeeService();
            CompanyService companyService = new CompanyService();
            Company company = Company.Instance;
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
            }
            else
            {
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
                    Id = ManagerFlow.idcounter++,
                    Employee = employee,
                    StartDate = startDate,
                    EndDate = endDate,
                    State = LeaveStatues.Pending,
                    Reason = "Personal"

                };
                bool success = employeeService.RequestLeave(leaveRequest);

                if (success)
                    Console.WriteLine("Request Submitted Successfully!");
                else
                    Console.WriteLine("Failed to submit request");
            }
        }
    }
}
