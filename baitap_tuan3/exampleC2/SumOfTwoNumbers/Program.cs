using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so thu nhat: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so thu hai: ");
            int num2 = int.Parse(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine($"Tong cua {num1} va {num2} la {sum}");
        }
    }
}
