using Dapper;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace WebTravelApi.Models.Repository
{
    public class MemberRepository : BaseRepository
    {
        public MemberRepository(IDbConnection connection) : base(connection)
        {
            
        }
        public IEnumerable<Member> GetMembers()
        {
            return connection.Query<Member>("select * from Members");
        }
    }
}
