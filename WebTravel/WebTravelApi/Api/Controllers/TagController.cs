using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using WebTravelApi.Models;

namespace WebTravelApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagController : BaseController
    {
        public TagController(IConfiguration configuration) : base(configuration)
        {
        }
        [HttpGet]
        public IEnumerable<Tag> GetTags()
        {
            return provider.Tag.GetTags();
        }
        [HttpPost]
        public int Add(Tag obj)
        {
            return provider.Tag.Add(obj);
        }
        [HttpGet("{id}")]
        public Tag GetTag(string id)
        {
            return provider.Tag.GetTag(id);
        }
        [HttpPost("delete/{id}")]
        public int Delete(string id)
        {
            return provider.Tag.Delete(id);
        }
    }
}
