namespace BumbleBikesLibrary;

public abstract class Bicycle: IBicycle
{
    public string ModelName { get; set; }

    public int Year { get; set; }
    public string SerialNumber { get; }
    public BicyclePaintColors Color { get; set; }
    public BicycleGeometries Geometry { get; set; } 
    public SuspensionTypes Suspension { get; set; }
    public ManufacturingStatus BuildStatus { get; set; }

    protected Bicycle()
    {
        ModelName = string.Empty;
        SerialNumber = Guid.NewGuid().ToString(); // Globally unique identifier. 
        Year = DateTime.Now.Year;
        BuildStatus = ManufacturingStatus.Specified;
    }

    public void Build()
    {
        Console.WriteLine($"Manufacturing a {Geometry.ToString()} frame..");
        BuildStatus = ManufacturingStatus.FramManufactured;
        PrintBuildStatus();
        
        Console.WriteLine($"Painting the {Color.ToString()} frame..");
        BuildStatus = ManufacturingStatus.Painted; 
        PrintBuildStatus();
        
        if(Suspension != SuspensionTypes.Hardtail)
        {
            Console.WriteLine($"Mounting the {Suspension.ToString()} suspension..");
            BuildStatus = ManufacturingStatus.SuspensionMounted;
        }
        
        Console.WriteLine($"{0} {1} Bicycle serial number {2} manufacturing complete!", Year, ModelName, SerialNumber);
        BuildStatus = ManufacturingStatus.Complete;
        PrintBuildStatus();
    }
    
    private void PrintBuildStatus()
    {
        Console.WriteLine(BuildStatus);
    }
}