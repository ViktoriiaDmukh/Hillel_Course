﻿namespace Fourth_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Дано тризначне число. Знайти число, отримане під час перестановки першої та другої цифр заданого числа.

            double firstValue, secondValue;

            Console.Write("Please enter first value: ");

            firstValue = double.Parse(Console.ReadLine());

            Console.Write("Please enter second value: ");

            secondValue = double.Parse(Console.ReadLine());

            double result = (firstValue + secondValue) / 2;

            Console.Write($"Arithmetic mean of the two values is: {result}");

            Console.ReadKey();

        }
    }
}
