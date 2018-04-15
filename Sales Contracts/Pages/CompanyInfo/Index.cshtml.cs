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

namespace Sales_Contracts.Pages.Contract_Company
{
    public class EditCompanyInfoModel : PageModel
    {
        NAV _context = new NAV(new Uri("http://nb-marven.softera.lt:7048/DynamicsNAV100/OData/Company('CRONUS%20International%20Ltd.')"));

        [BindProperty]
        public ContractCompany ContractCompany { get; set; }
        public ContractCompany ContractCompany2 { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            _context.Credentials = CredentialCache.DefaultNetworkCredentials;

            var company = _context.ContractCompany;

            DataServiceQuery<ContractCompany> query = company;

            TaskFactory<IEnumerable<ContractCompany>> taskFactory = new TaskFactory<IEnumerable<ContractCompany>>();
            var kompany = await taskFactory.FromAsync(query.BeginExecute(null, null), iar => query.EndExecute(iar));

            ContractCompany = kompany.LastOrDefault();

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            _context.Credentials = CredentialCache.DefaultNetworkCredentials;
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.AddToContractCompany(ContractCompany);
            _context.BeginSaveChanges(adoSave_RLMember, ContractCompany);

            var company = _context.ContractCompany;

            DataServiceQuery<ContractCompany> query = company;

            TaskFactory<IEnumerable<ContractCompany>> taskFactory = new TaskFactory<IEnumerable<ContractCompany>>();
            var kompany = await taskFactory.FromAsync(query.BeginExecute(null, null), iar => query.EndExecute(iar));

            ContractCompany2 = kompany.FirstOrDefault();

            _context.DeleteObject(ContractCompany2);
            _context.BeginSaveChanges(adoSave_RLMember, ContractCompany2);

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
