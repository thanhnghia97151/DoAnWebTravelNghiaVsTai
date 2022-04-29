using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using WebClient.Models.Repository;

namespace WebClient.Controllers
{
    public class MenuBarController : Controller
    {
        SiteProvider provider;
        public MenuBarController(IConfiguration configuration)
        {
            provider = new SiteProvider(configuration);
        }
        public IActionResult Index()
        {
            
            return PartialView("_PartialMenuBar");
        }
    }
}
