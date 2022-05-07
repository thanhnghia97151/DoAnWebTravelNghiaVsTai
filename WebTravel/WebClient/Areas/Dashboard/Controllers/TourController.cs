using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using WebClient.Models;
using WebClient.Models.Repository;
using WebClient.Models.ViewModels;

namespace WebClient.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class TourController : Controller
    {
        SiteProvider provider;
        public TourController(IConfiguration configuration)
        {
            provider = new SiteProvider(configuration);
        }
        public async Task<IActionResult> Index()
        {

            return View(await provider.Tour.GetTours());
        }
        public async Task<IActionResult> Create()
        {
            // Category
            ViewBag.categories = new SelectList(await provider.TourCategory.GetTourCategories(),"TourCategoriesId","Name");

            // Schedule
            ViewBag.schedules = new SelectList(await provider.TourSchedule.GetTourSchedules(), "TourScheduleId", "Content");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Tour obj, IFormFile f)
        {
            if (ModelState.IsValid)
            {
                if (f != null)
                {
                    Image image = await provider.Tour.AddImage(f);
                    obj.Image = image.Name;
                }
                var result = await provider.Tour.Add(obj);
                return Redirect("Index");
            }
            return View(obj);
        }
    }
}
