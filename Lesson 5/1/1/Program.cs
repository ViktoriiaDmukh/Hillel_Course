using System.ComponentModel;
using System.ComponentModel.Design.Serialization;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Напишіть програму, яка «запитуватиме» правильний пароль, доки він не буде введений.
             * Правильний пароль нехай буде "root". Якщо пароль неправильний, програма повинна сказати "Неправильний пароль!"
             */

            Console.Write("Please enter password: ");
          
            string password = Console.ReadLine();
            int i = 1;
            while (i <= 10)
            {
                if(password == "root")
                {
                    Console.WriteLine("Access allowed!");
                    break;
                }
                else
                {
                    Console.WriteLine("Entered password is wrong!");
                    break;
                }
                i++;
            }

                         
            Console.ReadKey();
        }

    }
}
