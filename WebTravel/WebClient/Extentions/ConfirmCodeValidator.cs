using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WebClient.Extentions
{
    public class ConfirmCodeValidator
    {
        public static string CheckOTPCode(string code) 
        {
            if (Regex.IsMatch(code, "^[0-9]{6}$"))
            {
                return "1";
            }
            else 
            {
                return "Mã code có 6 chữ số";
            }
        }
    }
}
