using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using WebTravelApi.Models;

namespace WebTravelApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TourController : BaseController
    {
        public TourController(IConfiguration configuration) : base(configuration)
        {
        }
        [HttpGet]
        public IEnumerable<Tour> GetTour()
        {
            return provider.Tour.GetTours();
        }
        [HttpPost]
        public int Add(Tour obj)
        {
            return provider.Tour.Add(obj);
        }
        [HttpGet("{id}")]
        public Tour GetTour(string id)
        {
            return provider.Tour.GetTour(id);
        }
        [HttpPost("delete/{id}")]
        public int Delete(string id)
        {
            return provider.Tour.Delete(id);
        }
    }
}
