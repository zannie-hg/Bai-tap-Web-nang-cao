using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Local_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 2;

            // Định nghĩa Local Function (Hàm cục bộ)
            void AddValue(int a, int b)
            {
                Console.WriteLine("Value of a is: " + a);
                Console.WriteLine("Value of b is: " + b);
                Console.WriteLine("Value of x is: " + x);
                Console.WriteLine("Value of y is: " + y);
                Console.WriteLine("Sum: {0}", a + b + x + y);
                Console.WriteLine();
            }

            // Gọi hàm cục bộ với các giá trị cụ thể
            AddValue(3, 4);
            AddValue(5, 6);

            Console.ReadLine();
        }
    }
}
