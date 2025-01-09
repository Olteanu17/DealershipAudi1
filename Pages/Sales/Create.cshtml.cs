using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DealershipAudi.Data;
using DealershipAudi.Models;

namespace DealershipAudi.Pages.Sales
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
            ViewData["CarID"] = new SelectList(_context.Cars, "ID", "Model");
            ViewData["CustomerID"] = new SelectList(_context.Customers, "ID", "Name");
            return Page();
        }

        [BindProperty]
        public Sale Sale { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                ViewData["CarID"] = new SelectList(_context.Cars, "ID", "Model");
                ViewData["CustomerID"] = new SelectList(_context.Customers, "ID", "Name");
                return Page();
            }

            _context.Sales.Add(Sale);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
