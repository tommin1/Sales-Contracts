﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sales_Contracts.Data;

namespace Sales_Contracts.Pages.Users
{
    public class DetailsModel : PageModel
    {
        private readonly Sales_Contracts.Data.ApplicationDbContext _context;

        public DetailsModel(Sales_Contracts.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public ApplicationUser ApplicationUser { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ApplicationUser = await _context.ApplicationUser.SingleOrDefaultAsync(m => m.Id == id);

            if (ApplicationUser == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
