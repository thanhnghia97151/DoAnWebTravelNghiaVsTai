using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebClient.Models.ViewModels;

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
        public async Task<int> Add(Member obj)
        {
            return await Post<Member>("/api/member", obj);
        }
        public async Task<ReponseLogin> Login(LoginModel obj)
        {
            return await PostGetData<LoginModel, ReponseLogin>("/api/auth", obj);
        }
        public async Task<ReponseLogin> LoginOAuth(Member obj)
        {
            return await PostGetData<Member, ReponseLogin>("/api/auth/loginoauth", obj);
        }

    }
}
