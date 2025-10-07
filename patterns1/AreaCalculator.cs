namespace patterns1;

public class AreaCalculator
{
    private double _area { get; set; }
    public double Area => _area;
    
    // Twice overloaded methods
    public void AddShape(Square square) => _area += (square.Area);
    public void AddShape(Circle circle) => _area += (circle.Area);
}