using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{

    class Program
    {

        static void Main(string[] args)
        {

            Point p1 = new snake.Point(1, 3, '*');
            p1.Draw();

            Point p2 = new snake.Point(4, 6, '#');
            p2.Draw();

            Console.ReadLine();
        }
    }
}