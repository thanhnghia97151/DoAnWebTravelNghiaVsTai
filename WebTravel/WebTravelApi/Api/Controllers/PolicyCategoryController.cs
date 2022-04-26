using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using WebTravelApi.Models;

namespace WebTravelApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PolicyCategoryController : BaseController
    {
        public PolicyCategoryController(IConfiguration configuration) : base(configuration)
        {
        }
        [HttpGet]
        public IEnumerable<PolicyCategory> GetPolicyCategories()
        {
            return provider.PolicyCategory.GetEnumberables();
        }
        [HttpPost]
        public int Add(PolicyCategory obj)
        {
            return provider.PolicyCategory.Add(obj);
        }
        [HttpGet("{id}")]
        public PolicyCategory GetPolicyCategory(string id)
        {
            return provider.PolicyCategory.GetPolicyCategory(id);
        }
        [HttpPost("delete/{id}")]
        public int Delete(string id)
        {
            return provider.PolicyCategory.Delete(id);
        }
    }
}
