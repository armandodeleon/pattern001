namespace patterns1;

public class OCPCircle: IShapeWithArea
{
    public double Area { get; }

    public OCPCircle(double radius)
    {
        Area = radius * radius * Math.PI;
    }
}