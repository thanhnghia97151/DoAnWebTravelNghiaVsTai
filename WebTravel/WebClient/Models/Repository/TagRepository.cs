using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebClient.Models.Repository
{
    public class TagRepository : BaseRepository
    {
        public TagRepository(IConfiguration configuration) : base(configuration)
        {
        }
        public async Task<IEnumerable<Tag>> GetTags()
        {
            return await Get<List<Tag>>("/api/tag");
        }
        public async Task<int> Add(Tag obj)
        {
            return await Post<Tag>("/api/tag", obj);
        }
        public async Task<Tag> GetTagById(string id)
        {
            return await Get<Tag>($"/api/tag/{id}");
        }
    }
}
