#pragma checksum "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Tour\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "833faf46c6c2d55706d7a5a20130a7022795960f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tour_Search), @"mvc.1.0.view", @"/Views/Tour/Search.cshtml")]
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
#nullable restore
#line 3 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"833faf46c6c2d55706d7a5a20130a7022795960f", @"/Views/Tour/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"169f23584bdde1d27398dd2e1409d4fef4c01ec3", @"/Views/_ViewImports.cshtml")]
    public class Views_Tour_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
                <h2> KẾT QUẢ SEARCH</h2>
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
            WriteLiteral("            </div>\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n\r\n<div class=\"row1\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 41 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Tour\Search.cshtml"
             foreach (var item in ViewBag.tour)
           {

#line default
#line hidden
#nullable disable
            WriteLiteral("             <div class=\"col-xs-12 col-sm-6 col-md-4 col-lg-4 item\">\r\n                <div class=\"thumbnail\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1860, "\"", 1896, 2);
            WriteAttributeValue("", 1867, "/home/detailtour/", 1867, 17, true);
#nullable restore
#line 45 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Tour\Search.cshtml"
WriteAttributeValue("", 1884, item.TourId, 1884, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 1902, "\"", 1950, 2);
            WriteAttributeValue("", 1908, "https://localhost:44384/images/", 1908, 31, true);
#nullable restore
#line 45 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Tour\Search.cshtml"
WriteAttributeValue("", 1939, item.Image, 1939, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1951, "\"", 1957, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                    <div class=\"captionbottomimage\">\r\n                        ");
#nullable restore
#line 47 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Tour\Search.cshtml"
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
#line 53 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Tour\Search.cshtml"
                                             Write(item.Schedule);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n                        </div>\r\n\r\n                        <div>\r\n                            <p><span class=\"fa fa-calendar\"></span>&nbsp; Khởi hành: ");
#nullable restore
#line 58 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Tour\Search.cshtml"
                                                                                Write(item.StartDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n\r\n                        <div class=\"detailItem\">\r\n                            <b class=\"pull-right price\">Giá: ");
#nullable restore
#line 62 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Tour\Search.cshtml"
                                                        Write(item.PromotionPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" đ</b>\r\n                            <p>\r\n                                <span class=\"fa fa-user book\"></span>\r\n                                &nbsp;Vé còn: ");
#nullable restore
#line 65 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Tour\Search.cshtml"
                                         Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n                        </div>\r\n\r\n                    </div>\r\n                </div> <!-- end slide left 2 item 1 -->\r\n            </div> <!-- the end column1 row 1 -->\r\n");
#nullable restore
#line 72 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Tour\Search.cshtml"
           }

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n\r\n        </div>\r\n\r\n        \r\n    </div>\r\n    <!-- Thêm mã phân trang -->\r\n\r\n\r\n</div> <!-- the end row 1 -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
