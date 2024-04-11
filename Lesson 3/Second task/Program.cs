namespace Second_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Написати програму, яка обчислює квадрат будь-якого введеного числа (бажано використати Math)

            Console.Write("Please enter any number that you'd like to squear: ");

            int number = int.Parse(Console.ReadLine());

            double squear_number = Math.Pow(number,2);

            Console.Write($"Squear number of the input number is: {squear_number}");

            Console.ReadKey();

        }
    }
}
