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

        [HttpPost("loginoauth")]
        public object LoginOAuth(Member obj)
        {
            Member member = provider.Member.GetMemberById(obj.MemberID);
            if (member is null)
            {
                provider.Member.AddMemberByGoogle(obj);

            }
            obj.Roles = provider.Role.GetRoleNamesByMember(obj.MemberID);
            //string token = Helper.CreateToken(obj);
            return new
            {
                //Token = token,
                MemberID = obj.MemberID,
                Email = obj.Email,
                Roles = obj.Roles
            };

        }
        [HttpPost("change-password")]
        public int ChangePassword(ChangePassword obj)
        {
            Member member = provider.Member.GetMemberById(obj.Id);
            if (member != null)
            {
                return provider.Member.ChangePassword(obj);

            }
            return 0;
        }
        [HttpPost("confirm-number-phone/{id}")]
        public int ConfirmNumberPhone(string id)
        {
            Member obj = provider.Member.GetMemberById(id); 
            if (obj != null)
            {
                return provider.Member.ConfirmNumberPhone(id);
            }
            return 0;
        }
    }
}
