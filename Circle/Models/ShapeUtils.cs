namespace Circle.Models;

public class ShapeUtils
{
    // Таким образом при передаче фигур в метод, мы не указываем конкретный тип фигур, а только их общий тип IModels.
    public static double CalculateTotalArea(List<IModels> shapes)
    {
        double allArea = 0;
        foreach (var shape in shapes)
        {
            allArea += shape.GetArea();
        }
        return allArea;
    }
}