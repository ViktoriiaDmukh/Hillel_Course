namespace First_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Дано тризначне число. Знайти число, отримане під час прочитання його цифр справа наліво

            int triple_figuer, reciprocal_number;
            int digit1, digit2, digit3;

            Console.Write("Please enter triple figuer: ");

            triple_figuer = int.Parse(Console.ReadLine());

            digit1 = triple_figuer / 100;

            digit2 = (triple_figuer - (digit1 * 100)) / 10;

            digit3 = triple_figuer % 10;

            Console.Write($"Reciprocal number is: {digit3}{digit2}{digit1}");

            Console.ReadKey();
        }
    }
}
