using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.OOP.InheritanceAnimal
{
    public class BaseAnimal
    {
        public string Name { get; set; }

        public BaseAnimal()
        {
            Name = "<Animal No Name>";
        }

        public BaseAnimal(string name)
        {
            Name = name;
        }

        public void DoEat()
        {
            Console.WriteLine($"Animal {Name} Eating...");
        }

        public void DoMove()
        {
            Console.WriteLine($"Animal {Name} Moving...");
        }


    }
}
