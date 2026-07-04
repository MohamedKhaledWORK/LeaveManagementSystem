using LeaveManagementSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagementSystem.Models
{
    public class Employee 
    {
        public  int id { get; set; }
        public  string Name { get; set; }
        public  Department Department { get; set; }
        public  DateOnly HireDate { get; set; }
        public override string ToString()
        {
            return $"ID: {id} | Name: {Name} | Department: {Department.Name} | Hire Date: {HireDate}";
        }

    }
}
