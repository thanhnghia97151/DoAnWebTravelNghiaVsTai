using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using WebTravelApi.Models;

namespace WebTravelApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsTagController : BaseController
    {
        public NewsTagController(IConfiguration configuration) : base(configuration)
        {
        }
        [HttpGet]
        public IEnumerable<NewsTag> GetNewsTags()
        {
            return provider.NewsTag.GetNewsTags();
        }
        [HttpPost]
        public int Add(NewsTag obj)
        {
            return provider.NewsTag.Add(obj);
        }
        [HttpPost("delete-by-news-id/{id}")]
        public int DeleteByNewsId(string id)
        {
            return provider.NewsTag.DeleteByNewsId(id);
        }
        [HttpPost("delete-by-tag-id/{id}")]
        public int Delete(string id)
        {
            return provider.NewsTag.DeleteByTagId(id);
        }
        [HttpGet("newstag-by-news/{id}")]
        public IEnumerable<NewsTag> GetNewsTagByNewsId(string id)
        {
            return provider.NewsTag.GetNewsTagByNewsId(id);
        }
    }
}
