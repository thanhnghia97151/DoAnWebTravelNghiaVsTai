using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using WebTravelApi.Models;
using WebTravelApi.Models.Repository;

namespace WebTravelApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginOAuthController : ControllerBase
    {
        SiteProvider provider;
        public LoginOAuthController(IConfiguration configuration)
        {
            provider = new SiteProvider(configuration);
        }
        //// SignIn Google
        //[HttpPost]
        //public object LoginOAuth(Member obj)
        //{

        //}
    }
}
