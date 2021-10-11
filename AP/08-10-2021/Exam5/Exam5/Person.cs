using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam5
{
    public class Person
    {
        private string _IDCard;
        private string _name;
        private int _age;
        public string IDCard { get => _IDCard; }
        public string Name { get => _name; }
        public int Age { get => _age; }
        //like Java
        public Person(string _IDCard, string _name, int _age)
        {
            this._IDCard = _IDCard;
            this._name = _name;
            this._age = _age;
        }
        public override string ToString() => $"{IDCard}          {Name}            {Age}";
    }
}
