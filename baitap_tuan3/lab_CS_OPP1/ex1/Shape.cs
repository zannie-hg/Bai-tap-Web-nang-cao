using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    abstract class Shape
    {
        protected int x, y;

        public Shape(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Move(int dx, int dy)
        {
            x += dx;
            y += dy;
            Console.WriteLine($"Shape moved to new position: ({x}, {y})");
        }

        public abstract void Show();

        public abstract override string ToString();
    }
}
