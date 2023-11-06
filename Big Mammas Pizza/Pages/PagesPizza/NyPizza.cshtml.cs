using Big_Mammas_Pizza.model;
using Big_Mammas_Pizza.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Big_Mammas_Pizza.Pages.PagesPizza
{
    public class NyPizzaModel : PageModel
    {
        private PizzaRepository _repo;

        public NyPizzaModel(PizzaRepository repo)
        {
            _repo = repo;
        }






        [BindProperty]
        public int NytPizzaPrice { get; set; }


        [BindProperty]
        [Required(ErrorMessage = "Need a name")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Minimum two characters")]
        public string NytPizzaNavn { get; set; }


        [BindProperty]
        public string NytPizzaDescription { get; set; }

        [BindProperty]
        public int NytPizzaNummer { get; set; }


        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Pizza nyPizza = new Pizza(NytPizzaPrice, NytPizzaNavn, NytPizzaDescription, NytPizzaNummer);

            //PizzaRepository repo = new PizzaRepository(true);
            _repo.Tilføj(nyPizza);

            return RedirectToPage("Index");
        }
    }
}
