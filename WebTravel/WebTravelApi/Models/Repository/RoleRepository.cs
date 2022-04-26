using Dapper;
using System.Collections.Generic;
using System.Data;
using WebTravelApi.Models.ViewModels;

namespace WebTravelApi.Models.Repository
{
    public class RoleRepository : BaseRepository
    {
        public RoleRepository(IDbConnection connection) : base(connection)
        {
        }
        public IEnumerable<Role> GetRoles()
        {
            return connection.Query<Role>("select * from Roles");
        }
        public IEnumerable<RoleChecked> GetRolesChecked(string id)
        {
            return connection.Query<RoleChecked>("GetRolesChecked",new { Id = id},commandType:CommandType.StoredProcedure);

        }
        public IEnumerable<string> GetRoleNamesByMemberId(string id)
        {
            return connection.Query<string>("GetRoleNamesByMemberId",new {Id = id},commandType:CommandType.StoredProcedure);
        }
        public int Add(Role obj)
        {
            return connection.Execute("insert into Roles(RoleName,RoleDesciption)  values (@Name,@Desciption)", new { Name = obj.RoleName, Desciption = obj.RoleDesciption });
        }
        public IEnumerable<string> GetRoleNamesByMember(string id)
        {
            return connection.Query<string>("GetRoleNamesByMemberId", new { Id = id }, commandType: CommandType.StoredProcedure);
        }
        public int Delete(string id)
        {
            return connection.Execute("delete from Roles where RoleID = @Id", new { Id = id });
        }
    }
}
