using System.ComponentModel.DataAnnotations;

namespace WebClient.Models
{
    public class InvoiceDetail
    {
        public string InvoiceId { get; set; }
        public string TourId { get; set; }               
        public decimal Price { get; set; }
        public short Quantity { get; set; }
        public Payment Payment { get; set; }       
        public int QuantityDepartment { get; set; }
        public string Description { get; set; }
        public bool PaymentMore { get; set; }
        public string FullName { get; set; }      
        public string Phone { get; set; }        
        public string Email { get; set; }
    }
    public enum Payment
    {
        MasterCard = 0,
        Bank = 1,
        EBanking = 2
    }
}
