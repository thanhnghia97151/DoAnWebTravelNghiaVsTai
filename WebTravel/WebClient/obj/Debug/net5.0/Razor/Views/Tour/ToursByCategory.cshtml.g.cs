#pragma checksum "D:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Tour\ToursByCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "441459556518168b1b1b77ff7fa2c447c1dbf38e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tour_ToursByCategory), @"mvc.1.0.view", @"/Views/Tour/ToursByCategory.cshtml")]
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
#line 1 "D:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\_ViewImports.cshtml"
using WebClient.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\_ViewImports.cshtml"
using WebClient.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"441459556518168b1b1b77ff7fa2c447c1dbf38e", @"/Views/Tour/ToursByCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"169f23584bdde1d27398dd2e1409d4fef4c01ec3", @"/Views/_ViewImports.cshtml")]
    public class Views_Tour_ToursByCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedList.IPagedList<Tour>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Tour\ToursByCategory.cshtml"
  
    TourCategory cate = ViewBag.tourcate;
    List<Tour> listTours = ViewBag.toursbycategoryid;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Tour\ToursByCategory.cshtml"
  
    int page = ViewBag.page;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Thong tin goi nho -->
<div class=""goinho"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12"">
                <div class=""thongtin"">
                    <small>Trang chủ > </small>
");
#nullable restore
#line 17 "D:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Tour\ToursByCategory.cshtml"
                     if (cate != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <small>");
#nullable restore
#line 19 "D:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Tour\ToursByCategory.cshtml"
                      Write(cate.Name.ToLower());

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n");
#nullable restore
#line 20 "D:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Tour\ToursByCategory.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
        </div>
    </div>
</div> <!-- the end goi nho -->
<!-- Thong tin khach san -->
<div class=""motakhachsanall"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12"">
");
#nullable restore
#line 31 "D:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Tour\ToursByCategory.cshtml"
                 if (cate != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h2> ");
#nullable restore
#line 33 "D:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Tour\ToursByCategory.cshtml"
                    Write(cate.Name.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
#nullable restore
#line 34 "D:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Tour\ToursByCategory.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
        <div class=""row"">
            <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12"">
                <p class=""danhgia"">Đánh giá:</p>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12"">
");
            WriteLiteral("            </div>\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n\r\n<!--  Demos -->\r\n<div class=\"row1\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 55 "D:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Tour\ToursByCategory.cshtml"
             if (Model != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "D:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Tour\ToursByCategory.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-xs-12 col-sm-6 col-md-4 col-lg-4 item\">\r\n                        <div class=\"thumbnail\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 2318, "\"", 2354, 2);
            WriteAttributeValue("", 2325, "/home/detailtour/", 2325, 17, true);
#nullable restore
#line 61 "D:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Tour\ToursByCategory.cshtml"
WriteAttributeValue("", 2342, item.TourId, 2342, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 2360, "\"", 2408, 2);
            WriteAttributeValue("", 2366, "https://localhost:44384/images/", 2366, 31, true);
#nullable restore
#line 61 "D:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Tour\ToursByCategory.cshtml"
WriteAttributeValue("", 2397, item.Image, 2397, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2409, "\"", 2415, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                            <div class=\"captionbottomimage\">\r\n                                ");
#nullable restore
#line 63 "D:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Tour\ToursByCategory.cshtml"
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
#line 69 "D:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Tour\ToursByCategory.cshtml"
                                                     Write(item.Schedule);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </p>\r\n                                </div>\r\n\r\n                                <div>\r\n                                    <p><span class=\"fa fa-calendar\"></span>&nbsp; Khởi hành: ");
#nullable restore
#line 74 "D:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Tour\ToursByCategory.cshtml"
                                                                                        Write(item.StartDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\r\n\r\n                                <div class=\"detailItem\">\r\n                                    <b class=\"pull-right price\">Giá: ");
#nullable restore
#line 78 "D:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Tour\ToursByCategory.cshtml"
                                                                Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" đ</b>\r\n                                    <p>\r\n                                        <span class=\"fa fa-user book\"></span>\r\n                                        &nbsp;Vé còn: ");
#nullable restore
#line 81 "D:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Tour\ToursByCategory.cshtml"
                                                 Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </p>\r\n                                </div>\r\n\r\n                            </div>\r\n                        </div> <!-- end slide left 2 item 1 -->\r\n                    </div> <!-- the end column1 row 1 -->\r\n");
#nullable restore
#line 88 "D:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Tour\ToursByCategory.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "D:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Tour\ToursByCategory.cshtml"
                 
            }
            else 
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h5 style=\"color: red\">Thông tin tạm thời không có</h5>\r\n");
#nullable restore
#line 93 "D:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Tour\ToursByCategory.cshtml"
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
#line 102 "D:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Tour\ToursByCategory.cshtml"
                 if (Model != null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 104 "D:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Tour\ToursByCategory.cshtml"
                     for (var i = 1; i <= Model.PageCount; i++)
                    {

                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 107 "D:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Tour\ToursByCategory.cshtml"
                         if (page == i)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li  class=\"page-item active\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 4463, "\"", 4522, 4);
            WriteAttributeValue("", 4470, "/tour/toursbycategory/", 4470, 22, true);
#nullable restore
#line 109 "D:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Tour\ToursByCategory.cshtml"
WriteAttributeValue("", 4492, cate.TourCategoriesId, 4492, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4514, "?page=", 4514, 6, true);
#nullable restore
#line 109 "D:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Tour\ToursByCategory.cshtml"
WriteAttributeValue("", 4520, i, 4520, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 109 "D:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Tour\ToursByCategory.cshtml"
                                                                                                                                      Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 110 "D:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Tour\ToursByCategory.cshtml"
                            
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li  class=\"page-item \"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 4723, "\"", 4782, 4);
            WriteAttributeValue("", 4730, "/tour/toursbycategory/", 4730, 22, true);
#nullable restore
#line 114 "D:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Tour\ToursByCategory.cshtml"
WriteAttributeValue("", 4752, cate.TourCategoriesId, 4752, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4774, "?page=", 4774, 6, true);
#nullable restore
#line 114 "D:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Tour\ToursByCategory.cshtml"
WriteAttributeValue("", 4780, i, 4780, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 114 "D:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Tour\ToursByCategory.cshtml"
                                                                                                                                Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a></li>\r\n");
#nullable restore
#line 115 "D:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Tour\ToursByCategory.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 115 "D:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Tour\ToursByCategory.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 116 "D:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Tour\ToursByCategory.cshtml"
                     
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                   <li><h5 style=\"color: red;\">Thông tin không có, vui lòng thử lại sau</h5></li>\r\n");
#nullable restore
#line 121 "D:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Tour\ToursByCategory.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </nav>\r\n    </div>\r\n</div> <!-- the end row 1 -->\r\n");
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
