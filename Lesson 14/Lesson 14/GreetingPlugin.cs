using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_14
{
    internal class GreetingPlugin : IPlug
    {
        public void Execute()
        {
            Console.WriteLine("Congratulation! This message is going from the GreetingPlugin!");
        }
    }
}
