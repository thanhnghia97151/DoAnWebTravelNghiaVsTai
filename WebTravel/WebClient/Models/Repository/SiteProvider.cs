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
        RoleRepository role;
        MemberInRoleRepository memberInRole;
        public MemberInRoleRepository MemberInRole
        {
            get
            {
                if (memberInRole is null)
                {
                    memberInRole = new MemberInRoleRepository(configuration);
                }
                return memberInRole;
            }
            
        }
        public RoleRepository Role
        {
            get
            {
                if (role is null)
                {
                    role = new RoleRepository(configuration);
                }
                return role;
            }
        }
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
