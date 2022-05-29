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
        private readonly IForgetPasswordRepository _forgetPasswordRepository;
        public InvoiceController(IConfiguration configuration,
            IForgetPasswordRepository forgetPasswordRepository)
        {
            provider = new SiteProvider(configuration);
            _forgetPasswordRepository = forgetPasswordRepository;
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
                obj.InvoiceId = Helper.RandomString(64);
                //Get Type of Tour
                ViewBag.typeoftours = await provider.TypeOfTour.GetTypeOfTours();

                //Get type of News Category
                ViewBag.newscategories = await provider.NewsCategory.GetNewsCategories();
                //Get Tour
                var tour = await provider.Tour.GetTourById(obj.TourId);
                ViewBag.tour = tour;

                if (User.FindFirstValue(ClaimTypes.NameIdentifier) != null)
                {

                    if (ModelState.IsValid)
                    {
                        if (NameValidator.CheckName(obj.FullName) == false)
                        {
                            if (NameValidator.CheckAddress(obj.Address) == true)
                            {
                                if (CheckNumber.NumberModel(obj.Price) == "1")
                                {
                                    //obj.InvoiceId = Helper.RandomString(64);
                                    if (await provider.Invoice.Add(obj) == 2)
                                    {
                                        await provider.Tour.Ticket(obj);
                                        _forgetPasswordRepository.SendOrder(obj.Phone, obj.InvoiceId, obj.Price, obj.Quantity, tour.StartDate, tour.StartPlace);
                                        _forgetPasswordRepository.SendInforBank(obj.Phone);
                                        return RedirectToAction("SuccessBook");
                                    }
                                }
                                ViewBag.ErrPrice = CheckNumber.NumberModel(obj.Price);
                            }
                            ViewBag.ErrorAddress = NameValidator.address;
                            return View(obj);
                        }
                        ViewBag.ErrorName = NameValidator.name;
                        return View(obj);
                    }
                }
                ViewBag.ErrorRegister = "Bạn Chưa đăng nhập để mua tour";

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
            //Get Type of Tour
            ViewBag.typeoftours = await provider.TypeOfTour.GetTypeOfTours();

            //Get type of News Category
            ViewBag.newscategories = await provider.NewsCategory.GetNewsCategories();

            return View(await provider.Invoice.GetInvoiceModelById(id));
        }
        [HttpPost]
        public async Task<IActionResult> DeleteInvoice(InvoiceModel obj)
        {
            if (obj != null)
            {
                await provider.Invoice.DeleteInvoiceDetail(obj);
                await provider.Invoice.DeleteInvoice(obj);
                var restore = await provider.Invoice.RestoreQuantity(obj);
                return Redirect("/invoice/history");
            }
            return View(obj);
        }
    }
}
