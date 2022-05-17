using Dapper;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace WebTravelApi.Models.Repository
{
    public class TypeOfTourRepository : BaseRepository
    {
        public TypeOfTourRepository(IDbConnection connection) : base(connection)
        {
        }
        public IEnumerable<TypeOfTour> GetTypeOfTours()
        {
            return connection.Query<TypeOfTour>("select * from TypeOfTours");
        }
        public int Add(TypeOfTour obj)
        {
            string sql = "insert into TypeOfTours values(@Id,@Type)";
            return connection.Execute(sql, new
            {
                Id = Helper.Helper.RandomString(64),
                Type = obj.Type
            });
        }
        public TypeOfTour GetTypeOfTour(string id)
        {
            return connection.QuerySingleOrDefault<TypeOfTour>("select * from TypeOfTours where Id=@TypeOfTourId", new { TypeOfTourId = id });
        }
        public int Delete(string id)
        {
            return connection.Execute("delete from TypeOfTours where Id = @Id", new { Id = id });
        }
        
    }
}
