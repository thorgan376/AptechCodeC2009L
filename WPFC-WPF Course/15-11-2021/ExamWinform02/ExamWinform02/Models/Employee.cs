using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamWinform02.Models
{
    class Employee
    {
        public string EmployeeName { get; set; }
        public int EmployeeID { get; set; }
        public int Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public Department DeptID { get; set; }
        public string Tel { get; set; }
    }
}
