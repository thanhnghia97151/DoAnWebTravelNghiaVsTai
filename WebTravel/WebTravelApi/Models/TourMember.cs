using System;

namespace WebTravelApi.Models
{
    public class TourMember
    {
        public string MemberId { get; set; }
        public string TourId { get; set; }
        public decimal PriceSale { get; set; }
        public int NumberTicket { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
