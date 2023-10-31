using Big_Mammas_Pizza.model;
using Big_Mammas_Pizza.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Big_Mammas_Pizza.Pages.Pizza
{
    public class PizzaModel : PageModel
    {
        //property til View'et
        public List<Pizza> Pizzaer { get; set; }

        public void OnGet()
        {
            PizzaRepository repo = new PizzaRepository(true);

            Pizzaer = repo.HentAllePizzaer();
        }
    }
}
