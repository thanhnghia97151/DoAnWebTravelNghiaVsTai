
using Dapper;
using System.Collections.Generic;
using System.Data;

namespace WebTravelApi.Models.Repository
{
    public class AboutRepository : BaseRepository
    {
        public AboutRepository(IDbConnection connection) : base(connection)
        {
        }
        public IEnumerable<About> GetAbouts()
        {
            return connection.Query<About>("select * from Abouts");
        }

        public About GetAbout()
        {
            return connection.QuerySingleOrDefault<About>("select * from Abouts");
        }

        public int Add(About obj)
        {
            string sql = "insert into Abouts values (@Id,@Name,@MetaTitle,@Content,@Image,@Detail,@Note,@CreatedDate,@CreatedBy,@ModifiedDate,@ModifiedBy,@PolicyId,@Status)";
            return connection.Execute(sql, new
            {
                Id = Helper.Helper.RandomString(64),
                Name= obj.Name,
                MetaTitle = obj.MetaTitle,
                Content= obj.Content,
                Image= obj.Image,
                Detail= obj.Detail,
                Note= obj.Note,
                CreatedDate= obj.CreatedDate,
                CreatedBy = obj.CreatedBy,
                ModifiedDate = obj.ModifiedDate,
                ModifiedBy = obj.ModifiedBy,
                PolicyId = obj.PolicyId,
                Status = obj.Status
            }) ;
        }
       /* public About GetAbout(string id)
        {
            return connection.QueryFirstOrDefault<About>("select * from Abouts where Id =@Id", new { Id = id });
        }*/
        public int Delete(string id)
        {
            return connection.Execute("delete from Abouts where Id = @Id", new { Id = id });
        }
    }
}
