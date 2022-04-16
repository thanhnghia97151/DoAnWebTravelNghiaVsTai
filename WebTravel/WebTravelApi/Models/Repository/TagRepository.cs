using Dapper;
using System.Collections.Generic;
using System.Data;

namespace WebTravelApi.Models.Repository
{
    public class TagRepository : BaseRepository
    {
        public TagRepository(IDbConnection connection) : base(connection)
        {
        }
        public IEnumerable<Tag> GetTags()
        {
            return connection.Query<Tag>("select * from Tags");
        }
        public int Add(Tag obj)
        {
            string sql = "insert into Tags values(@TagId,@Name)";
            return connection.Execute(sql, new
            {
                TagId = Helper.Helper.RandomString(64),
                Name = obj.Name
            });
        }
        public Tag GetTag(string id)
        {
            return connection.QuerySingleOrDefault<Tag>("select * from Tags where TagId =@Id", new { Id = id });
        }
    }
}
