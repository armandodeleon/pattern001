namespace patterns1;

public class Circle
{
    public double Area { get; }

    public Circle(double radius)
    {
        Area = radius * radius * Math.PI;
    }
}