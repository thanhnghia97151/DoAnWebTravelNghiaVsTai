using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using WebClient.Models.Repository;

namespace WebClient.Controllers
{
    public class ContactController : Controller
    {
        SiteProvider provider;
        public ContactController(IConfiguration configuration)
        {
            provider = new SiteProvider(configuration); 
        }
        public async Task<IActionResult> Index()
        {
            //Get Type of Tour
            ViewBag.typeoftours = await provider.TypeOfTour.GetTypeOfTours();

            //Get type of News Category
            ViewBag.newscategories = await provider.NewsCategory.GetNewsCategories();
            return View();
        }
        public async Task<IActionResult> ContactWithMe()
        {
            //Get Type of Tour
            ViewBag.typeoftours = await provider.TypeOfTour.GetTypeOfTours();

            //Get type of News Category
            ViewBag.newscategories = await provider.NewsCategory.GetNewsCategories();

            // Infomation about company
            ViewBag.abouts = await provider.About.GetAbouts();

            //Get 10 news hot.
            ViewBag.news10hot = await provider.News.GetNews10Hot();

            return View();  
        }
    }
}
