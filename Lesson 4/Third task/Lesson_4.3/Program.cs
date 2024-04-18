namespace Lesson_4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Напишіть програму, яка приймає від користувача число від 1 до 100.
             * При цьому якщо число кратне трьом, програма повинна виводити слово Fizz, а якщо кратно п'яти - слово Buzz.
             * Якщо число кратно п'ятнадцяти, програма повинна виводити слово FizzBuzz.
             * Завдання може здатися очевидним, але потрібно отримати найбільш просте та красиве рішення.
             */

            

            Console.Write("Please enter random number in the range from 1 to 100: ");

            int value = int.Parse(Console.ReadLine());

            if (value < 1)
            {
                Console.WriteLine("Please try again, the value can not be less then 1!");
                
            }
            else if (value > 100)
            {
                Console.WriteLine("Please try again, the value can not be greater then 100!");
            }
            else
            {
                Console.WriteLine($"You've done great! Your value is {value}");
               
            }

            if (value % 3 == 0)
            {
                Console.Write("Fizz");
            }

            else if (value % 5 == 0)
            {
                Console.Write("Buzz");
            }
            else if(value % 15 == 0)
            {
                Console.Write("FizzBuzz");
            }
            else
            {
                Console.ReadKey();
            }

            Console.ReadKey();
        }
    }
}
