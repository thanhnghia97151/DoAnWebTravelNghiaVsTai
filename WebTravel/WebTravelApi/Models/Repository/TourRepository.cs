using Dapper;
using System.Collections.Generic;
using System.Data;

namespace WebTravelApi.Models.Repository
{
    public class TourRepository : BaseRepository
    {
        public TourRepository(IDbConnection connection) : base(connection)
        {
        }
        public IEnumerable<Tour> GetTours()
        {
            return connection.Query<Tour>("select * from Tours");
        }
        public int Add(Tour obj)
        {
            string sql = "insert into Tours(TourId,Name,MetaTitle,Code,Image,Schedule,Price,PromotionPrice,Quantity,DepartureDat,StartPlace,EndPlace,Transport,Detail,Note,CategoryId,ScheduleId,CreatedDate,CreatedBy,ModifiedDate,ModifiedBy) values(@TourId,@Name,@MetaTitle,@Code,@Image,@Schedule,@Price,@PromotionPrice,@Quantity,@DepartureDat,@StartPlace,@EndPlace,@Transport,@Detail,@Note,@CategoryId,@ScheduleId,@CreatedDate,@CreatedBy,@ModifiedDate,@ModifiedBy)";
            return connection.Execute(sql, new
            {
                TourId=obj.TourId,
                Name=obj.Name,
                MetaTitle= obj.MetaTitle,
                Code=obj.Code,
                Image=obj.Image,
                Schedule=obj.Schedule,
                Price=obj.Price,
                PromotionPrice=obj.PromotionPrice,
                Quantity=obj.Quantity,
                DepartureDat=obj.DepartureDat,
                StartPlace=obj.StartPlace,
                EndPlace=obj.EndPlace,
                Transport=obj.Transport,
                Detail=obj.Detail,
                Note=obj.Note,
                CategoryId=obj.CategoryId,
                ScheduleId=obj.ScheduleId,
                CreatedDate=obj.CreatedDate,
                CreatedBy=obj.CreatedBy,
                ModifiedDate=obj.ModifiedDate,
                ModifiedBy=obj.ModifiedBy
            });

        }
        public Tour GetTour(string id)
        {
            return connection.QueryFirstOrDefault<Tour>("select * from Tours where TourId =@Id",new {Id = id});
        }
    }
}
