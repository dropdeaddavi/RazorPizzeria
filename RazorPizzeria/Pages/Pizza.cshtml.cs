using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> pizzasDB = new List<PizzasModel>()
        {
            new PizzasModel(){ImageTitle="Bolognese", PizzaName="Bolognese", FinalPrice=10},
            new PizzasModel(){ImageTitle="Carbonara", PizzaName = "Carbonera", FinalPrice = 8},
            new PizzasModel(){ImageTitle="Hawaiian", PizzaName = "Hawaiian", FinalPrice = 10},
            new PizzasModel(){ImageTitle="Margerita", PizzaName = "Margerita", FinalPrice = 8},
            new PizzasModel(){ImageTitle="MeatFeast", PizzaName = "MeatFeast", FinalPrice = 10},
            new PizzasModel(){ImageTitle="Mushroom", PizzaName = "Mushroom", FinalPrice = 8},
            new PizzasModel(){ImageTitle="Pepperoni", PizzaName = "Pepperoni", FinalPrice = 7},
            new PizzasModel(){ImageTitle="Seafood", PizzaName = "Seafood", FinalPrice = 10},
            new PizzasModel(){ImageTitle="Vegetarian", PizzaName = "Vegetarian", FinalPrice = 10},
        };
        public void OnGet()
        {

        }

        public void OnPost()
        {

        }
    }
}
