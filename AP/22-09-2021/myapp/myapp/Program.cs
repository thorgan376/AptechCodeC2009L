// See https://aka.ms/new-console-template for more information
using myapp.Models;
namespace myapp {
    public class Program { 
        public static void Main(string[] args)
        {
            Console.WriteLine("Write a C program using C#");
            Person p1 = new Person() //constructor
            {
                Name = "Program test by C",
                Nationality = "VietNam",
                BirthYear = 1997,
                NetWorth = 1234
            };
            Person p3 = new Person() //constructor
            {
                Name = "But now written by C#",
                Nationality = "Russia",
                BirthYear = 1997,
                NetWorth = 1234
            };
            //question ? p3 la "clone" cua p1 hay la "reference" cua p1 ?
            //p3 la "clone" cua p1 new Person la struct
            //p3 la "reference" cua p1 new Person la class
            Console.WriteLine($"They said = {p1.Name}");
            Console.WriteLine($"I said = {p3.Name}");
            Menu menu = new Menu();
            menu.ShowMenu();

        }
    }
}