// See https://aka.ms/new-console-template for more information

string book_name, author, year_of_publication, price;

Console.WriteLine("Please eneter the name of the book; ");

book_name = Console.ReadLine();

Console.WriteLine("Please enter the author of the book: ");

author = Console.ReadLine();

Console.WriteLine("Please enter the year of publication; ");

year_of_publication = Console.ReadLine();

Console.WriteLine("Please enter the price of the book: ");

price = Console.ReadLine();

Console.WriteLine("Below you have all information about the book that you provide me: ");

Console.WriteLine(book_name + "  " + author + "  " + year_of_publication + "  " + price);

Console.ReadLine();