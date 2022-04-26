using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using WebClient.Models.Repository;

namespace WebClient.Controllers
{
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

        public async Task<IActionResult> Detail(string id)
        {
            return View(await provider.News.GetNewById(id));
        }
    }
}
