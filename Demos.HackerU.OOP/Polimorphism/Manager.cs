using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.OOP.Polimorphism
{
    public class Manager : Employee
    {
        public int LidsCount { get; set; }
        public Manager(int lidsCount)
        {
            LidsCount = lidsCount;
        }

        public override int CalculateSalary()
        {
            return base.CalculateSalary() + (LidsCount*5000);
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Lids:"+LidsCount);
        }
    }
}

