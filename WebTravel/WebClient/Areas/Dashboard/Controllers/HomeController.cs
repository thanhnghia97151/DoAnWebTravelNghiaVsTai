using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;
using WebClient.Models.Repository;

namespace WebClient.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class HomeController : Controller
    {
        SiteProvider provider;
        public HomeController(IConfiguration configuration)
        {
            provider = new SiteProvider(configuration);
        }
        public IActionResult Index()
        {

            return View();
        }

        public async Task<IActionResult> GetStatsDay(DateTime time)
        {
            var t = await provider.Invoice.GetStatsDay(time);
            return Json(await provider.Invoice.GetStatsDay(time));  
        }
    }
}
