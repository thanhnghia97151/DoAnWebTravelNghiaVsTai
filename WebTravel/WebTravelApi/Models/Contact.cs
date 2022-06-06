using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebTravelApi.Models
{
    public class Contact
    {
        public string ContactId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Company { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Status { get; set; }
        public string CustomerID { get; set; }
    }
}
