using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using WebClient.Models.Repository;

namespace WebClient.Controllers
{
    public class PolicyController : Controller
    {
        SiteProvider provider;
        public PolicyController(IConfiguration configuration)
        {
            provider = new SiteProvider(configuration);
        }
        public async Task<IActionResult> ChinhSachBaoMat()
        {
            //Get Type of Tour
            ViewBag.typeoftours = await provider.TypeOfTour.GetTypeOfTours();

            //Get type of News Category
            ViewBag.newscategories = await provider.NewsCategory.GetNewsCategories();

            return View(await provider.Policy.GetPolycies());
        }
        public async Task<IActionResult> ChinhSachDatTour()
        {
            //Get Type of Tour
            ViewBag.typeoftours = await provider.TypeOfTour.GetTypeOfTours();

            //Get type of News Category
            ViewBag.newscategories = await provider.NewsCategory.GetNewsCategories();

            return View(await provider.Policy.GetPolycies());
        }
    }
}
