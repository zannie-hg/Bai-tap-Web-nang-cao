using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ex2
{
    internal class Cat:Animal
    {
        public Cat(string name) : base("Mammal", name) { }

        public override string MakeSound()
        {
            return "Meow! Meow!";
        }

        public void Climb(string where)
        {
            Console.WriteLine($"{Name} is climbing {where}.");
        }
    }
}
