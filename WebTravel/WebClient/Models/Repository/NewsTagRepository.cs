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
        public async Task<List<NewsTag>> GetNewsTagByNewsId(string id)
        {
            return await Get<List<NewsTag>>($"/api/newstag/newstag-by-news/{id}");
        }
        public async Task<int> DeleteByNewsId(NewsTag obj)
        {
            return await Post<NewsTag>($"/api/newstag/delete-by-news-id/{obj.NewsId}", obj);
        }
    }
}
