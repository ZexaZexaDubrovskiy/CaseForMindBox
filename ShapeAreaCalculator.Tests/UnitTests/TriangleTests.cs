using ShapeAreaCalculator.Shapes;

namespace ShapeAreaCalculator.Tests.UnitTests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void CalculateArea_ReturnsCorrectValue()
        {
            var triangle = new Triangle(3, 4, 5);
            double expectedArea = 6;
            Assert.AreEqual(expectedArea, triangle.CalculateArea());
        }

        [TestMethod]
        public void IsRightAngled_RightTriangle_ReturnsTrue()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.IsTrue(triangle.IsRightAngled());
        }

        [TestMethod]
        public void IsRightAngled_NonRightTriangle_ReturnsFalse()
        {
            var triangle = new Triangle(3, 4, 6);
            Assert.IsFalse(triangle.IsRightAngled());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constructor_InvalidSides_ThrowsException()
        {
            new Triangle(1, 2, 3);
        }
    }
}
