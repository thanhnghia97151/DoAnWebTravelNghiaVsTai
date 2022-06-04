using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebClient.Extentions
{
    public class CheckDate
    {
        public static bool CheckDateInvoice(DateTime date) 
        {
            var value = DateTime.Now.Date.Subtract(date.Date);
            string[] result = value.ToString().Split('.', ':');
            if (result[0] == "1" || result[0] == "0" )
            {
                return true;
            }
            return false;
        }
    }
}
