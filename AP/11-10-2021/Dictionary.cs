using System;
using DictionaryApp;

namespace _11_10_2021
{
    public class Dictionary : IDictionary
    {
        private HashSet<Word> words = new HashSet<Word>();
        public void AddWord(string word, string meaning)
        {
            Word? foundWord = words.Where(eachWord => eachWord.word.Equals(word))?.FirstOrDefault();
            if (foundWord == null)
            {
                words.Add(new Word()
                {
                    word = word,
                    meaning = meaning
                });
            }
            else {
                Console.WriteLine($"The word : {word} already exists");
            }
        }

        public void EditWord(string word, string meaning)
        {
            
        }

        public void List()
        {
            
        }

        public bool Remove(string word)
        {
            
        }

        public void Search(string word)
        {
            
        }
    }
}

