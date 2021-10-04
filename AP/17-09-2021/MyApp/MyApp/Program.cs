using MyApp.models;
using System;
using System.Collections.Generic;
using System.Threading;
/*
* 1 solution(workspace) can contain: 1 or many projects
*/

namespace MyApp
{
    //namspace = package in Java
    class Program
    {
        public static void Main(string[] args)
        {
            string name = "Hoang";
            int x = 10;
            int y = 20;
            //unknown
            var z = 123f;
            long creditCard = 1234_5678_9966_2233L;
            Console.WriteLine($"hello {name}, x = {x}, y = {y}"); //string template                                                                              
            Console.WriteLine($"credit card = {creditCard}");
            //int sum = Calculation.sum2Numbers(2, 4);
            //int sum = Calculation.sum2Numbers(y: 4, x: 5);//named arguments = labeled parameters
            int sum = Calculation.Sum2Numbers(x: 4, y: null);//named arguments = labeled parameters

            Console.WriteLine($"sum : {sum}");
            Calculation.DoSomeThing(123f);
            Calculation.DoSomeThing("I have a dream");
            Console.WriteLine($"multiply = {Calculation.Multiply2Numbers(x: 5, y: 3)}");
            Console.WriteLine("I say: \"I have a dream\"");
            //create 2 persons
            Person p1 = new Person() {
                Name = "Hoang",
                Id = 1,                
                Email = "hoang123@gmail.com",
            };
            Person p2 = new Person()
            {
                Name = "Andy",
                Id = 2,
                Email = "andy@gmail.com",
            };
            Person p3 = p1;//p3 and p1 are 2 separated objects(located in 2 memory addresses)
            //giong struct trong C
            p1.Name = "xxx";
            //struct is "value type", class is "reference type"
            Console.WriteLine("haha");

            List<Thread> threads = new List<Thread>();
            for(int i = 0; i < 1000; i++)
            {
                Thread t = new Thread(() => {
                    Calculation.GeneratePoints();
                });
                threads.Add(t);
                t.Start();
                Console.WriteLine($"thread {i} created");
            }
            Console.WriteLine("finish added");

        }
    }
}
