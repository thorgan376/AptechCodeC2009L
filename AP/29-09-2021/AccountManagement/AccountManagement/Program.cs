using BookManagement;
using System.Linq;// Language Integrated Query
namespace AccountManagement
{
    public class Program
    {
        public static void Main(string [] args)
        {
            List<Book> books = new List<Book>();
            /*
            Console.WriteLine("Enter number of books");
            int numberOfBooks = Convert.ToInt32 (Console.ReadLine());
            for(int i = 0; i < numberOfBooks;i++)
            {
                Console.WriteLine($"Enter book [{i + 1}]");
                Book book = new Book();
                book.Input();
                books.Add(book);
            }
            */
            Console.WriteLine("haha");
            //fake books
            books = new List<Book>()
            { 
                new ReferenceBook(){ 
                    Code = "c11",
                    Price = 11,
                    Amount = 1,
                    Publisher = "p1",
                    Tax = 0.2f
                },
                new SchoolBook(){
                    Code = "c22",
                    Price = 22,
                    Amount = 2,
                    Publisher = "x",
                    BookType = BookType.New
                },
                new ReferenceBook(){
                    Code = "c33",
                    Price = 33,
                    Amount = 3,
                    Publisher = "p3",
                    Tax = 0.15f
                },
                new SchoolBook(){
                    Code = "c44",
                    Price = 44,
                    Amount = 4,
                    Publisher = "p4"
                },
                new SchoolBook(){
                    Code = "c55",
                    Price = 55,
                    Amount = 5,
                    Publisher = "x"
                },
            };
            double totalMoneyOfSchoolBooks = 0.0;
            double totalMoneyOfReferenceBooks = 0.0;
            int numberOfReferenceBooks = 0;
            foreach(var book in books)
            {
                if(book is ReferenceBook)
                {
                    totalMoneyOfReferenceBooks += ((ReferenceBook)book).TotalPrice;
                } else if(book is SchoolBook)
                {
                    totalMoneyOfSchoolBooks += ((SchoolBook)book).TotalPrice;
                    numberOfReferenceBooks += ((SchoolBook)book).Amount;
                }
            }
            Console.WriteLine($"totalMoneyOfSchoolBooks = {Math.Round(totalMoneyOfSchoolBooks, 2)}, \n" +
                $"totalMoneyOfReferenceBooks={Math.Round(totalMoneyOfReferenceBooks, 2)},\n" +
                $"average reference books: {Math.Round(totalMoneyOfReferenceBooks / numberOfReferenceBooks, 2)}\n");
            List<Book> filteredBooks = books
                .Where(eachBook => eachBook is SchoolBook && eachBook.Publisher.ToLower().Equals("x"))
                .ToList();
            foreach(Book book in filteredBooks)
            {
                Console.WriteLine(book.ToString());
            }

        }
    }
}