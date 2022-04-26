using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using WebClient.Models;
using WebClient.Models.Repository;

namespace WebClient.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class NewsTagController : Controller
    {
        SiteProvider provider;
        public NewsTagController(IConfiguration configuration)
        {
            provider = new SiteProvider(configuration);
        }
        public async Task<IActionResult> Index()
        {
            return View(await provider.NewsTag.GetNewsTags());
        }
        public async Task<IActionResult> Create()
        {
            ViewBag.news =new SelectList(await provider.News.GetNews(),"NewsId","Name");
            ViewBag.tags =new SelectList(await provider.Tag.GetTags(),"TagId","Name");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(NewsTag obj)
        {
            if (ModelState.IsValid)
            {
                await provider.NewsTag.Add(obj);
                return RedirectToAction("Index");
            }
            else
                return View(obj);
        }
    }
}
