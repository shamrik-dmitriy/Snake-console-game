using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class FoodCreator
    {
        #region Private Properties

        /// <summary>
        ///     Ширина карты
        /// </summary>
        private int MapWidth { get; set; }

        /// <summary>
        ///     Высота карты
        /// </summary>
        private int MapHeight { get; set; }

        /// <summary>
        ///     Символ "еды"
        /// </summary>
        private char FoodSymbol { get; set; }

        /// <summary>
        ///     Генератор случайных чисел
        /// </summary>
        private readonly Random _randomFoodPositiongenerator = new Random();

        #endregion

        #region Constructor

        /// <summary>
        ///     Конструктор
        /// </summary>
        /// <param name="mapWidth">Ширина карты</param>
        /// <param name="mapHeight">Высота карты</param>
        /// <param name="foodSymbol">Символ еды</param>
        public FoodCreator(int mapWidth, int mapHeight, char foodSymbol)
        {
            MapWidth = mapWidth;
            MapHeight = mapHeight;
            FoodSymbol = foodSymbol;
        }

        #endregion

        #region Public Methods

        /// <summary>
        ///     Создаёт "еду" и возвращает позицию "еды" на карте
        /// </summary>
        /// <returns>Позиция "еды" на карте</returns>
        public Point CreateFood()
        {
            var x = _randomFoodPositiongenerator.Next(2, MapWidth - 2);
            var y = _randomFoodPositiongenerator.Next(2, MapHeight - 2);
            return new Point(x, y, FoodSymbol);
        }

        #endregion
    }
}