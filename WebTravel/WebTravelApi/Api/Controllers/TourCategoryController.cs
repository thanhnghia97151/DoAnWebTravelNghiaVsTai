using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using WebTravelApi.Models;

namespace WebTravelApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TourCategoryController : BaseController
    {
        public TourCategoryController(IConfiguration configuration) : base(configuration)
        {
        }
        [HttpGet]
        public IEnumerable<TourCategory> GetTourCategories()
        {
            return provider.TourCategory.GetTourCategories();
        }
        [HttpPost]
        public int Add(TourCategory obj)
        {
            return provider.TourCategory.Add(obj);
        }
        [HttpGet("{id}")]
        public TourCategory GetTourCategory(string id)
        {
            return provider.TourCategory.GetTourCategory(id);
        }
        [HttpPost("delete/{id}")]
        public int Delete(string id)
        {
            return provider.TourCategory.Delete(id);
        }
    }
}
