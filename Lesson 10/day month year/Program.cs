/*
 * Напишіть програму для створення власного представлення дати у форматі "день-місяць-рік".

 * Вимоги:

 * Користувач повинен мати можливість ввести день, місяць та рік.
 * Програма повинна перевірити введені значення на коректність та перетворити їх у формат "день-місяць-рік".
 * Дату потрібно вивести на консоль у форматі "день-місяць-рік" (наприклад, "10-05-2024").
 * Використайте StringBuilder для конструювання рядка з датою.
 *
 */


using System.Text;

namespace day_month_year
{
    class Data
    {
        private int day;
        
        public void SetDay(int day)
        {
            
            if (day < 0)
            {
                this.day = 1;
                return;
            }
            if (day > 31)
            {
                
               if (month == 2)
               {
                    this.day = 28;
                    return;
               }
               if (month % 2 == 0)
               {
                    this.day = 30;

               }
                this.day = 31;
                return;
            }
            this.day = day;
        }

        private int month;

        public void SetMonth(int month)
        {
            if (month < 0)
            {
                this.month = 1;
                return;
            }
            if (month > 12)
            {
                this.month = 12;
                return;
            }
            this.month = month;
        }
        private int year;
        public void SetYear(int year)
        {
            if(year < 0)
            {
                this.year = 1;
                return;
            }
            this.year = year;
        }

        public int GetDay()
        { 
            return this.day; 
        }
        public int GetMonth()
        {
            return this.month;
        }
        public int GetYear()
        {
            return this.year;
        }
        public void PrintData()
        {
            Console.WriteLine($"{day}-{month}-{year}");
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int month, day, year;
            Data data = new Data();
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append("Please enter the month: ");
            Console.WriteLine(stringBuilder);
            int.TryParse(Console.ReadLine(), out month);
            data.SetMonth(month);
           

            stringBuilder.Replace("Please enter the month: ", "Please enter the day of the month: ");
            Console.WriteLine(stringBuilder);
            int.TryParse(Console.ReadLine(), out day);
            data.SetDay(day);

            stringBuilder.Replace("Please enter the day of the month: ", "Please enter the year: ");
            Console.WriteLine(stringBuilder);
            int.TryParse(Console.ReadLine(), out year);
            data.SetYear(year);

            data.PrintData();
            
        }
    }
}
