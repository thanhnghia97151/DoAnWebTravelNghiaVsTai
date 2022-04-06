using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using WebTravelApi.Models;
using WebTravelApi.Models.Repository;

namespace WebTravelApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberInRoleController : BaseController
    {
        public MemberInRoleController(IConfiguration configuration) : base(configuration)
        {
        }
        [HttpPost]
        public int Add(MemberInRole obj)
        {
            return provider.MemberInRole.Add(obj);
        }
    }
}
