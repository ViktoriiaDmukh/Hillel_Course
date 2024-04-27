namespace Lesson_6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Потрібно додати до масиву елемент на початок. Нехай масив буде на 10 елементів.
             * Масив заповнити рандомними числами. Той елемент, що потрібно додати, також взяти рандомно. 
             */

            int[] myArray = new int[10];

            var random = new Random();

            Console.Write("Array output: \n \n");

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = random.Next(0, 101);
                Console.Write(myArray[i] + "\t");
            }

            Console.Write("\n\nArray output with the added first value: \n \n");

            int firstValue = random.Next(0, 101);

            int[] myArray2 = new int[myArray.Length + 1];

            myArray2[0] = firstValue;

            Console.Write(myArray2[0] + "\t");

            for (int i = 1;i < myArray2.Length;i++)
            {
                myArray2[i] = myArray[i-1];
                Console.Write(myArray2[i] + "\t");
            }

            Console.ReadKey();
        }
    }
}
