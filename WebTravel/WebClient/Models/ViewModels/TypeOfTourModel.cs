using System.Collections.Generic;

namespace WebClient.Models.ViewModels
{
    public class TypeOfTourModel 
    {
        public string Name { get; set; }
        public List<TourCategoryModel> TourCategories { get; set; }
    }
}
