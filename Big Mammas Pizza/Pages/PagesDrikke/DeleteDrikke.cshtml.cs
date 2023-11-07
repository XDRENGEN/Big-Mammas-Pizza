using Big_Mammas_Pizza.model;
using Big_Mammas_Pizza.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text;

namespace Big_Mammas_Pizza.Pages.PagesDrikke;

    public class DeleteDrikkeModel : PageModel
    {
        private DrikkeRepository _repo;

        public DeleteDrikkeModel(DrikkeRepository repo)
        {
            _repo = repo;
        }



        public Drikke Drikke { get; private set; }



        public IActionResult OnGet(int number)
        {
            Drikke = _repo.HentDrikke(number);


            return Page();
        }

        public IActionResult OnPostDelete(int number)
        {
            _repo.Slet(number);

            return RedirectToPage("Index");
        }

        public IActionResult OnPostCancel()
        {
            return RedirectToPage("Index");
        }



    }


