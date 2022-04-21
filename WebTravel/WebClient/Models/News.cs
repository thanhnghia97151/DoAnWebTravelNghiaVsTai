using System;

namespace WebClient.Models
{
    public class News
    {
        public string NewsId { get; set; }
        public string Name { get; set; }
        public string MetaTitle { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public string Image { get; set; }

        public string Detail { get; set; }
        public string Note { get; set; }
        public string NewCategoryId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public bool Status { get; set; }
        public DateTime TopHot { get; set; }
        public int ViewCount { get; set; }
    }
}
