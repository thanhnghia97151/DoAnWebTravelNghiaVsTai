using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebClient.Models.Repository
{
    public class AboutRepository : BaseRepository
    {
        public AboutRepository(IConfiguration configuration) : base(configuration)
        {
        }
        public async Task<List<About>> GetAbouts()
        {
            return await Get<List<About>>("/api/about");
        }
        public async Task<int> Add(About obj)
        {
            return await Post<About>("/api/about", obj);
        }
        public async Task<About> GetAbout(string id)
        {
            return await Get<About>($"/api/about/{id}");
        }
        public async Task<int> Delete(About obj)
        {
            return await Post<About>($"/api/about/{obj.Id}", obj);
        }
    }
}
