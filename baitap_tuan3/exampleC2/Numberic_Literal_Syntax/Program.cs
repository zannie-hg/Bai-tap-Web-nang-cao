using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numberic_Literal_Syntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Use Digit Separators *****");

            Console.Write("Integer:");
            Console.WriteLine(123_456);  // Tương đương với 123456

            Console.Write("Double:");
            Console.WriteLine(123_456.12);  // Tương đương với 123456.12

            Console.Write("Hex:");
            Console.WriteLine(0x_00_00_FF);  // Tương đương với 255 trong hệ thập phân

            Console.WriteLine("***** Use Binary Literals *****");
            Console.WriteLine("Sixteen: {0}", 0b_0001_0000);  // Nhị phân 0001 0000 = 16
            Console.WriteLine("Thirty Two: {0}", 0b_0010_0000);  // Nhị phân 0010 0000 = 32
            Console.WriteLine("Sixty Four: {0}", 0b_0100_0000);  // Nhị phân 0100 0000 = 64

            Console.ReadLine();
        }
    }
}
