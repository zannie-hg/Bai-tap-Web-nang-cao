using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfSeries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n, tong = 0;
            Console.Write("Nhập vào một số nguyên lớn hơn 0: ");
            n = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                tong += i;
            }

            Console.WriteLine("Tổng của dãy số là: {0}", tong);
        }
    }
}
