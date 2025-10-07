namespace liskov;

// C# allows interfaces to inherit from other interfaces
public interface IThreeDeeShape: ITwoDeeShape
{
    public double Depth { get; set; }
}