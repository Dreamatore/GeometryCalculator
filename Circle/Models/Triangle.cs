namespace Circle.Models;

public class Triangle : IModels
{
    //Инициируем стороны треугольника
    public double Left { get; }
    public double Right { get; }
    public double Bottom { get; }

    public Triangle(double a, double b, double c)
    {
        Left = a;
        Right = b;
        Bottom = c;
    }

    public double GetArea()
    {
        var halfPerimeter = (Left + Right + Bottom) / 2;
        return Math.Sqrt(halfPerimeter * (halfPerimeter - Left) * (halfPerimeter - Right) * (halfPerimeter - Bottom)); //Формула Герона по трём сторонам треуг для выч площади.
    }

    public bool IsTriangleRight()
    {
        var threeSides = new[] { Left, Right, Bottom }; //длины сторон треугольника
        Array.Sort(threeSides); //так мы находим гипотенузу, ведь это самая длинная сторона треугольника. После сортировки она встанет на место threeSides[2];
        // Применяем теорему Пифагора для проверки
        // Сторона с индексом 2 будет гипотенузой (самая длинная сторона)
        // Сравниваем квадрат гипотенузы с суммой квадратов двух других сторон
        //c^2=a^2+b^2; |C^2-(a^2+b^2)|<1e-10(0.0000000001)
        return Math.Abs(threeSides[2] * threeSides[2] -
                        (threeSides[0] * threeSides[0] + threeSides[1] * threeSides[1])) < 1e-10; // для проверки, что разница между этими значениями близка к нулю, учитывая погрешности.
    }
}