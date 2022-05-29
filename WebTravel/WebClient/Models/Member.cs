using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebClient.Models
{
    public class Member
    {
        public string? MemberID { get; set; }

        [Required(ErrorMessage = "Tên không được để trống")]
        [StringLength(36, ErrorMessage = "Tên phải nhỏ hơn hoặc bằng 36 ký tự")]
        [RegularExpression("^.+$", ErrorMessage = "Tên phải là chuỗi ký tự")]
        public string UserName { get; set; }

        //[Required(ErrorMessage = "Tên đầy đủ không được để trống")]
        [StringLength(36, ErrorMessage = "Tên đầy đủ phải nhỏ hơn hoặc bằng 36 ký tự")]
        [RegularExpression("^.+$", ErrorMessage = "Tên đầy đủ phải là chuỗi ký tự")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Ngày sinh không được để trống")]
        public DateTime Birthday { get; set; }
        public string Gender { get; set; }

        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        [RegularExpression("^([0][0-9]{9})|([0][0-9]{11})$", ErrorMessage = "Số điện thoại phải có 10 hoặc 12 chữ số")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Địa chỉ không được để trống")]
        [StringLength(60, ErrorMessage = "Địa chỉ phải nhỏ hơn hoặc bằng 60 ký tự")]
        [RegularExpression("^.+$", ErrorMessage = "Địa chỉ không có ký tự đặc biệt")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Email không được để trống")]
        [StringLength(30, ErrorMessage = "Email phải nhỏ hơn hoặc bằng 30 ký tự")]
        [RegularExpression("^[a-zA-Z]+[0-9a-zA-Z]+[/@][gG][mM][aA][iY][lL][/.][cC][oO][mM]$", ErrorMessage = "Email không đúng định dạng chuẩn")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Mật khẩu không được để trống")]
        public string Password { get; set; }
        public bool ConfirmedPhone { get; set; }
        public bool? Status { get; set; }
        public IEnumerable<string>? Roles { get; set; }
    }
}
