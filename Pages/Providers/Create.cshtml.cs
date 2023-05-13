using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SupermarketWEB.Data;
using SupermarketWEB.Models;


namespace SupermarketWEB.Pages.Providers
{
    public class IndexModel : PageModel
    {
        private readonly SupermarketContext context;
        public IndexModel(SupermarketContext context)
        {
            this.context = context;
        }


        [BindProperty]
        public Provider Provider { get; set; }



        public void OnPost() 
        {
            var providerDomainModel = new Provider
            {
                FirstName = Provider.FirstName,
                Email = Provider.Email,
                PhoneNumber = Provider.PhoneNumber,
                Company = Provider.Company,

            };
            context.Providers.Add(providerDomainModel);
            context.SaveChanges();

            ViewData["Message"] = "Creado con Extito";
        }
    }
}
