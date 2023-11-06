using Big_Mammas_Pizza.model;
using Big_Mammas_Pizza.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Big_Mammas_Pizza.Pages.Pizzaer
{
    public class IndexModel : PageModel
    {

        //Instans af pizza repository
        private PizzaRepository _repo;

        //Dependency Injection
        public IndexModel(PizzaRepository repository)
        {
            _repo = repository;
        }



        //property til View'et
        public List<Pizza> Pizzaer { get; set; }

        public void OnGet()
        {
            //PizzaRepository repo = new PizzaRepository(true)
            Pizzaer = _repo.HentAllePizzaer();
        }


        public IActionResult OnPost()
        {
            return RedirectToPage("Pizza");
        }
    }
}