using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            var figures = new List<Figure>()
            {
                new HorizontalLine(0, 78, 0, '+'),
                new HorizontalLine(0, 78, 24, '+'),
                new VerticalLine(0, 24, 0, '+'),
                new VerticalLine(0, 24, 78, '+')
            };

            foreach (var figure in figures)
            {
                figure.Draw();
            }

            var point = new Point(0, 0, '#');
            var snake = new Snake(point, 10, Direction.Down);
            snake.Draw();
            snake.Move();
            Console.ReadLine();
        }
    }
}