using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.models
{
    public class Person
    {
        public int Id {  get; set; } //property = method
        public string Name {  get; set; }
        public string Email {  get; set; }
        //auto-generated constructors, no need to define
        //Function can be "overloaded"
        public void DoTask(string taskName) { 

        }
        public void DoTask(string taskName, int time)
        {

        }
    }
}
