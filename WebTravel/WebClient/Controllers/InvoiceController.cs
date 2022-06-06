using DinkToPdf;
using DinkToPdf.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.IO;
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
        private readonly IConverter _converter;
        public InvoiceController(IConfiguration configuration,
            IForgetPasswordRepository forgetPasswordRepository,
            IConverter converter)
        {
            provider = new SiteProvider(configuration);
            _forgetPasswordRepository = forgetPasswordRepository;
            _converter = converter;
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
        public async Task<IActionResult> Create(InvoiceDetailModel obj, IFormCollection f)
        {
            
            try
            {
                obj.InvoiceId = Helper.RandomString(64);
                int quantitys = int.Parse(f["quantitySmall"].ToString());
                var quantityResult = ((int)obj.Quantity) + quantitys;
                obj.Quantity = ((short)quantityResult);
                List<Customer> listCustomers = new List<Customer>();
                var result = 1;
                try
                {
                    result = int.Parse(f["result"].ToString());
                }
                catch (System.Exception)
                {
                    result = 1;
                }
                for (int i = 0; i < result; i++)
                {
                    Customer customer = new Customer()
                    {
                        CustomerID = Helper.RandomString(64),
                        UserName = f["customername" + i].ToString(),
                        Phone = f["customersdt" + i].ToString(),
                        Address = f["customeraddress" + i].ToString(),
                        InvoiceId = obj.InvoiceId
                    };
                    listCustomers.Add(customer);
                }

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
                                        foreach (var item in listCustomers)
                                        {
                                            await provider.Customer.Add(item);
                                        }
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

        [HttpGet]
        public IActionResult Checkout(string MemberId)
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Checkout()
        {
            var list = await provider.Invoice.GetInvoiceByMemberId(User.FindFirstValue(ClaimTypes.NameIdentifier));
            foreach (var item in list)
            {
                await provider.Invoice.CheckOut(item);
            }
            return RedirectToAction("History");
        }

        [HttpPost]
        public async Task<IActionResult> CreatePDF(IFormCollection f)
        {
            double totalResult = 0;
            var soTT = 1;
            List<ExportOrder> exportOrders = new List<ExportOrder>();
            var result = int.Parse(f["Result"].ToString());
            for (int i = 0; i < result; i++)
            {
                string invoicedId = f["InvoicedId+"+i].ToString();
                string name = f["Name+"+i].ToString();
                int quantity = int.Parse(f["Quantity+" + i].ToString());
                double price = double.Parse(f["Price+" + i].ToString());
                string check = f["Check+" + i].ToString();
                string status = f["Status+" + i].ToString();
                if (check == "1" && status == "1")
                {
                 
                    ExportOrder export = new ExportOrder()
                    {
                        ID = invoicedId,
                        Stt = soTT,
                        Name = name,
                        Quantity = quantity,
                        Price = price,
                        TotalMoney = quantity * price
                    };
                    totalResult += export.TotalMoney;
                    soTT++;
                    exportOrders.Add(export);
                }
             }

            Users users = new Users()
            {
                Name = User.FindFirstValue(ClaimTypes.Name),
                Email = User.FindFirstValue(ClaimTypes.Email),
                Phone = User.FindFirstValue(ClaimTypes.MobilePhone) == "" || User.FindFirstValue(ClaimTypes.MobilePhone) is null ? "Chưa cập nhật" : User.FindFirstValue(ClaimTypes.MobilePhone)
            };
            int customerSTT = 1;
            List<CustomerInformation> listCustomer = new List<CustomerInformation>(); 
            foreach (var item in exportOrders)
            {
                var invoice = await provider.Invoice.GetInvoice(item.ID);
                var cus = await provider.Customer.GetCustomer(item.ID);
                CustomerInformation customerInformation = new CustomerInformation()
                {
                    Stt = customerSTT,
                    InvoicedId = item.ID.Substring(0,10),
                    InvoiceDate = invoice.InvoiceDate,
                    Counts = cus.Count,
                    customerExports = cus
                };
                listCustomer.Add(customerInformation);
                customerSTT++;
            }

            var globalSettings = new GlobalSettings
            {
                ColorMode = ColorMode.Color,
                Orientation = Orientation.Portrait,
                PaperSize = PaperKind.A4,
                Margins = new MarginSettings { Top = 10 },
                DocumentTitle = "PDF Report"
            };

            var objectSettings = new ObjectSettings
            {
                PagesCount = true,
                HtmlContent = TemplateGenerator.GetHTMLString(exportOrders, users, totalResult, listCustomer),
                WebSettings = { DefaultEncoding = "utf-8", UserStyleSheet = Path.Combine(Directory.GetCurrentDirectory(), "assets", "generate.css") },
                HeaderSettings = { FontName = "Arial", FontSize = 9, Right = "Page [page] of [toPage]", Line = true },
                FooterSettings = { FontName = "Arial", FontSize = 9, Line = true, Center = "Report Footer" }
            };

            var pdf = new HtmlToPdfDocument()
            {
                GlobalSettings = globalSettings,
                Objects = { objectSettings }
            };

            var file = _converter.Convert(pdf);
            return File(file, "application/pdf");
        }
    }
}
