using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using WebTravelApi.Models;
using WebTravelApi.Models.ViewModels;

namespace WebTravelApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : BaseController
    {
        public RoleController(IConfiguration configuration) : base(configuration)
        {
        }

        [HttpGet]
        public IEnumerable<Role> GetRoles()
        {
            return provider.Role.GetRoles();
        }
        [HttpGet("role-checked/{id}")]
        public IEnumerable<RoleChecked> GetRolesChecked(string id)
        {
            return provider.Role.GetRolesChecked(id);
        }
        [HttpGet("role-name/{id}")]
        public IEnumerable<string> GetRoleNamesByMemberId(string id)
        {
            return provider.Role.GetRoleNamesByMemberId(id);
        }
        [HttpPost]
        public int Add(Role obj)
        {
            return provider.Role.Add(obj);
        }
        [HttpPost("delete/{id}")]
        public int Delete(string id)
        {
            return provider.Role.Delete(id);
        }

    }
}
