namespace FactoryPizza;

public abstract class Pizza
{
    protected string _description;
    protected string _origin;
    
    public void Render()
    {
        Console.WriteLine($"Pizza: {_description} from {_origin}");
    }
}