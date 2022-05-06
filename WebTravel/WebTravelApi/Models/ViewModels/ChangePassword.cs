using System;

namespace WebTravelApi.Models.ViewModels
{
    public class ChangePassword
    {
        public string Id { get; set; }
        public string ConfirmPassword { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
    }
}
