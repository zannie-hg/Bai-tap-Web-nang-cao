using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ex2
{
    internal class Duck:Animal
    {
        public Duck(string name) : base("Bird", name) { }

        public override string MakeSound()
        {
            return "Quack! Quack!";
        }

        public void Swim(string where)
        {
            Console.WriteLine($"{Name} is swimming in the {where}.");
        }
    }
}
