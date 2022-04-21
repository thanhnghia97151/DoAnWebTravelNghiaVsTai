using System;
using System.Collections.Generic;

namespace WebClient.Models
{
    public class NewsCategory
    {
        public string NewsCategoryId { get; set; }
        public string Name { get; set; }
        public string SeoTitle { get; set; }
        public string MetaTitle { get; set; }
        public string ParentId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public bool Status { get; set; }
        public bool ShowOnHome { get; set; }

        public ICollection<NewsCategory> Childrens { get; set; }
    }
}
