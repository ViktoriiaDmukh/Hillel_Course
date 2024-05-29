using System.Collections;

namespace Lesson_14_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger.AddLog("Start!");
            Logger.AddLog("Enter!");
            Logger.AddLog("The operation has been done!");
            Logger.AddLog("Exit!");

            ArrayList logs = Logger.GetLogs();
            Console.WriteLine("System logs: ");
            foreach(LogEntry log in logs)
            {
                Console.WriteLine(log);
            }
        }
    }
}
