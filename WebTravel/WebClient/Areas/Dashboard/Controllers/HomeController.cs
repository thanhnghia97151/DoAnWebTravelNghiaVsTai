using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebClient.Models;
using WebClient.Models.Repository;
using WebClient.Models.ViewModels;

namespace WebClient.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class HomeController : Controller
    {
        SiteProvider provider;
        public HomeController(IConfiguration configuration)
        {
            provider = new SiteProvider(configuration);
        }
        public IActionResult Index()
        {
            return View();
        }
        

        public async Task<IActionResult> GetStatsDay([FromQuery]string time)
        {

            List<InvoiceModel> t = await provider.Invoice.GetStatsMonth(time);

            List<TypeOfTourModel> typeOfTourModels = new List<TypeOfTourModel>();
            List<TypeOfTour> listTypOfTour = await provider.TypeOfTour.GetTypeOfTours();
            foreach (var item in listTypOfTour)
            {
                List<TourCategoryModel> cates = await provider.TourCategory.GetTourCategoryModelByTypeOfTour(item.Id);
                foreach (var cate in cates)
                {
                    cate.Tours = await provider.Tour.GetTourByCategoryId(cate.TourCategoriesId);
                }
                typeOfTourModels.Add(new TypeOfTourModel { Name = item.Type, TourCategories = cates });
            }

            List<StatsViewModel> stats = new List<StatsViewModel>();
            foreach (TypeOfTourModel type in typeOfTourModels)
            {
                List<CategoryTotal> categoryTotals = new List<CategoryTotal>();
                string typeName = type.Name;
                foreach (TourCategoryModel cate in type.TourCategories)
                {
                    string cateName = cate.Name;
                    decimal total = 0;
                    foreach (Tour tour in cate.Tours)
                    {
                        foreach (InvoiceModel item in t)
                        {
                            if (item.TourId == tour.TourId)
                            {
                                total += item.Price;
                            }
                        }
                    }
                    categoryTotals.Add(new CategoryTotal() { CateName = cateName, Total = total });
                }
                stats.Add(new StatsViewModel() { TypeOfTour = typeName, Categories = categoryTotals });
            }


            return Json(stats);  
            //return null;
        }
        public async Task<IActionResult> GetStatsMonth([FromQuery] string time)
        {
            List<InvoiceModel> t = await provider.Invoice.GetStatsMonth(time);

            List<TypeOfTourModel> typeOfTourModels = new List<TypeOfTourModel>();
            List<TypeOfTour> listTypOfTour = await provider.TypeOfTour.GetTypeOfTours();
            foreach (var item in listTypOfTour)
            {
                List<TourCategoryModel> cates = await provider.TourCategory.GetTourCategoryModelByTypeOfTour(item.Id);
                foreach (var cate in cates)
                {
                    cate.Tours = await provider.Tour.GetTourByCategoryId(cate.TourCategoriesId);
                }
                typeOfTourModels.Add(new TypeOfTourModel { Name = item.Type, TourCategories = cates });
            }

            List<StatsViewModel> stats = new List<StatsViewModel>();
            foreach (TypeOfTourModel type in typeOfTourModels)
            {
                List<CategoryTotal> categoryTotals = new List<CategoryTotal>();
                string typeName = type.Name;
                foreach (TourCategoryModel cate in type.TourCategories)
                {
                    string cateName = cate.Name;
                    decimal total = 0;
                    foreach (Tour tour in cate.Tours)
                    {
                        foreach (InvoiceModel item in t)
                        {
                            if (item.TourId == tour.TourId)
                            {
                                total += item.Price;
                            }
                        }
                    }
                    categoryTotals.Add(new CategoryTotal() { CateName = cateName, Total = total });
                }
                stats.Add(new StatsViewModel() {TypeOfTour = typeName, Categories = categoryTotals });
            }

            return Json(stats);
        }
        public async Task<IActionResult> GetStatsYear([FromQuery] string time)
        {
            List<InvoiceModel> t = await provider.Invoice.GetStatsMonth(time);

            List<TypeOfTourModel> typeOfTourModels = new List<TypeOfTourModel>();
            List<TypeOfTour> listTypOfTour = await provider.TypeOfTour.GetTypeOfTours();
            foreach (var item in listTypOfTour)
            {
                List<TourCategoryModel> cates = await provider.TourCategory.GetTourCategoryModelByTypeOfTour(item.Id);
                foreach (var cate in cates)
                {
                    cate.Tours = await provider.Tour.GetTourByCategoryId(cate.TourCategoriesId);
                }
                typeOfTourModels.Add(new TypeOfTourModel { Name = item.Type, TourCategories = cates });
            }

            List<StatsViewModel> stats = new List<StatsViewModel>();
            foreach (TypeOfTourModel type in typeOfTourModels)
            {
                List<CategoryTotal> categoryTotals = new List<CategoryTotal>();
                string typeName = type.Name;
                foreach (TourCategoryModel cate in type.TourCategories)
                {
                    string cateName = cate.Name;
                    decimal total = 0;
                    foreach (Tour tour in cate.Tours)
                    {
                        foreach (InvoiceModel item in t)
                        {
                            if (item.TourId == tour.TourId)
                            {
                                total += item.Price;
                            }
                        }
                    }
                    categoryTotals.Add(new CategoryTotal() { CateName = cateName, Total = total });
                }
                stats.Add(new StatsViewModel() { TypeOfTour = typeName, Categories = categoryTotals });
            }



            return Json(stats);
        }
    }
}
