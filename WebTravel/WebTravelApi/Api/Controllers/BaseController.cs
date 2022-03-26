using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using WebTravelApi.Models.Repository;

namespace WebTravelApi.Api.Controllers
{
    public class BaseController : ControllerBase
    {
        protected SiteProvider provider;
        public BaseController(IConfiguration configuration)
        {
            provider = new SiteProvider(configuration);
        }
    }
}
