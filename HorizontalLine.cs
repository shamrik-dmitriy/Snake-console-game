using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class HorizontalLine : Figure
    {
        #region Constructor

        /// <summary>
        ///     Рисует горизонтальную линию
        /// </summary>
        /// <param name="xLeft">Левая точка линии</param>
        /// <param name="xRight">Правая точка линии</param>
        /// <param name="y">Точка позиции линии по оси Y</param>
        /// <param name="symbol">Символ отрисовки линии</param>
        public HorizontalLine(int xLeft, int xRight, int y, char symbol)
        {
            for (var i = xLeft; i <= xRight; i++)
            {
                LinePoints.Add(new Point(i, y, symbol));
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