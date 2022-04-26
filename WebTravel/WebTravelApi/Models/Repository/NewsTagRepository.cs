using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace WebTravelApi.Models.Repository
{
    public class NewsTagRepository : BaseRepository
    {
        public NewsTagRepository(IDbConnection connection) : base(connection)
        {
        }
        public IEnumerable<NewsTag> GetNewsTags()
        {
            return connection.Query<NewsTag>("select * from NewTags");

        }
        public int Add(NewsTag obj )
        {
            string sql = "insert into NewTags values(@Nid,@Tid)";
            return connection.Execute(sql, new
            {
                Nid = obj.NewsId,
                Tid = obj.TagId
            });
        }
        public IEnumerable<NewsTag> GetNewsTagByNewsId(string id)
        {
            string sql = $"select * from NewTags where NewsId = '{id}'";
            return connection.Query<NewsTag>(sql);
        }
        public int DeleteByNewsId(string id)
        {
            return connection.Execute("delete from NewTags where NewsId = @Id", new { Id = id });
        }
        public int DeleteByTagId(string id)
        {
            return connection.Execute("delete from NewTags where TagId = @Id", new { Id = id });
        }

    }
}
