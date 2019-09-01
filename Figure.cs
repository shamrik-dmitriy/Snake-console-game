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

        #endregion
    }
}