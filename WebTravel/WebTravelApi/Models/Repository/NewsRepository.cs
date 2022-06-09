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
        public IEnumerable<News> GetFourNewses()
        {
            return connection.
                Query<News>("select TOP 4 n.NewsId, n.Name, n.Description, n.Image from [dbo].[News] as n  order by n.CreatedDate DESC");
        }
        public int Edit(News obj)
        {
            string sql = "update News set Name = @Name,MetaTitle = @MetaTitle,Description = @Description,Code = @Code,Image = @Image,Detail = @Detail,Note = @Note, NewCategoryId = @NewCategoryId,Status = @Status, ViewCount = @ViewCount where NewsId = @Id";
                
            return connection.Execute(sql, new
            {
                
                Name = obj.Name,
                MetaTitle = obj.MetaTitle,
                Description = obj.Description,
                Code = obj.Code,
                Image = obj.Image,
                Detail = obj.Detail,
                Note = obj.Note,
                NewCategoryId = obj.NewCategoryId,
                //CreatedDate = obj.CreatedDate,
                //CreatedBy = obj.CreatedBy,
                //ModifiedDate = obj.ModifiedDate,
                //ModifiedBy = obj.ModifiedBy,
                Status = obj.Status,
                //TopHot = obj.TopHot,
                ViewCount = obj.ViewCount,
                Id = obj.NewsId
            });
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

        public bool UpdateCountViewer(int count, string id)
        {
            string sql = "UPDATE [dbo].[News] SET ViewCount = @Count Where NewsId = @Id";
            if (connection.Execute(sql, new { Id = id, Count = count }) > 0) 
            {
                return true;
            }
            return false;
        }

        public News GetNewsHot() 
        {
            string sql = "select TOP 1 n.NewsId, n.Name, n.Description, n.CreatedDate, n.ViewCount, n.Image from [dbo].[News] as n order by n.ViewCount DESC";
            return connection.QueryFirst<News>(sql);
        }

        public IEnumerable<News> GetNews10Host() 
        {
            string sql = "select TOP 12 n.NewsId, n.Name, n.Description, n.CreatedDate, n.ViewCount, n.Image from [dbo].[News] as n order by n.ViewCount DESC";
            return connection.Query<News>(sql);
        }

        public IEnumerable<News> GetNewsOutstanding()
        {
            string sql = "select TOP 3 n.NewsId, n.Name, n.Description, n.CreatedDate, n.ViewCount, n.Image from [dbo].[News] as n order by n.ViewCount DESC";
            return connection.Query<News>(sql);
        }

        public IEnumerable<News> GetNewsPaging(int page, int size)
        {
            return connection.Query<News>("GetNewsPaging", new
            {
                Page = page,
                Size = size
            }, commandType: CommandType.StoredProcedure);
        }

        public IEnumerable<News> GetNewsByCategoryId(string id)
        {
            return connection.Query<News>($"select * from News where NewCategoryId = '{id}'");
        }
    }
}
