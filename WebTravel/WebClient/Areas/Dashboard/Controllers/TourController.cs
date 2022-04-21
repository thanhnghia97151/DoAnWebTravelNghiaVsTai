using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using WebClient.Models;
using WebClient.Models.Repository;

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
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Tour obj)
        {
            if (ModelState.IsValid)
            {
                var result = await provider.Tour.Add(obj);
                return Redirect("Index");
            }
            return View(obj);
        }
    }
}
