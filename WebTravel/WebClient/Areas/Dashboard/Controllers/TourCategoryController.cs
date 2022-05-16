using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using WebClient.Models;
using WebClient.Models.Repository;

namespace WebClient.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class TourCategoryController : Controller
    {
        SiteProvider provider;
        public TourCategoryController(IConfiguration configuration)
        {
            provider = new SiteProvider(configuration); 
        }
        public async Task<IActionResult> Index()
        {

            return View(await provider.TourCategory.GetTourCategories());
        }
        public async Task<IActionResult> Create()
        {
            //Get Type Of Tour
            ViewBag.typeoftours = new SelectList(await provider.TypeOfTour.GetTypeOfTours(),"Id","Type");

            //Get Tour Category
            ViewBag.categories = new SelectList(await provider.TourCategory.GetTourCategories(), "TourCategoriesId", "Name");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(TourCategory obj)
        {
            if (ModelState.IsValid)
            {
                await provider.TourCategory.Add(obj);
                return Redirect("Index");
            }
            return View(obj);
        }
    }
}
