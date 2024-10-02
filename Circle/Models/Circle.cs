namespace Circle.Models
{
    public class Circle : IModels
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Radius * Radius; // Площадь круга: π * r^2
        }
    }
}