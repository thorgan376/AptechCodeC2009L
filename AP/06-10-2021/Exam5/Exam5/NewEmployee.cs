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

    }
}
