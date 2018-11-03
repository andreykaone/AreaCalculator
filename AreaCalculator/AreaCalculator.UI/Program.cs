using AreaCalculator.Shapes;
using System;
using System.Collections.Generic;

namespace AreaCalculator.UI
{
    class Program
    {
        static void Main(string[] args)
        {

            // В итоге мы можем воспользоваться сервисом Calculator, который посчитаем для нас площадь фигуры.
            var calculator = new Calculator();
            var triangle = new Triangle(3, 4, 5);

            var isright = triangle.IsRight ? "Yea!" : "No!";
            Console.WriteLine($"Area of {triangle.GetType().Name}: {calculator.GetArea(triangle)}. Is this triangle right? {isright}\n");


            // Либо не пользоваться сервисами вообще и получить площадь у каждой фигуры, не важно что это за фигура, главное, что реализующая  абстрактный Shape
            var shapes = new List<Shape>
            {
                new Triangle(3, 4, 5),

                new Circle(2),
                new Square(5)
            };

            foreach (var shape in shapes)
                Console.WriteLine($"Area of {shape.GetType().Name}: {shape.GetArea()}");

            Console.ReadKey();
        }
    }

    /*
     * Если нам не хватает двух дефолтных фигур, можно создать свою собственную фигуру, наследующую абстрактный Shape,
     * и обращаться в методу GetArea за площадью.
     * Данная фигура так же будет работать с AreaCalculator'ом
     */

    public class Square : Shape
    {
        private double _side;
        public double Side
        {
            get { return _side; }
            set
            {
                if (value == _side)
                    return;

                _side = value;
            }
        }

        public Square(double side)
        {
            if(side <= 0)
                throw new ArgumentException("Сторона треугольника не может равна 0 или быть меньше 0.", nameof(side));

            _side = side;
        }
        public override double GetArea()
        {
            return _side * _side;
        }
    }
}
