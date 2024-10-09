using ShapeAreaCalculator.Shapes;

namespace ShapeAreaCalculator.Tests.UnitTests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void CalculateArea_PositiveRadius_ReturnsCorrectValue()
        {
            var circle = new Circle(10);
            double expectedArea = Math.PI * 100;
            Assert.AreEqual(expectedArea, circle.CalculateArea());
        }

        [TestMethod]
        public void CalculateArea_SmallPositiveRadius_ReturnsCorrectValue()
        {
            var circle = new Circle(0.5);
            double expectedArea = Math.PI * 0.25;
            Assert.AreEqual(expectedArea, circle.CalculateArea(), 1e-10);
        }

        [TestMethod]
        public void Circle_PositiveRadius_CreatesSuccessfully()
        {
            var circle = new Circle(1);
            Assert.AreEqual(1, circle.Radius);
        }

        [TestMethod]
        public void CalculateArea_LargeRadius_ReturnsCorrectValue()
        {
            var circle = new Circle(1000);
            double expectedArea = Math.PI * 1000000;
            Assert.AreEqual(expectedArea, circle.CalculateArea());
        }

    }
}
