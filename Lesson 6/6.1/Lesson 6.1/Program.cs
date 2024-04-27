namespace Lesson_6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Задати масив із 10 елементів. Заповнити цей масив рандомними числами від -100 до 100.
             * Знайти кількість додатніх чисел у масиві. Вивести на екран масив і кількість порахованих чисел. 
             */

            int[] myArray = new int[10];

           var random = new Random();
           

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = random.Next(-101, 101);
                Console.Write(myArray[i] + "\t");
            }

            int integer = 0;

            for (int i = 0; i < myArray.Length;i++)
            {
                if (myArray[i] > 0)
                {
                    integer++;
                }
            }
           
            Console.WriteLine($"\n\nThe amount of integers: {integer} ");

            Console.ReadKey();
        }
    }
}
