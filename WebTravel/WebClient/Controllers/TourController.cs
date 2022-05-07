﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using WebClient.Models.Repository;

namespace WebClient.Controllers
{
    public class TourController : Controller
    {
        SiteProvider provider;

        public TourController(IConfiguration configuration)
        {
            this.provider = new SiteProvider(configuration);
        }

        public async Task<IActionResult> BookTour(string id)
        {
            //Get Type of Tour
            ViewBag.typeoftours = await provider.TypeOfTour.GetTypeOfTours();

            //Get type of News Category
            ViewBag.newscategories = await provider.NewsCategory.GetNewsCategories();

            //Get Tour
            ViewBag.tour = await provider.Tour.GetTourById(id);

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> BookTour()
        {
            return View();
        }
    }
}
