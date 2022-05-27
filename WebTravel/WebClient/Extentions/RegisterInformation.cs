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
        public static string address = "";

        public static bool CheckMember(Member member)
        {
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

            if (Regex.IsMatch(member.Address, "^[0-9]+$"))
            {
                address = "Địa chỉ phải là chuỗi ký tự không phải số";
            }
            else
            if (Regex.IsMatch(member.Address, "^[/`/!/@/#/$/%/^/&/*/(/)/-/+/=/~/./,/;/:/'//]+$"))
            {
                address = "Địa chỉ phải là chuỗi ký tự không là ký tự đặt biệt";
            }

            if (username != "" || address != "")
            {
                return false;
            }
            return true;
        }
    }
}
