namespace patterns1;

public class Square
{
    public double Area { get; }

    public Square(double lengthOfOneSide)
    {
        Area = lengthOfOneSide * lengthOfOneSide;
    }
}