namespace Third_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Дано тризначне число. Знайти число, отримане під час перестановки першої та другої цифр заданого числа

            int triple_figuer;
            int digit1, digit2, digit3;

            Console.Write("Please enter triple figuer: ");

            triple_figuer = int.Parse(Console.ReadLine());

            digit1 = triple_figuer / 100;

            digit2 = (triple_figuer - (digit1 * 100)) / 10;

            digit3 = triple_figuer % 10;

            Console.Write($"Adjusted number is: {digit2}{digit1}{digit3}");

            Console.ReadKey();
        }
    }
}
