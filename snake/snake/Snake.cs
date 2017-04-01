using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Snake : Figure
    {
        public Directions direction;

        public Snake(Point tail, int lenght, Directions direction)
        {
            this.direction = direction;
            pList = new List<Point>();
            for (int i = 0; i < lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
                p.Draw();
            }
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextpoint = new Point(head);
            nextpoint.Move(1, direction);
            return nextpoint;
        }

        public void handleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
            {
                direction = Directions.LEFT;

            }
            else if (key == ConsoleKey.RightArrow)
            {
                direction = Directions.RIGHT;
            }
            else if (key == ConsoleKey.DownArrow)
            {
                direction = Directions.DOWN;
            }
            else if (key == ConsoleKey.UpArrow)
            {
                direction = Directions.UP;
            }
        }
    }
}
