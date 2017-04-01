using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace snake
{

    class Program
    {

        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(5, 5, 60, 30, '#');
            Point p = new Point(35, 17, '*');
            Snake snake = new Snake(p, 3, Directions.RIGHT);

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.handleKey(key.Key);

                }
                Thread.Sleep(100);
                snake.Move();
            }
        }
    }
}