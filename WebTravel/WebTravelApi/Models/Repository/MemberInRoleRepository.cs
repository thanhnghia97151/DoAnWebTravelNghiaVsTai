using Dapper;
using System.Data;

namespace WebTravelApi.Models.Repository
{
    public class MemberInRoleRepository : BaseRepository
    {
        public MemberInRoleRepository(IDbConnection connection) : base(connection)
        {
        }
        public int Add(MemberInRole obj)
        {
            return connection.Execute("AddMemberInRole", obj, commandType: CommandType.StoredProcedure);
        }
    }
}
