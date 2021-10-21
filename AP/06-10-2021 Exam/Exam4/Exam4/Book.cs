using System;
namespace Exam4
{
    public class Book : IBook
    {
        private string title = "";
        private string author = "";
        private string publisher = "";
        private int year;
        private string isbn = "";
        private List<string> chapters = new List<string>(); //store chapters of this book;


        public string this[int i] {
            get {
                if(i < 0 || i > chapters.Count - 1)
                {
                    throw new Exception("out of range");
                }
                return chapters[i];
            }
            set {
                if (i < 0 || i > chapters.Count - 1)
                {
                    throw new IndexOutOfRangeException("out of range");
                }
                chapters[i] = value;
            }
        }

        public string Title {
            get => title;
            set {
                if(value.Length < 6 || value.Length > 40)
                {
                    throw new Exception("title must be 6-40 in length");
                }
                title = value;
            }
        }
        public string Author { get => author; set => author = value; }
        public string Publisher { get => publisher; set => publisher = value; }
        public int Year {
            get => year;
            set {
                if (value >= 1900 && value <= DateTime.Now.Year)
                {
                    year = value;
                }
                else {
                    throw new Exception("year must be 1900-Now");
                }
            }
        }
        public string ISBN
        {
            get => isbn;
            set
            {
                if (value.Length != 13)
                {
                    throw new Exception("isbn must be 13 characters");
                }
                title = value;
            }
        }
        public void Input()
        {
            Console.WriteLine("Input Title: ");
            Title = (Console.ReadLine() ?? "").Trim();

            Console.WriteLine("Input Author: ");
            Author = (Console.ReadLine() ?? "").Trim();

            Console.WriteLine("Input Publisher");
            Publisher = (Console.ReadLine() ?? "").Trim();

            Console.WriteLine("Input Year: ");
            Year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input ISBN: ");
            ISBN = (Console.ReadLine() ?? "").Trim();

            Console.WriteLine("Input chapters<finish with empty string>:");

            this.chapters.Clear();
            int i = 0;
            while(true)
            {
                i++;
                Console.WriteLine($"Input chapter {i}:");
                string chapter = (Console.ReadLine() ?? "").Trim();
                if (chapter.Equals("")) {
                    break;
                }                
                this.chapters.Add(chapter);
            }
        }
        public void Show()
        {
            Console.WriteLine("========================================");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Publisher: {Publisher}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine("Chapter: ");
            int i = 0; 
            foreach(string chapter in chapters)
            {
                i++;
                Console.WriteLine($"    {i}: {chapter}");
            }
            Console.WriteLine("========================================");
        }        
    }
}

