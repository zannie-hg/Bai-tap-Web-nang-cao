using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    internal class Rectangle : Shape
    {
        private int x2, y2, x3, y3;

        public Rectangle(int x1, int y1, int x2, int y2, int x3, int y3) : base(x1, y1)
        {
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
        }

        public override void Show()
        {
            Console.WriteLine($"Rectangle with points ({x}, {y}), ({x2}, {y2}), ({x3}, {y3})");
        }

        public override string ToString()
        {
            return $"Rectangle: ({x}, {y}), ({x2}, {y2}), ({x3}, {y3})";
        }
    }
}
