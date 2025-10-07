namespace patterns1;

public class OCPSquare: IShapeWithArea
{
    public double Area { get; }

    public OCPSquare(double lengthOfOneSide)
    {
        Area = lengthOfOneSide * lengthOfOneSide;
    }
}