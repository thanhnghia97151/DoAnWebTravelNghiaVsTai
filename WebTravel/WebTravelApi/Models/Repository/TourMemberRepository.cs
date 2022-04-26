using Dapper;
using System.Collections.Generic;
using System.Data;

namespace WebTravelApi.Models.Repository
{
    public class TourMemberRepository : BaseRepository
    {
        public TourMemberRepository(IDbConnection connection) : base(connection)
        {
        }
        public IEnumerable<TourMember> GetTourMembers()
        {
            return connection.Query<TourMember>("select * from TourMembers");
        }
        public int Add(TourMember obj)
        {
            string sql = "insert into TourMembers values (@MemberId,@TourId,@PriceSale,@NumberTicket,@CreatedDate)";
            return connection.Execute(sql, new
            {
                MemberId = obj.MemberId,
                TourId = obj.TourId,
                PriceSale = obj.PriceSale,
                NumberTicket = obj.NumberTicket,
                CreatedDate = obj.CreatedDate,
            });
        }
        public int DeleteByMemberId(string id)
        {
            return connection.Execute("delete from TourMembers where MemberId = @Id", new { Id = id });
        }
        public int DeleteByTourId(string id)
        {
            return connection.Execute("delete from TourMembers where TourId = @Id", new { Id = id });
        }

    }
}
