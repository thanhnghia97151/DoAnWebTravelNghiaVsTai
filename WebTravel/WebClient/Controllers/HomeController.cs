using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using WebClient.Models;
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

            //Get Type of Tour
            ViewBag.typeoftours = await provider.TypeOfTour.GetTypeOfTours();

            //Get type of News Category
            ViewBag.newscategories = await provider.NewsCategory.GetNewsCategories();
            return View();
        }
        public async Task<IActionResult> DetailTour(string id)
        {
            //Get Type of Tour
            ViewBag.typeoftours = await provider.TypeOfTour.GetTypeOfTours();

            //Get type of News Category
            ViewBag.newscategories = await provider.NewsCategory.GetNewsCategories();

            //Get Type Tour
            Tour tour = await provider.Tour.GetTourById(id);

            //Get Schedule
            ViewBag.schedule = await provider.TourSchedule.GetTourScheduleById(tour.ScheduleId);

            return View(await provider.Tour.GetTourById(id));
        }
    }
}
