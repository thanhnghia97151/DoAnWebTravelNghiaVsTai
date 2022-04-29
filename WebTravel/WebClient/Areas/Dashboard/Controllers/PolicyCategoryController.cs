using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using WebClient.Models;
using WebClient.Models.Repository;

namespace WebClient.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class PolicyCategoryController : Controller
    {
        SiteProvider provider;
        public PolicyCategoryController(IConfiguration configuration)
        {
            provider = new SiteProvider(configuration);
        }
        public async Task<IActionResult> Index()
        {
            return View(await provider.PolicyCategory.GetPolicyCategories());
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(PolicyCategory obj)
        {
            if (ModelState.IsValid)
            {
                await provider.PolicyCategory.Add(obj);
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
