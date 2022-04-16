using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

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
    }
}
