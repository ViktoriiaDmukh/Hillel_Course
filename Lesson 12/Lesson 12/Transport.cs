using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System;
 
namespace Lesson_12
{
    abstract class Transport
    {
        protected string type;
        public string Type
        { 
            get { return type; }
            set { type = value; }
        }
        
        protected int speed;
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        protected Transport(string type, int speed)
        {
            Type = type;
            Speed = speed;
        }
        public virtual void Move()
        {
            Console.WriteLine($"{Type} is going with the Max speed {Speed} km/hour");
        }
    }
        



    
}
