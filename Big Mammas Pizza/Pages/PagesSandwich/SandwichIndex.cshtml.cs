using Big_Mammas_Pizza.model;
using Big_Mammas_Pizza.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Big_Mammas_Pizza.Pages.PagesSandwich;
public class SandwichIndexModel : PageModel
{
    //property til View'et
    public List<Sandwich> Sandwiches { get; set; }

    public void OnGet()
    {
        SandwichRepository repo = new SandwichRepository(true);

        Sandwiches = repo.HentAlleSandwiches();
    }
}

