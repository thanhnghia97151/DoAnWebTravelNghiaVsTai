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
    public class AuthController : BaseController
    {
        public AuthController(IConfiguration configuration) : base(configuration)
        {
        }       
        [HttpPost]
        
        public object Login(LoginModel obj)
        {
            Member member = provider.Member.Login(obj);
            if (member != null)
            {
                //code

                member.Roles = provider.Role.GetRoleNamesByMemberId(member.MemberID);
                //
                string token = Helper.Helper.CreateToken(member);
                return new
                {
                    Token = token,
                    MemberId = member.MemberID,
                    Email = member.Email,
                    Roles = member.Roles
                };
            }
            return null;
        }
    }
}
