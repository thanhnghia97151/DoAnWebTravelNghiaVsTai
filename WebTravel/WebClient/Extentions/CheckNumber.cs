using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebClient.Extentions
{
    public class CheckNumber
    {
        public static string NumberModel(decimal price)
        {
            try
            {
                if (price < 0)
                {
                    return "Giá phải lớn hơn 0";
                }
            }
            catch (Exception)
            {

                return "Giá phải là số lớn hơn 0";
            }
            return "1";
        }
    }
}
