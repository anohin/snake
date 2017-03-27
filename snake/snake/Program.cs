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
            
            Point p2 = new snake.Point(4, 6, '#');

            List<Point> pList = new List<Point>();

            pList.Add(p1);
            pList.Add(p2);

            pList[0].Draw();
            pList[1].Draw();

            Console.ReadLine();
        }
    }
}