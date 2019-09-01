using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class VerticalLine : Figure
    {
        #region Constructor

        /// <summary>
        ///     Рисует вертикальную линию
        /// </summary>
        /// <param name="yTop">Верхняя точка линии</param>
        /// <param name="yBottom">Нижняя точка линии</param>
        /// <param name="x">Точка позиции линии по оси X</param>
        /// <param name="symbol">Символ отрисовки линии</param>
        public VerticalLine(int yTop, int yBottom, int x, char symbol)
        {
            for (var i = yTop; i <= yBottom; i++)
            {
                LinePoints.Add(new Point(x, i, symbol));
            }
        }

        #endregion

        #region Public Methods

        /// <summary>
        ///     Рисование границы голубым цветом
        /// </summary>
        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            foreach (var linePoint in LinePoints)
            {
                linePoint.Draw();
            }

            Console.ForegroundColor = ConsoleColor.White;
        }

        #endregion
    }
}