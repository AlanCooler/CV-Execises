
#region Usings

using System;
using Source.Libs;

#endregion


namespace CV_Tasks.Shapes
{
    public sealed class Circle : IShape
    {
        /// <summary>
        /// Радиус окружности
        /// </summary>
        public readonly double Radius;

        /// <summary>
        /// Создание объекта типа Круг
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        public Circle(double radius)
        {
            #region Check Region

            if (radius <= 0) throw new ArgumentException("Круга с таким радиусом не существует!");

            #endregion

            #region Init Region

            this.Radius = radius;

            #endregion
        }

        /// <summary>
        /// Реализует подсчет площади фигуры
        /// </summary>
        /// <returns>Площадь фигуры</returns>
        public double CountArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
