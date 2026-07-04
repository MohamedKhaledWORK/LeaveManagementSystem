using LeaveManagementSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagementSystem.Models
{
    public class Company
    {
      private static Company? _instance;

        public static Company Instance
        {
            get 
            {
                _instance ??= new Company();
                return _instance;
            }
        }
      public Dictionary<int, Employee> Employee { get; }
      public List<Department> Departments { get;  }
      public List<LeaveRequest> LeaveRequests { get; }

        private Company()
        {
        }
    }
}
