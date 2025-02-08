using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Var_Dynamic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var name = "John";  
            var age = 25;      

            dynamic data = "Hello";
            Console.WriteLine($"Giá trị dynamic: {data}");

            data = 100;  // dynamic có thể thay đổi kiểu dữ liệu tại runtime
            Console.WriteLine($"Giá trị dynamic sau khi thay đổi: {data}");
        }
    }
}
