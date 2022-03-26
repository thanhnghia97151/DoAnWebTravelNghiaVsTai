using System.Data;

namespace WebTravelApi.Models.Repository
{
    public abstract class BaseRepository
    {
        protected IDbConnection connection;
        public BaseRepository(IDbConnection connection)
        {
            this.connection = connection;
        }
    }
}
