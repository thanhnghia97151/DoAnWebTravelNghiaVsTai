using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebClient.Models.Repository
{
    public class PolicyRepository : BaseRepository
    {
        public PolicyRepository(IConfiguration configuration) : base(configuration)
        {
        }
        public async Task<List<Policy>> GetPolycies()
        {
            return await Get<List<Policy>>("/api/policy");
        }
        public async Task<int> Add(Policy policy)
        {
            return await Post<Policy>("/api/policy",policy);
        }
        public async Task<int> Delete(Policy policy)
        {
            return await Post<Policy>($"/api/policy/{policy.Id}", policy);
        }
        public async Task<Policy> GetPolicy(string id)
        {
            return await Get<Policy>($"/api/policy/{id}");
        }
    }
}
