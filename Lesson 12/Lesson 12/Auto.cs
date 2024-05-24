using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_12
{
    internal class Auto : Transport
    {
        public int amountdoors;
        public int AmountDoors
        {
            get { return amountdoors; }
            set { amountdoors = value; }
        }
        public Auto(string type, int speed, int amountdoors): base(type, speed)
        {
            AmountDoors = amountdoors;
        }
        public override void Move()
        {
            Console.WriteLine($"{Type} with {AmountDoors} doors is going with Max speed {Speed} km/hour.");
        }
    }
}
