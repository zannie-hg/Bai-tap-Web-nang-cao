using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingAndUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int num = 10;  // Value type
            object obj = num;  // Boxing: Ép kiểu từ value type sang object
            int unboxedNum = (int)obj;  // Unboxing: Ép kiểu từ object về int

            Console.WriteLine($"Giá trị sau khi unboxing: {unboxedNum}");
        }
    }
}
