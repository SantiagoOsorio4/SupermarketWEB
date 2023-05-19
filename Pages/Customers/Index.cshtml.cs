using FirstWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SupermarketWEB.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace SupermarketWEB.Pages.Customers
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly SupermarketContext _context;

        public IndexModel(SupermarketContext context)
        {
            _context = context;
        }
        public IList<Customer> Customers { get; set; } = default!;
        public async Task OnGetAsync()
        {
            if (_context.Customers != null)
            {
                Customers = await _context.Customers.ToListAsync();
            }
        }
    }
}
