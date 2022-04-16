using Dapper;
using System.Collections.Generic;
using System.Data;

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
       
    }
}
