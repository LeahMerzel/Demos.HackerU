using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.OOP.InheritanceAnimal
{
    public class Mammal : BaseAnimal
    {

        public Mammal()
        {
            Name = "<Mammal No Name>";
        }

        public Mammal(string name) : base(name)
        {
        }

        public new void DoMove()
        {
            Console.WriteLine($"Fish {Name} Move...");
        }

        public void DoRun()
        {
            Console.WriteLine($"Mammal {Name} Run...");
        }

    }
}
