﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class VerticalLine
    {
        private List<Point> LinePoints { get; set; }

        public VerticalLine(int yTop, int yBottom, int x, char symbol)
        {
            for (var i = yTop; i <= yBottom; i++)
            {
                LinePoints.Add(new Point(x, i, symbol));
            }
        }

        public void Draw()
        {
            foreach (var linePoint in LinePoints)
            {
                linePoint.Draw();
            }
        }
    }
}