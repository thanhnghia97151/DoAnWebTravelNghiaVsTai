using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using WebTravelApi.Models;

namespace WebTravelApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PolicyController : BaseController
    {
        public PolicyController(IConfiguration configuration) : base(configuration)
        {
        }
        [HttpGet]
        public IEnumerable<Policy> GetPolicies()
        {
            return provider.Policy.GetPolicies();
        }
        [HttpPost]
        public int Add(Policy obj)
        {
            return provider.Policy.Add(obj);
        }
        [HttpGet("{id}")]
        public Policy GetPolicy(string id)
        {
            return provider.Policy.GetPolicy(id);
        }
        [HttpPost("delete/{id}")]
        public int Delete(string id)
        {
            return provider.Policy.Delete(id);
        }
    }
}
