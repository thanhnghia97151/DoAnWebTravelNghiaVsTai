#pragma checksum "D:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Tour\TourModelByTourCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e7c6ff6115cd5529159329e0e557f0274458950"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tour_TourModelByTourCategory), @"mvc.1.0.view", @"/Views/Tour/TourModelByTourCategory.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e7c6ff6115cd5529159329e0e557f0274458950", @"/Views/Tour/TourModelByTourCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"169f23584bdde1d27398dd2e1409d4fef4c01ec3", @"/Views/_ViewImports.cshtml")]
    public class Views_Tour_TourModelByTourCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Tour\TourModelByTourCategory.cshtml"
  
    List<TourCategoryModel> listTour = ViewBag.tour;

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
                    <small>Trang chủ > </small>
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
");
#nullable restore
#line 24 "D:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Tour\TourModelByTourCategory.cshtml"
                 if (ViewBag.parent != null)
                {
                    var parent = ViewBag.parent;

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h2> ");
#nullable restore
#line 27 "D:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Tour\TourModelByTourCategory.cshtml"
                    Write(parent.Name.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
#nullable restore
#line 28 "D:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Tour\TourModelByTourCategory.cshtml"
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
            WriteLiteral("            </div>\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n<hr />\r\n<br />\r\n\r\n");
#nullable restore
#line 47 "D:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Tour\TourModelByTourCategory.cshtml"
 if (listTour != null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "D:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Tour\TourModelByTourCategory.cshtml"
     foreach (var item in listTour)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "D:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Tour\TourModelByTourCategory.cshtml"
         if (item.Tours.Count() > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"loaikhachsan1\">\r\n                <div class=\"container\">\r\n                    <div class=\"row\">\r\n                        <div class=\"col-xs-12 col-sm-10 col-md-10 col-lg-10\">\r\n                            <h2>");
#nullable restore
#line 57 "D:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Tour\TourModelByTourCategory.cshtml"
                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        </div>\r\n                        <div class=\"col-xs-12 col-sm-2 col-md-2 col-lg-2\">\r\n                            <div class=\"left\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2346, "\"", 2397, 2);
            WriteAttributeValue("", 2353, "/tour/toursbycategory/", 2353, 22, true);
#nullable restore
#line 61 "D:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Tour\TourModelByTourCategory.cshtml"
WriteAttributeValue("", 2375, item.TourCategoriesId, 2375, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><span class=""fa fa-eye"">&nbsp;&nbsp;</span>Xem tất cả</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div> <!-- the end loaikhachsan1 -->
            <!--  Demos -->
            <section>
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12"">
                            <div class=""large-10 columns"">
                                <div class=""owl-carousel owl-theme"">
");
#nullable restore
#line 74 "D:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Tour\TourModelByTourCategory.cshtml"
                                     foreach (var tour in item.Tours)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"item\">\r\n                                            <div class=\"thumbnail\">\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 3259, "\"", 3295, 2);
            WriteAttributeValue("", 3266, "/home/detailtour/", 3266, 17, true);
#nullable restore
#line 78 "D:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Tour\TourModelByTourCategory.cshtml"
WriteAttributeValue("", 3283, tour.TourId, 3283, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 3301, "\"", 3349, 2);
            WriteAttributeValue("", 3307, "https://localhost:44384/images/", 3307, 31, true);
#nullable restore
#line 78 "D:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Tour\TourModelByTourCategory.cshtml"
WriteAttributeValue("", 3338, tour.Image, 3338, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3350, "\"", 3356, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                                                <div class=\"captionbottomimage\">\r\n                                                    ");
#nullable restore
#line 80 "D:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Tour\TourModelByTourCategory.cshtml"
                                               Write(tour.MetaTitle);

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
#line 86 "D:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Tour\TourModelByTourCategory.cshtml"
                                                                         Write(tour.Schedule);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                        </p>
                                                    </div>
                                                    <div>
                                                        <p><span class=""fa fa-calendar""></span>&nbsp; Khởi hành: ");
#nullable restore
#line 90 "D:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Tour\TourModelByTourCategory.cshtml"
                                                                                                            Write(tour.StartDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                    </div>\r\n\r\n                                                    <div class=\"detailItem\">\r\n                                                        <b class=\"pull-right price\">Giá: ");
#nullable restore
#line 94 "D:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Tour\TourModelByTourCategory.cshtml"
                                                                                    Write(tour.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" đ</b>\r\n                                                        <p>\r\n                                                            <span class=\"fa fa-user book\"></span>\r\n                                                            &nbsp;Vé còn: ");
#nullable restore
#line 97 "D:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Tour\TourModelByTourCategory.cshtml"
                                                                     Write(tour.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                        </p>
                                                    </div>

                                                </div>
                                            </div> <!-- end slide left 2 item 1 -->
                                        </div>
");
#nullable restore
#line 104 "D:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Tour\TourModelByTourCategory.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </section>\r\n");
#nullable restore
#line 112 "D:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Tour\TourModelByTourCategory.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 112 "D:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Tour\TourModelByTourCategory.cshtml"
         
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 113 "D:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Tour\TourModelByTourCategory.cshtml"
     
}
else 
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h5 style=\"color: red;\">Tour không tồn tại, vui lòng thử lại sau</h5>\r\n");
#nullable restore
#line 118 "D:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Tour\TourModelByTourCategory.cshtml"
}

#line default
#line hidden
#nullable disable
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
