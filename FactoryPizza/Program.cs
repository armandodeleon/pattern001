
using FactoryPizza;

Pizzeria pizzeria = new PizzeriaArgentina();
var pizza = pizzeria.CrearPizza("cancha");
pizza.Render();

pizzeria = new PizzeriaItaliana();
pizza = pizzeria.CrearPizza("napo");
pizza.Render();
