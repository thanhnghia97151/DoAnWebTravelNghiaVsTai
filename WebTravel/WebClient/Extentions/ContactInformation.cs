using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WebClient.Models;

namespace WebClient.Extentions
{
    public class ContactInformation
    {
        public static string name = "";
        public static string title = "";
        public static string company = "";
        public static string content = "";
        public static bool CheckInformationContact(Contact contact)
        {
            try
            {
                name = "";
                title = "";
                company = "";
                content = "";
                if (Regex.IsMatch(contact.Name, "^[0-9]+$"))
                {
                    name = "Tên phải là chuỗi ký tự không phải số";
                }
                else if (Regex.IsMatch(contact.Name, "^[0-9 /`/!/@/#/$/%/^/&/*/(/)/-/+/=/~/./,/;/:/'//]+$"))
                {
                    name = "Tên phải là chuỗi ký tự không có ký tự đặt biệt";
                }
                else if (CheckName(contact.Name) == false)
                {
                    name = "Tên là chuỗi những ký tự";
                }
                else
                if (Regex.IsMatch(contact.Name, "^[/`/!/@/#/$/%/^/&/*/(/)/-/+/=/~/./,/;/:/'//]+$"))
                {
                    name = "Tên phải là chuỗi ký tự không là ký tự đặt biệt";
                }

                if (Regex.IsMatch(contact.Title, "^[0-9]+$"))
                {
                    title = "Tiêu đề phải là chuỗi ký tự không phải số";
                }
                else if (Regex.IsMatch(contact.Title, "^[0-9]+/w*$"))
                {
                    title = "Tiêu đề phải là chuỗi ký tự không bắt đầu bằng số";
                }
                else
                if (Regex.IsMatch(contact.Title, "^[/`/!/@/#/$/%/^/&/*/(/)/-/+/=/~/./,/;/:/'//]+$"))
                {
                    title = "Tiêu đề phải là chuỗi ký tự không là ký tự đặt biệt";
                }
                
                else 
                if (Regex.IsMatch(contact.Content, "^[0-9]+$"))
                {
                    content = "Nội dung phải là chuỗi ký tự không phải số";
                }
                else
                if (Regex.IsMatch(contact.Content, "^[/`/!/@/#/$/%/^/&/*/(/)/-/+/=/~/./,/;/:/'//]+$"))
                {
                    content = "Nội dung phải là chuỗi ký tự không là những ký tự đặt biệt";
                }
                else if (Regex.IsMatch(contact.Content, "^[0-9]+/w*$"))
                {
                    content = "Nội dung phải là chuỗi ký tự không bắt đầu bằng số";
                }
                if (contact.Company != "" || contact.Company != null)
                {
                    if (Regex.IsMatch(contact.Company, "^[0-9]+$"))
                    {
                        company = "Tên công ty phải là chuỗi ký tự không phải số";
                    } else
                    if (Regex.IsMatch(contact.Company, "^[0-9]+/w*$"))
                    {
                        company = "Tên công ty phải là chuỗi ký tự không bắt đầu bằng số";
                    }
                    else
                if (Regex.IsMatch(contact.Company, "^[/`/!/@/#/$/%/^/&/*/(/)/-/+/=/~/./,/;/:/'//]+$"))
                    {
                        company = "Tên công ty phải là chuỗi ký tự không là ký tự đặt biệt";
                    }
                }
                if (name != "" || title != "" || content != "" || company != "")
                {
                    return false;
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool CheckName(string name)
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
