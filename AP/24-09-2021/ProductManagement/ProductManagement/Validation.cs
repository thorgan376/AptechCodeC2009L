using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProductManagement
{
    public class Validation
    {
        public bool IsValidEmail(string email) =>
            (new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")).Match(email).Success;
    }
}
