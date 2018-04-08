using System;
using System.Collections.Generic;
using System.Data.Services.Client;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NAVN;
using Sales_Contracts.Data;

namespace Sales_Contracts.Pages.Contractz
{
    public class DeleteModel : PageModel
    {
        NAV _context = new NAV(new Uri("http://nb-marven.softera.lt:7048/DynamicsNAV100/OData/Company('CRONUS%20International%20Ltd.')"));

        [BindProperty]
        public Contract Contract { get; set; }

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

        public async Task<IActionResult> OnPostAsync(string id)
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

            //_context.AttachTo("Contracts", Contract);
            //_context.AddLink(Contract, "Contract_No", Contract);
            _context.DeleteObject(Contract);
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
