using Circle.Models; 

namespace GeometryTests
{
    public class SquareTests
    {
        [Fact]
        public void TestCalculateTotalArea()
        {
            // Создаем список фигур
            var shapes = new List<IModels>()
            {
                new Circle.Models.Circle(5),      // Новый круг с радиусом 5
                new Triangle(3, 4, 5), // Новый треугольник с длинами сторон 3, 4 и 5
                new Square(2)       // Новый квадрат со стороной 2
            };

            // Получаем общую площадь
            double totalArea = ShapeUtils.CalculateTotalArea(shapes);

            // Проверяем, соответствует ли общая площадь ожиданиям
            double expectedArea = Math.PI * 5 * 5 + 6 + 4; // π * 5^2 + 6 (площадь треугольника) + 4 (площадь квадрата)
            Assert.Equal(expectedArea, totalArea, 2); // Сравниваем с учетом двух десятичных знаков
        }
    }
}