﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cow cow1 = new Cow("Kobe");
            cow1.Sleep();
            cow1.Eat();
            cow1.Swim();
            Duck duck1 = new Duck("Donal");
            duck1.Sleep();
            duck1.Eat();
            duck1.Fly();
            duck1.Swim();
            Console.ReadLine();
        }
    }
}
