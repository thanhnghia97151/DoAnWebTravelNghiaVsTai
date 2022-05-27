using System.ComponentModel.DataAnnotations;

namespace WebClient.Models
{
    public class InvoiceDetail
    {
        public string InvoiceId { get; set; }
        public string TourId { get; set; }

        [Required(ErrorMessage = "Giá tiền không được để trống")]        
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Số lượng không được để trống")]
        [RegularExpression("^[0-9]+$", ErrorMessage = "Số lượng phải là những số")]
        public short Quantity { get; set; }
        public Payment Payment { get; set; }

        [Required(ErrorMessage = "Số lượng phòng đơn không được để trống")]
        [RegularExpression("^[0-9]+$", ErrorMessage = "Số lượng phòng đơn phải là những số")]
        public int QuantityDepartment { get; set; }
        public string Description { get; set; }
        public bool PaymentMore { get; set; }

        [Required(ErrorMessage = "Tên không được để trống")]
        [StringLength(36, ErrorMessage = "Tên phải nhỏ hơn hoặc bằng 36 ký tự")]
        [RegularExpression("^(.+)$", ErrorMessage = "Tên không được xuống dòng")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Số điện thoại không được để trống ")]
        [RegularExpression("^([0][0-9]{9})|([0-9]{12})$", ErrorMessage = "Số điện thoại phải là số có 10 hoặc 12 số")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Email không được để trống")]
        [StringLength(30, ErrorMessage = "Email phải nhỏ hơn hoặc bằng 30 ký tự")]
        [RegularExpression("^[a-zA-Z]+[0-9a-zA-Z]+[/@][gG][mM][aA][iY][lL][/.][cC][oO][mM]$", ErrorMessage = "Email không đúng định dạng chuẩn")]
        public string Email { get; set; }
    }
    public enum Payment
    {
        MasterCard = 0,
        Bank = 1,
        EBanking = 2
    }
}
