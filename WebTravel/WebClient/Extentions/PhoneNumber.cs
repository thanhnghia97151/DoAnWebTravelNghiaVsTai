using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WebClient.Extentions
{
    public static class PhoneNumber
    {
        public static bool CheckPhone(string phone) 
        {
            if (Regex.IsMatch(phone, "^([0][0-9]{9})|([0-9]{12})$"))
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
