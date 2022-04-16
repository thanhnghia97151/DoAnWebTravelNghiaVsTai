using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using WebTravelApi.Models;

namespace WebTravelApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : BaseController
    {
        public NewsController(IConfiguration configuration) : base(configuration)
        {
        }
        [HttpGet]
        public IEnumerable<News> GetNewses()
        {
            return provider.News.GetNewses();
        }
        [HttpPost]
        public int Add(News obj)
        {
           
                return provider.News.Add(obj);  
            
        }
        [HttpGet("{id}")]
        public News GetNews(string id)
        {
            return provider.News.GetNews(id);
        }

    }
}
