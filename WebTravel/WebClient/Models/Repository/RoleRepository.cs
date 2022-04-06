using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebClient.Models.ViewModels;

namespace WebClient.Models.Repository
{
    public class RoleRepository : BaseRepository
    {
        public RoleRepository(IConfiguration configuration) : base(configuration)
        {
        }
        public async Task<List<Role>> GetRoles() 
        {
            return await Get<List<Role>>("/api/role");
        }
        public async Task<List<RoleChecked>> GetRoleCheckeds(string id)
        {
            return await Get<List<RoleChecked>>($"/api/role/role-checked/{id}");
        }

        public async Task<List<string>> GetRoleNamesByMemberId(string id)
        {
            return await Get<List<string>>($"/api/role/role-name/{id}");
        }
        public async Task<int> Add(Role obj)
        {
            return await Post<Role>("/api/role", obj);
        }
    }
}
