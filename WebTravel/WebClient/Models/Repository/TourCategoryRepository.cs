using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebClient.Models.ViewModels;

namespace WebClient.Models.Repository
{
    public class TourCategoryRepository : BaseRepository
    {
        public TourCategoryRepository(IConfiguration configuration) : base(configuration)
        {
        }
        public async Task<IEnumerable<TourCategory>> GetTourCategories()
        {
            return await Get<List<TourCategory>>("/api/tourcategory");
        }
        public async Task<int> Add(TourCategory obj)
        {
            return await Post<TourCategory>("/api/tourcategory", obj);
        }
        public async Task<TourCategory> GetCategory(string id)
        {
            return await Get<TourCategory>($"/api/tourcategory/{id}");
        }
        public async Task<List<TourCategory>> GetCategoriesByTypeOfTourId(string id)
        {
            return await Get<List<TourCategory>>($"/api/tourcategory/typeoftour/{id}");

        }
        public async Task<List<TourCategoryModel>> GetTourCategoryModelByTypeOfTour(string id)
        {
            return await Get<List<TourCategoryModel>>($"/api/tourcategory/categorymodel/{id}");
        }
    }
}
