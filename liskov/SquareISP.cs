namespace liskov;

public class SquareISP:ITwoDeeShape
{
    public double Width { get; set; }
    public double Height { get; set; }
    public double Area => Width * Height;
}