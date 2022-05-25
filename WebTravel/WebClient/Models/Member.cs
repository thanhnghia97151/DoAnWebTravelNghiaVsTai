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
        [RegularExpression("^[a-zA-Z\\s\\.]+$", ErrorMessage = "Tên phải là chuỗi ký tự")]
        public string UserName { get; set; }
        public string FullName { get; set; }
        public DateTime Birthday { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool ConfirmedPhone { get; set; }
        public bool? Status { get; set; }
        public IEnumerable<string>? Roles { get; set; }
    }
}
