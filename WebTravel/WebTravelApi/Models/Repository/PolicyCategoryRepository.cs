using Dapper;
using System.Collections.Generic;
using System.Data;

namespace WebTravelApi.Models.Repository
{
    public class PolicyCategoryRepository : BaseRepository
    {
        public PolicyCategoryRepository(IDbConnection connection) : base(connection)
        {
        }
        public IEnumerable<PolicyCategory> GetEnumberables()
        {
            return connection.Query<PolicyCategory>("select * from PolicyCategories");
        }
        public int Add(PolicyCategory obj)
        {
            string sql = "insert into PolicyCategories values(@Id,@Name)";
            return connection.Execute(sql, new
            {
                Id = Helper.Helper.RandomString(64),
                Name= obj.Name
            });
        }
        public PolicyCategory GetPolicyCategory(string id)
        {
            return connection.QueryFirstOrDefault<PolicyCategory>("select * from PolicyCategories where Id=@Id",new {Id =id});
        }
    }
}
