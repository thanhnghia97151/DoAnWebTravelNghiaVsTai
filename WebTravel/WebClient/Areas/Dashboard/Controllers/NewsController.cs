using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using WebClient.Models;
using WebClient.Models.Repository;

namespace WebClient.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class NewsController : Controller
    {
        SiteProvider provider;
        public NewsController(IConfiguration configuration)
        {
            provider = new SiteProvider(configuration); 
        }
        public async Task<IActionResult> Index()
        {
            return View(await provider.News.GetNews());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(News news)
        {
            if (ModelState.IsValid)
            {
                await provider.News.Add(news);
                return Redirect("Index");
            }
            return View(news);
        }
        
        public async Task<IActionResult> ConfirmDelete(string id)
        {
            return View(await provider.News.GetNewById(id));
        }
        [HttpPost]
        public async Task<IActionResult> Delete(News obj)
        {
            if ((await provider.News.Delete(obj)) == 1)
            {
                return RedirectToAction("Index");
            }
            return Redirect("/");
        }
        
    }
}
