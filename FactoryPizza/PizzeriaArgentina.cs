namespace FactoryPizza;

public class PizzeriaArgentina: Pizzeria
{
    public override Pizza CrearPizza(string type)
    {
        if (type == "cancha")
        {
            return new PizzaCancha("Argentina");
        }
        else if (type == "napo")
        {
            return new PizzaNapolitana("Argentina");
        }
        else
        {
            return null;
        }
    }
}