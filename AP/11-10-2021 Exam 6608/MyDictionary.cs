using System;
using DictionaryApp;
namespace DictionaryApp
{
    public class MyDictionary
    {
        private IDictionary dictionary = new Dictionary();
        public void ShowMenu()
        {
            Console.WriteLine("====================================");
            Console.WriteLine("Welcome to MyDictionary");
            Console.WriteLine("====================================");
            while (true)
            {                
                Console.WriteLine("Please choose a task:");
                Console.WriteLine("1.Add a Word");
                Console.WriteLine("2.Edit a word");
                Console.WriteLine("3.Remove a word");
                Console.WriteLine("4.List all words");
                Console.WriteLine("5.Search");
                Console.WriteLine("6.Clear Screen");
                Console.WriteLine("7.Exit");
                Console.WriteLine("Enter choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                if(choice == 1)
                {
                    Console.WriteLine("Enter a word:");
                    string word = (Console.ReadLine() ?? "").Trim();

                    Console.WriteLine($"Enter a meaning of word \"{ word}\":");
                    string meaning = (Console.ReadLine() ?? "").Trim();
                    dictionary.AddWord(meaning: meaning, word: word);
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Enter a word to edit:");
                    string word = (Console.ReadLine() ?? "").Trim();

                    Console.WriteLine($"Enter a meaning of word \"{ word}\":");
                    string meaning = (Console.ReadLine() ?? "").Trim();
                    dictionary.EditWord(meaning: meaning, word: word);

                }
                else if (choice == 3)
                {
                    Console.WriteLine("Enter a word to remove:");
                    string word = (Console.ReadLine() ?? "").Trim();
                    dictionary.Remove(word);
                }
                else if (choice == 4)
                {
                    dictionary.List();
                }
                else if (choice == 5)
                {
                    Console.WriteLine("Enter a word to search:");
                    string word = (Console.ReadLine() ?? "").Trim();
                    dictionary.Search(word);
                }
                else if (choice == 6)
                {
                    Console.Clear();
                }
                else if (choice == 7)
                {
                    break;
                }                
            }
            Console.WriteLine("Program ended");
        }
    }
}

