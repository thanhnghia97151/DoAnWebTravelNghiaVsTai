using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebClient.Models.ViewModels;

namespace WebClient.Models.Repository
{
    public class CustomerRepository :BaseRepository
    {
        public CustomerRepository(IConfiguration configuration) : base(configuration)
        {
        }
        public async Task<int> Add(Customer obj)
        {
            return await Post<Customer>("/api/customer", obj);
        }

        public async Task<List<CustomerExport>> GetCustomer(string InvoicedId)
        {
            return await Get<List<CustomerExport>>($"/api/customer/{InvoicedId}");
        }
    }
}
