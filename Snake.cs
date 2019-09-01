using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Snake : Figure
    {
        #region Private Properties

        /// <summary>
        ///     Направление перемещения
        /// </summary>
        private Direction Direction { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        ///     Конструктор
        /// </summary>
        /// <param name="tail">Позиция хвоста змейки</param>
        /// <param name="length">Длина змейки</param>
        /// <param name="direction">Направление перемещения змейки</param>
        public Snake(Point tail, int length, Direction direction)
        {
            Direction = direction;
            for (var i = 0; i <= length; i++)
            {
                var point = new Point(tail);
                point.Move(i, direction);
                LinePoints.Add(point);
            }
        }

        #endregion

        #region Public Methods

        /// <summary>
        ///     Перемещает змейку
        /// </summary>
        public void Move()
        {
            var tail = LinePoints.First();
            LinePoints.Remove(tail);
            var head = GetNextPoint();
            LinePoints.Add(head);

            tail.Clear();
            head.Draw();
        }

        /// <summary>
        ///     Обработка нажатия клавиш
        /// </summary>
        /// <param name="key">Клавиша</param>
        public void HandleKey(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    Direction = Direction.Left;
                    break;
                case ConsoleKey.RightArrow:
                    Direction = Direction.Right;
                    break;
                case ConsoleKey.DownArrow:
                    Direction = Direction.Down;
                    break;
                case ConsoleKey.UpArrow:
                    Direction = Direction.Up;
                    break;
            }
        }

        /// <summary>
        ///     Процесс поедания
        /// </summary>
        /// <param name="food">Точка еды</param>
        /// <returns>True - в данном ходе змейка ест, False - в данном ходе змейка не ест</returns>
        public bool Eat(Point food)
        {
            var head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.Symbol = head.Symbol;
                LinePoints.Add(food);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        ///     Обработка столкновения с хвостом
        /// </summary>
        /// <returns>True - столкновение было, False - столкновения не было</returns>
        public bool IsHitTail()
        {
            var head = LinePoints.Last();
            for (var i = 0; i < LinePoints.Count - 2; i++)
            {
                if (head.IsHit(LinePoints[i]))
                {
                    return true;
                }
            }

            return false;
        }

        #endregion

        #region Private Methods

        /// <summary>
        ///     Получить следующую точку
        /// </summary>
        /// <returns>Следующая точка</returns>
        private Point GetNextPoint()
        {
            var nextPoint = new Point(LinePoints.Last());
            nextPoint.Move(1, Direction);
            return nextPoint;
        }

        #endregion
    }
}