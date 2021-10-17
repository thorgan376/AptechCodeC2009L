using System;
using System.Collections.Generic;
using System.Linq;
using TodoApp.Models;
//insert to DB
//install SQL Server(2019) in Docker
//access SQL Server using Azure DB Studio(Windows/MacOS)
//pull and start SQL Server container:
/*
docker run -d --name sql-server-2019-c2009l \
-e "ACCEPT_EULA=Y" \
-e "SA_PASSWORD=Abc123456789" \
-p 1434:1433 \
-d mcr.microsoft.com/mssql/server:2019-latest
 */
namespace TodoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDBContext myDBContext = new MyDBContext();            
            int choice;
            while (true)
            {
                Console.WriteLine("1. Insert new Todo");
                Console.WriteLine("2. Show all Todos");
                Console.WriteLine("3. Edit a Todo item");
                Console.WriteLine("4. Delete a Todo");
                
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    //insert to DB
                    Console.WriteLine("Enter todo's content: ");
                    Todo todo = new Todo()
                    {
                        Content = Console.ReadLine(),
                        IsFinished = false
                    };
                    myDBContext.Todos.Add(todo);
                    myDBContext.SaveChanges();
                }
                else if (choice == 2)
                {
                    List<Todo> allTodos = myDBContext.Todos.ToList();
                    foreach (Todo todo in allTodos)
                    {
                        Console.WriteLine(todo.ToString());
                    }
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Enter todo's Id: ");
                    int selectedId = Convert.ToInt32(Console.ReadLine());
                    Todo foundTodo = myDBContext.Todos.Where(todo => todo.Id == selectedId).FirstOrDefault();
                    if (foundTodo == null)
                    {
                        Console.WriteLine("Cannot find this Todo");
                    } else {
                        Console.WriteLine("Enter content: ");

                    }
                }
                else
                {
                    break;
                }
            }
        }
    }
}
