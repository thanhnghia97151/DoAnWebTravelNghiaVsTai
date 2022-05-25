using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WebClient.Models.ViewModels;

namespace WebClient.Extentions
{
    public class LoginInformation
    {
        public static string CheckLogin(LoginModel loginModel)
        {
            if (Regex.IsMatch(loginModel.Pwd, "^[a-zA-Z]+$"))
            {
                return "Mật khẩu phải có cả số và chữ";
            }
            else if (Regex.IsMatch(loginModel.Pwd, "^[0-9]+$"))
            {
                return "Mật khẩu phải có cả số và chữ";
            }
            return "1";
        }
    }
}
