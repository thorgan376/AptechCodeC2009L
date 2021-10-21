using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam5
{
    class EmployeeTest
    {
        public void Test()
        {
            NewEmployee newEmployee = new NewEmployee();
            newEmployee.Input();
            newEmployee.DisplayDetails();
        }
    }
}
