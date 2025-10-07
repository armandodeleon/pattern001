namespace patterns1;

class Program
{
    static void Main(string[] args)
    {
        var areaCalculator1 = new OCPAreaCalculator();
        areaCalculator1.AddShape(new OCPSquare(5));
        areaCalculator1.AddShape(new OCPCircle(10));
        
        Console.WriteLine(areaCalculator1.Area);
    }
}