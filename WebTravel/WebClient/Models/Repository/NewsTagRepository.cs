using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebClient.Models.Repository
{
    public class NewsTagRepository : BaseRepository
    {
        public NewsTagRepository(IConfiguration configuration) : base(configuration)
        {
        }
        public async Task<List<NewsTag>> GetNewsTags()
        {
            return await Get<List<NewsTag>>("/api/newstag");
        }
        public async Task<int> Add(NewsTag news)
        {
            return await Post<NewsTag>("/api/newstag", news);
        }
        public async Task<NewsTag> GetNewsTagById(string id)
        {
            return await Get<NewsTag>($"/api/newstag/{id}");
        }
    }
}
