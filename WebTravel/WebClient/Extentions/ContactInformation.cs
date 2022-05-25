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
            if (Regex.IsMatch(contact.Name, "^[0-9]+$"))
            {
                name = "Tên phải là chuỗi ký tự không phải số";
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
            else
            if (Regex.IsMatch(contact.Title, "^[/`/!/@/#/$/%/^/&/*/(/)/-/+/=/~/./,/;/:/'//]+$"))
            {
                title = "Tiêu đề phải là chuỗi ký tự không là ký tự đặt biệt";
            }
            if (Regex.IsMatch(contact.Company, "^[0-9]+$"))
            {
                company = "Tên công ty phải là chuỗi ký tự không phải số";
            }
            else
            if (Regex.IsMatch(contact.Company, "^[/`/!/@/#/$/%/^/&/*/(/)/-/+/=/~/./,/;/:/'//]+$"))
            {
                company = "Tên công ty phải là chuỗi ký tự không là ký tự đặt biệt";
            }
            if (Regex.IsMatch(contact.Content, "^[0-9]+$"))
            {
                content = "Nội dung phải là chuỗi ký tự không phải số";
            }
            else
            if(Regex.IsMatch(contact.Content, "^[/`/!/@/#/$/%/^/&/*/(/)/-/+/=/~/./,/;/:/'//]+$"))
            {
                content = "Nội dung phải là chuỗi ký tự không là ký tự đặt biệt";
            }
            if (name != null || title != null || content != null || company != null)
            {
                return false;
            }
            return true;
        }
    }
}
