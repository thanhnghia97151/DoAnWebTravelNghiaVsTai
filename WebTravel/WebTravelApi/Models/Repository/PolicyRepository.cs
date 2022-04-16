using Dapper;
using System.Collections.Generic;
using System.Data;

namespace WebTravelApi.Models.Repository
{
    public class PolicyRepository : BaseRepository
    {
        public PolicyRepository(IDbConnection connection) : base(connection)
        {
        }
        public IEnumerable<Policy> GetPolicies()
        {
            return connection.Query<Policy>("select * from Policies");
        }
        public int Add(Policy obj)
        {
            string sql = "insert into Policies values(@Id,@Content,@PolicyCategoryId)";
            return connection.Execute(sql, new
            {
                Id = Helper.Helper.RandomString(64),
                Content = obj.Content,
                PolicyCategoryId = obj.PolicyCategoryId
            });
        }
        public Policy GetPolicy(string id)
        {
            return connection.QueryFirstOrDefault<Policy>("select * from Policies where Id = @Id", new {Id = id});
        }
    }
}
