using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using WebClient.Models;
using WebClient.Models.Repository;

namespace WebClient.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class TourScheduleController : Controller
    {
        SiteProvider provider;
        public TourScheduleController(IConfiguration configuration)
        {
            provider = new SiteProvider(configuration);
        }
        public async Task<IActionResult> Index()
        {

            return View(await provider.TourSchedule.GetTourSchedules());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(TourSchedule obj)
        {
            if (ModelState.IsValid)
            {
                await provider.TourSchedule.Add(obj);
                return Redirect("Index");
            }
            return View(obj);
        }
    }
}
