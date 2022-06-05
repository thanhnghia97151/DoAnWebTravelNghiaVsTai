using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTravelApi.Models;
using WebTravelApi.Models.ViewModels;

namespace WebTravelApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : BaseController
    {
       
        public CustomerController(IConfiguration configuration) : base(configuration)
        {
        }

        [HttpPost]
        public int Add(Customer customer)
        {
            return provider.Customer.Add(customer);
        }

        [HttpGet("{InvoicedId}")]
        public IEnumerable<CustomerExport> GetCustomer(string InvoicedId)
        {
            return provider.Customer.Get(InvoicedId);
        }
    }
}
