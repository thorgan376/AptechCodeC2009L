using System;
using DictionaryApp;

namespace DictionaryApp
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

