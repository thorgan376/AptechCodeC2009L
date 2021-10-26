using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryManagement
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
