using Big_Mammas_Pizza.model;
using Big_Mammas_Pizza.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text;

namespace Big_Mammas_Pizza.Pages
{
    public class menuModel : PageModel
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
    

