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
    }
}
