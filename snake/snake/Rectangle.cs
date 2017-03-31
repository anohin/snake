using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Rectangle
    {
        public Rectangle(int xLeftTop, int yLeftTop, int xRightBottom, int yRightBottom, char sym)
        {
            HorisontalLine l1 = new HorisontalLine(xLeftTop, xRightBottom, yLeftTop, sym);
            l1.Draw();
            HorisontalLine l2 = new HorisontalLine(xLeftTop, xRightBottom, yRightBottom, sym);
            l2.Draw();
            VerticalLine l3 = new VerticalLine(yLeftTop + 1, yRightBottom - 1, xLeftTop, sym);
            l3.Draw();
            VerticalLine l4 = new VerticalLine(yLeftTop + 1, yRightBottom - 1, xRightBottom, sym);
            l4.Draw();
        }
    }
}
