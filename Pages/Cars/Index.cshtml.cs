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
    public class IndexModel : PageModel
    {
        private readonly DealershipAudi.Data.DealershipAudiContext _context;

        public IndexModel(DealershipAudi.Data.DealershipAudiContext context)
        {
            _context = context;
        }

        public IList<Car> Car { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Car = await _context.Cars.ToListAsync();
        }
    }
}
