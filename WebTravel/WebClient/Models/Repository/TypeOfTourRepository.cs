using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebClient.Models.Repository
{
    public class TypeOfTourRepository : BaseRepository
    {
        public TypeOfTourRepository(IConfiguration configuration) : base(configuration)
        {
        }
        public async Task<IEnumerable<TypeOfTour>> GetTypeOfTours()
        {
            return await Get<List<TypeOfTour>>("/api/typeoftour");
        }
        public async Task<int> Add(TypeOfTour obj)
        {
            return await Post<TypeOfTour>("/api/typeoftour", obj);
        }
        public async Task<TypeOfTour> GetTypeOfTour(string id) 
        {
            return await Get<TypeOfTour>($"/api/typeoftour/{id}");
        }
    }
}
