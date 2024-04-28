namespace Lesson_6._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Написати програму, яка виводить всі елементи масиву доки не зустрінеться елемент -1. 
             * Масив заповнити рандомними числами, діапазон чисел від -5 до 5. 
             */

            int[] myArray = new int[11];

            var random = new Random();

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = random.Next(-6, 6);
                
                if (myArray[i] != -1)
                {
                    Console.Write(myArray[i] + "\t");
                }
            }

            Console.WriteLine("\n Sorry I have met element -1 and I have closed inputing elements of the Array!");

            Console.ReadKey();


        }
    }
}
