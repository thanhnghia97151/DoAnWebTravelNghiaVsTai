using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
    }
}
