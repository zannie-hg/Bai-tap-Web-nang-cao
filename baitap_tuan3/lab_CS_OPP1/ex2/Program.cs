using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Buddy", "Spaniel");
            Cat cat = new Cat("Whiskers");
            Duck duck = new Duck("Daffy");

            Console.WriteLine(dog.GetInfo());
            Console.WriteLine(dog.MakeSound());

            Console.WriteLine(cat.GetInfo());
            Console.WriteLine(cat.MakeSound());
            cat.Climb("tree");

            Console.WriteLine(duck.GetInfo());
            Console.WriteLine(duck.MakeSound());
            duck.Swim("pond");
        }
    }
}
