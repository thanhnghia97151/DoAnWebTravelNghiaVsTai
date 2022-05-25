using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using WebClient.Extentions;
using WebClient.Models;
using WebClient.Models.Repository;

namespace WebClient.Controllers
{
    public class ContactController : Controller
    {
        SiteProvider provider;
        public ContactController(IConfiguration configuration)
        {
            provider = new SiteProvider(configuration); 
        }
        public async Task<IActionResult> Index()
        {
            //Get Type of Tour
            ViewBag.typeoftours = await provider.TypeOfTour.GetTypeOfTours();

            //Get type of News Category
            ViewBag.newscategories = await provider.NewsCategory.GetNewsCategories();
            return View();
        }
        public async Task<IActionResult> ContactWithMe()
        {
            try
            {
                //Get Type of Tour
                ViewBag.typeoftours = await provider.TypeOfTour.GetTypeOfTours();

                //Get type of News Category
                ViewBag.newscategories = await provider.NewsCategory.GetNewsCategories();

                // Infomation about company
                ViewBag.abouts = await provider.About.GetAbouts();

                //Get 10 news hot.
                ViewBag.news10hot = await provider.News.GetNews10Hot();
            }
            catch (System.Exception)
            {

                return View();
            }

            return View();  
        }

        // DisplayContact.
        [HttpGet]
        public async Task<IActionResult> DisplayContact() 
        {
            //Get Type of Tour
            ViewBag.typeoftours = await provider.TypeOfTour.GetTypeOfTours();

            //Get type of News Category
            ViewBag.newscategories = await provider.NewsCategory.GetNewsCategories();

            // Infomation about company
            ViewBag.abouts = await provider.About.GetAbouts();            

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> DisplayContact( Contact contact) 
        {
            //Get Type of Tour
            ViewBag.typeoftours = await provider.TypeOfTour.GetTypeOfTours();

            //Get type of News Category
            ViewBag.newscategories = await provider.NewsCategory.GetNewsCategories();

            // Infomation about company
            ViewBag.abouts = await provider.About.GetAbouts();

            if (ModelState.IsValid) 
            {
                if (ContactInformation.CheckInformationContact(contact) == true)
                {
                    await provider.Contact.Add(contact);
                    return RedirectToAction("Index", "Home");
                }
                ViewBag.ErrorName = ContactInformation.name;
                ViewBag.ErrorTitle = ContactInformation.title;
                ViewBag.ErrorContent = ContactInformation.content;
                ViewBag.ErrorCompany = ContactInformation.company;
            }
            return View(contact);
        }
    }
}
