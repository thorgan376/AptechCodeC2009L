using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam5
{
    class PersonTest
    {
        public void Test()
        {
            Person person1 = new Person("id0001", "Nguyen Van A", 20);
            Person person2 = new Person("id0002", "Nguyen Van B", 25);
            PersonVietnam personVietnam = new PersonVietnam(2);
            personVietnam[0] = person1;
            personVietnam[1] = person2;
            personVietnam.DisplayDetails();
        }
    }

}
