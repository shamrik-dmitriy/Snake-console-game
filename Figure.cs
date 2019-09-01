using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Figure
    {
        #region Protected Properties

        /// <summary>
        ///     Коллекция точек
        /// </summary>
        protected List<Point> LinePoints { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        ///     Конструктор
        /// </summary>
        protected Figure()
        {
            LinePoints = new List<Point>();
        }

        #endregion

        #region Public Methods

        /// <summary>
        ///     Отрисовывает фигуру
        /// </summary>
        public virtual void Draw()
        {
            foreach (var linePoint in LinePoints)
            {
                linePoint.Draw();
            }
        }

        /// <summary>
        ///     Проверка столкновения
        /// </summary>
        /// <param name="figure">Фигура</param>
        /// <returns>True - столкновение было, False - столкновения не было</returns>
        public bool IsHit(Figure figure)
        {
            foreach (var linePoint in LinePoints)
            {
                if (figure.IsHit(linePoint))
                {
                    return true;
                }
            }

            return false;
        }

        #endregion

        #region Private Methods

        /// <summary>
        ///     Проверка, было ли столкновение с точкой
        /// </summary>
        /// <param name="point">Точка</param>
        /// <returns>True - было столкновение, False - не было столкновения</returns>
        private bool IsHit(Point point)
        {
            foreach (var linePoint in LinePoints)
            {
                if (linePoint.IsHit(point))
                {
                    return true;
                }
            }

            return false;
        }

        #endregion
    }
}