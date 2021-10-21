// See https://aka.ms/new-console-template for more information
using myapp.Models;
namespace myapp {
    public class Program { 
        public static void Main(string[] args)
        {
            Console.WriteLine("Write a C program using C#");
            Person p1 = new Person() //constructor
            {
                Name = "Nguyen Van A",
                Nationality = "vietnam",
                BirthYear = 1997,
                NetWorth = 1234
            };
            Person p2 = new Person() //constructor
            {
                //Name = "Nguyen Van A",
                Nationality = "vietnam",
                BirthYear = 1997,
                NetWorth = 1234
            };
            Person p3 = p1;
            //question ? p3 la "clone" cua p1 hay la "reference" cua p1 ?
            //p3 la "clone" cua p1 new Person la struct
            //p3 la "reference" cua p1 new Person la class
            
            Console.WriteLine($"p1.name = {p1.Name}");
            Console.WriteLine($"p3.name = {p3.Name}");
            Menu menu= new Menu();
            menu.ShowMenu();

        }
    }
}