﻿using System;
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

            var snake = new Snake(new Point(0, 0, '#'), 10, Direction.Down);
            snake.Draw();
            var foodCreator = new FoodCreator(80, 25, '$');
            var food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
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