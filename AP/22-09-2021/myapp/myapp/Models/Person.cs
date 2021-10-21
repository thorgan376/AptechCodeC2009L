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

        public string? Name { get; set; } //property = function
        public string? Nationality { get; set; }
        public int BirthYear { get; set; }
        public float NetWorth { get; set; }
        public void Input()
        {
            Console.WriteLine("Name: ");
            this.Name = (Console.ReadLine() ?? "").Trim();

            Console.WriteLine("Nationality: ");
            this.Nationality = (Console.ReadLine() ?? "Anonymous").Trim();
            Console.WriteLine("Processing...");    
            
            while (this.BirthYear <= 2000 )
            {
                Console.WriteLine("Enter your Birth Year");
                this.BirthYear = Convert.ToInt32(Console.ReadLine() ?? "");
                if (this.BirthYear <= 2000)
                {
                    Console.WriteLine("Birthyear must be bigger than 2000 ");
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
        public int AgeNow { 
            get => BirthYear == 0 ? 0 : DateTime.Now.Year - BirthYear; }
        public override string ToString() =>
            $"|    {Name}   |   {Nationality}  |     {BirthYear}     |           {NetWorth}           |";
        

    }
}
