using AreaCalculator.Shapes;
using Xunit;

namespace AreaCalculator.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void CalculatorCreate()
        {
            var calculator = new Calculator();

            Assert.NotNull(calculator);
        }

        [Fact]
        public void CalculatorGetShapeArea()
        {
            var calculator = new Calculator();
            Shape triangle = new Triangle(3, 4, 5);
            var area = 6;

            var calculatorArea = calculator.GetArea(triangle);

            Assert.Equal(area, calculatorArea);
        }
    }
}
