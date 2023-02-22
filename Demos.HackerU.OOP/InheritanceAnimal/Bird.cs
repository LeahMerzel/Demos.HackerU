using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.OOP.InheritanceAnimal
{
    public class Bird : BaseAnimal
    {
        public Bird()
        {
            Name = "<Bird No Name>";
        }

        public Bird(string name) : base(name)
        {
        }

        public new void DoMove()
        {
            Console.WriteLine($"Bird {Name} Move...");
        }

        public void DoFly()
        {
            Console.WriteLine($"Bird {Name} Flying...");
        }



    }
}
