using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_14
{
    internal class CalculatorPlugin : IPlug
    {
        public void Execute()
        {
            int firstVariable = 100;
            int secondVariable = 100;
            int multiple = firstVariable * secondVariable;
            Console.WriteLine($"The result of the multiplication: {firstVariable} * {secondVariable} = {multiple}");
        }
    }
}
