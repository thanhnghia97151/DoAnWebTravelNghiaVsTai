using System.ComponentModel.DataAnnotations;

namespace WebClient.Models.ViewModels
{
    public class ChangePassword
    {
        public string Id { get; set; }

        [Required(ErrorMessage = "Mật khẩu không để trống")]
        public string OldPassword { get; set; }

        [Required(ErrorMessage = "Mật khẩu không để trống")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Mật khẩu không để trống")]
        public string NewPassword { get; set; }
    }
}
