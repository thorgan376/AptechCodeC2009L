using System;
using DictionaryApp;

namespace DictionaryApp
{
    public class Dictionary : IDictionary
    {
        private HashSet<Word> words = new HashSet<Word>();
        public void AddWord(string word, string meaning)
        {
            Word? foundWord = words
                .Where(eachWord => eachWord.word.ToLower().Trim().Equals(word))?
                .FirstOrDefault();
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
            Word? foundWord = words
                .Where(eachWord => eachWord.word.Equals(word.ToLower().Trim()))?
                .FirstOrDefault();                        
            if (foundWord != null)
            {
                foundWord.meaning = meaning;
            }
        }

        public void List()
        {
            Console.WriteLine("List words:");
            foreach(Word eachWord  in words)
            {
                eachWord.Display();
            }            
        }

        public bool Remove(string word)
        {

            Word? foundWord = words
                .Where(eachWord => eachWord.word.Equals(word.ToLower().Trim()))?
                .FirstOrDefault();
            if (foundWord != null)
            {
                words.Remove(foundWord);
                return true;
            }
            else {
                return false;
            }
        }

        public void Search(string word)
        {
            Word? foundWord = words
                .Where(eachWord => eachWord.word.ToLower().Trim().Equals(word))?
                .FirstOrDefault();
            if (foundWord != null)
            {
                foundWord.Display();
            }
            else {
                Console.WriteLine($"Cannot find the word: {word}");
            }
        }
    }
}

