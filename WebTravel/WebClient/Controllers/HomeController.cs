using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using WebClient.Models.Repository;

namespace WebClient.Controllers
{
    public class HomeController : Controller
    {
        SiteProvider provider;
        public HomeController(IConfiguration configuration)
        {
            provider = new SiteProvider(configuration);
        }
        public async Task<IActionResult> Index()
        {
            //Get Tours
            ViewBag.tours = await provider.Tour.GetTours();
            
            //Get News
            ViewBag.news = await provider.News.GetNews();   
            return View();
        }
        public async Task<IActionResult> DetailTour(string id)
        {

            return View(await provider.Tour.GetTourById(id));
        }
    }
}
