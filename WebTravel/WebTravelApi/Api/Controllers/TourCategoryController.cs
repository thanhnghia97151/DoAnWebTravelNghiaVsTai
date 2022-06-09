using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using WebTravelApi.Models;
using WebTravelApi.Models.ViewModels;

namespace WebTravelApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TourCategoryController : BaseController
    {
        public TourCategoryController(IConfiguration configuration) : base(configuration)
        {
        }
        [HttpGet]
        public IEnumerable<TourCategory> GetTourCategories()
        {
            return provider.TourCategory.GetTourCategories();
        }
        [HttpPost]
        public int Add(TourCategory obj)
        {
            return provider.TourCategory.Add(obj);
        }
        [HttpGet("{id}")]
        public TourCategory GetTourCategory(string id)
        {
            return provider.TourCategory.GetTourCategory(id);
        }
        [HttpPost("delete/{id}")]
        public int Delete(string id)
        {
            return provider.TourCategory.Delete(id);
        }
        [HttpGet("childrent/{id}")]
        public IEnumerable<TourCategory> GetListCategoriesChildrent(string id)
        {
            return provider.TourCategory.GetListCategoriesChildrent(id);
        }
        [HttpGet("typeoftour/{id}")]
        public IEnumerable<TourCategory> GetTourCategoriesByTypeOfTourId(string id)
        {
            return provider.TourCategory.GetCategoriesByTypeOfTour(id);
        }
        [HttpGet("categorymodel/{id}")]
        public IEnumerable<TourCategoryModel> GetTourCategoryModelssByTypeOfTourId(string id)
        {
            return provider.TourCategory.GetCategoryModelsByTypeOfTour(id);
        }
        [HttpGet("categoryparent/{id}")]
        public IEnumerable<TourCategoryModel> GetCategoryParent(string id)
        {
            return provider.TourCategory.GetTourCategoriesParent(id);
        }
        [HttpGet("categorychild/{id}")]
        public IEnumerable<TourCategoryModel> GetCategoryChildrent(string id)
        {
            return provider.TourCategory.GetTourCategoryChildrent(id);
        }
        [HttpGet("categorymodelbyid/{id}")]
        public TourCategoryModel GetTourCategoryModelById(string id)
        {
            return provider.TourCategory.GetTourCategoryModel(id);
        }
    }
}
