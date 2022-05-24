using System;

namespace WebTravelApi.Models
{
    public class Comment
    {
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime PublishedAt { get; set; }
        public string Content { get; set; }
        public string TourId { get; set; }
        public string MemberId { get; set; }
        public string ParentId { get; set; }
        public bool Status { get; set; }
    }
}
