﻿using Dapper;
using System.Collections.Generic;
using System.Data;

namespace WebTravelApi.Models.Repository
{
    public class TourCategoryRepository : BaseRepository
    {
        public TourCategoryRepository(IDbConnection connection) : base(connection)
        {
        }
        public IEnumerable<TourCategory> GetTourCategories()
        {
            return connection.Query<TourCategory>("select * from TourCategories");
        }
        public int Add(TourCategory obj)
        {
            string sql = "insert into TourCategories(TourCategoriesId,Name,SeoTitle,MetaTitle,ParentId,CreateDate,CreatedBy,ModifiedDate,ModifiedBy,TypeOfTourId) values(@TourCategoriesId,@Name,@SeoTitle,@MetaTitle,@ParentId,@CreateDate,@CreatedBy,@ModifiedDate,@ModifiedBy,@TypeOfTourId)";
            return connection.Execute(sql, new {
                TourCategoriesId = Helper.Helper.RandomString(64),
                Name = obj.Name,
                SeoTitle=obj.SeoTitle,
                MetaTitle=obj.MetaTitle,
                ParentId=obj.ParentId,
                CreateDate=obj.CreateDate,
                CreatedBy=obj.CreatedBy,
                ModifiedDate=obj.ModifiedDate,
                ModifiedBy=obj.ModifiedBy,
                TypeOfTourId=obj.TypeOfTourId
            });
        }
        public TourCategory GetTourCategory(string id)
        {
            return connection.QuerySingleOrDefault<TourCategory>("select * from TourCategories where TourCategoriesId=@Id", new { Id = id});
        }
        public int Delete(string id)
        {
            return connection.Execute("delete from TourCategories where TourCategoriesId = @Id", new { Id = id });
        }
    }
}
