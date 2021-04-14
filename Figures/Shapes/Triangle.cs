
#region Usings

using CV_Tasks.Libs;
using System;

#endregion

namespace CV_Tasks.Shapes
{
    public sealed class Triangle : IShape
    {
        // Все стороны треугольника
        public readonly double A;
        public readonly double B;
        public readonly double C;

        private bool _isRightTriangle = false;

        public Triangle(double a, double b, double c)
        {
            #region Check Region

            // Проверка введеных данных.
            if (a <= 0 || b <= 0 || c <= 0) throw new ArgumentNullException("Введены неправильные значения сторон!");

            // Треугольник существует тогда и только тогда, когда сумма двух сторон больше третьей.
            if ((a + b) < c || (a + c) < b || (b + c) < a) throw new ArgumentException("Треугольника с такими значениями не существует!");

            // Треугольник является прямоугольным если сумма квадратов катетов равна квадрату гипотенузы.
            if (

                (Math.Pow(a, 2) + Math.Pow(b, 2)) == Math.Pow(c, 2)
                ||
                (Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2))
                ||
                (Math.Pow(b, 2) + Math.Pow(c, 2) == Math.Pow(a, 2))

                )
            {
                // Треугольник прямоугольный
                _isRightTriangle = true;
            }

            #endregion

            #region Init Values Region

            this.A = a;
            this.B = b;
            this.C = c;

            #endregion
        }

        public double CountArea()
        {
            // Решение по формуле S = 0.5 * высоту * сторону
            if (_isRightTriangle) 
            {
                if (A > B && A > C) return 0.5 * B * C;
                else if (B > A && B > C) return 0.5 * A * C;
                else return 0.5 * A * B;    
            }

            double halfPerimeter = (A + B + C) / 2;
            
            // Формула Герона для треугольника
            return Math.Sqrt( halfPerimeter * (halfPerimeter - A) * (halfPerimeter - B) * (halfPerimeter - C) );
        }
    }
}
