namespace Lesson_4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Написати програму, в якій користувач вводить номер місяця. Якщо місяць 1,2,12 відображає "Зима"; 3,4,5 - «Весна»;
            // 6-8 - «Літо»; 9-11 – «Осінь». У будь-якому іншому випадку - "Немає такого місяця на цій планеті" .

            Console.Write("Please enter month number: ");

            byte month = byte.Parse(Console.ReadLine());

            switch (month)
            {
                case 1:
                    Console.WriteLine("January is the first month of the year and it is winter");
                    break;
                case 2:
                    Console.WriteLine("Fabruary is the second month of the year and it is winter");
                    break;
                case 3:
                    Console.WriteLine("March is the third month of the year and it's still winter in Canada and spring in Ukraine");
                    break;
                case 4:
                    Console.WriteLine("April is the fourth month of the year and it's spring");
                    break;
                case 5:
                    Console.WriteLine("May is the fifth month of the year and it's spring");
                    break;
                case 6:
                    Console.WriteLine("June is the sixth month of the year and it's summer, but not in Canada");
                    break;
                case 7:
                    Console.WriteLine("July is the seventh month of the year and it's summer");
                    break;
                case 8:
                    Console.WriteLine("August is the eighth month of the year and it's summer");
                    break;
                case 9:
                    Console.WriteLine("September is the ninth month of the year and it's fall, not so easy in Canada");
                    break;
                case 10:
                    Console.WriteLine("October is the tenth month of the year and it's fall");
                    break;
                case 11:
                    Console.WriteLine("November is the eleventh month of the year and it's fall");
                    break;
                case 12:
                    Console.WriteLine("December is the twelfth month of the year and it's winter. Not still so cold in Canada, but it's not winter here....");
                    break;
                default:
                    Console.WriteLine("Ooooopsss....There is no such a month in this universe! Try again!");
                    break;


            }
            Console.ReadKey();
        }
    }
}
