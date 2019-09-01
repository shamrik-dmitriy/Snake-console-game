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
            Point point = new Point(0, 0, '#');
            Snake snake = new Snake(point, 10, Direction.Down);
            snake.Draw();
            Console.ReadLine();
        }
    }
}