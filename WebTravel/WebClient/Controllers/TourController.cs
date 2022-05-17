using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebClient.Models;
using WebClient.Models.Repository;
using WebClient.Models.ViewModels;

namespace WebClient.Controllers
{
    public class TourController : Controller
    {
        SiteProvider provider;

        public TourController(IConfiguration configuration)
        {
            this.provider = new SiteProvider(configuration);
        }
        public async Task<IActionResult> TypeOfTour(string id)
        {
            //Get Type of Tour
            ViewBag.typeoftours = await provider.TypeOfTour.GetTypeOfTours();

            //Get type of News Category
            ViewBag.newscategories = await provider.NewsCategory.GetNewsCategories();

            //Get Type Of Tour
            ViewBag.typeoftour = await provider.TypeOfTour.GetTypeOfTour(id);

            //Get Category By Type Of Tour
            List<TourCategoryModel> tourCate = await provider.TourCategory.GetTourCategoryModelByTypeOfTour(id);

            //Get Tour by Category
            foreach (var item in tourCate)
            {
                item.Tours = await provider.Tour.GetTourByCategoryId(item.TourCategoriesId);
            }
            ViewBag.tourcategories = tourCate;

            return View();
        }
        public async Task<IActionResult> ToursByCategory()
        {
            //Get Type of Tour
            ViewBag.typeoftours = await provider.TypeOfTour.GetTypeOfTours();

            //Get type of News Category
            ViewBag.newscategories = await provider.NewsCategory.GetNewsCategories();

            return View();
        }
    }
}
