using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using WebClient.Models;
using WebClient.Models.Repository;

namespace WebClient.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class PolicyController : Controller
    {
        SiteProvider provider;
        public PolicyController(IConfiguration configuration)
        {
            provider = new SiteProvider(configuration);
        }
        public async Task<IActionResult> Index()
        {
            return View(await provider.Policy.GetPolycies());
        }
        public async Task<IActionResult> Create()
        {
            ViewBag.cate = await provider.PolicyCategory.GetPolicyCategories();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Policy obj)
        {
            if (ModelState.IsValid)
            {
                
                await provider.Policy.Add(obj);
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
