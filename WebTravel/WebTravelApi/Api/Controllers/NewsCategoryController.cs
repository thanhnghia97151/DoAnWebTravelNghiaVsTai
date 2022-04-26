using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using WebTravelApi.Models.ViewModels;

namespace WebTravelApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsCategoryController : BaseController
    {
        public NewsCategoryController(IConfiguration configuration) : base(configuration)
        {
        }
        [HttpGet]
        public IEnumerable<NewsCategory> GetNewsCategories()
        {
            return provider.NewsCategory.GetNewsCategories();
        }
        [HttpPost]
        public int Add(NewsCategory obj)
        {
            return provider.NewsCategory.Add(obj);  
        }
        [HttpGet("{Id}")]
        public NewsCategory GetNewsCategory(string id)
        {
            return provider.NewsCategory.GetNewsCategory(id);
        }
        [HttpPost("delete/{id}")]
        public int Delete(string id)
        {
            return provider.NewsCategory.Delete(id);
        }
    }
}
