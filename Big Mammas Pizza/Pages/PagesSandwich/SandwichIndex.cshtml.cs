using Big_Mammas_Pizza.model;
using Big_Mammas_Pizza.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Big_Mammas_Pizza.Pages.PagesSandwich
{
    public class IndexModel : PageModel
    {

        //Instans af pizza repository
        private SandwichRepository _repo;

        //Dependency Injection
        public IndexModel(SandwichRepository repository)
        {
            _repo = repository;
        }



        //property til View'et
        public List<Sandwich> Sandwicher { get; set; }

        public void OnGet()
        {
            //PizzaRepository repo = new PizzaRepository(true)
            Sandwicher = _repo.HentAlleSandwiches();
        }


        public IActionResult OnPost()
        {
            return RedirectToPage("NySandwich");
        }
    }
}