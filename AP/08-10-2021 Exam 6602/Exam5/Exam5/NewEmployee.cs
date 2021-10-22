using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam5
{
    class NewEmployee:Employee
    {
        public override double CalculateBonus(string designation, int tenure, double salary)
        {
            if (designation.ToLower().Equals("teacher"))
            {
                _bonus = tenure < 3 ? salary * 3 : salary * 4;
            }
            else {
                base.CalculateBonus(designation, tenure, salary);
            }
            //cach 2, no if
            /*
            _bonus = designation.ToLower().Equals("teacher") ? tenure < 3 ? salary * 3 : salary * 4 :
                        base.CalculateBonus(designation, tenure, salary);
            */
            return _bonus;
        }
        public override void DisplayDetails()
        {
            base.DisplayDetails();
        }
        public void Input()
        {
            Console.WriteLine("Enter employee name:");
            EmpName = Console.ReadLine().Trim();
            while (true)
            {
                Console.WriteLine("Select the designation(1-4): ");
                Console.WriteLine("1 - Manager");
                Console.WriteLine("2 - Engineer");
                Console.WriteLine("3 - Technician");
                Console.WriteLine("4 - Teacher");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Designation = "Manager";
                    Salary = 5000;
                    break;
                }
                else if (choice == 2)
                {
                    Designation = "Engineer";
                    Salary = 4000;
                    break;
                }
                else if (choice == 3)
                {
                    Designation = "Technician";
                    Salary = 3000;
                    break;
                }
                else if (choice == 4)
                {
                    Designation = "Technician";
                    Salary = 2000;
                    break;
                }
                else {
                    Console.WriteLine("Invalid option selected");
                }                
            }
            Console.WriteLine("Enter year of service: ");
            YearsOfService = Convert.ToInt32(Console.ReadLine());
        }
    }
}
