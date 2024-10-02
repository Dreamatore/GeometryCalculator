using Circle.Models;

namespace GeometryTests
{
    public class TriangleTests
    {
        [Fact]
        public void TestArea()
        {
            var triangle = new Triangle(3, 4, 5);
            double expectedArea = 6; // Площадь прямоугольного треугольника 3x4x5
            Assert.Equal(expectedArea, triangle.GetArea(), 2);
        }

        [Fact]
        public void TestIsRightTriangle()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.True(triangle.IsTriangleRight()); // Проверка, что если треугольник 3, 4, 5 является прямоугольным
        }

        [Fact]
        public void TestNotRightTriangle()
        {
            var triangle = new Triangle(3, 3, 5);
            Assert.False(triangle.IsTriangleRight()); // Обратная проверка, если треугольник 3, 3, 5 не является прямоугольным
        }
    }
}