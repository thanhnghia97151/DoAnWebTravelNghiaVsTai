#pragma checksum "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Introduce\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2a252b7225ead372d28f24d69b1181152cef606"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Introduce_Index), @"mvc.1.0.view", @"/Views/Introduce/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2a252b7225ead372d28f24d69b1181152cef606", @"/Views/Introduce/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b8fad72161a928ca3d5d332110946d494b91cc1", @"/Views/_ViewImports.cshtml")]
    public class Views_Introduce_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/introduce.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Introduce\Index.cshtml"
  
    var news10host = (List<News>)ViewBag.news10hot;
    var abouts = (List<About>)ViewBag.abouts;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f2a252b7225ead372d28f24d69b1181152cef6064121", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<!-- Thong tin goi nho -->
<div class=""goinho"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12"">
                <div class=""thongtin"">
                    <small>Trang chủ > </small><small>Giới thiệu về doanh nghiệp</small>
                </div>
            </div>
        </div>
    </div>
</div> <!-- the end goi nho -->
<!-- Thong tin khach san -->
<!-- Thong tin khach san -->
<div class=""motakhachsan"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12"">
                <h2>Giới thiệu</h2>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12"">
                <p class=""tinkhachsan"">CÔNG TY CỔ PHẦN DU LỊCH VIỆT NAM</p>
            </div>
        </div>
    </div>
</div>

<!--  Section -->
<div class=""gioithieu"">
    <div class=""container"">
        <div class=""row"">
 ");
            WriteLiteral("           <div class=\"aboutcompany\">\r\n");
#nullable restore
#line 41 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Introduce\Index.cshtml"
                 if(abouts != null)
                {
                   

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Introduce\Index.cshtml"
              Write(Html.Raw(System.Web.HttpUtility.HtmlDecode(@abouts.ElementAtOrDefault(0).Detail)));

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Introduce\Index.cshtml"
                                                                                                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div class=\"col-xs-12 col-sm-12 col-md-12 col-lg-12 khoangcach\">\r\n                <iframe");
            BeginWriteAttribute("src", " src=\"", 1521, "\"", 1562, 1);
#nullable restore
#line 47 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Introduce\Index.cshtml"
WriteAttributeValue("", 1527, abouts.ElementAtOrDefault(0).Image, 1527, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100%\" height=\"330\" style=\"border:0;\"");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 1607, "\"", 1625, 0);
            EndWriteAttribute();
            WriteLiteral(@" loading=""lazy""></iframe>
            </div>
        </div>
    </div>
</div>

<!-- infor relation -->
<div class=""thongtinlienquan"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12"">
                <h3>THÔNG TIN NỔI BẬT</h3>
            </div>
        </div>
    </div>
</div>

<!-- content relation -->
<section>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12"">
                <div class=""large-12 columns"">
                    <div class=""owl-carousel owl-theme"">
");
#nullable restore
#line 71 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Introduce\Index.cshtml"
                         if (news10host != null)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Introduce\Index.cshtml"
                             foreach (var news in news10host)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""item"">
                                    <div class=""row"">
                                        <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12"">
                                            <div class=""thumbnail"">
                                                <img");
            BeginWriteAttribute("src", " src=\"", 2754, "\"", 2803, 2);
            WriteAttributeValue("", 2760, "https://localhost:44384/images//", 2760, 32, true);
#nullable restore
#line 79 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Introduce\Index.cshtml"
WriteAttributeValue("", 2792, news.Image, 2792, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2804, "\"", 2810, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <div class=\"caption\">\r\n");
#nullable restore
#line 81 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Introduce\Index.cshtml"
                                                         if (news.Name.Length > 65)
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <h4>");
#nullable restore
#line 83 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Introduce\Index.cshtml"
                                                           Write(news.Name.Substring(0, 65));

#line default
#line hidden
#nullable disable
            WriteLiteral(";...</h4>\r\n");
#nullable restore
#line 84 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Introduce\Index.cshtml"
                                                        }
                                                        else
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <h4>");
#nullable restore
#line 87 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Introduce\Index.cshtml"
                                                           Write(news.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n");
#nullable restore
#line 88 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Introduce\Index.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <div class=\"eye\">\r\n                                                        <p>\r\n                                                            <span class=\"fa fa-calendar\"></span>&nbsp; ");
#nullable restore
#line 91 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Introduce\Index.cshtml"
                                                                                                  Write(news.ModifiedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                            &nbsp;&nbsp; &nbsp;<small><span class=\"fa fa-eye\"></span>&nbsp;");
#nullable restore
#line 92 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Introduce\Index.cshtml"
                                                                                                                      Write(news.ViewCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                                        </p>\r\n                                                    </div>\r\n");
#nullable restore
#line 95 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Introduce\Index.cshtml"
                                                         if (news.Description.Length > 145)
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <p>");
#nullable restore
#line 97 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Introduce\Index.cshtml"
                                                          Write(news.Description.Substring(0, 145));

#line default
#line hidden
#nullable disable
            WriteLiteral(";...</p>\r\n");
#nullable restore
#line 98 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Introduce\Index.cshtml"
                                                        }
                                                        else
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <p>");
#nullable restore
#line 101 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Introduce\Index.cshtml"
                                                          Write(news.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 102 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Introduce\Index.cshtml"
                                                        }                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                </div>\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 108 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Introduce\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 108 "F:\Khoa_Luan_Tot_Nghiep\CodeSourceFull\WebTravel\WebClient\Views\Introduce\Index.cshtml"
                             
                        }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
