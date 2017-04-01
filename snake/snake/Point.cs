using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point(int x, int y, char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }

        public Point(Point p)
        {
            this.x = p.x;
            this.y = p.y;
            this.sym = p.sym;
        }

        public void Move(int offset, Directions dir)
        {
            if (dir == Directions.RIGHT)
            {
                x += offset;
            }
            if (dir == Directions.LEFT)
            {
                x -= offset;
            }
            if (dir == Directions.UP)
            {
                y -= offset;
            }
            if (dir == Directions.DOWN)
            {
                y += offset;
            }
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
        public void Clear()
        {
            sym = ' ';
            Draw();
        }

        public override string ToString()
        {
            return x + "," + y + "," + sym;
        }
    }
}
