using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebClient.Models;
using WebClient.Models.Repository;

namespace WebClient.Controllers
{
    public class IntroduceController : Controller
    {
        SiteProvider provider;
        public IntroduceController(IConfiguration configuration)
        {
            provider = new SiteProvider(configuration);
        }
        public async Task<IActionResult> Index()
        {
            try
            {
                //Get Type of Tour
                ViewBag.typeoftours = await provider.TypeOfTour.GetTypeOfTours();

                //Get type of News Category
                ViewBag.newscategories = await provider.NewsCategory.GetNewsCategories();

                List<About> aboutList = new List<About>();
                // Infomation about company
                aboutList = await provider.About.GetAbouts();
                ViewBag.abouts = aboutList;

                //Get 10 news hot.
                ViewBag.news10hot = await provider.News.GetNews10Hot();
            }
            catch (System.Exception)
            {

                ViewBag.ErrorSystem = "Hệ thống tạm thời bị lỗi vui lòng trở lại sau.";
            }

            return View();
        }
    }
}
