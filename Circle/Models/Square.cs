namespace Circle.Models;

public class Square : IModels
{
    public double A;

    public Square(double a)
    {
        A = a;
    }
    public double GetArea()
    {
        return A * A; //площадь квадрата a^2
    }
}