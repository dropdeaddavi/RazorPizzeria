using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;
using RazorPizzeria.Pages;

namespace RazorPizzeria.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel Pizzas { get; set; }
        public float PizzaPrice { get; set; }
        public void OnGet()
        {

        }

		public IActionResult OnPost()
		{
            PizzaPrice = Pizzas.BasePrice;

            if (Pizzas.Cheese)
            {
                PizzaPrice += 1;
            }
            if (Pizzas.Bacon)
			{
				PizzaPrice += 2;
			}
			if (Pizzas.Beef)
			{
				PizzaPrice += 2;
			}
			if (Pizzas.Ham)
			{
				PizzaPrice += 2;
			}
			if (Pizzas.Mushroom)
			{
				PizzaPrice += 1;
			}
			if (Pizzas.Pepperoni)
			{
				PizzaPrice += 1;
			}
			if (Pizzas.TomatoSauce)
			{
				PizzaPrice += 1;
			}

			return RedirectToPage("/Checkout/Checkout", new { Pizzas.PizzaName, PizzaPrice });
		}
	}
}
