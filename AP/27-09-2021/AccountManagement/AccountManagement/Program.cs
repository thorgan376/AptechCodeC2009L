using BookManagement;

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
                    Publisher = "p2",
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
            };
        }
    }
}