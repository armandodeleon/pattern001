namespace liskov;

class Program
{
    static void Main(string[] args)
    {
        CubeISP cube = new CubeISP();
        cube.Width = 10;
        cube.Height = 10;
        cube.Depth = 10;
        Console.WriteLine(cube.GetVolume);
    }
}