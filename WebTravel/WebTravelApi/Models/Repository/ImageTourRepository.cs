using Dapper;
using System;
using System.Collections.Generic;
using System.Data;

namespace WebTravelApi.Models.Repository
{
    public class ImageTourRepository : BaseRepository
    {
        public ImageTourRepository(IDbConnection connection) : base(connection)
        {
        }
        public IEnumerable<ImageTour> GetImageTours()
        {
            return connection.Query<ImageTour>("select * from ImageTour");
        }
        public int Add(ImageTour image)
        {
            string sql = "insert into ImageTour(ImageUrl,ImageOriginal,ImageContentType,Size,TourId) values(@ImageUrl, @ImageOriginal, @ContentType, @Size, @TourId)";
            return connection.Execute(sql, new
            {
                ImageUrl = image.ImageUrl,
                ImageOriginal = image.ImageOriginal,
                ContentType = image.ImageContentType,
                Size = image.Size,
                TourId = image.TourId

            });
        }
        public int Delete(Guid id)
        {
            string sql = $"update ImageTour set Status = 1 where ImageId = {id}";
            return connection.Execute(sql);
        }
    }
}
