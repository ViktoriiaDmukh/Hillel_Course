/*
   1) Користувач повинен ввести свій вік за допомогою консолі.

   2) Програма повинна перевірити, чи вік введений коректно (ціле додатнє число).

   3) Якщо вік введений некоректно (наприклад, це не ціле число або він менший за 0), програма повинна викинути виняток FormatException.

   4) Якщо вік введений коректно, програма повинна вивести повідомлення про вік користувача.

   5) Обробіть виняток FormatException та виведіть користувачеві повідомлення про помилку.

   6) Програма повинна продовжити своє виконання після обробки винятку.
 */

namespace Lesson_11_2
{
    class InvAgeExeption:Exception
    {
        public InvAgeExeption(string message):base(message)
        {
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            bool isValide = false;
            while(!isValide)
            {
                Console.WriteLine("Please enter you age: ");
                try
                {
                    age = int.Parse(Console.ReadLine());

                    try
                    {
                        if (age == 0) throw new InvAgeExeption("Your age can't be 0!");
                        if (age > 0) throw new InvAgeExeption("Your age can't be less than 0!");
                        if (age < 18) throw new InvAgeExeption("Sorry, but your age is less than 18");
                        if (age > 75) throw new InvAgeExeption("Please ask someone to help you! It might be difficult for you!");
                        if (age > 100) throw new InvAgeExeption("Your age can not be greater than 100! Please check your input data!");
                        isValide = true;
                        Console.WriteLine("Your age is {0}", age);
                    }
                    catch (InvAgeExeption e)
                    {
                        Console.WriteLine(e.Message);
                    }

                }
                catch
                {
                    Console.WriteLine("Error during convertion! Please try again!");
                }
            }
           

        }   
    }    
}
