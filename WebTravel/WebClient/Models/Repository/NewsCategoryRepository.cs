using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebClient.Models.Repository
{
    public class NewsCategoryRepository : BaseRepository
    {
        public NewsCategoryRepository(IConfiguration configuration) : base(configuration)
        {
            
        }
        public async Task<List<NewsCategory>> GetNewsCategories()
        {
            return await Get<List<NewsCategory>>("/api/newscategory");
        }
        public async Task<int> Add(NewsCategory obj)
        {
            return await Post<NewsCategory>("/api/newscategory", obj);
        }
        public async Task<NewsCategory> GetNewsCategoryById(string id)
        {
            return await Get<NewsCategory>($"/api/newscategory/{id}");
        }


    }
}
