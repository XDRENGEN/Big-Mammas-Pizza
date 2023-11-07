using Big_Mammas_Pizza.model;
using Big_Mammas_Pizza.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Big_Mammas_Pizza.Pages.PagesDrikke
{
    public class DrikkeModel : PageModel
    {
        /*
         * instans af drikke repository
         */

        private DrikkeRepository _repo;

        /*
         * Dependency Injection
         */
        public DrikkeModel(DrikkeRepository repository)

        {
            _repo = repository;
        }

        /*
         * property til viewet
         */
        public List<Drikke> Drikkes { get; set; }

        public void OnGet()
        {
            /*
             * DrikkeRepository repo = new DrikkeRepository(true);
             */

            Drikkes = _repo.HentAlleDrikke();
           
        }
      
        public IActionResult OnPost()
        {
            return RedirectToPage("NyDrikke");
        }


        }
    }

