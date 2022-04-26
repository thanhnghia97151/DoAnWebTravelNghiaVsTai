using Dapper;
using System.Collections.Generic;
using System.Data;

namespace WebTravelApi.Models.Repository
{
    public class NewsRepository : BaseRepository
    {
        public NewsRepository(IDbConnection connection) : base(connection)
        {
        }
        public int Delete(string id)
        {
            return connection.Execute("delete from News where NewsId = @Id", new { Id = id });
        }
        public IEnumerable<News> GetNewses()
        {
            return connection.Query<News>("select * from News");
        }
        public int Add(News obj)
        {
            string sql = "insert into News values(@Id,@Name,@MetaTitle,@Description,@Code,@Image,@Detail,@Note,@NewCategoryId,@CreatedDate,@CreatedBy,@ModifiedDate,@ModifiedBy,@Status,@TopHot,@ViewCount)";
            return connection.Execute(sql, new
            {
                Id = Helper.Helper.RandomString(64),
                Name = obj.Name,
                MetaTitle = obj.MetaTitle,
                Description = obj.Description,
                Code = obj.Code,
                Image = obj.Image,
                Detail = obj.Detail,
                Note = obj.Note,
                NewCategoryId = obj.NewCategoryId,
                CreatedDate = obj.CreatedDate,
                CreatedBy = obj.CreatedBy,
                ModifiedDate = obj.ModifiedDate,
                ModifiedBy = obj.ModifiedBy,
                Status = obj.Status,
                TopHot = obj.TopHot,
                ViewCount = obj.ViewCount
            });
        }
        public News GetNews(string id)
        {
            return connection.QueryFirstOrDefault<News>("select * from News where NewsId = @Id", new {Id = id});
        }

    }
}
