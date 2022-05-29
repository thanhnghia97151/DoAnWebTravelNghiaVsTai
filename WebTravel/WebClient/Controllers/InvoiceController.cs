using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Security.Claims;
using System.Threading.Tasks;
using WebClient.Extentions;
using WebClient.Models;
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
            try
            {
                if (User.FindFirstValue(ClaimTypes.NameIdentifier) != null)
                {
                    obj.InvoiceId = Helper.RandomString(64);
                    //Get Type of Tour
                    ViewBag.typeoftours = await provider.TypeOfTour.GetTypeOfTours();

                    //Get type of News Category
                    ViewBag.newscategories = await provider.NewsCategory.GetNewsCategories();

                    //Get Tour
                    ViewBag.tour = await provider.Tour.GetTourById(obj.TourId);
                    //obj.InvoiceId = Helper.RandomString(64);
                    if (await provider.Invoice.Add(obj) == 2)
                    {
                        await provider.Tour.Ticket(obj);
                        return RedirectToAction("SuccessBook");
                    }
                }

            }
            catch (System.Exception)
            {
                ModelState.AddModelError("", "Lỗi hệ thống, vui lòng truy cập sau");  
            }
            //return Redirect($"/invoice/create/{obj.TourId}");
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
        [Authorize]
        public async Task<IActionResult> History()
        {
            //Get Type of Tour
            ViewBag.typeoftours = await provider.TypeOfTour.GetTypeOfTours();

            //Get type of News Category
            ViewBag.newscategories = await provider.NewsCategory.GetNewsCategories();

            var list = await provider.Invoice.GetInvoiceModelByMemberId(User.FindFirstValue(ClaimTypes.NameIdentifier));
            foreach (var item in list)
            {
                item.Tour = await provider.Tour.GetTourById(item.TourId);
            }
            return View(list);
        }
        public async Task<IActionResult> ConfirmDelete(string id)
        {
            var t = await provider.Invoice.GetInvoice(id);
            return View(await provider.Invoice.GetInvoice(id));
        }
        [HttpPost]
        public async Task<IActionResult> DeleteInvoice(Invoice obj)
        {
            if (ModelState.IsValid)
            {
                if (obj != null)
                {
                    await provider.Invoice.DeleteInvoiceDetail(obj);
                    await provider.Invoice.DeleteInvoice(obj);
                    
                    return Redirect("/invoice/history");

                }
            }
            
            return NotFound();
        }
    }
}
