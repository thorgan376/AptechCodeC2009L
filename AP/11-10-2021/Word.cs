using System;
using DictionaryApp;

namespace _11_10_2021
{
    public class Word : IWord
    {
        public string word { get; set; }//not recommended
        public string meaning { get; set; }
        public void Display()
        {
            Console.WriteLine($"{word} : {meaning}");
        }
    }
}

