using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_14_2
{
    public static class Logger
    {
        private static readonly ArrayList logs = new ArrayList();
        public static void AddLog(string message)
        {
            logs.Add(new LogEntry(message));
        }
        public static ArrayList GetLogs()
        {
            return new ArrayList(logs);
        }
    }
}
