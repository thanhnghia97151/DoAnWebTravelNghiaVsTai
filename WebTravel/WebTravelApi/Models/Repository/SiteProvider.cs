using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WebTravelApi.Models.Repository
{
    public class SiteProvider
    {
        IConfiguration configuration;
        IDbConnection connection;
        public SiteProvider(IConfiguration configuration)
        {
            this.configuration = configuration;
            connection = new SqlConnection(configuration.GetConnectionString("TravelWeb"));
            // Thiếu đóng kết nối
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
                    memberInRole = new MemberInRoleRepository(connection);
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
                    role = new RoleRepository(connection);
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
                    member = new MemberRepository(connection);
                }
                return member;
            }
        }

    }
}
