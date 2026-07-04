using LeaveManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagementSystem.Interfaces
{
    public interface IManager : IEmployee
    {
        public void ApproveLeave();
        public void RejectLeave();
    }
}
