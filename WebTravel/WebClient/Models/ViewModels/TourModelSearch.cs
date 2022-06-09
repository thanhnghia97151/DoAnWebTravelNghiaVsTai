using System;

namespace WebClient.Models.ViewModels
{
    public class TourModelSearch
    {
        public string Address { get; set; }
        public decimal PriceStart { get; set; }
        public decimal PriceEnd { get; set; }        
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
