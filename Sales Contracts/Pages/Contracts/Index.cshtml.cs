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
    public class IndexModel : PageModel
    {
        NAV _nav = new NAV(new Uri("http://nb-marven.softera.lt:7048/DynamicsNAV100/OData/Company('CRONUS%20International%20Ltd.')"));
        public IEnumerable<Contract> Contract { get;set; }

        public async Task OnGetAsync()
        {
            _nav.Credentials = CredentialCache.DefaultNetworkCredentials;
            var contracts = _nav.Contract;

            DataServiceQuery<Contract> query = contracts;

            TaskFactory<IEnumerable<Contract>> taskFactory = new TaskFactory<IEnumerable<Contract>>();
            Contract = await taskFactory.FromAsync(query.BeginExecute(null, null), iar => query.EndExecute(iar));
        }
    }
}
