using ShapeAreaCalculator.Interfaces;

namespace ShapeAreaCalculator.Shapes
{
    public class Circle : IShape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Радиус должен быть полож. числом.");

            Radius = radius;
        }

        public double CalculateArea() => Math.PI * Radius * Radius;
    }
}
