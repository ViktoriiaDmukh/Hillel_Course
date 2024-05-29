using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_14_2
{
    internal class LogEntry
    {
        public DateTime Timestamp { get; set; }
        public string Message {  get; set; }

        public LogEntry(string message)
        {
            Timestamp = DateTime.Now;
            Message = message;
        }
        public override string ToString()
        {
            return $"{Timestamp}: {Message}";
        }
    }
}
