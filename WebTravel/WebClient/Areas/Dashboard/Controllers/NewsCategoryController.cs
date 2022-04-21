using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using WebClient.Models;
using WebClient.Models.Repository;

namespace WebClient.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]

    public class NewsCategoryController : Controller
    {
        SiteProvider provider;
        public NewsCategoryController(IConfiguration configuration)
        {
            provider = new SiteProvider(configuration);
        }
        public async Task<IActionResult> Index()
        {
            return View(await provider.NewsCategory.GetNewsCategories());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(NewsCategory obj)
        {
            if (ModelState.IsValid)
            {
                await provider.NewsCategory.Add(obj);
                return Redirect("Index");
            }
            return View(obj);
        }
    }
}
