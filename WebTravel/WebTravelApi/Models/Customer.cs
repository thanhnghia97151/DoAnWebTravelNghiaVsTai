using System;

namespace WebTravelApi.Models
{
    public class Customer
    {
        public string CustomerID { get; set; }
        public bool ConfirmedPhone { get; set; }

        public DateTime Birthday { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
