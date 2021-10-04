using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Product
{
    //sealed class = cannot be inherited
    //sealed abstract => NO!
    public abstract class Product
    {
        public string ProductId {  get; set; }
        public string ProductName { get; set; }
        public int Year {  get; set; }
        public float Price {  get; set; }
        public abstract void Input();//abstract = has no content
        public abstract void Display();//abstract = has no content
        public virtual void DoSomething()
        {
            //private virtual => NO!
        }
    }
}
