#pragma checksum "F:\Khoa_Luan_Tot_Nghiep\DoANCodeSourse\WebTravel\WebClient\Views\Tour\AllTour.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c88b35e457a232cabfb09126ee6320197693d9de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tour_AllTour), @"mvc.1.0.view", @"/Views/Tour/AllTour.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "F:\Khoa_Luan_Tot_Nghiep\DoANCodeSourse\WebTravel\WebClient\Views\_ViewImports.cshtml"
using WebClient.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Khoa_Luan_Tot_Nghiep\DoANCodeSourse\WebTravel\WebClient\Views\_ViewImports.cshtml"
using WebClient.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Khoa_Luan_Tot_Nghiep\DoANCodeSourse\WebTravel\WebClient\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c88b35e457a232cabfb09126ee6320197693d9de", @"/Views/Tour/AllTour.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"169f23584bdde1d27398dd2e1409d4fef4c01ec3", @"/Views/_ViewImports.cshtml")]
    public class Views_Tour_AllTour : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedList.IPagedList<Tour>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "F:\Khoa_Luan_Tot_Nghiep\DoANCodeSourse\WebTravel\WebClient\Views\Tour\AllTour.cshtml"
  
    int p = ViewContext.RouteData.Values["id"] != null ? Convert.ToInt32(ViewContext.RouteData.Values["id"]) : 1;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Thong tin goi nho -->
<div class=""goinho"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12"">
                <div class=""thongtin"">
                    <small>Trang chủ > </small><small>Khách Sạn</small>
                </div>
            </div>
        </div>
    </div>
</div> <!-- the end goi nho -->
<!-- Thong tin khach san -->
<div class=""motakhachsanall"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12"">
                <h2> DANH SÁCH TOUR DU LICH</h2>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12"">
                <p class=""danhgia"">Du lịch kỳ thú - Tour Du lịch hấp dẫn - Du lịch kỳ thú cung cấp những
                tour du lịch có giá tốt - Du khách sẽ được khám phá những danh lam thắng 
                cảnh thiên nhiên đẹp mê hồn cùng nhiều công trình kiến");
            WriteLiteral(@" trúc ấn tượng được 
                tạo nên bởi bàn tay khéo léo của con người. Cùng Du Lịch Kỳ Thú tìm hiểu 
                những địa điểm du lịch để bắt đầu lên kế hoạch cho chuyến du lịch ngay nhé!</p>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12"">
");
            WriteLiteral("            </div>\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n<!--  Demos -->\r\n<div class=\"row1\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 49 "F:\Khoa_Luan_Tot_Nghiep\DoANCodeSourse\WebTravel\WebClient\Views\Tour\AllTour.cshtml"
             if (Model != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "F:\Khoa_Luan_Tot_Nghiep\DoANCodeSourse\WebTravel\WebClient\Views\Tour\AllTour.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-xs-12 col-sm-6 col-md-4 col-lg-4 item\">\r\n                        <div class=\"thumbnail\" style=\"height:400px;\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 2583, "\"", 2619, 2);
            WriteAttributeValue("", 2590, "/home/detailtour/", 2590, 17, true);
#nullable restore
#line 55 "F:\Khoa_Luan_Tot_Nghiep\DoANCodeSourse\WebTravel\WebClient\Views\Tour\AllTour.cshtml"
WriteAttributeValue("", 2607, item.TourId, 2607, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 2625, "\"", 2673, 2);
            WriteAttributeValue("", 2631, "https://localhost:44384/images/", 2631, 31, true);
#nullable restore
#line 55 "F:\Khoa_Luan_Tot_Nghiep\DoANCodeSourse\WebTravel\WebClient\Views\Tour\AllTour.cshtml"
WriteAttributeValue("", 2662, item.Image, 2662, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2674, "\"", 2680, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"height:200px;\"></a>\r\n                            <div class=\"captionbottomimage\">\r\n                                ");
#nullable restore
#line 57 "F:\Khoa_Luan_Tot_Nghiep\DoANCodeSourse\WebTravel\WebClient\Views\Tour\AllTour.cshtml"
                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                            <div class=""caption"">
                                <div class=""review"">
                                    <p>
                                        <span class=""fa fa-history""></span>
                                        &nbsp;Lịch trình: ");
#nullable restore
#line 63 "F:\Khoa_Luan_Tot_Nghiep\DoANCodeSourse\WebTravel\WebClient\Views\Tour\AllTour.cshtml"
                                                     Write(item.Schedule);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </p>\r\n                                </div>\r\n\r\n                                <div>\r\n                                    <p><span class=\"fa fa-calendar\"></span>&nbsp; Khởi hành: ");
#nullable restore
#line 68 "F:\Khoa_Luan_Tot_Nghiep\DoANCodeSourse\WebTravel\WebClient\Views\Tour\AllTour.cshtml"
                                                                                        Write(item.StartDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\r\n\r\n                                <div class=\"detailItem\">\r\n                                    <b class=\"pull-right price\">Giá: ");
#nullable restore
#line 72 "F:\Khoa_Luan_Tot_Nghiep\DoANCodeSourse\WebTravel\WebClient\Views\Tour\AllTour.cshtml"
                                                                Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" đ</b>\r\n                                    <p>\r\n                                        <span class=\"fa fa-user book\"></span>\r\n                                        &nbsp;Vé còn: ");
#nullable restore
#line 75 "F:\Khoa_Luan_Tot_Nghiep\DoANCodeSourse\WebTravel\WebClient\Views\Tour\AllTour.cshtml"
                                                 Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </p>\r\n                                </div>\r\n\r\n                            </div>\r\n                        </div> <!-- end slide left 2 item 1 -->\r\n                    </div> <!-- the end column1 row 1 -->\r\n");
#nullable restore
#line 82 "F:\Khoa_Luan_Tot_Nghiep\DoANCodeSourse\WebTravel\WebClient\Views\Tour\AllTour.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "F:\Khoa_Luan_Tot_Nghiep\DoANCodeSourse\WebTravel\WebClient\Views\Tour\AllTour.cshtml"
                 
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h5 style=\"color: red;\">Thông tin không có, vui lòng thử lại sau</h5>\r\n");
#nullable restore
#line 87 "F:\Khoa_Luan_Tot_Nghiep\DoANCodeSourse\WebTravel\WebClient\Views\Tour\AllTour.cshtml"
            }    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
        <nav aria-label=""Page navigation example"">
            <ul class=""pagination justify-content-center"">
                <li class=""page-item disabled"">
                    <a class=""page-link"" href=""#"" tabindex=""-1"">Previous</a>
                </li>
");
#nullable restore
#line 94 "F:\Khoa_Luan_Tot_Nghiep\DoANCodeSourse\WebTravel\WebClient\Views\Tour\AllTour.cshtml"
                 if (Model != null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 96 "F:\Khoa_Luan_Tot_Nghiep\DoANCodeSourse\WebTravel\WebClient\Views\Tour\AllTour.cshtml"
                     for (var i = 1; i <= Model.PageCount; i++)
                    {

                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 99 "F:\Khoa_Luan_Tot_Nghiep\DoANCodeSourse\WebTravel\WebClient\Views\Tour\AllTour.cshtml"
                         if (p == i)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"page-item active\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 4747, "\"", 4770, 2);
            WriteAttributeValue("", 4754, "/tour/alltour/", 4754, 14, true);
#nullable restore
#line 101 "F:\Khoa_Luan_Tot_Nghiep\DoANCodeSourse\WebTravel\WebClient\Views\Tour\AllTour.cshtml"
WriteAttributeValue("", 4768, i, 4768, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 101 "F:\Khoa_Luan_Tot_Nghiep\DoANCodeSourse\WebTravel\WebClient\Views\Tour\AllTour.cshtml"
                                                                                                 Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 102 "F:\Khoa_Luan_Tot_Nghiep\DoANCodeSourse\WebTravel\WebClient\Views\Tour\AllTour.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"page-item \"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 4940, "\"", 4963, 2);
            WriteAttributeValue("", 4947, "/tour/alltour/", 4947, 14, true);
#nullable restore
#line 105 "F:\Khoa_Luan_Tot_Nghiep\DoANCodeSourse\WebTravel\WebClient\Views\Tour\AllTour.cshtml"
WriteAttributeValue("", 4961, i, 4961, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 105 "F:\Khoa_Luan_Tot_Nghiep\DoANCodeSourse\WebTravel\WebClient\Views\Tour\AllTour.cshtml"
                                                                                           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 106 "F:\Khoa_Luan_Tot_Nghiep\DoANCodeSourse\WebTravel\WebClient\Views\Tour\AllTour.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 106 "F:\Khoa_Luan_Tot_Nghiep\DoANCodeSourse\WebTravel\WebClient\Views\Tour\AllTour.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 107 "F:\Khoa_Luan_Tot_Nghiep\DoANCodeSourse\WebTravel\WebClient\Views\Tour\AllTour.cshtml"
                     
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h5 style=\"color: red;\">Thông tin không có, vui lòng thử lại sau</h5>\r\n");
#nullable restore
#line 112 "F:\Khoa_Luan_Tot_Nghiep\DoANCodeSourse\WebTravel\WebClient\Views\Tour\AllTour.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </nav>\r\n    </div>\r\n    <!-- Thêm mã phân trang -->\r\n\r\n\r\n</div> <!-- the end row 1 -->");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedList.IPagedList<Tour>> Html { get; private set; }
    }
}
#pragma warning restore 1591
