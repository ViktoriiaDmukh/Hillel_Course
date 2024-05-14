using System.Reflection.Metadata.Ecma335;
using System.Text;
/*
 * Напишіть програму для створення власного представлення дати у форматі "день-місяць-рік".

 * Вимоги:

 * Користувач повинен мати можливість ввести день, місяць та рік.
 * Програма повинна перевірити введені значення на коректність та перетворити їх у формат "день-місяць-рік".
 * Дату потрібно вивести на консоль у форматі "день-місяць-рік" (наприклад, "10-05-2024").
 * Використайте StringBuilder для конструювання рядка з датою.
 *
 */
StringBuilder sb = new StringBuilder();
int day, month, year;
Console.WriteLine("Now we are going to enter data!");
Console.Write("Please enter the day of the month: ");
int.TryParse(Console.ReadLine(), out day);
if (day < 0)
{
    Console.WriteLine("Error! Try again.");
}
if (day > 31)
{
    Console.WriteLine("Error! Try again.");
}
else
{
    
}
Console.Write("Please enter the month: ");
string month = Console.ReadLine();
Console.Write("Please enter the year: ");
string year = Console.ReadLine();
sb.Append(day);
