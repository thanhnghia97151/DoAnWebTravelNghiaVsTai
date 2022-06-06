using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebClient.Models.ViewModels
{
    public class CustomerInformation
    {
        public int Stt { get; set; }
        public string InvoicedId { get; set; }
        public int Counts { get; set; }
        public DateTime InvoiceDate { get; set; }
        public List<CustomerExport> customerExports { get; set; }
    }
}
