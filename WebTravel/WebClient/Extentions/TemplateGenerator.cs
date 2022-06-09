using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebClient.Models.ViewModels;

namespace WebClient.Extentions
{
    public class TemplateGenerator
    {
        public static string GetHTMLString(List<ExportOrder> exportOrders, Users users, double totalResult, List<CustomerInformation> customerInformations)
        {
            var sb = new StringBuilder();
            sb.AppendFormat(@"
                        <html>
                            <head>
                            </head>
                            <body>
                                <br><br>
                                <div style='text-align: center;  color: green;  padding-bottom: 8px;'><h1>THÔNG TIN HÓA ĐƠN CỦA KHÁCH HÀNG!!!</h1></div>
                                <p style='text-align: center;'>------------------------||-----------------------</p>
                                <div style='text-align:center; font-size:22px;'>
                                    <p>Tên công ty:&nbsp;&nbsp;&nbsp;<small style='color:red; font-size:23px;'>CÔNG TY TNHH DU LỊCH VIỆT</small></p>
                                    <p>Địa chỉ: &nbsp;&nbsp;&nbsp;<small style='color:red; font-size:23px;'>127 Trần Bá Giao, P5, Gò Vấp</small></p>
                                    <p>Email: &nbsp;&nbsp;&nbsp;<small style='color:red; font-size:23px;'>leanhthanhtai@gmail.com</small></p>
                                    <p>Số điện thoại: &nbsp;&nbsp;&nbsp;<small style='color:red; font-size:23px;'>0868321730</small></p>
                                </div> <br><br><br>
                                <div  style='font-size:22px;'>
                                     <p>Tên khách hàng:&nbsp;&nbsp;<small style='color:brown; font-size:23px;'>{0}</small></p>
                                     <p>Email:&nbsp;&nbsp;<small style='color:brown; font-size:23px;'>{1}</small></p>
                                     <p>Số điện thoại:&nbsp;&nbsp;<small style='color:brown; font-size:23px;'>{2}</small></p>
                                </div>
                               <div><p style='font-size: 20px; text-align: center;'>THÔNG TIN HÓA ĐƠN</p></div>
                                <table border='1' style='border-collapse: collapse; width: 100%;' align='center'>
                                    <tr style=' background-color: green; color: white;  text-align: center; font-size: 18px;'>
                                        <th>STT</th>
                                        <th>Tên Tour</th>
                                        <th>Số Lượng</th>
                                        <th>Giá</th>
                                        <th>Thành Tiền</th>
                                    </tr>", users.Name, users.Email, users.Phone);
            if (exportOrders.Count > 0)
            {
                foreach (var emp in exportOrders)
                {
                    sb.AppendFormat(@"<tr style='font-size: 18px;'>
                                    <td style='text-align: center;'>{0}</td>
                                    <td>{1}</td>
                                    <td style='text-align: center;'>{2}</td>
                                    <td style='text-align: center;'>{3}</td>
                                    <td style='text-align: center;'>{4}</td>
                                  </tr>", emp.Stt, emp.Name, emp.Quantity, emp.Price, emp.TotalMoney);
                }
            }
            sb.AppendFormat(@"
                                </table>
                             <br><br>
                            <div style='float:right; font-size:22px'>
                            <p>Tổng tiền đã thanh toán:&nbsp;&nbsp;&nbsp; <small style='font-size:25px'>{0}</small></p>
                            </div> <br><br><br>
                            <div><p style='font-size: 20px; text-align: center;'>THÔNG TIN KHÁCH HÀNG</p></div>
                            ", totalResult.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("vi-VN")));

            sb.Append(@" <table border='1' style='border-collapse: collapse; width: 100%;' align='center'>
                                    <tr style=' background-color: green; color: white;  text-align: center; font-size: 18px;'>
                                        <th>STT</th>
                                        <th>Ngày đặt</th>
                                        <th>Tên</th>
                                        <th>Địa chỉ</th>
                                        <th>Số điện thoại</th>
                                    </tr>");

            if (customerInformations.Count > 0)
            {
                foreach (var cus in customerInformations)
                {
                    if (cus.customerExports.Count > 0)
                    {
                        sb.AppendFormat(@"<tr style='font-size: 18px;'>
                                    <td rowspan='{0}' style='text-align: center;'>{1}</td>
                                    <td rowspan='{2}' style='text-align: center;'>{3}</td>
                                    <td style='text-align: center;'>{4}</td>
                                    <td style='text-align: center;'>{5}</td>
                                    <td style='text-align: center;'>{6}</td>
                                  </tr>", cus.Counts, cus.Stt, cus.Counts, cus.InvoiceDate, cus.customerExports.ElementAt(0).UserName, cus.customerExports.ElementAt(0).Address, cus.customerExports.ElementAt(0).Phone);

                        for (var i = 1; i < cus.Counts; i++)
                        {
                            sb.AppendFormat(@"<tr style='font-size: 18px;'>
                                    <td style='text-align: center;'>{0}</td>
                                    <td style='text-align: center;'>{1}</td>
                                    <td style='text-align: center;'>{2}</td>
                                  </tr>", cus.customerExports.ElementAt(i).UserName, cus.customerExports.ElementAt(i).Address, cus.customerExports.ElementAt(i).Phone);
                        }
                    }                   

                }
            }
            sb.Append(@"
                                </table>
                                <br><br><br><br><br><br>
                            <div style='text-align: center;  color: black;  padding-bottom: 13x;'><h5>------||------CẢM ƠN QUÝ KHÁCH ĐÃ TIN TƯỞNG SỬ DỤNG DỊCH VỤ CỦA CHÚNG TÔI!!!------||------</h5></div>
                            </body>
                        </html>");
            return sb.ToString();
        }
    }
}
