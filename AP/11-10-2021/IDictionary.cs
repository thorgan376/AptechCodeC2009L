using System;
namespace DictionaryApp
{
    public interface IDictionary
    {
        void AddWord(string word, string meaning);
        void EditWord(string word, string meaning);
        bool Remove(string word);
        void List();
        void Search(string word);
    }
}

