using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using WebClient.Models;
using WebClient.Models.Repository;

namespace WebClient.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class TagController : Controller
    {
        SiteProvider provider;
        public TagController(IConfiguration configuration)
        {
            provider = new SiteProvider(configuration);
        }
        public async Task<IActionResult> Index()
        {

            return View(await provider.Tag.GetTags());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Tag obj)
        {
            if (ModelState.IsValid)
            {
                var result = await provider.Tag.Add(obj);
                return Redirect("Index");
            }
            return View(obj);
        }
    }
}
