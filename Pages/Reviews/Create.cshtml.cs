using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DealershipAudi.Data;
using DealershipAudi.Models;

namespace DealershipAudi.Pages.Reviews
{
    public class CreateModel : PageModel
    {
        private readonly DealershipAudi.Data.DealershipAudiContext _context;

        public CreateModel(DealershipAudi.Data.DealershipAudiContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CarID"] = new SelectList(_context.Cars, "ID", "Manufacturer");
        ViewData["CustomerID"] = new SelectList(_context.Customers, "ID", "Email");
            return Page();
        }

        [BindProperty]
        public Review Review { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Reviews.Add(Review);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
