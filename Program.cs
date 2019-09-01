using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            var walls = new Walls(80, 25);
            walls.Draw();

            var snake = new Snake(new Point(2, 2, '#'), 1, Direction.Down);
            snake.Draw();

            var foodCreator = new FoodCreator(80, 25, '$');
            var food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }

                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(200);
                if (Console.KeyAvailable)
                {
                    snake.HandleKey(Console.ReadKey().Key);
                }
            }
        }
    }
}