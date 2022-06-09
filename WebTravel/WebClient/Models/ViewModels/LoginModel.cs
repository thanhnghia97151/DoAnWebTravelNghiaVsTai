using System.ComponentModel.DataAnnotations;

namespace WebClient.Models.ViewModels
{
    public class LoginModel
    {
        public string Urs { get; set; }

        [Required(ErrorMessage = "Mật khẩu không được để trống ")]
        [StringLength(23, ErrorMessage = "Mật khẩu phải dài từ 6 tới 23 ký tự", MinimumLength = 6)]
        public string Pwd { get; set; }
        public bool Rem { get; set; }

        [Required(ErrorMessage = "Số điện thoại không được để trống ")]
        [RegularExpression("^([0][0-9]{9})|([0-9]{12})$", ErrorMessage = "Số điện thoại phải là số có 10 hoặc 12 số")]
        public string Phone { get; set; }
    }
}
