using Dapper;
using System.Collections.Generic;
using System.Data;

namespace WebTravelApi.Models.Repository
{
    public class TourScheduleRepository : BaseRepository
    {
        public TourScheduleRepository(IDbConnection connection) : base(connection)
        {
        }
        public IEnumerable<TourSchedule> GetTourSchedule()
        {
            return connection.Query<TourSchedule>("select * from TourSchedules");
        }
        public int Add(TourSchedule obj)
        {
            string sql = "insert into TourSchedules values(@TourScheduleId,@Content)";
            return connection.Execute(sql, new
            {
                TourScheduleId = Helper.Helper.RandomString(64),
                Content = obj.Content

            });
        }
        public TourSchedule GetTourSchedule(string id)
        {
            return connection.QuerySingleOrDefault<TourSchedule>("select * from TourSchedules where TourScheduleId = @Id", new { Id = id });
        }
        public int Delete(string id)
        {
            return connection.Execute("delete from TourSchedules where TourScheduleId = @Id", new { Id = id });
        }
    }
}
