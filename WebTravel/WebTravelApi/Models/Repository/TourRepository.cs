using Dapper;
using System;
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
            string sql = "insert into Tours(TourId,Name,MetaTitle,Code,Image,Schedule,Price,PromotionPrice,Quantity,DepartureDat,StartPlace,EndPlace,Transport,Detail,Note,CategoryId,ScheduleId,CreatedDate,CreatedBy,ModifiedDate,ModifiedBy,Status,TopHot,ViewCount,StartDate,EndDate) values(@TourId,@Name,@MetaTitle,@Code,@Image,@Schedule,@Price,@PromotionPrice,@Quantity,@DepartureDat,@StartPlace,@EndPlace,@Transport,@Detail,@Note,@CategoryId,@ScheduleId,@CreatedDate,@CreatedBy,@ModifiedDate,@ModifiedBy,@Status,@TopHot,@ViewCount,@StartDate,@EndDate)";
            return connection.Execute(sql, new
            {
                TourId=Helper.Helper.RandomString(64),
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
                ModifiedBy=obj.ModifiedBy,
                Status = obj.Status,
                TopHot = obj.TopHot,
                ViewCount = obj.ViewCount,
                StartDate = obj.StartDate,
                EndDate = obj.EndDate
                
            });

        }
        public Tour GetTour(string id)
        {
            return connection.QueryFirstOrDefault<Tour>("select * from Tours where TourId =@Id",new {Id = id});
        }
        public IEnumerable<Tour> GetToursPaging(int page, int size, out int total)
        {
            List<Tour> list =(List<Tour>) connection.Query<Tour>("select * from Tour");
            total = list.Count;
            return connection.Query<Tour>("GetToursPaging",new { Page = page, Size = size},commandType: CommandType.StoredProcedure);
        }
        public int Delete(string id)
        {
            return connection.Execute("delete from Tours where TourId = @Id", new { Id = id });
        }
        public List<Tour> GetTourByCategoryId(IEnumerable<TourCategory> tourCategories)
        {
            List<Tour> tours = new List<Tour>();
            if (tourCategories != null)
            {
                foreach (var item in tourCategories)
                {
                     tours.AddRange(connection.Query<Tour>($"select * from Tours where CategoryId = '{item.TourCategoriesId}'"));   
                }
                return tours;
            }
            return null;
        }
        public IEnumerable<Tour> GetNewTourByCategoryId(string id)
        {
            return connection.Query<Tour>("select * from Tours where CategoryId = @Id", new { Id = id });
        } 

    }
}
