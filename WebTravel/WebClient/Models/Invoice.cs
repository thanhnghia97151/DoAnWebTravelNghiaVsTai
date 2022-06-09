using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebClient.Models
{
    public class Invoice
    {
        public string InvoiceId { get; set; }

        [Required(ErrorMessage = "Địa chỉ không được để trống")]
        [StringLength(60, ErrorMessage = "Địa chỉ phải nhỏ hơn hoặc bằng 60 ký tự")]
        [RegularExpression("^.+$", ErrorMessage = "Địa chỉ không có ký tự đặc biệt")]
        public string Address { get; set; }
        public DateTime InvoiceDate { get; set; }
        public bool Status { get; set; }
        public string MemberId { get; set; }
   
    }
}
