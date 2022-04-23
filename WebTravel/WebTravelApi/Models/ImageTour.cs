using System;

namespace WebTravelApi.Models
{
    public class ImageTour
    {
        public Guid ImageId { get; set; }
        public string ImageUrl { get; set; }
        public string ImageOriginal { get; set; }
        public string ImageContentType { get; set; }
        public long Size { get; set; }
        public string TourId { get; set; }
        public bool Status { get; set; }
    }
}
