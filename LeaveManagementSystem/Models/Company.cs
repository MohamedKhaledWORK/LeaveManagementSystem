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
        public List<Department> Departments { get; } 
        public List<LeaveRequest> LeaveRequests { get; set; }

        private Company()
        {
        Departments = new()
        {
            new Department { Id = 1, Name = "IT", },
            new Department { Id = 2, Name = "HR",  },
            new Department { Id = 3, Name = "Finance",},
            new Department { Id = 4, Name = "Sales", }
        };
            Employee = new Dictionary<int, Employee>
        {
            { 101, new Employee
                {
                    id = 101,
                    Name = "Ahmed Ali",
                    Department = new Department { Id = 1, Name = "IT" },
                    HireDate = new DateOnly(2023, 5, 15)
                }
            },
            { 102, new Employee
                {
                    id = 102,
                    Name = "Sara Mohammed",
                    Department = new Department { Id = 2, Name = "HR" },
                    HireDate = new DateOnly(2024, 1, 10)
                }
            },
            { 103, new Employee
                {
                    id = 103,
                    Name = "Omar Hassan",
                    Department = new Department { Id = 1, Name = "IT" },
                    HireDate = new DateOnly(2022, 11, 20)
                }
            },
            { 104, new Employee
                {
                    id = 104,
                    Name = "Fatima Khaled",
                    Department = new Department { Id = 3, Name = "Finance" },
                    HireDate = new DateOnly(2023, 8, 5)
                }
            }
        };
            LeaveRequests = new List<LeaveRequest>();
        }
    }
}
