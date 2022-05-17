using System.Collections.Generic;

namespace WebTravelApi.Models.ViewModels
{
    public class TourCategoryModel : TourCategory
    {
        public ICollection<Tour> Tours { get; set; }
    }
}
