using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
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
    }
}
