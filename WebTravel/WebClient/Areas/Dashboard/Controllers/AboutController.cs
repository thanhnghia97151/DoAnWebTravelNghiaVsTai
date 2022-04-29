using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using WebClient.Models;
using WebClient.Models.Repository;

namespace WebClient.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class AboutController : Controller
    {
        SiteProvider provider;
        public AboutController(IConfiguration configuration)
        {
            provider = new SiteProvider(configuration);
        }
        
        public async Task<IActionResult> Index()
        {
            return View(await provider.About.GetAbouts());
        }
        public async Task<IActionResult> Create()
        {
            ViewBag.policies =new SelectList(await provider.Policy.GetPolycies(),"Id","Content");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(About obj)
        {
            if (ModelState.IsValid)
            {

                await provider.About.Add(obj);
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
