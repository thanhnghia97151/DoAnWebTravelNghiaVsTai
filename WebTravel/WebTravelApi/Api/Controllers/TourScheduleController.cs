using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using WebTravelApi.Models;

namespace WebTravelApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TourScheduleController : BaseController
    {
        public TourScheduleController(IConfiguration configuration) : base(configuration)
        {
        }
        [HttpGet]
        public IEnumerable<TourSchedule> GetTourSchedules()
        {
            return provider.TourSchedule.GetTourSchedule();
        }
        [HttpGet("{id}")]
        public TourSchedule GetTourSchedule(string id)
        {
            return provider.TourSchedule.GetTourSchedule(id);
        }
        [HttpPost]
        public int Add(TourSchedule obj)
        {
            return provider.TourSchedule.Add(obj);  
        }
        [HttpPost("delete/{id}")]
        public int Delete(string id)
        {
            return provider.TourSchedule.Delete(id);
        }
    }
}
