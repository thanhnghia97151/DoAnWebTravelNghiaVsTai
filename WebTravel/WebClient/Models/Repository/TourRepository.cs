using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebClient.Models.Repository
{
    public class TourRepository:BaseRepository
    {
        public TourRepository(IConfiguration configuration) : base(configuration)
        {
        }
        public async Task<IEnumerable<Tour>> GetTours()
        {
            return await Get<List<Tour>>("/api/tour");
        }
        public async Task<int> Add(Tour obj)
        {
            return await Post<Tour>("/api/tour", obj);
        }
        public async Task<Tour> GetTourById(string id)
        {
            return await Get<Tour>($"/api/tour/{id}");
        }
        public async Task<int> Delete(News obj)
        {
            return await Post<News>($"/api/tour/delete/{obj.NewsId}", obj);
        }
    }
}
