namespace GeometryTests
{
    public class CircleTests
    {
        [Fact]
        public void TestCircleArea()
        {
            var circle = new Circle.Models.Circle(5);
            double expectedArea = Math.PI * 25; // Площадь круга с радиусом 5
            Assert.Equal(expectedArea, circle.GetArea(), 2);
        }
    }
}