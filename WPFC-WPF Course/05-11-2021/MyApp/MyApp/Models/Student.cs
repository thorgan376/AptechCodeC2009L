using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Models
{
    public class Student
    {
        public int Id {  get; set; }
        public string Name {  get; set; }
        public string Gender {  get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public Class Class { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
