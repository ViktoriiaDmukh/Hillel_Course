using System;

namespace Lesson_7
{
    internal class Program
    {
        static void Main(string[] args)

        {
           
            /*
        * Створіть програму, яка дозволяє вводити оцінки студента з різних предметів та обчислювати середню оцінку. 
        * Використовуйте масиви для зберігання оцінок. 
        * 
        * Завдання повинно включати такі пункти:
        * 
        * Введення оцінок студента з різних предметів (наприклад, математика, історія, мова).
        * Збереження цих оцінок у масивах.
        * Обчислення середньої оцінки студента на основі введених даних.
        * Виведення середньої оцінки на екран.
        * Виведення оцінок. 
        */
            {

                int[] currentMarks_Math = new int[5];
                int[] currentMarks_Social_study = new int[5];
                int[] currentMarks_Science = new int[5];
                InitializeDataMath(currentMarks_Math);
                InitializeDataSS(currentMarks_Social_study);
                InitializeData(currentMarks_Science);
                int[] currentMarks = null;

                var random = new Random();

                while (true)
                {
                    int input = MultipleChoice(true, new Subjects());
                    switch ((Subjects)input)
                    {
                        case Subjects.Mathematics:
                            currentMarks = currentMarks_Math;
                            break;
                        case Subjects.Social_study:
                            currentMarks = currentMarks_Social_study;
                            break;
                        case Subjects.Science:
                            currentMarks = currentMarks_Science;
                            break;
                        default:
                            break;
                    }
                    int inputMarks = MultipleChoice(true, new Marks());
                    

                    switch ((Marks)input)
                    {
                        case Marks.Current_Marks:
                            switch ((Subjects)input)
                            {
                                case Subjects.Mathematics:
                                    Console.WriteLine("\n\n");
                                    for (int i = 0; i < currentMarks.Length; i++)
                                    {
                                        Console.Write(currentMarks[i] + ";" + "\t");
                                    }
                                    break;
                                case Subjects.Social_study:
                                    Console.WriteLine("\n\n");
                                    for (int i = 0; i < currentMarks.Length; i++)
                                    {
                                        Console.Write(currentMarks[i] + ";" + "\t");
                                    }
                                    break;
                                case Subjects.Science:
                                        Console.WriteLine("\n\n");
                                    for (int i = 0; i < currentMarks.Length; i++)
                                    {
                                        Console.Write(currentMarks[i] + ";" + "\t");
                                    }
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case Marks.Add_Mark:                          
                            Array.Resize(ref currentMarks, currentMarks.Length +1);                            
                            var newGrade = int.Parse(Console.ReadLine());
                            currentMarks[currentMarks.Length - 1] = newGrade;
                            
                            var action = int.Parse(Console.ReadLine());
                            switch (action)
                            {
                                case 0:                                   
                                    currentMarks_Math = currentMarks;
                                    break;
                                case 1:                                    
                                    currentMarks_Social_study = currentMarks;
                                    break;
                                case 2:                                    
                                    currentMarks_Science = currentMarks;
                                    break;
                            default:
                                    break;
                            }
                            break;
                        case Marks.Average:
                            Console.Write($"\n\n Average mark: {currentMarks.Average()}");
                            break;
                        default:
                            break;
                    }

                    Console.ReadLine();
                    Console.Clear();
                }
            }

            
        }

        private static void InitializeData(int[] currentMarks_Science)
        {
            Random randon = new Random();
            for (int i = 0; i < currentMarks_Science.GetLength(0); i++)
            {
                currentMarks_Science[i] = randon.Next(0, 6);
            }
        }

        private static void InitializeDataSS(int[] currentMarks_Social_study)
        {
            Random randon = new Random();
            for (int i = 0; i < currentMarks_Social_study.GetLength(0); i++)
            {
                currentMarks_Social_study[i] = randon.Next(0, 6);
            }
        }

        private static void InitializeDataMath(int[] currentMarks_Math)
        {
            Random randon = new Random();
            for (int i = 0; i < currentMarks_Math.GetLength(0); i++)
            {
                currentMarks_Math[i] = randon.Next(0, 6);
            }

        }

        enum Subjects
        {
            Mathematics,
            Social_study,
            Science
        }
        enum Marks
        {
            Current_Marks,
            Add_Mark,
            Average
        }
        /// <summary>
        /// Menu based enum
        /// </summary>
        /// <param name="canCancel"></param>
        /// <param name="userEnum">Enum enumeration of the user for which we build the menu</param>
        /// <param name="spacingPerLine">Number of indents between columns</param>
        /// <param name="optionsPerLine">Number of values in one column</param>
        /// <param name="startX">Number of indents on the left side of the console</param>
        /// <param name="startY">Number of indents on the upper side of the console</param>
        /// <returns></returns>
        public static int MultipleChoice(bool canCancel, Enum userEnum, int spacingPerLine = 15, int optionsPerLine = 3,
            int startX = 1, int startY = 2)
        {
            int currentSelection = 0;
            ConsoleKey key;
            Console.CursorVisible = false;
            int length = Enum.GetValues(userEnum.GetType()).Length;
            do
            {
                Console.Clear();
                Console.WriteLine("The marks for subjects below for the student: ");
                Console.WriteLine("\n");

                for (int i = 0; i < length; i++)
                {

                    Console.SetCursorPosition(startX + (i % optionsPerLine) * spacingPerLine, startY + i / optionsPerLine);

                    if (i == currentSelection)
                        Console.ForegroundColor = ConsoleColor.Red;

                    Console.Write(Enum.Parse(userEnum.GetType(), i.ToString()));

                    Console.ResetColor();
                }

                key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                        {
                            if (currentSelection % optionsPerLine > 0)
                                currentSelection--;
                            break;
                        }
                    case ConsoleKey.RightArrow:
                        {
                            if (currentSelection % optionsPerLine < optionsPerLine - 1)
                                currentSelection++;
                            break;
                        }
                    case ConsoleKey.UpArrow:
                        {
                            if (currentSelection >= optionsPerLine)
                                currentSelection -= optionsPerLine;
                            break;
                        }
                    case ConsoleKey.DownArrow:
                        {
                            if (currentSelection + optionsPerLine < length)
                                currentSelection += optionsPerLine;
                            break;
                        }
                    case ConsoleKey.Escape:
                        {
                            if (canCancel)
                                return -1;
                            break;
                        }
                }
            } while (key != ConsoleKey.Enter);

            Console.CursorVisible = true;

            return currentSelection;
        }
    }
}

