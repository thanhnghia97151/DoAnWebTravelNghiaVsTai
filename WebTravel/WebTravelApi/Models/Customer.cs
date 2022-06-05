using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebTravelApi.Models
{
    public class Customer
    {
        public string? CustomerID { get; set; }
        public string UserName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime BrithDay { get; set; }
        public string InvoiceId { get; set; }
    }
}
