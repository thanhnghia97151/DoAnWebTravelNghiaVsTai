#pragma checksum "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Tour\TourModelByTourCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b266cb21fd12a100c97c6e3e9c9431ad3cb23b88"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b266cb21fd12a100c97c6e3e9c9431ad3cb23b88", @"/Views/Tour/TourModelByTourCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"169f23584bdde1d27398dd2e1409d4fef4c01ec3", @"/Views/_ViewImports.cshtml")]
    public class Views_Tour_TourModelByTourCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Tour\TourModelByTourCategory.cshtml"
  
    List<TourCategoryModel> listTour = ViewBag.tour;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Tour\TourModelByTourCategory.cshtml"
 if (listTour != null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Tour\TourModelByTourCategory.cshtml"
     foreach (var item in listTour)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Tour\TourModelByTourCategory.cshtml"
         if (item.Tours.Count() > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"loaikhachsan1\">\r\n                <div class=\"container\">\r\n                    <div class=\"row\">\r\n                        <div class=\"col-xs-12 col-sm-10 col-md-10 col-lg-10\">\r\n                            <h2>");
#nullable restore
#line 15 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Tour\TourModelByTourCategory.cshtml"
                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        </div>\r\n                        <div class=\"col-xs-12 col-sm-2 col-md-2 col-lg-2\">\r\n                            <div class=\"left\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 622, "\"", 673, 2);
            WriteAttributeValue("", 629, "/tour/toursbycategory/", 629, 22, true);
#nullable restore
#line 19 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Tour\TourModelByTourCategory.cshtml"
WriteAttributeValue("", 651, item.TourCategoriesId, 651, 22, false);

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
#line 32 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Tour\TourModelByTourCategory.cshtml"
                                     foreach (var tour in item.Tours)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"item\">\r\n                                            <div class=\"thumbnail\">\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 1535, "\"", 1571, 2);
            WriteAttributeValue("", 1542, "/home/detailtour/", 1542, 17, true);
#nullable restore
#line 36 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Tour\TourModelByTourCategory.cshtml"
WriteAttributeValue("", 1559, tour.TourId, 1559, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 1577, "\"", 1625, 2);
            WriteAttributeValue("", 1583, "https://localhost:44384/images/", 1583, 31, true);
#nullable restore
#line 36 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Tour\TourModelByTourCategory.cshtml"
WriteAttributeValue("", 1614, tour.Image, 1614, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1626, "\"", 1632, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                                                <div class=\"captionbottomimage\">\r\n                                                    ");
#nullable restore
#line 38 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Tour\TourModelByTourCategory.cshtml"
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
#line 44 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Tour\TourModelByTourCategory.cshtml"
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
#line 48 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Tour\TourModelByTourCategory.cshtml"
                                                                                                            Write(tour.StartDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                    </div>\r\n\r\n                                                    <div class=\"detailItem\">\r\n                                                        <b class=\"pull-right price\">Giá: ");
#nullable restore
#line 52 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Tour\TourModelByTourCategory.cshtml"
                                                                                    Write(tour.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" đ</b>\r\n                                                        <p>\r\n                                                            <span class=\"fa fa-user book\"></span>\r\n                                                            &nbsp;Vé còn: ");
#nullable restore
#line 55 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Tour\TourModelByTourCategory.cshtml"
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
#line 62 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Tour\TourModelByTourCategory.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </section>\r\n");
#nullable restore
#line 70 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Tour\TourModelByTourCategory.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Tour\TourModelByTourCategory.cshtml"
         
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Tour\TourModelByTourCategory.cshtml"
     
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
