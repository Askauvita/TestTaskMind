using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestTask.Figuries;

namespace TestTask
{
    [TestFixture]
    public class AreaCalculatorUnitTests
    {
        [Test]
        public void CheckNegativeOrZeroIncorrectTriangleSidesTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-3, 5, 4));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(5, -3, 4));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(5, 4, -3));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, 4, 5));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(4, 0, 5));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(5, 4, 0));
        }

        [Test]
        public void CheckPositiveIncorrectTriangleSidesTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(1, 1, 100000));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(100000, 1, 1));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(1, 10000, 1));
        }
        [Test]
        public void RectangularTriangleTest()
        {
            var triangle = new Triangle(3, 4, 5);

            var isRectangular = triangle._isRectangular;

            Assert.AreEqual(true, isRectangular);
        }

        [Test]
        public void isNoRectangularTriangleTest()
        {
            var triangle = new Triangle(6, 2, 5);

            var isRectangular = triangle._isRectangular;

            Assert.AreEqual(false, isRectangular);
        }

        [Test]
        public void TriangleAreaCalculationTest()
        {
            var triangle = new Triangle(3, 4, 5);

            var triangleArea = triangle.Area;

            Assert.AreEqual(6, triangleArea);
        }

        [Test]
        public void CheckIncorrectCircleRadiusTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-123));
        }
         
        [Test]
        public void CircleAreaCalculationTest()
        {
            var circle = new Circle(5);

            var circleArea = circle.Area;

            Assert.AreEqual(78.53981633974483, circleArea);
        }
    }
}