using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam5
{
    class Employee : IEmployee
    {
        private string _empName;
        private int _yearsOfService;
        protected double _bonus = 0.0;
        protected int x = 120;

        public string Designation;
        public double Salary;

        public string EmpName {
            get => _empName;
            set {
                if (value.Length < 6 || value.Length > 40)
                {
                    throw new Exception("Employee's name must be 6-40 characters");
                }
                _empName = value;
            }
        }
        public int YearsOfService
        {
            get => _yearsOfService;
            set
            {
                if (value < 0 || value > 60)
                {
                    throw new Exception("Years of service must be in range: 0-60");
                }
                _yearsOfService = value;
            }
        }


        public virtual double CalculateBonus(string designation, int tenure, double salary)
        {            
            if (designation.ToLower().Equals("manager")) {
                _bonus = (tenure <= 5) ? salary : salary * 2;
            } else if (designation.ToLower().Equals("engineer"))
            {
                _bonus = (tenure <= 5) ? salary * 0.5 : salary * 2;
            }else if (designation.ToLower().Equals("technician"))
            {
                _bonus = (tenure <= 3) ? salary * 0.25 : (tenure > 3 && tenure <= 5 ? salary * 0.5 : salary * 2);
            }

            //cach 2
            //bo het if...else
            /*
            _bonus = designation.ToLower().Equals("manager") ?
                (tenure <= 5) ? salary : salary * 2
                : (designation.ToLower().Equals("engineer") 
                ? (tenure <= 5) ? salary * 0.5 : salary * 2 :
                (designation.ToLower().Equals("technician") 
                ? (tenure <= 3) ? salary * 0.25 
                : (tenure > 3 && tenure <= 5 ? salary * 0.5 : salary * 2) : 0.0));
            */
            return _bonus;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Employee Name: {EmpName}");
            Console.WriteLine($"Designation: {Designation}");
            Console.WriteLine($"Salary: {Salary}");
            Console.WriteLine($"Total income earned: " +
                $"{Salary + CalculateBonus(Designation, YearsOfService, Salary)} $");
        }
    }
}
