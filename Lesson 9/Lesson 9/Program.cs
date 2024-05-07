namespace Lesson_9
{
   public class Book
    {
        public string title;
        public string author;
        public int publication;
        public int pages;

      
        

    }


    internal class Program
    {
        

        static void Main(string[] args)
        {
            var firstbook = GetInfo();
            DisplayInfo(firstbook);
            IsThick(firstbook);
            
        
        }

        private static void DisplayInfo(Book book)
        {
            Console.WriteLine("The information about the book: ");
            Console.WriteLine($"The title of the book is: {book.title}");
            Console.WriteLine($"The author of the book is: {book.author}");
            Console.WriteLine($"Publication year is: {book.publication}");
            Console.WriteLine($"Amount of the pages is: {book.pages}");
        }

        private static Book GetInfo()
        {
            Book book = new Book();
            book.title = "Pro C# 10 with .NET 6";
            book.author = "Andrew Troelson, Phil Japikse";
            book.publication = 2022;
            book.pages = 1640;

            return book;
        }

        private static object IsThick(object firstbook)
        {
            Book book = new Book();
            int pages = GetInfo().pages;

            if (pages > 500)
            {
                Console.WriteLine("This book is thick!"); 

            }
            else
            {
                Console.WriteLine("This book is not so thick!");
            }
            return true;
        }

       
    }
}
