using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebClient.Models
{
    public class Contact
    {
        public string Id { get; set; }

        [Required(ErrorMessage = "Tên không được để trống")]
        [StringLength(36, ErrorMessage = "Tên phải nhỏ hơn hoặc bằng 36 ký tự")]
        [RegularExpression("^(.+)$", ErrorMessage = "Tên không được xuống dòng")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Tiêu đề không được để trống")]
        [StringLength(50, ErrorMessage = "Tiêu đề phải nhỏ hơn hoặc bằng 50 ký tự")]
        [RegularExpression("^(.+)$", ErrorMessage = "Tiêu đề không được xuống dòng")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Nội dung không được trống ")]
        [StringLength(500, ErrorMessage = "Nội dung phải nhỏ hơn hoặc bằng 500 ký tự")]    
        public string Content { get; set; }

        [StringLength(30, ErrorMessage = "Công ty phải nhỏ hơn hoặc bằng 30 ký tự")]
        [RegularExpression("^(.+)$", ErrorMessage = "Công ty không được xuống dòng")]
        public string Company { get; set; }

        [Required (ErrorMessage = "Số điện thoại không được để trống ")]
        [RegularExpression("^([0][0-9]{9})|([0-9]{12})$", ErrorMessage = "Số điện thoại phải là số có 10 hoặc 12 số")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Email không được để trống")]
        [StringLength(30, ErrorMessage = "Email phải nhỏ hơn hoặc bằng 30 ký tự")]  
        [RegularExpression("^[a-zA-Z]+[0-9a-zA-Z]+[/@][gG][mM][aA][iY][lL][/.][cC][oO][mM]$", ErrorMessage = "Email không đúng định dạng chuẩn")]
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
        public string MemberId { get; set; }
        public bool Status { get; set; }
    }
}
