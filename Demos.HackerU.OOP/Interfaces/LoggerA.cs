using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.OOP.Interfaces
{
    public class LoggerA : ILogger
    {
        public void Log(string text, int level)
        {
            Console.WriteLine(text + " (" + level + ")");
        }

        public void Log(string text, int level, string fileName)
        {
             var logEntry = string.Format("{0}-{1}"+Environment.NewLine,text,level);
             File.WriteAllText("LoggerA.txt",logEntry);

        }
    }
}
