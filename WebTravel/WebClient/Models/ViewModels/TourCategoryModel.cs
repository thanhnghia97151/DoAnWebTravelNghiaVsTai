using System.Collections.Generic;

namespace WebClient.Models.ViewModels
{
    public class TourCategoryModel : TourCategory
    {
        public ICollection<Tour> Tours { get; set; }
    }
}
