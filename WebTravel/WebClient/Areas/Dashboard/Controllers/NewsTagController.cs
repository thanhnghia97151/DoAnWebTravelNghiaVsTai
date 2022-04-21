using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using WebClient.Models.Repository;

namespace WebClient.Areas.Dashboard.Controllers
{
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
    }
}
