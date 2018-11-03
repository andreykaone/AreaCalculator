using AreaCalculator.Shapes;

namespace AreaCalculator
{
    /*
     * Считаю, что в таком виде не очень нужна реализация (даже такая из 3 строк) класса Calculator, если только внутри не будет сложной логики,
     * или пока "пользователь не захочет складывать площади разных фигур".
     * С расчетом своей площади справляется каждая фигура сама.
     * Ну или если это тестовое задание :)
     */
    public class Calculator
    {
        //ctor

        public double GetArea(Shape shape)
        {
            return shape.GetArea();
        }
    }
}
