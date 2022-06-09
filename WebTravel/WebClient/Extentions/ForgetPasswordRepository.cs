using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace WebClient.Extentions
{
    public class ForgetPasswordRepository : IForgetPasswordRepository
    {
        private readonly IConfiguration _configuration;
        public ForgetPasswordRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string SendSMS(string phone) 
        {
            try
            {
                var createCode = "";
                var random = new Random();
                for (int i = 0; i < 6; i++)
                {
                    createCode += random.Next(0, 9);
                }
                var phoneNumber = "";
                string accountSid = _configuration["TwilioAccountDetails:AccountSid"];
                string authToken = _configuration["TwilioAccountDetails:AuthToken"];
                if (phone.Substring(0, 1) == "0")
                {
                    phoneNumber = "+84" + phone.Substring(1, phone.Length - 1);
                }
                TwilioClient.Init(accountSid, authToken);

                var result = ""; MessageResource.Create(
                    body: "your code: " + createCode,
                    from: new Twilio.Types.PhoneNumber("+19378723828"),
                    to: new Twilio.Types.PhoneNumber(phoneNumber)
                );
                if (result is null)
                {
                    return "";
                }
                return createCode;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return "";
            }
        }
        public string SendInforBank(string phone)
        {
            try
            {
                var createInforBank = "Thông báo: Quý khách vui lòng chuyển tiền trước 1 ngày: \n+Tên ngân hàng: Vietinbank \n+Chủ tài khoản: Du lịch kỳ thú \n+ stk: 098453749263";
                var phoneNumber = "";
                string accountSid = _configuration["TwilioAccountDetails:AccountSid"];
                string authToken = _configuration["TwilioAccountDetails:AuthToken"];
                if (phone.Substring(0, 1) == "0")
                {
                    phoneNumber = "+84" + phone.Substring(1, phone.Length - 1);
                }
                TwilioClient.Init(accountSid, authToken);

                var result = ""; MessageResource.Create(
                    body: createInforBank,
                    from: new Twilio.Types.PhoneNumber("+19378723828"),
                    to: new Twilio.Types.PhoneNumber(phoneNumber)
                );
                if (result is null)
                {
                    return "";
                }
                return "1";
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                return "";
            }
        }

        public string SendOrder(string phone, string codeOrder, decimal price, int number, DateTime dateDepartment, string startPlace)
        {
            try
            {
                var createInfor = $": Du lịch kỳ thú gửi tới bạn đơn hàng:\n +Mã ĐH:{codeOrder}\n + Giá:{price}\n +Số lượng:{number}\n: +Ngày khởi hành: {dateDepartment}";
                var phoneNumber = "";
                string accountSid = _configuration["TwilioAccountDetails:AccountSid"];
                string authToken = _configuration["TwilioAccountDetails:AuthToken"];
                if (phone.Substring(0, 1) == "0")
                {
                    phoneNumber = "+84" + phone.Substring(1, phone.Length - 1);
                }
                TwilioClient.Init(accountSid, authToken);

                var result = ""; MessageResource.Create(
                    body: createInfor,
                    from: new Twilio.Types.PhoneNumber("+19378723828"),
                    to: new Twilio.Types.PhoneNumber(phoneNumber)
                );
                if (result is null)
                {
                    return "";
                }
                return "1";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return "";
            }
        }
    }
}
