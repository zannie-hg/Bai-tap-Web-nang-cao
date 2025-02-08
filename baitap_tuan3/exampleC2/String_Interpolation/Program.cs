using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Interpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Soren";
            double salary = 200.234;

            // Dùng string.Format()
            string str1 = string.Format("Name{0,6}, Salary{1,7:N2}", name, salary);

            // Dùng string interpolation
            string str2 = $"Name{name,7},Salary{salary,8:N2}";

            Console.WriteLine(str1);
            Console.WriteLine(str2);

        }
    }
}
