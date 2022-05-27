using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using WebTravelApi.Models;

namespace WebTravelApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : BaseController
    {
        public AboutController(IConfiguration configuration) : base(configuration)
        {
        }
        [HttpGet]
        public IEnumerable<About> GetAbouts()
        {
            return provider.About.GetAbouts();
        }
        [HttpPost]
        public int Add(About obj)
        {
            return provider.About.Add(obj);
        }
        /*[HttpGet("{id}")]
        public About GetAbout(string id)
        {
            return provider.About.GetAbout(id);
        }*/
        [HttpGet("abouts")]
        public About GetAbout()
        {
            return provider.About.GetAbout();
        }

        [HttpPost("delete/{id}")]
        public int Delete(string id)
        {
            return provider.About.Delete(id);
        }
    }
}
