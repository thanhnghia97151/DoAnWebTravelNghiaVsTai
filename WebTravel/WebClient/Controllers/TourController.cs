using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using PagedList;
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


            //Get tour category parent
            List<TourCategoryModel> listparentCate = await provider.TourCategory.GetTourCategoryParent(id);
            if (listparentCate != null)
            {
                foreach (var item in listparentCate)
                {
                    item.Childrens = await provider.TourCategory.GetTourCategroyChild(item.TourCategoriesId);
                }
            }

            if (listparentCate != null)
            {
                foreach (var item in listparentCate)
                {
                    if (item.Childrens != null)
                    {
                        foreach (var child in item.Childrens)
                        {
                            child.Tours = await provider.Tour.GetTourByCategoryId(child.TourCategoriesId);
                        }
                    }
                }
            }

            ViewBag.tourcateparent = listparentCate;

            return View();
        }
        public async Task<IActionResult> ToursByCategory(string id)
        {
            //Get Type of Tour
            ViewBag.typeoftours = await provider.TypeOfTour.GetTypeOfTours();

            //Get type of News Category
            ViewBag.newscategories = await provider.NewsCategory.GetNewsCategories();

            //Get Tour Category by Id
            ViewBag.tourcate = await provider.TourCategory.GetCategory(id);


            //Get Tours by CategoryId
            ViewBag.toursbycategoryid = await provider.Tour.GetTourByCategoryId(id);

            return View();
        }
        public async Task<IActionResult> AllTour()
        {
            //Get Type of Tour
            ViewBag.typeoftours = await provider.TypeOfTour.GetTypeOfTours();

            //Get type of News Category
            ViewBag.newscategories = await provider.NewsCategory.GetNewsCategories();

            List<Tour> list =(List<Tour>) await provider.Tour.GetTours();

            

            return View(await provider.Tour.GetTours());
        }
        
    }
}
