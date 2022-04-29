using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebClient.Models.Repository
{
    public class PolicyCategoryRepository : BaseRepository
    {
        public PolicyCategoryRepository(IConfiguration configuration) : base(configuration)
        {
        }
        public async Task<List<PolicyCategory>> GetPolicyCategories()
        {
            return await Get<List<PolicyCategory>>("/api/policycategory");
        }
        public async Task<int> Add(PolicyCategory obj)
        {
            return await Post<PolicyCategory>("/api/policycategory", obj);
        }
        public async Task<PolicyCategory> GetPolicyCategory(string id)
        {
            return await Get<PolicyCategory>($"/api/policycategory/{id}");
        }
        public async Task<int> Delete(PolicyCategory obj)
        {
            return await Post<PolicyCategory>($"/api/policycategory/{obj.Id}", obj);
        }
    }
}
