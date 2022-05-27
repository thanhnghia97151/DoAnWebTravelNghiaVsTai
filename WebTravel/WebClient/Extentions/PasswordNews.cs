using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WebClient.Extentions
{
    public class PasswordNews
    {
        public static string CheckPassword(string Pasword, string confirmPassword) 
        {
            if (Pasword is null)
            {
                return "Mật khẩu Không được để trống";
            }
            else if (Pasword != confirmPassword) 
            {
                return "Mật khẩu không khớp";
            }
            else
            {
                if (Regex.IsMatch(Pasword, "^[a-zA-Z]+$")) 
                {
                    return "Mật khẩu phải có cả số và chữ";
                }
                else if (Regex.IsMatch(Pasword, "^[0-9]+$"))
                {
                    return "Mật khẩu phải có cả số và chữ";
                }
                else 
                {
                    if (Regex.IsMatch(Pasword, "^[a-zA-Z][a-zA-Z0-9]+$")) 
                    {
                        if (Pasword.Length >= 6 && Pasword.Length <= 23)
                        {
                            return "1";
                        }
                        else return "Mật khẩu phải dài từ 6 tới 23 ký tự";
                    }
                }
            }
            return "Nhập lại mật khẩu";
        }
    }
}
