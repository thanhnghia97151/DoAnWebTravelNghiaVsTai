using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections;
using System.Collections.Generic;
using WebTravelApi.Models;
using WebTravelApi.Models.Repository;

namespace WebTravelApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : BaseController
    {
        

        public MemberController(IConfiguration configuration) : base(configuration)
        {
        }
        [HttpGet]
        public IEnumerable<Member> GetMembers()
        {
            return provider.Member.GetMembers();
        }
        [HttpGet("{id}")]
        public Member GetMemberById(string id)
        {
            return provider.Member.GetMemberById(id);
        }
        [HttpPost]
        public int Add(Member obj)
        {
             
            return provider.Member.Add(obj);
        }
        [HttpPost("delete/{id}")]
        public int Delete(string id)
        {
            return provider.Member.Delete(id);
        }

    }
}
