namespace Lesson_5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Таблиця множення

            

            int i = 1;
            while (i <= 5)
            {
                Console.WriteLine('\n');

                for (int j = 1; j <= 5; j++)
                {
                    Console.Write($"{j} * {i} = {i * j}" + "        ");
                }
                i++;
            }

            Console.WriteLine('\t');

            i = 6;
            while (i <= 10)
            {
                Console.WriteLine('\n');

                for (int j = 6; j <= 10; j++)
                {
                    Console.Write($"{j} * {i} = {i * j}" + "        ");
                }
                i++;
            }

            Console.ReadKey();

        }

    }
}
