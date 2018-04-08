using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using NAVN;
using Sales_Contracts.Data;

namespace Sales_Contracts.Pages.Contractz
{
    public class CreateModel : PageModel
    {
        NAV _context = new NAV(new Uri("http://nb-marven.softera.lt:7048/DynamicsNAV100/OData/Company('CRONUS%20International%20Ltd.')"));

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Contract Contract { get; set; }

#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        public async Task<IActionResult> OnPostAsync()
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            _context.Credentials = CredentialCache.DefaultNetworkCredentials;
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.AddToContract(Contract);
            _context.BeginSaveChanges(adoSave_RLMember, Contract);

            return RedirectToPage("./Index");
        }

        void adoSave_RLMember(IAsyncResult result)
        {
            try
            {
                _context.EndSaveChanges(result);
            }
            catch
            {
                throw;
            }
        }
    }
}