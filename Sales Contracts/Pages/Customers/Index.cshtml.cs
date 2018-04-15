using System;
using System.Collections.Generic;
using System.Data.Services.Client;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NAVN;

namespace Sales_Contracts.Pages.Customers
{
    public class IndexModel : PageModel
    {
        NAV _nav = new NAV(new Uri("http://nb-marven.softera.lt:7048/DynamicsNAV100/OData/Company('CRONUS%20International%20Ltd.')"));
        public IEnumerable<Customer> Customer { get; set; }

        public async Task OnGetAsync()
        {
            _nav.Credentials = CredentialCache.DefaultNetworkCredentials;
            var contracts = _nav.Customer;

            DataServiceQuery<Customer> query = contracts;

            TaskFactory<IEnumerable<Customer>> taskFactory = new TaskFactory<IEnumerable<Customer>>();
            Customer = await taskFactory.FromAsync(query.BeginExecute(null, null), iar => query.EndExecute(iar));
        }
    }
}
