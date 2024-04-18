using System.CodeDom.Compiler;
using System.Numerics;

namespace Lesson_4._4
{
    internal class Program

        /* Коефіцієнти a, b, c рівняння це рандомні числа.

         a* x^2 + b* x + c = 0

         D = b^2 - 4 * a * c

         В залежності від знаку дискримінанту рівняння може:

         1) не мати коренів - D< 0 

         2) один корінь - D = 0

         3) два корені - D> 0

         Виводимо рівняння в консоль, про кількість коренів інформуємо користувача.

         Нагадую про написання власних методів, розділення обовязків між методами.

         *** (плюсик в карму) якщо рівняння має корені, то вивести їх також в консоль.*/
    {
        static void Main(string[] args)


        {
            Console.WriteLine("Solving a quadratic equation: ");

            int a = GenerateRandomNumber(1, 50);

            int b = GenerateRandomNumber(1, 50);

            int c = GenerateRandomNumber(1, 50);

            double x1, x2;

            double discriminant = Math.Pow(b, 2) - 4 * a * c;

            if (discriminant < 0)
            {
                Console.Write("The equation has no roots!");
            }
            else if (discriminant > 0)
            {
                x1 = (-b + Math.Sqrt(discriminant) / (2 * a));
                x2 = (-b - Math.Sqrt(discriminant) / (2 * a));
                Console.Write($"The roots of the equation is x1 = {x1}, x2 = {x2}");
            }
            else
            {
                x1 = (-b + Math.Sqrt(discriminant) / (2 * a));
                x2 = x1;
                Console.Write($"The roots of the equation is x1 = {x1}, x2 = {x2}");
            }

            Console.ReadKey();

        }

        private static 
            int GenerateRandomNumber(int minValue, int maxValue)
        {
           
           Random rand = new Random();
           return rand.Next(minValue, maxValue);
          
        }

    }
}
