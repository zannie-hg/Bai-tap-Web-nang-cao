using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref_Out
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            Console.WriteLine($"Giá trị ban đầu của a: {a}");

            Square(ref a);
            Console.WriteLine($"Giá trị của a sau khi gọi hàm Square: {a}");

            int result;
            GetDoubleValue(out result);
            Console.WriteLine($"Giá trị của result sau khi gọi GetDoubleValue: {result}");
        }
        static void Square(ref int num)
        {
            num *= num;
        }

        static void GetDoubleValue(out int value)
        {
            value = 10 * 2;  // Bắt buộc phải gán giá trị trước khi return
        }
    }
}
