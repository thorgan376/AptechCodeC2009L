using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myapp.Models
{
    //public struct Person
    public class Person
    {        
        //string? = optional string = "string that can be null"

        public string? Name {  get; set; } //property = function
        public string? Nationality {  get; set; }
        public int BirthYear { get; set; }
        public float NetWorth { get; set; }
        public void Input()
        {
            Console.WriteLine("Name: ");
            this.Name = (Console.ReadLine() ?? "").Trim();

            Console.WriteLine("Nationality: ");
            this.Nationality = (Console.ReadLine() ?? "").Trim();
            Console.WriteLine("haha");            
            while(this.Age <= 30)
            {
                Console.WriteLine("BirthYear: ");
                this.BirthYear = Convert.ToInt32(Console.ReadLine());
                if(this.Age <= 30)
                {
                    Console.WriteLine("Person age must be greater than 30 in the current year");
                }
            }
            while (this.NetWorth < 1 || this.NetWorth > 100)
            {
                Console.WriteLine("NetWorth: ");
                this.NetWorth = (float)Convert.ToDouble(Console.ReadLine());//explicit casting
                if (this.NetWorth < 1 || this.NetWorth > 100)
                {
                    Console.WriteLine("Networth must be between 1(billion $) and 100(billion $).");
                }
            }            
        }
        //calculated value (Age)
        public int Age {
            get => BirthYear == 0 ? 0 : DateTime.Now.Year - BirthYear;
        }
        public override string ToString() =>
            $"|{Name} |{Nationality} |{BirthYear} |{NetWorth} |";
        

    }
}
