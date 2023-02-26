using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.OOP.Polimorphism
{
    public class QA : Employee
    {
        int BugFixCount { get; set; }

        public QA(int bugFixCount)
        {
            BugFixCount = bugFixCount;
        }

        public override int CalculateSalary()
        {
            return base.CalculateSalary() + (BugFixCount * 1000);
        }

        public override void DisplayInfo()
        {
            
            Console.WriteLine("BugFixes:" + BugFixCount);
        }

   
    }
}
