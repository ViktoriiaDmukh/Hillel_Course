namespace Lesson4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter first value to compare: ");

            int firstValue = int.Parse(Console.ReadLine());

            Console.Write("Please enter second value to compare: ");

            int secondValue = int.Parse(Console.ReadLine());

            if (firstValue == secondValue)
            {
                Console.Write("The entered values are equal!");
            }
            else if (firstValue > secondValue)
            {
                Console.Write($"The value {firstValue} is greater then second one.");
            }
            else
            {
                Console.Write($"The value {secondValue} is greater then first one.");
            }

            Console.WriteLine();
        }

    }
}
