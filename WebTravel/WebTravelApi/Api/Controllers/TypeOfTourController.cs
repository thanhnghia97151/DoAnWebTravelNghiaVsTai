using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using WebTravelApi.Models;

namespace WebTravelApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypeOfTourController : BaseController
    {
        public TypeOfTourController(IConfiguration configuration) : base(configuration)
        {
        }
        [HttpGet]
        public IEnumerable<TypeOfTour> GetTypeOfTours()
        {
            return provider.TypeOfTour.GetTypeOfTours();
        }
        [HttpPost]
        public int Add(TypeOfTour obj)
        {
            return provider.TypeOfTour.Add(obj);
        }
        [HttpGet("{id}")]
        public TypeOfTour GetTypeOfTour(string id)
        {
            return provider.TypeOfTour.GetTypeOfTour(id);
        }
        [HttpPost("delete/{id}")]
        public int Delete(string id)
        {
            return provider.TypeOfTour.Delete(id);
        }

    }
}
