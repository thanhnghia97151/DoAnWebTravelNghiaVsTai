using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTravelApi.Models;

namespace WebTravelApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : BaseController
    {
        public ContactController(IConfiguration configuration) : base(configuration)
        {
        }

        [HttpPost]
        public int SendContact(Contact contact)
        {
            return provider.Contact.Add(contact);
        }
    }
}
