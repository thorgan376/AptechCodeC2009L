using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryManagement
{
    public class Word : IWord
    {
        public string? word { get; set; }
        public string? meaning { get; set; }
        public void Display()
        {
            Console.WriteLine($"Word here: {word} : {meaning}");
        }
    }
}
