﻿namespace WebTravelApi.Models.ViewModels
{
    public class InvoiceModel : InvoiceDetail
    {
        public bool Status { get; set; }
        public string MemberId { get; set; }

        public Tour Tour { get; set; }
    }
}
