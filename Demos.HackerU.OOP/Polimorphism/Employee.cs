using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.OOP.Polimorphism
{
    public class Employee
    {
       public int BaseSalary { get; set; }

        public Employee()
        {
            BaseSalary = 7000;
        }

        public virtual int CalculateSalary()
        {
            return BaseSalary;
        }

    }
}
