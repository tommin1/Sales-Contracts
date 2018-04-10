using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Services.Client;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using NAVN;
using Sales_Contracts.Data;
using static System.Net.Mime.MediaTypeNames;

namespace Sales_Contracts.Pages.Contractz
{
    public class CreateModel : PageModel
    {
        NAV _context = new NAV(new Uri("http://nb-marven.softera.lt:7048/DynamicsNAV100/OData/Company('CRONUS%20International%20Ltd.')"));

        [BindProperty]
        public Contract Contract { get; set; }

        public IEnumerable<Customer> Customer { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            _context.Credentials = CredentialCache.DefaultNetworkCredentials;
            var customers = _context.Customer;

            DataServiceQuery<Customer> query = customers;

            TaskFactory<IEnumerable<Customer>> taskFactory = new TaskFactory<IEnumerable<Customer>>();
            Customer = await taskFactory.FromAsync(query.BeginExecute(null, null), iar => query.EndExecute(iar));
            Customer = Customer;

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