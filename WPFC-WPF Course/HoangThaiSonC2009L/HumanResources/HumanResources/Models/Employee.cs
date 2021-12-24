using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public int DepartmentID { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string Telephone { get; set; }
        public string Address { get; set; }
    }
}
