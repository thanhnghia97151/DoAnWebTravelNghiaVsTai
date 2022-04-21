using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebClient.Models.Repository
{
    public class NewsRepository : BaseRepository
    {
        public NewsRepository(IConfiguration configuration) : base(configuration)
        {
        }
        public async Task<List<News>> GetNews()
        {
            return await Get<List<News>>("/api/news");
        }
        public async Task<int> Add(News news)
        {
            return await Post<News>("/api/news", news);
        }
        public async Task<News> GetNewById(string id)
        {
            return await Get<News>($"/api/news/{id}");
        }
    }
}
