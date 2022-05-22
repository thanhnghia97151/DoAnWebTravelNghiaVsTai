using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using WebClient.Models.Repository;
using WebClient.Models.ViewModels;

namespace WebClient.Controllers
{
    public class InvoiceController : Controller
    {
        SiteProvider provider;
        public InvoiceController(IConfiguration configuration)
        {
            provider = new SiteProvider(configuration);
        }

        public async Task<IActionResult> Create(string id)
        {
            //Get Type of Tour
            ViewBag.typeoftours = await provider.TypeOfTour.GetTypeOfTours();

            //Get type of News Category
            ViewBag.newscategories = await provider.NewsCategory.GetNewsCategories();

            //Get Tour
            ViewBag.tour = await provider.Tour.GetTourById(id);

            return View();
        }

        public async Task<IActionResult> NewCreate()
        {
            //Get Type of Tour
            ViewBag.typeoftours = await provider.TypeOfTour.GetTypeOfTours();

            //Get type of News Category
            ViewBag.newscategories = await provider.NewsCategory.GetNewsCategories();

            //Get Tour
            ViewBag.tour = await provider.Tour.GetTourById("u0abw0zjfr1fh9jszfyezw2169uura4ttymrqhkd0m8p1x6go7qrmictix2e3fde");

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(InvoiceDetailModel obj)
        {
            //Get Type of Tour
            ViewBag.typeoftours = await provider.TypeOfTour.GetTypeOfTours();

            //Get type of News Category
            ViewBag.newscategories = await provider.NewsCategory.GetNewsCategories();

            //Get Tour
            ViewBag.tour = await provider.Tour.GetTourById(obj.TourId);
            obj.InvoiceId = Helper.RandomString(64);
            if (await provider.Invoice.Add(obj) == 2)
            {
                await provider.Tour.Ticket(await provider.Tour.GetTourById(obj.TourId));
                return RedirectToAction("SuccessBook");
            }
            return View(obj);
        }
        public async Task<IActionResult> SuccessBook()
        {
            //Get Type of Tour
            ViewBag.typeoftours = await provider.TypeOfTour.GetTypeOfTours();

            //Get type of News Category
            ViewBag.newscategories = await provider.NewsCategory.GetNewsCategories();

            return View();
        }
    }
}
