using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using WebTravelApi.Models;
using WebTravelApi.Models.Repository;

namespace WebTravelApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceDetailController : ControllerBase
    {
        SiteProvider provider;
        public InvoiceDetailController(IConfiguration configuration)
        {
            provider = new SiteProvider(configuration);
        }
        [HttpGet("{id}")]
        public InvoiceDetail GetInvoiceDetailByInvoiceId(string id)
        {
            return provider.InvoiceDetail.GetInvoiceDetailByInvoiceId(id);
        }
    }
}
