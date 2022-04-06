using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebClient.Models.Repository
{
    public class MemberRepository : BaseRepository
    {
        public MemberRepository(IConfiguration configuration) : base(configuration)
        {
        }
        public async Task<List<Member>> GetMembersAsyn()
        {
            return await Get<List<Member>>("/api/member");
        }
        public async Task<Member> GetMemberById(string id)
        {
            return await Get<Member>($"/api/member/{id}");
        }
    }
}
