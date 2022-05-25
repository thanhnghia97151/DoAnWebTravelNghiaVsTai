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
        [HttpGet("category/{id}")]
        public List<Tour> GetTourByCategoryId(string id)
        {
            var list =provider.TourCategory.GetListCategoriesChildrent(id);
            
            return provider.Tour.GetTourByCategoryId(list);
        }
        [HttpGet("newcategory/{id}")]
        public IEnumerable<Tour> GetNewTourByCategoryId(string id)
        {
            return provider.Tour.GetNewTourByCategoryId(id);
        }
        [HttpPost("ticket/{id}")]
        public int Ticket(string id)
        {
            return provider.Tour.Ticket(id);
        }
        [HttpGet("search/{address}/{priceStart}/{priceEnd}")]
        public IEnumerable<Tour> Search(string address, decimal priceStart, decimal priceEnd)
        {
            return provider.Tour.Search(address,priceStart,priceEnd);
        }
    }
}
