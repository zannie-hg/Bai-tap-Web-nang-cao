using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.Write("Nhập số nguyên a: ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Nhập số nguyên b: ");
                int b = int.Parse(Console.ReadLine());

                Console.Write("Nhập toán tử (+, -, *, /): ");
                char op = Console.ReadLine()[0];

                switch (op)
                {
                    case '+':
                        Console.WriteLine($"Kết quả: {a + b}");
                        break;
                    case '-':
                        Console.WriteLine($"Kết quả: {a - b}");
                        break;
                    case '*':
                        Console.WriteLine($"Kết quả: {a * b}");
                        break;
                    case '/':
                        if (b != 0)
                            Console.WriteLine($"Kết quả: {a / (double)b}");
                        else
                            Console.WriteLine("Lỗi: Không thể chia cho 0.");
                        break;
                    default:
                        Console.WriteLine("Toán tử không hợp lệ.");
                        break;
                }
            }
        }
    }
}
