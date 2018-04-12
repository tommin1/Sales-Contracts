using System;
using System.Collections.Generic;
using System.Data.Services.Client;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NAVN;
using Sales_Contracts.Data;

namespace Sales_Contracts.Pages.Contractz
{
    public class EditModel : PageModel
    {
        NAV _context = new NAV(new Uri("http://nb-marven.softera.lt:7048/DynamicsNAV100/OData/Company('CRONUS%20International%20Ltd.')"));

        [BindProperty]
        public Contract Contract { get; set; }
        public Contract Contract2 { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            _context.Credentials = CredentialCache.DefaultNetworkCredentials;
            if (id == null)
            {
                return NotFound();
            }

            var contracts = _context.Contract;

            DataServiceQuery<Contract> query = contracts;

            TaskFactory<IEnumerable<Contract>> taskFactory = new TaskFactory<IEnumerable<Contract>>();
            var kontract = await taskFactory.FromAsync(query.BeginExecute(null, null), iar => query.EndExecute(iar));

            Contract = kontract.SingleOrDefault(m => m.Contract_No == id);

            if (Contract == null)
            {
                return NotFound();
            }
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

            var contract = _context.Contract;

            DataServiceQuery<Contract> query = contract;

            TaskFactory<IEnumerable<Contract>> taskFactory = new TaskFactory<IEnumerable<Contract>>();
            var kontrakt = await taskFactory.FromAsync(query.BeginExecute(null, null), iar => query.EndExecute(iar));

            Contract2 = kontrakt.FirstOrDefault();

            _context.DeleteObject(Contract2);
            _context.BeginSaveChanges(adoSave_RLMember, Contract2);

            _context.AddToContract(Contract);
            _context.BeginSaveChanges(adoSave_RLMember, Contract);
            return RedirectToPage("./Index");
        }

        private bool ContractExists(string id)
        {
            return _context.Contract.Any(e => e.Contract_No == id);
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
