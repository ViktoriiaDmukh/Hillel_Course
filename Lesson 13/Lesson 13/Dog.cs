﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_13
{
    internal class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark!");
        }

        public override void Move()
        {
            Console.WriteLine("Runs!"); 
        }
    }
}
