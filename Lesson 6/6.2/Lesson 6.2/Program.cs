namespace Lesson_6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Написати програму для інверсії масиву, тобто перевороту його у зворотному порядку.
             * В цьому завданні недостатньо просто вивести елементи масиву у зворотному порядку.
             */

            int[] myArray = new int[8];

            int numValue = 1;

            Console.WriteLine("Array output: \t");

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = numValue;
                numValue++;
                Console.WriteLine(myArray[i]);
            }

            Console.WriteLine("\nArray reverse (first method): \t");

            for (int i = myArray.Length - 1;i >= 0;i--)
            {
                Console.WriteLine(myArray[i]);
            }

            Console.WriteLine("\nArray reverse (second method): \t");

            Array.Reverse(myArray);

            for ( int i = 0;i < myArray.Length;i++)
            {
                Console.WriteLine(myArray[i]);
            }

            Console.WriteLine("\nArray reverse (third method): \t");

            int[] myArray2 = new int[8];

            int numValue2 = myArray.Length;

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray2[i] = numValue2;
                numValue2--;
                Console.WriteLine(myArray2[i]);
            }

            Console.ReadKey();
        }
    }
}
