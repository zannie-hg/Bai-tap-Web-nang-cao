using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tìm nghiệm của phương trình bậc hai
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập hệ số a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Nhập hệ số b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Nhập hệ số c: ");
            double c = double.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("Đây không phải là phương trình bậc hai.");
            }
            else
            {
                double delta = b * b - 4 * a * c;

                if (delta > 0)
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine($"Phương trình có 2 nghiệm phân biệt: x1 = {x1}, x2 = {x2}");
                }
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine($"Phương trình có nghiệm kép: x = {x}");
                }
                else
                {
                    Console.WriteLine("Phương trình vô nghiệm.");
                }
            }
        }
    }
}

