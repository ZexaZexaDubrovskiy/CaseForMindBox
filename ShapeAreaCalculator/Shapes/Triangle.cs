using ShapeAreaCalculator.Interfaces;

namespace ShapeAreaCalculator.Shapes
{
    public class Triangle : IShape
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                throw new ArgumentException("Стороны должны быть положи. числами.");
            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
                throw new ArgumentException("Указанные стороны не могут образовать треугольник.");

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double CalculateArea()
        {
            double s = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        public bool IsRightAngled()
        {
            double a = SideA, b = SideB, c = SideC;
            double maxSide = Math.Max(a, Math.Max(b, c));
            double sumOfSquaresSides;

            if (maxSide == a)
                sumOfSquaresSides = b * b + c * c;
            else if (maxSide == b)
                sumOfSquaresSides = a * a + c * c;
            else
                sumOfSquaresSides = a * a + b * b;

            double maxSideSquared = maxSide * maxSide;

            return maxSideSquared == sumOfSquaresSides;
        }
    }
}
