using System;

namespace AreaCalculator.Shapes
{
   /*
    * Выделил абстрактный класс, следуя принципу подстановки Liskov ( SOLID ), чтобы у нас была возможность расширять базовый функционал библиотеки
    */
    public abstract class Shape
    {
        public abstract double GetArea();
    }
   /*
    * Выделил private поля, следуя принципу инкапсуляции ( ООП ) для того,
    * чтобы клиенты могли пользоваться только public свойствами, им предоставленными (рефлексию в расчет не берём), скрывая от них детали реализации и внутреннее поведение.
    * Внутри работаю только с private полями.
    */
    public class Triangle : Shape
    {
        private double _a;
        public double SideA
        {
            get
            {
                return _a;
            }
            set
            {
                if (value == _a)
                    return;

                _a = value;
            }
        }

        private double _b;
        public double SideB
        {
            get
            {
                return _b;
            }
            set
            {
                if (value == _b)
                    return;

                _b = value;
            }
        }

        private double _c;
        public double SideC
        {
            get
            {
                return _c;
            }
            set
            {
                if (value == _c)
                    return;

                _c = value;
            }
        }

        public bool IsRight => (_a * _a + _b * _b) == (_c * _c) ||
                               (_a * _a + _c * _c) == (_b * _b) ||
                               (_b * _b + _c * _c) == (_a * _a) ? true : false;


        public Triangle(double a, double b, double c)
        {
            if (a <= 0)
                throw new ArgumentException("Сторона треугольника не может равна 0 или быть меньше 0.", nameof(a));
            if (b <= 0)
                throw new ArgumentException("Сторона треугольника не может равна 0 или быть меньше 0.", nameof(b));
            if (c <= 0)
                throw new ArgumentException("Сторона треугольника не может равна 0 или быть меньше 0.", nameof(c));

            _a = a;
            _b = b;
            _c = c;
        }

        /*
         * Почему выбраны рич-модели, реализующие какую-то логику внутри? 
         * SRP из SOLID - об единственной ответственности класса. И т.к. площадь фигуры - ответственность фигуры, можно реализовывать этот функционал в моделях.
         */
        public override double GetArea()
        {
            var p = (_a + _b + _c) / 2;
            var area = Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
            return area;
        }

        [Obsolete("Неоптимален (benchmark в папке проекта, колонка Mean (меньше - лучше)). Используйте IsRight свойство")]
        public bool IsRightOptimized()
        {
            var squareA = _a * _a;
            var squareB = _b * _b;
            var squareC = _c * _c;

            return squareA == (squareB + squareC) ||
                    squareB == (squareA + squareC) ||
                    squareC == (squareA + squareC);
        }
    }


    public class Circle : Shape
    {
        private double _radius;
        public double Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                if (value == _radius)
                    return;

                _radius = value;
            }
        }
        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentException("Радиус окружности не может быть меньше 0.", nameof(radius));

            _radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * _radius * _radius;
        }
    }
}
