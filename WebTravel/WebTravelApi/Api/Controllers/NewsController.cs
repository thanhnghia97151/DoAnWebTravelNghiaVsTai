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

        [HttpGet("fournews")]
        public IEnumerable<News> GetFourNewses()
        {
            return provider.News.GetFourNewses();
        }

        [HttpPost]
        public int Add(News obj)
        {

            return provider.News.Add(obj);

        }

        [HttpGet("{id}")]
        public News GetNews(string id)
        {
            var news = provider.News.GetNews(id);
            var count = news.ViewCount + 1;
            provider.News.UpdateCountViewer(count, id);

            return provider.News.GetNews(id);
        }

        [HttpGet("newshot")]
        public News GetNewsHot() 
        {
            return provider.News.GetNewsHot();
        }

        [HttpGet("newsoutstanding")]
        public IEnumerable<News> GetNewsOutStanding()
        {
            return provider.News.GetNewsOutstanding();
        }

        [HttpPost("delete/{id}")]
        public int Delete(string id)
        {
            return provider.News.Delete(id);
        }
        [HttpPost("edit")]
        public int Edit(News obj)
        {
            return provider.News.Edit(obj);
        }

    }
}
