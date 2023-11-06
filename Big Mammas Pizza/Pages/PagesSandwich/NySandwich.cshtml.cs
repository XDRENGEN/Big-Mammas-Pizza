using Big_Mammas_Pizza.model;
using Big_Mammas_Pizza.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Big_Mammas_Pizza.Pages.PagesSandwich
{
    public class NySandwichModel : PageModel
    {
        private SandwichRepository _repo;

        public NySandwichModel(SandwichRepository repo)
        {
            _repo = repo;
        }






        [BindProperty]
        public int NytSandwichPrice { get; set; }


        [BindProperty]
        [Required(ErrorMessage = "Need a name")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Minimum two characters")]
        public string NytSandwichNavn { get; set; }


        [BindProperty]
        public string NytSandwichDescription { get; set; }

        [BindProperty]
        public int NytSandwichNummer { get; set; }


        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Sandwich nySandwich = new Sandwich(NytSandwichPrice, NytSandwichNavn, NytSandwichDescription, NytSandwichNummer);

            //PizzaRepository repo = new PizzaRepository(true);
            _repo.Tilføj(nySandwich);

            return RedirectToPage("Index");
        }
    }
}