using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class HorizontalLine : Figure
    {
        public HorizontalLine(int xLeft, int xRight, int y, char symbol)
        {
            for (var i = xLeft; i <= xRight; i++)
            {
                LinePoints.Add(new Point(i, y, symbol));
            }
        }
    }
}