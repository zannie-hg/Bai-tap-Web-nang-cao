using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_For_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i=i+2) {
                Console.WriteLine("Value of i: {0}", i);
            }
        }
    }
}
