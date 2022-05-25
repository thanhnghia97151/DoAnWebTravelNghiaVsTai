using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebClient.Extentions
{
    public interface IForgetPasswordRepository
    {
        string SendSMS(string phone);
    }
}
