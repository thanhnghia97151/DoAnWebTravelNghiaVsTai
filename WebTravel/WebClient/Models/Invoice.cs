using System;
using System.Collections.Generic;

namespace WebClient.Models
{
    public class Invoice
    {
        public string InvoiceId { get; set; }
        public string Address { get; set; }
        public DateTime InvoiceDate { get; set; }
        public bool Status { get; set; }
        public string MemberId { get; set; }
   
    }
}
