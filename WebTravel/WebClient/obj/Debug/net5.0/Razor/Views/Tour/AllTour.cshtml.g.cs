#pragma checksum "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Tour\AllTour.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e580d805adec62ec62c4696decb84294c662742"
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
#line 1 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\_ViewImports.cshtml"
using WebClient.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\_ViewImports.cshtml"
using WebClient.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e580d805adec62ec62c4696decb84294c662742", @"/Views/Tour/AllTour.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b8fad72161a928ca3d5d332110946d494b91cc1", @"/Views/_ViewImports.cshtml")]
    public class Views_Tour_AllTour : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Tour>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
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
                <h2> CÁC TOUR DU LICH</h2>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12"">
                <p class=""danhgia"">Đánh giá:</p>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12"">
");
            WriteLiteral("            </div>\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n<!--  Demos -->\r\n<div class=\"row1\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 40 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Tour\AllTour.cshtml"
             foreach (var item in Model)
           {

#line default
#line hidden
#nullable disable
            WriteLiteral("             <div class=\"col-xs-12 col-sm-6 col-md-4 col-lg-4 item\">\r\n                <div class=\"thumbnail\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1885, "\"", 1921, 2);
            WriteAttributeValue("", 1892, "/home/detailtour/", 1892, 17, true);
#nullable restore
#line 44 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Tour\AllTour.cshtml"
WriteAttributeValue("", 1909, item.TourId, 1909, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 1927, "\"", 1975, 2);
            WriteAttributeValue("", 1933, "https://localhost:44384/images/", 1933, 31, true);
#nullable restore
#line 44 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Tour\AllTour.cshtml"
WriteAttributeValue("", 1964, item.Image, 1964, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1976, "\"", 1982, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                    <div class=\"captionbottomimage\">\r\n                        ");
#nullable restore
#line 46 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Tour\AllTour.cshtml"
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
#line 52 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Tour\AllTour.cshtml"
                                             Write(item.Schedule);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n                        </div>\r\n\r\n                        <div>\r\n                            <p><span class=\"fa fa-calendar\"></span>&nbsp; Khởi hành: ");
#nullable restore
#line 57 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Tour\AllTour.cshtml"
                                                                                Write(item.StartDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n\r\n                        <div class=\"detailItem\">\r\n                            <b class=\"pull-right price\">Giá: ");
#nullable restore
#line 61 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Tour\AllTour.cshtml"
                                                        Write(item.PromotionPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" đ</b>\r\n                            <p>\r\n                                <span class=\"fa fa-user book\"></span>\r\n                                &nbsp;Vé còn: ");
#nullable restore
#line 64 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Tour\AllTour.cshtml"
                                         Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n                        </div>\r\n\r\n                    </div>\r\n                </div> <!-- end slide left 2 item 1 -->\r\n            </div> <!-- the end column1 row 1 -->\r\n");
#nullable restore
#line 71 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Tour\AllTour.cshtml"
           }

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n");
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div> <!-- the end row 1 -->");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Tour>> Html { get; private set; }
    }
}
#pragma warning restore 1591
