using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebClient.Models;
using WebClient.Models.Repository;

namespace WebClient.Controllers
{
    public class NewsController : Controller
    {
        SiteProvider provider;
        public NewsController(IConfiguration configuration)
        {
            provider = new SiteProvider(configuration);
        }
        public async Task<IActionResult> Index(int id =1)
        {
            //Get Type of Tour
            ViewBag.typeoftours = await provider.TypeOfTour.GetTypeOfTours();

            //Get type of News Category
            ViewBag.newscategories = await provider.NewsCategory.GetNewsCategories();
            List<News> listnews = await provider.News.GetNews();
            ViewBag.total = (listnews.Count - 1) / 6 + 1;
            return View(await provider.News.GetNewsPaging(id,6));
        }

        public async Task<IActionResult> Detail(string id)
        {

            //Get Type of Tour
            ViewBag.typeoftours = await provider.TypeOfTour.GetTypeOfTours();

            //Get type of News Category
            ViewBag.newscategories = await provider.NewsCategory.GetNewsCategories();

            return View(await provider.News.GetNewById(id));
        }
    }
}
