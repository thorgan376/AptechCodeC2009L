namespace Exam4
{
    public class Program
    {
        public delegate void ADelegate(string message);
        public static void AFunctionWithDelegate(string x)
        { 
            Console.WriteLine(x);
        }
        public static void Main(string[] args)
        {
            /*
            BookList bookList = new BookList();
            bookList.InputList();
            bookList.ShowList();
            */
            ADelegate aFunction = AFunctionWithDelegate;
            aFunction("This is me !");

            //test interface
            IMyInterface aFunction2 = new MyFakeClass();//ko thi phan nay
            aFunction2.DoSomething("haha");
        }
        //Thu dung interface thay cho delegate
    }
}

