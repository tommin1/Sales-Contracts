using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NAVN;

namespace Sales_Contracts.Pages.Customers
{
    public class CreateModel : PageModel
    {
        NAV _context = new NAV(new Uri("http://nb-marven.softera.lt:7048/DynamicsNAV100/OData/Company('CRONUS%20International%20Ltd.')"));

        [BindProperty]
        public Customer Customer { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            return Page();
        }


#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        public async Task<IActionResult> OnPostAsync()
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            _context.Credentials = CredentialCache.DefaultNetworkCredentials;
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.AddToCustomer(Customer);
            _context.BeginSaveChanges(adoSave_RLMember, Customer);

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