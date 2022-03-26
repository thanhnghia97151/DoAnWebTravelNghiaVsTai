using Microsoft.Extensions.Configuration;

namespace WebClient.Models.Repository
{
    public class SiteProvider
    {
        IConfiguration configuration;
        public SiteProvider(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        MemberRepository member;
        public MemberRepository Member
        {
            get
            {
                if (member is null)
                {
                    member = new MemberRepository(configuration);
                }
                return member;
            }
        }
    }
}
