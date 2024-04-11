namespace Fifth_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Користувач вводить радіус круга. Напишіть програму, яка обчислює площу цього круга і виводить в консоль результат. 

            double round_radius, circle_area;

            Console.Write("Please enter the radius of the round, could be not integer amount: ");

            round_radius = double.Parse(Console.ReadLine());

            circle_area = 2 * Math.PI * round_radius;

            Console.Write($"The area of the circle is: {circle_area}");

            Console.ReadKey();

        }
    }
}
