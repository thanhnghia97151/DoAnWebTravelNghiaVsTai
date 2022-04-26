using Microsoft.AspNetCore.Mvc;

namespace WebClient.Controllers
{
    public class TourController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
