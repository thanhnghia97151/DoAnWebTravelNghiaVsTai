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
        [HttpPost("delete-by-member-id/{id}")]
        public int DeleteByMemberId(string id)
        {
            return provider.TourMember.DeleteByMemberId(id);
        }
        [HttpPost("delete-by-tour-id/{id}")]
        public int Delete(string id)
        {
            return provider.TourMember.DeleteByTourId(id);
        }
    }
}
