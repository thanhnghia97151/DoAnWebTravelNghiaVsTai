using System;
using System.Collections.Generic;
using WebTravelApi.Models.ViewModels;

namespace WebTravelApi.Models
{
    public class TourCategory
    {
        public string TourCategoriesId { get; set; }
        public string Name { get; set; }
        public string SeoTitle { get; set; }
        public string MetaTitle { get; set; }
        public string ParentId { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string TypeOfTourId { get; set; }
        public bool Status { get; set; }
        public bool ShowOnHome { get; set; }

        public ICollection<TourCategoryModel> Childrens { get; set; }
    }
}
