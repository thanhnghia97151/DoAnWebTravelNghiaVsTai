using System.Collections.Generic;

namespace WebClient.Models.ViewModels
{
    public class ReponseLogin
    {
        //public string Token { get; set; }
        public string MemberId { get; set; }
        public string Email { get; set; }
        public IEnumerable<string>? Roles { get; set; }
    }
}
