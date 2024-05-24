using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_12
{
    internal class Bicycle: Transport
    {
        public string bicycleType;
        public string BicycleType
        {
            get { return bicycleType; }
            set { bicycleType = value; }
        }

        public Bicycle(string type, int speed, string bicycleType): base(type, speed)
        {
            BicycleType = bicycleType;
        }
        public override void Move()
        {
            Console.WriteLine($"{Type} ({BicycleType}) is going with the Max speed {Speed} km/hour. ");
        }

    }
}
