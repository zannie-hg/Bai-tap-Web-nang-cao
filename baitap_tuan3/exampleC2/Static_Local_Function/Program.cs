using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Local_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Hàm cục bộ tính diện tích hình tròn
            void AreaOfCircle(double radius)
            {
                double area = 3.14 * radius * radius;
                Console.WriteLine("Radius of the circle: " + radius);
                Console.WriteLine("Area of circle: " + area);

                // Gọi hàm cục bộ tĩnh để tính chu vi
                Circumference(radius);
            }

            // Static Local Function tính chu vi hình tròn
            void Circumference(double radius)
            {
                double circumference = 2 * 3.14 * radius;
                Console.WriteLine($"Circumference of the circle is: {circumference:N2}");
            }

            // Gọi hàm tính diện tích với bán kính = 10
            AreaOfCircle(10);

            Console.ReadLine();
        }
    }
}
