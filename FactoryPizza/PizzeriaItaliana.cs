namespace FactoryPizza;

public class PizzeriaItaliana:Pizzeria
{
    public override Pizza CrearPizza(string type)
    {
        if (type == "cancha")
        {
            return new PizzaCancha("Italiana");
        }
        else if (type == "napo")
        {
            return new PizzaNapolitana("Italiana");
        }
        else
        {
            return null;
        }
    }
}