using LeaveManagementSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagementSystem.Services
{
    public class ManagerService : EmployeeService , IManager
    {

        public void ApproveLeave()
        {
            throw new NotImplementedException();
        }

        public void RejectLeave()
        {
            throw new NotImplementedException();
        }

    }
}
