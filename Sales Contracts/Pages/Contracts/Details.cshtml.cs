using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NAVN;
using Sales_Contracts.Data;

namespace Sales_Contracts.Pages.Contractz
{
    public class DetailsModel : PageModel
    {
        /*
        private readonly Sales_Contracts.Data.ApplicationDbContext _context;

        public DetailsModel(Sales_Contracts.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Contract Contract { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Contract = await _context.Contract.SingleOrDefaultAsync(m => m.Contract_No == id);

            if (Contract == null)
            {
                return NotFound();
            }
            return Page();
        }*/
    }
}
