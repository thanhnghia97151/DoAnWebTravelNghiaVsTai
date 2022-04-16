using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using WebTravelApi.Models;

namespace WebTravelApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TourMemberController : BaseController
    {
        public TourMemberController(IConfiguration configuration) : base(configuration)
        {
        }
        [HttpGet]
        public IEnumerable<TourMember> GetTourMembers()
        {
            return provider.TourMember.GetTourMembers();
        }
        [HttpPost]
        public int Add(TourMember obj)
        {
            return provider.TourMember.Add(obj);
        }
    }
}
