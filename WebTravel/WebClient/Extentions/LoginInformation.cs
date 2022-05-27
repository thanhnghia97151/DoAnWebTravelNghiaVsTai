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

        public static string CheckBrithday(DateTime date) 
        {
            if (date <= DateTime.Now) 
            {
                if ( DateTime.Now.Year - date.Year < 15)
                {
                    return "Bạn chưa đủ 15 tuổi để đăng ký dịch vụ của chúng tôi";
                }
                return "1";
            }
            else 
            {
                return "Ngày sinh không được nhỏ hơn ngày hiện tại";
            }
        }
    }
}
