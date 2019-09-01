using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Point
    {
        #region Public Properties

        /// <summary>
        ///     Координата по оси X
        /// </summary>
        public int X { get; set; }

        /// <summary>
        ///     Координата по оси Y
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        ///     Символ вывода
        /// </summary>
        public char Symbol { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        ///     Конструктор для точки с заданием координат по осям
        /// </summary>
        /// <param name="x">Координата по оси X</param>
        /// <param name="y">Координата по оси Y</param>
        /// <param name="symbol">Символ отрисовки</param>
        public Point(int x, int y, char symbol)
        {
            X = x;
            Y = y;
            Symbol = symbol;
        }

        /// <summary>
        ///     Конструктор для точки с заданием точки
        /// </summary>
        /// <param name="point">Точка</param>
        public Point(Point point)
        {
            X = point.X;
            Y = point.Y;
            Symbol = point.Symbol;
        }

        #endregion

        #region Public Methods

        /// <summary>
        ///     Отобразит символ в заданных координатах
        /// </summary>
        public void Draw()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(Symbol);
        }

        /// <summary>
        ///     Перемещение точки
        /// </summary>
        /// <param name="offset">Смещение</param>
        /// <param name="direction">Направление движения</param>
        public void Move(int offset, Direction direction)
        {
            switch (direction)
            {
                case Direction.Up:
                {
                    Y -= offset;
                    break;
                }
                case Direction.Down:
                {
                    Y += offset;
                    break;
                }
                case Direction.Left:
                {
                    X -= offset;
                    break;
                }
                case Direction.Right:
                {
                    X += offset;
                    break;
                }
            }
        }

        /// <summary>
        ///     Очистка и перерисовка точка
        /// </summary>
        public void Clear()
        {
            Symbol = ' ';
            Draw();
        }

        #endregion
    }
}