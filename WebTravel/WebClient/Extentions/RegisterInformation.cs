using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WebClient.Models;

namespace WebClient.Extentions
{
    public class RegisterInformation
    {
        public static string username = "";

        public static bool CheckMember(Member member)
        {
            username = "";
            if (Regex.IsMatch(member.UserName, "^[0-9]+$"))
            {
                username = "Tên phải là chuỗi ký tự không phải số";
            }
            else if (Regex.IsMatch(member.UserName, "^[0-9]+[a-zA-Z0-9]+$"))
            {
                username = "Tên phải là chuỗi ký tự không có số đầu";
            }
            else
            if (Regex.IsMatch(member.UserName, "^[/`/!/@/#/$/%/^/&/*/(/)/-/+/=/~/./,/;/:/'//]+$"))
            {
                username = "Tên phải là chuỗi ký tự không là ký tự đặt biệt";
            }           
            if (username != "")
            {
                return false;
            }
            return true;
        }

        public static bool CheckNameTrue(string name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i].ToString() == "0" || name[i].ToString() == "1" ||
                    name[i].ToString() == "2" || name[i].ToString() == "3" ||
                    name[i].ToString() == "4" || name[i].ToString() == "5" ||
                    name[i].ToString() == "6" || name[i].ToString() == "7" ||
                    name[i].ToString() == "8" || name[i].ToString() == "9")
                {
                    return false;
                }
            }
            return true;
        }
    }
}
