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
            List<News> listnews = new List<News>();
            try
            {
                //Get Type of Tour
                ViewBag.typeoftours = await provider.TypeOfTour.GetTypeOfTours();

                //Get type of News Category
                ViewBag.newscategories = await provider.NewsCategory.GetNewsCategories();

                // Infomation about company
                ViewBag.abouts = await provider.About.GetAbouts();

                listnews = await provider.News.GetNews();
                ViewBag.total = (listnews.Count - 1) / 6 + 1;
            }
            catch (System.Exception)
            {

                ViewBag.ErrorSystem = "Lỗi hệ thống, vui lòng thử lại sau";
            }

            return View(await provider.News.GetNewsPaging(id,6));
        }

        public async Task<IActionResult> Detail(string id)
        {

            try
            {
                //Get Type of Tour
                ViewBag.typeoftours = await provider.TypeOfTour.GetTypeOfTours();

                //Get type of News Category
                ViewBag.newscategories = await provider.NewsCategory.GetNewsCategories();

                // Infomation about company
                ViewBag.abouts = await provider.About.GetAbouts();

                //Get 10 news hot.
                ViewBag.news10hot = await provider.News.GetNews10Hot();
            }
            catch (System.Exception)
            {

                ViewBag.ErrorSystem = "Lỗi hệ thống, vui lòng thử lại sau";
            }

            return View(await provider.News.GetNewById(id));
        }
        public async Task<IActionResult> NewsCategory(string id)
        {
            try
            {
                //Get Type of Tour
                ViewBag.typeoftours = await provider.TypeOfTour.GetTypeOfTours();

                //Get type of News Category
                ViewBag.newscategories = await provider.NewsCategory.GetNewsCategories();

                // Infomation about company
                ViewBag.abouts = await provider.About.GetAbouts();
            }
            catch (System.Exception)
            {

                ViewBag.ErrorSystem = "Lỗi hệ thống, vui lòng thử lại sau";
            }

            return View(await provider.News.GetNewsByCategoryId(id));
        }
    }
}
