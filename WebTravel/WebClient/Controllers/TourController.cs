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
            try
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
            }
            catch (Exception)
            {

                ViewBag.ErrorSystem = "Lỗi hệ thống, vui lòng thử lại sau!";
            }

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
        public async Task<IActionResult> AllTour(int id = 1)
        {
            List<Tour> list = new List<Tour>();
            try
            {
                //Get Type of Tour
                ViewBag.typeoftours = await provider.TypeOfTour.GetTypeOfTours();

                //Get type of News Category
                ViewBag.newscategories = await provider.NewsCategory.GetNewsCategories();

                list = (List<Tour>)await provider.Tour.GetTours();
            }
            catch (Exception)
            {

                ViewBag.ErrorSystem = "Lỗi hệ thống, vui lòng thử lại sau!";
            }

            //var t = list.ToPagedList(3, 6);            
            //return View(await provider.Tour.GetTours());
            return View(list.ToPagedList(id, 6));
        }

        [HttpGet]
        public async Task<IActionResult> Search()
        {
            try
            {
                //Get Type of Tour
                ViewBag.typeoftours = await provider.TypeOfTour.GetTypeOfTours();

                //Get type of News Category
                ViewBag.newscategories = await provider.NewsCategory.GetNewsCategories();

            }
            catch (Exception)
            {

                ViewBag.ErrorSystem = "Lỗi hệ thống, vui lòng thử lại sau!";
            }

            //var t = list.ToPagedList(3, 6);            
            //return View(await provider.Tour.GetTours());
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Search(TourModelSearch obj)
        {
            //Get Type of Tour
            ViewBag.typeoftours = await provider.TypeOfTour.GetTypeOfTours();

            //Get type of News Category
            ViewBag.newscategories = await provider.NewsCategory.GetNewsCategories();
            try
            {

                if (obj != null)
                {
                    if (obj.PriceEnd <= 8000000)
                    {
                        obj.PriceStart = obj.PriceEnd - 2000000;

                    }
                    else
                    {
                        obj.PriceStart = 8000001;
                        obj.PriceEnd = 100000000;
                    }
                }

                //Get Tour Search
                ViewBag.tour = await provider.Tour.Search(obj);
            }
            catch (Exception)
            {

                ViewBag.ErrorSystem = "Lỗi hệ thống, vui lòng thử lại sau!";
            }

            return View();
        }
        public async Task<IActionResult> TourModelByTourCategory(string id)
        {
            try
            {
                //Get Type of Tour
                ViewBag.typeoftours = await provider.TypeOfTour.GetTypeOfTours();

                //Get type of News Category
                ViewBag.newscategories = await provider.NewsCategory.GetNewsCategories();

                //Get tour cate
                var listTourCate = await provider.TourCategory.GetTourCategroyChild(id);

                if (listTourCate != null)
                {
                    foreach (var item in listTourCate)
                    {
                        item.Tours = await provider.Tour.GetTourByCategoryId(item.TourCategoriesId);
                    }
                }

                ViewBag.tour = listTourCate;
            }
            catch (Exception)
            {

                ViewBag.ErrorSystem = "Lỗi hệ thống, vui lòng thử lại sau!";
            }

            return View();
        }
    }
}
