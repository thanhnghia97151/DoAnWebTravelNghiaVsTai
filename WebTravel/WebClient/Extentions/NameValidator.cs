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
        public static string address = "";
        public static bool CheckName(string FullName) 
        {
            name = "";
            if (Regex.IsMatch(FullName, "^[0-9]+$"))
            {
                name = "Tên phải là chuỗi ký tự không phải số";
            }
            else if (CheckNameTrue(FullName) == false)
            {
                name = "Tên phải là chuỗi ký tự không có số";
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
        public static bool CheckAddress(string Address)
        {
            try
            {
                address = "";
                if (Regex.IsMatch(Address, "^[/`/!/@/#/$/%/^/&/*/(/)/-/+/=/~/./,/;/:/'//]+$"))
                {
                    address = "Địa chỉ phải là chuỗi ký tự không là ký tự đặt biệt";
                }
                else
                        if (Regex.IsMatch(Address, "^([0-9])+$"))
                {
                    address = "Địa chỉ phải là chuỗi ký tự không phải số";
                }
                else
                        if (Regex.IsMatch(Address, "^[-+][0-9]+$"))
                {
                    address = "Địa chỉ phải là chuỗi ký tự không phải số";
                }
                if (address != "")
                {
                    return false;
                }
            }
            catch (Exception)
            {
                address = "Lỗi định dạng chuẩn cho address";
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
