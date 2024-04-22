
namespace Lesson_5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *  Програма загадує число від 1 до 146 (привіт, Random). Користувач намагається вгадати його.
             *  У разі неправильної відповіді програма підказує «більше» або «менше»
             */

            int randomNumber = GenerateRandomNumber(147);

            Console.WriteLine("Please enter random number from 0 to 146 to compare it: ");

            

            int tryTimes = 1;

            while(tryTimes < 15)
            {
                int enteredNumber = int.Parse(Console.ReadLine());

                if (randomNumber < enteredNumber)
                {
                    Console.WriteLine("Less!");
                   
                }
                else if (randomNumber > enteredNumber)
                {
                    Console.WriteLine("More");
                    
                }
                else
                {
                    Console.WriteLine("You guessed!");
                   
                }

                tryTimes++;
                
                
            }
           
            Console.ReadKey();


        }

        private static int GenerateRandomNumber(int limit)
        {
            
            Random rand = new Random();
            return rand.Next(limit);
           
        }
    }
}
