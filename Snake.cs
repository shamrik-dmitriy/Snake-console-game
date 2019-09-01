using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Snake : Figure
    {
        private Point BeginPoint { get; set; }
        private Point EndPoint { get; set; }

        public Snake(Point tail, int length, Direction direction)
        {
            for (var i = 0; i <= length; i++)
            {
                var point = new Point(tail);
                point.Move(i, direction);
                LinePoints.Add(point);
            }
        }
    }
}