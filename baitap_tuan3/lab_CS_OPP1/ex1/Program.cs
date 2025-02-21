using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape line = new Line(0, 0, 5, 5);
            Shape circle = new Circle(2, 3, 10);
            Shape rectangle = new Rectangle(1, 1, 4, 1, 4, 3);
            Shape polyLine = new PolyLine(new List<(int, int)> { (1, 1), (2, 3), (4, 5) });

            line.Show();
            circle.Show();
            rectangle.Show();
            polyLine.Show();
        }
    }
}
