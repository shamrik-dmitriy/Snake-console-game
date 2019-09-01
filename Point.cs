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

        public Point(int x, int y, char symbol)
        {
            X = x;
            Y = y;
            Symbol = symbol;
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

        #endregion
    }
}