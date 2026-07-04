using LeaveManagementSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagementSystem.Models
{
    public class Company 
    {
      public Dictionary<int, Employee> Employee { get; }
      public List<Department> Departments { get;  }
      public List<LeaveRequest> LeaveRequests { get; }

       
    }
}
