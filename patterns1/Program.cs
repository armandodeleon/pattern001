namespace patterns1;

class Program
{
    static void Main(string[] args)
    {
        var areaCalculator1 = new AreaCalculator();
        areaCalculator1.AddShape(new Square(5));
        areaCalculator1.AddShape(new Circle(10));
        
        Console.WriteLine(areaCalculator1.Area);
    }
}