using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
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

            //Get News hot.
            ViewBag.news = await provider.News.GetNewsHot();

            //Get News outstanding.
            ViewBag.newsoutstanding = await provider.News.GetNewsOutstanding();

            //Get new Tour
            ViewBag.newnews = await provider.News.GetNews();

            //Get new Tour
            ViewBag.fournews = await provider.News.GetFourNews();

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

            //Get 
            List<Comment> listCommentParent = await provider.Comment.GetCommentsByTourIdParent(id);
            foreach (var item in listCommentParent)
            {
                item.Childrent = await provider.Comment.GetCommentsByTourId(item.TourId);
            }
            ViewBag.comments = listCommentParent;

            return View(await provider.Tour.GetTourById(id));
        }
        [HttpPost]
        public async Task<IActionResult> SaveCommentData(Comment obj)
        {
            if (ModelState.IsValid)
            {
                if (obj != null)
                {
                    await provider.Comment.Add(obj);
                    return RedirectToAction("DetailTour", "Home", new { id = obj.TourId });
                }
            }
            // edit at here.
            return NotFound();
        }
    }
}
