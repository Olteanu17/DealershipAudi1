using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DealershipAudi.Data;
using DealershipAudi.Models;

namespace DealershipAudi.Pages.Customers
{
    public class IndexModel : PageModel
    {
        private readonly DealershipAudi.Data.DealershipAudiContext _context;

        public IndexModel(DealershipAudi.Data.DealershipAudiContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Customer = await _context.Customers.ToListAsync();
        }
    }
}
