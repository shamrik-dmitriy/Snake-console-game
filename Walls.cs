using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Walls
    {
        #region Private Properties

        private List<Figure> WallList { get; set; }

        #endregion

        #region Constructor

        public Walls(int mapWidth, int mapHeight)
        {
            WallList = new List<Figure>()
            {
                new HorizontalLine(0, mapWidth - 2, 0, '+'),
                new HorizontalLine(0, mapWidth - 2, mapHeight - 1, '+'),
                new VerticalLine(0, mapHeight - 1, 0, '+'),
                new VerticalLine(0, mapHeight - 1, mapWidth - 2, '+'),
            };
        }

        #endregion

        #region Public Methods

        /// <summary>
        ///     Попадание в стену
        /// </summary>
        /// <param name="figure">Змейка</param>
        /// <returns>True - попадание в стену было, False - попадания в стену не было</returns>
        public bool IsHit(Figure figure)
        {
            foreach (var wall in WallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        ///     Отрисовка стен
        /// </summary>
        public void Draw()
        {
            foreach (var wall in WallList)
            {
                wall.Draw();
            }
        }

        #endregion
    }
}