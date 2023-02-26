using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.OOP.Polimorphism
{
    public abstract class Employee
    {
       public int BaseSalary { get; set; }

        //--VIRTUSL BY DEFAULT
        //--Must To do Implementation in derived/Child class
        public abstract void DisplayInfo(); 

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
