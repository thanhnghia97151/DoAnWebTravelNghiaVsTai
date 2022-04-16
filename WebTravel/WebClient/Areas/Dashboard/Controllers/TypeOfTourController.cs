using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using WebClient.Models;
using WebClient.Models.Repository;

namespace WebClient.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class TypeOfTourController : Controller
    {
        SiteProvider provider;
        public TypeOfTourController(IConfiguration configuration)
        {
            provider = new SiteProvider(configuration);
        }
        public async Task<IActionResult> Index()
        {

            return View(await provider.TypeOfTour.GetTypeOfTours());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(TypeOfTour obj)
        {
            if (ModelState.IsValid)
            {
                await provider.TypeOfTour.Add(obj);
            }
            return RedirectToAction("Index");
        }
       
    }
}
