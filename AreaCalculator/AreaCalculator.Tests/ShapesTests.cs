using AreaCalculator.Shapes;
using System;
using Xunit;

namespace AreaCalculator.Tests
{
    public class ShapesTests
    {

        [Fact]
        public void TriangleCreate()
        {
            var sideA = 3;
            var sideB = 4;
            var sideC = 5;
            var triagle = new Triangle(sideA, sideB, sideC);

            Assert.NotNull(triagle);
            Assert.Equal(sideA, triagle.SideA);
            Assert.Equal(sideB, triagle.SideB);
            Assert.Equal(sideC, triagle.SideC);
        }

        [Fact]
        public void TriangleGetArea()
        {
            var sideA = 3;
            var sideB = 4;
            var sideC = 5;
            var square = 6;

            var triagle = new Triangle(sideA, sideB, sideC);

            Assert.Equal(square, triagle.GetArea());
        }

        [Fact]
        public void TriangleIsRight()
        {
            var sideA = 3;
            var sideB = 4;
            var sideC = 5;
            var isRight = true;

            var triagle = new Triangle(sideA, sideB, sideC);

            Assert.Equal(isRight, triagle.IsRight);
        }

        [Fact]
        public void TriangleIsNotRight()
        {
            var sideA = 3;
            var sideB = 6;
            var sideC = 5;
            var isRight = false;

            var triagle = new Triangle(sideA, sideB, sideC);

            Assert.Equal(isRight, triagle.IsRight);
        }



        [Fact]
        public void CircleCreate()
        {
            var radius = 3;
            var circle = new Circle(radius);

            Assert.NotNull(circle);
            Assert.Equal(radius, circle.Radius);
        }



        [Fact]
        public void CircleGetArea()
        {
            var radius = 3;
            var circle = new Circle(radius);

            var area = Math.PI * radius * radius;

            Assert.Equal(area, circle.GetArea());
        }
    }
}
