using LeaveManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagementSystem.Interfaces
{
    public interface IEmployee
    {
        public bool RequestLeave(LeaveRequest leaveRequest);
    }
}
