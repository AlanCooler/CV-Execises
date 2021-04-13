using CV_Tasks.Shapes;
using CV_Tasks.Libs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CV_Library_Testing
{
    [TestClass]
    public class TriangleUnitTest
    {
        /// <summary>
        /// Тест на равносторонний треугольник
        /// </summary>
        [TestMethod]
        public void CountArea_a10_b10_c10_result_4330127()
        {
            // ARRANGE
            
            int a = 10;
            int b = 10;
            int c = 10;

            // ACT
            IShape triangle = new Triangle(a, b, c);

            // ASSERT
            Assert.AreEqual(triangle.CountArea(), 43.30127);
        }

        /// <summary>
        /// Тест на несуществующий треугольник
        /// </summary>
        [TestMethod]
        [ExpectedException (typeof(ArgumentException), "Треугольника с такими значениями не существует!")]
        public void CreatingObjTriangle_a20_b5_c1_resultEXCEPTION()
        {
            // ARRANGE
            int a = 20;
            int b = 5;
            int c = 1;

            // ACT
            Triangle triangle = new Triangle(a, b, c);

            // ASSERT
            // Exception | Такого треугольника не существует
        }

        /// <summary>
        /// Тест на треугольник с невозможными сторонами
        /// </summary>
        [TestMethod]
        [ExpectedException (typeof (ArgumentNullException), "Введены неправильные значения сторон!")]
        public void CreationgObjTriangle_a0_b10_c10_resultEXCEPTION()
        {
            // ARRANGE
            int a = 0;
            int b = 10;
            int c = 10;

            // ACT
            IShape triangle = new Triangle(a, b, c);
            
            // ASSERT
            // Exception | Треугольника с такими сторонами не существует
        }
    }
}
