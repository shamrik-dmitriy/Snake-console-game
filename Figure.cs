using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Figure
    {
        protected Figure()
        {
            LinePoints = new List<Point>();
        }

        protected List<Point> LinePoints { get; set; }

        public void Draw()
        {
            foreach (var linePoint in LinePoints)
            {
                linePoint.Draw();
            }
        }
    }
}