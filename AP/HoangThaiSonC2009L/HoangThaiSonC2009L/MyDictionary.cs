using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryManagement
{
    public class MyDictionary
    {
        private IDictionary dictionary = new Dictionary();
        public void ShowMenu()
        {
            Console.WriteLine("====================================================================");
            Console.WriteLine("================Welcome to my Dictionary Management=================");
            Console.WriteLine("====================================================================");
            while (true)
            {
                Console.WriteLine("Please choose a task from down bellow:");
                Console.WriteLine("1. Add a word: ");
                Console.WriteLine("2. Edit a word: ");
                Console.WriteLine("3. Remove a word: ");
                Console.WriteLine("4. List all word: ");
                Console.WriteLine("5. Search: ");
                Console.WriteLine("6. Clear Screen: ");
                Console.WriteLine("7. Exit: ");
                Console.WriteLine("Enter choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("Enter Word: ");
                    string word = (Console.ReadLine() ?? "").Trim();
                    Console.WriteLine($"Enter the meaning of word \"{word}\":");
                    string meaning = (Console.ReadLine() ?? "".Trim());
                    dictionary.AddWord(meaning: meaning, word : word);
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Edit Word now: ");
                    string word = (Console.ReadLine() ?? "").Trim();
                    Console.WriteLine($"Enter the meaning of word \"{word}\":");
                    string meaning = (Console.ReadLine() ?? "".Trim());
                    dictionary.EditWord(meaning: meaning, word: word);
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Enter a word to remove: ");
                    string word = (Console.ReadLine() ?? "").Trim();
                    dictionary.Remove(word);
                }
                else if(choice == 4)
                {
                    dictionary.List();
                }
                else if(choice == 5)
                {
                    Console.WriteLine("Enter a word to search: ");
                    string word = (Console.ReadLine() ?? "").Trim();
                    dictionary.Search(word);
                }
                else if(choice == 6)
                {
                    Console.WriteLine("Clear now");
                    Console.Clear();
                }
                else if(choice == 7)
                {
                    break;
                }
            }
            Console.WriteLine("Program Ended");
        }
    }
}
