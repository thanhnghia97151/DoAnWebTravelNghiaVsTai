#pragma checksum "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Tour\AllTour.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d52bd5198cf2a081860e49ef9d1acb0d133d7e4"
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
#nullable restore
#line 3 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d52bd5198cf2a081860e49ef9d1acb0d133d7e4", @"/Views/Tour/AllTour.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"169f23584bdde1d27398dd2e1409d4fef4c01ec3", @"/Views/_ViewImports.cshtml")]
    public class Views_Tour_AllTour : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedList.IPagedList<Tour>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Tour\AllTour.cshtml"
  
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
#line 45 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Tour\AllTour.cshtml"
             foreach (var item in Model)
           {

#line default
#line hidden
#nullable disable
            WriteLiteral("             <div class=\"col-xs-12 col-sm-6 col-md-4 col-lg-4 item\">\r\n                <div class=\"thumbnail\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 2048, "\"", 2084, 2);
            WriteAttributeValue("", 2055, "/home/detailtour/", 2055, 17, true);
#nullable restore
#line 49 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Tour\AllTour.cshtml"
WriteAttributeValue("", 2072, item.TourId, 2072, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 2090, "\"", 2138, 2);
            WriteAttributeValue("", 2096, "https://localhost:44384/images/", 2096, 31, true);
#nullable restore
#line 49 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Tour\AllTour.cshtml"
WriteAttributeValue("", 2127, item.Image, 2127, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2139, "\"", 2145, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                    <div class=\"captionbottomimage\">\r\n                        ");
#nullable restore
#line 51 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Tour\AllTour.cshtml"
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
#line 57 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Tour\AllTour.cshtml"
                                             Write(item.Schedule);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n                        </div>\r\n\r\n                        <div>\r\n                            <p><span class=\"fa fa-calendar\"></span>&nbsp; Khởi hành: ");
#nullable restore
#line 62 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Tour\AllTour.cshtml"
                                                                                Write(item.StartDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n\r\n                        <div class=\"detailItem\">\r\n                            <b class=\"pull-right price\">Giá: ");
#nullable restore
#line 66 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Tour\AllTour.cshtml"
                                                        Write(item.PromotionPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" đ</b>\r\n                            <p>\r\n                                <span class=\"fa fa-user book\"></span>\r\n                                &nbsp;Vé còn: ");
#nullable restore
#line 69 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Tour\AllTour.cshtml"
                                         Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n                        </div>\r\n\r\n                    </div>\r\n                </div> <!-- end slide left 2 item 1 -->\r\n            </div> <!-- the end column1 row 1 -->\r\n");
#nullable restore
#line 76 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Tour\AllTour.cshtml"
           }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            

        </div>

        <nav aria-label=""Page navigation example"">
            <ul class=""pagination justify-content-center"">
                <li class=""page-item disabled"">
                        <a class=""page-link"" href=""#"" tabindex=""-1"">Previous</a>
                    </li>
");
#nullable restore
#line 86 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Tour\AllTour.cshtml"
                 for (var i = 1; i <= Model.PageCount; i++)
                {
                    
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Tour\AllTour.cshtml"
                     if (p == i)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"page-item active\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 3826, "\"", 3849, 2);
            WriteAttributeValue("", 3833, "/tour/alltour/", 3833, 14, true);
#nullable restore
#line 91 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Tour\AllTour.cshtml"
WriteAttributeValue("", 3847, i, 3847, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 91 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Tour\AllTour.cshtml"
                                                                                             Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 92 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Tour\AllTour.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"page-item \"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 4003, "\"", 4026, 2);
            WriteAttributeValue("", 4010, "/tour/alltour/", 4010, 14, true);
#nullable restore
#line 95 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Tour\AllTour.cshtml"
WriteAttributeValue("", 4024, i, 4024, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 95 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Tour\AllTour.cshtml"
                                                                                       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 96 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Tour\AllTour.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 96 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Tour\AllTour.cshtml"
                     
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
