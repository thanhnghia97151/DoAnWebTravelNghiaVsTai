using System.Collections.Generic;

namespace WebClient.Models.ViewModels
{
    public class StatsViewModel
    {
        public string TypeOfTour { get; set; }
        public List<CategoryTotal> Categories { get; set; }

    }
}
