using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebClient.Models.Repository
{
    public class TourScheduleRepository : BaseRepository
    {
        public TourScheduleRepository(IConfiguration configuration) : base(configuration)
        {
        }
        public async Task<IEnumerable<TourSchedule>> GetTourSchedules()
        {
            return await Get<List<TourSchedule>>("/api/tourschedule");
        }
        public async Task<int> Add(TourSchedule obj)
        {
            return await Post<TourSchedule>("/api/tourschedule", obj);
        }
        public async Task<TourSchedule> GetTourScheduleById(string id)
        {
            return await Get<TourSchedule>($"/api/tourschedule/{id}");
        }
    }
}
