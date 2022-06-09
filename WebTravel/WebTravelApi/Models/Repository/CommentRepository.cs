using Dapper;
using System.Collections.Generic;
using System.Data;

namespace WebTravelApi.Models.Repository
{
    public class CommentRepository : BaseRepository
    {
        public CommentRepository(IDbConnection connection) : base(connection)
        {
        }
        public int Add(Comment obj)
        {
            return connection.Execute("insert into Comments values (@Id,GETDATE(),GETDATE(),@Content,@TourId,@MemberId,@ParentId,0)", new
            {
                Id = Helper.Helper.RandomString(64),
                Content = obj.Content,
                TourId = obj.TourId,
                MemberId = obj.MemberID,
                ParentId = obj.ParentId
            }) ;
        }
        public int Edit(Comment obj)
        {
            return connection.Execute($"update Comments set Content = '{obj.Content}' where Id = '{obj.Id}'");
        }
        public IEnumerable<Comment> GetCommentsByTourId(string id)
        {
            return connection.Query<Comment>($"select * from Comments where TourId = '{id}' and ParentId <> null");
        }
        public IEnumerable<Comment> GetCommentsByTourIdParent(string id)
        {
            return connection.Query<Comment>($"select * from Comments where TourId = '{id}' and ParentId is null");
        }
        
    }
}
