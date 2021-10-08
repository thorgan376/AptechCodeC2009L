using System;
namespace Exam4
{
    public class BookList
    {
        private List<Book> list = new List<Book>();
        public void AddBook()
        {
            Book book = new Book();
            Console.WriteLine("==============================================");
            Console.WriteLine("Input book information");
            book.Input();
            list.Add(book);
            Console.WriteLine("==============================================");
        }
        public void ShowList()
        {
            Console.WriteLine($"Amount of books: {list.Count}");
            foreach(Book book in list)
            {
                book.Show();
            }
        }
        public void InputList()
        {
            Console.WriteLine("Number of books: ");
            int numberOfBooks = int.Parse(Console.ReadLine() ?? "");
            for (int i = 0; i < numberOfBooks; i++)
            {
                AddBook();
            }

        }
    }
}

