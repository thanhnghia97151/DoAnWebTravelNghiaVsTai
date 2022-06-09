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
        [HttpPost("ticket/{id}/{quantity}")]
        public int Ticket(string id, int quantity)
        {
            return provider.Tour.Ticket(id,quantity);
        }

        [HttpGet("search/{address}/{priceStart}/{priceEnd}/{startDate}/{endDate}")]
        public IEnumerable<Tour> Search(string address, decimal priceStart, decimal priceEnd, string startDate, string endDate)
        {
            string[] dateStart = startDate.ToString().Split('.');
            var resultStart = dateStart[0] + "/" + dateStart[1] + "/" + dateStart[2];

            string[] dateEnd = endDate.ToString().Split('.');
            var resultEnd = dateEnd[0] + "/" + dateEnd[1] + "/" + dateEnd[2];
            return provider.Tour.Search(address, priceStart, priceEnd, resultStart, resultEnd);
        }
    }
}
