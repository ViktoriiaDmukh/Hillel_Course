namespace Lesson_7
{
    internal class Program
    {
        static void Main(string[] args)

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
            int length = 5;
            int[] currentMarks_Math = new int[length];
            int[] currentMarks_Social_study = new int[length];
            int[] currentMarks_Science = new int[length];
            InitializeData(currentMarks_Math);


            while (true)
            {
                int input = MultipleChoice(true, new Subjects());
                switch ((Subjects)input)
                {
                    case Subjects.Mathematics:
                        Console.Write("\n\n Your choice: Start");
                        break;
                    case Subjects.Social_study:
                        Console.Write("\n\n Your choice: Settings");
                        break;
                    case Subjects.Science:
                        Console.Write("\n\n Your choice: About");
                        break;
                    default:
                        break;
                }
                int inputMarks = MultipleChoice(true, new Marks());
                switch ((Marks)input)
                {
                    case Marks.Current_Marks:
                        Console.Write("\n");
                        for (int i = 0; i < currentMarks_Math.Length; i++)
                        {
                           
                            Console.Write(currentMarks_Math[i] + "\t");
                        }
                                         
                        break;
                    case Marks.Add_Mark:
                        Console.Write("\n\n Your choice: Settings");
                        break;
                    case Marks.Average:
                        Console.Write("\n\n Your choice: About");
                        break;
                    default:
                        break;
                }

                Console.ReadLine();
                Console.Clear();
            }
        }

        private static void InitializeData(int[] currentMarks_Math)
        {
            Random randon = new Random();
            
            for (int i = 0; i < currentMarks_Math.GetLength(0); i++)
            {
                i = randon.Next(0, 6);
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
