using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebClient.Models.ViewModels
{
    public class Users
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; } = "Chưa cập nhật";
    }
}
