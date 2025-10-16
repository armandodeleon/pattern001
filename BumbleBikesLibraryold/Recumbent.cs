namespace BumbleBikesLibrary;

public class Recumbent: Bicycle
{
    public Recumbent()
    {
        ModelName = "Big Bendr";
        Suspension = SuspensionTypes.Front;
        Color = BicyclePaintColors.White;
        Geometry = BicycleGeometries.Recumbent;

    }
}