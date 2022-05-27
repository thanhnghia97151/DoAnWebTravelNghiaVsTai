using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WebClient.Extentions
{
    public class NameValidator
    {
        public static string name = "";
        public static bool CheckName(string FullName) 
        {
            if (Regex.IsMatch(FullName, "^[0-9]+$"))
            {
                name = "Tên phải là chuỗi ký tự không phải số";
            }
            else if (Regex.IsMatch(FullName, "^[0-9]+[a-zA-Z0-9]+$"))
            {
                name = "Tên phải là chuỗi ký tự không có số đầu";
            }
            else
            if (Regex.IsMatch(FullName, "^[/`/!/@/#/$/%/^/&/*/(/)/-/+/=/~/./,/;/:/'//]+$"))
            {
                name = "Tên phải là chuỗi ký tự không là ký tự đặt biệt";
            }
            if (name != "")
            {
                return true;
            }
            return false;
        }
    }
}
