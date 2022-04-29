using System;

namespace WebClient.Models
{
    public class About
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string MetaTitle { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
        public string Detail { get; set; }
        public string Note { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string PolicyId { get; set; }
        public bool Status { get; set; }
    }
}
