using Big_Mammas_Pizza.model;
using Big_Mammas_Pizza.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Big_Mammas_Pizza.Pages.PagesDrikke
{
    public class NyDrikkeModel : PageModel
    {
        private DrikkeRepository _repo;

        public NyDrikkeModel(DrikkeRepository repo)
        {
            _repo = repo;
        }


        [BindProperty]
        public int NytDrinkNumber { get; set; }


        [BindProperty]
        [Required(ErrorMessage = "Need a name")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Minimum two characters")]
        public string NytDrinkName { get; set; }


        [BindProperty]
        public int NytDrinkPrice { get; set; }

        [BindProperty]
        public bool NytAlcoholic { get; set; }


        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Drikke nyDrikke = new Drikke(NytDrinkNumber, NytDrinkName, NytDrinkPrice, NytAlcoholic);

            /*
             * PizzaRepository repo = new PizzaRepository(true);
             */

            _repo.Tilføj(nyDrikke);

            return RedirectToPage("Index");
        }
    }

}
