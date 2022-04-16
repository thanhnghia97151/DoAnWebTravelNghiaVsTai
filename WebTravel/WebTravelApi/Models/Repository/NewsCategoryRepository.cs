using Dapper;
using System.Collections.Generic;
using System.Data;
using WebTravelApi.Models.ViewModels;

namespace WebTravelApi.Models.Repository
{
    public class NewsCategoryRepository : BaseRepository
    {
        public NewsCategoryRepository(IDbConnection connection) : base(connection)
        {
        }
        public IEnumerable<NewsCategory> GetNewsCategories()
        {
            return connection.Query<NewsCategory>("select * from NewsCategories");
        }
        public int Add(NewsCategory obj)
        {
            string sql = "insert into NewsCategories values (@Id,@Name,@SeoTitle,@MetaTitle,@ParentId,@CreatedDate,@CreatedBy,@ModifiedDate,@ModifiedBy,@Status,@ShowOnHome)";
            return connection.Execute(sql, new
            {
                Id = Helper.Helper.RandomString(64),
                Name = obj.Name,
                SeoTitle = obj.SeoTitle,
                MetaTitle= obj.MetaTitle,
                ParentId = obj.ParentId,
                CreatedDate = obj.CreatedDate,
                CreatedBy = obj.CreatedBy,
                ModifiedDate = obj.ModifiedDate,
                ModifiedBy = obj.ModifiedBy,
                Status = obj.Status,
                ShowOnHome = obj.ShowOnHome
            });

        }
        public NewsCategory GetNewsCategory(string id)
        {
            return connection.QueryFirstOrDefault<NewsCategory>("select * from NewsCategories where NewsCategoryId = @Id", new { Id = id });
        }
    }
}
