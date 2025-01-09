using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DealershipAudi.Data;
using DealershipAudi.Models;

namespace DealershipAudi.Pages.Cars
{
    public class DetailsModel : PageModel
    {
        private readonly DealershipAudi.Data.DealershipAudiContext _context;

        public DetailsModel(DealershipAudi.Data.DealershipAudiContext context)
        {
            _context = context;
        }

        public Car Car { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = await _context.Cars.FirstOrDefaultAsync(m => m.ID == id);
            if (car == null)
            {
                return NotFound();
            }
            else
            {
                Car = car;
            }
            return Page();
        }
    }
}
