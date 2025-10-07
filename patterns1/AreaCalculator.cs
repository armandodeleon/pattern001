namespace patterns1;

public class OCPAreaCalculator
{
    private double _area { get; set; }
    public double Area => _area;
    
    // Twice overloaded methods
    public void AddShape(IShapeWithArea shape) => _area += (shape.Area);
    
}