using System;

namespace WebClient.Models
{
    public class Tour
    {
        public string TourId { get; set; }
        public string Name { get; set; }
        public string MetaTitle { get; set; }
        public string Code { get; set; }
        public string Image { get; set; }
        public string Schedule { get; set; }
        public decimal Price { get; set; }
        public decimal PromotionPrice { get; set; }
        public int Quantity { get; set; }
        public DateTime DepartureDat { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public string StartPlace { get; set; }
        public string EndPlace { get; set; }
        public string Transport { get; set; }
        public string Detail { get; set; }
        public string Note { get; set; }
        public string CategoryId { get; set; }
        public string ScheduleId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public bool Status { get; set; }
        public DateTime TopHot { get; set; }
        public int ViewCount { get; set; }
    }
}
