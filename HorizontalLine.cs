using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class HorizontalLine
    {
        private List<Point> LinePoints { get; set; }

        public HorizontalLine(int xLeft, int xRight, int y, char symbol)
        {
            for (int i = xLeft; i <= xRight; i++)
            {
                LinePoints.Add(new Point(i, y, symbol));
            }
        }

        public void Draw()
        {
            foreach (var linePoint in LinePoints)
            {
                
            }
        }
    }
}
