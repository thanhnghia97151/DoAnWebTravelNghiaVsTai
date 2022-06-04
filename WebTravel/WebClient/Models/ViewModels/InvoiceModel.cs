using System;

namespace WebClient.Models.ViewModels
{
    public class InvoiceModel : InvoiceDetail
    {
        public bool Status { get; set; }
        public string MemberId { get; set; }
        public DateTime IncoiceDate { get; set; }
        public Tour Tour { get; set; }
    }
}
