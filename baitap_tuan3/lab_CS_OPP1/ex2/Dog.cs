using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    internal class Dog:Animal
    {
        private string Breed;

        public Dog(string name, string breed) : base("Mammal", name)
        {
            Breed = breed;
        }

        public override string MakeSound()
        {
            return "Woof! Woof!";
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $", Breed: {Breed}";
        }
    }
}
