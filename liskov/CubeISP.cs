namespace liskov;

public class CubeISP: IThreeDeeShape
{
    public double Width { get; set; }
    public double Height { get; set; }
    public double Depth { get; set; }
    public double GetVolume => Width * Height * Depth;  
}