#pragma checksum "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\News\NewsCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88fe4076f1515e1fd5e06303d5195d02c78aaadf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_News_NewsCategory), @"mvc.1.0.view", @"/Views/News/NewsCategory.cshtml")]
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
#line 1 "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\_ViewImports.cshtml"
using WebClient.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\_ViewImports.cshtml"
using WebClient.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88fe4076f1515e1fd5e06303d5195d02c78aaadf", @"/Views/News/NewsCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"169f23584bdde1d27398dd2e1409d4fef4c01ec3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_News_NewsCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<News>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/hotel.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/flight.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "88fe4076f1515e1fd5e06303d5195d02c78aaadf4470", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "88fe4076f1515e1fd5e06303d5195d02c78aaadf5585", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<!-- Thong tin khach san -->
<div class=""motakhachsan"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12"">
                <h2>Tin T???c</h2>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12"">
                <p class=""danhgia"">????nh gi??:</p>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12"">
                <p class=""tinkhachsan"">Tin t???c Du l???ch - Tin t???c Du l???ch 2022 cung c???p c??c th??ng tin Du l???ch Vi???t Nam, Th??ng tin Du l???ch Th??? Gi???i, c??c S??? ki???n Du l???ch di???n ra trong ng??y. Th??ng qua c??c b??i vi???t ???????c c???p nh???t li??n t???c, du kh??ch c?? th??? n???m b???t th??m ???????c nhi???u th??ng tin h???u ??ch v??? du l???ch.</p>
            </div>
        </div>

    </div>
</div>


<!--  Section -->

<div class=""row1"">
    <div class=""container"">
        <div class=""row"">
            <h5 style=""color:");
            WriteLiteral(" red;\">");
#nullable restore
#line 33 "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\News\NewsCategory.cshtml"
                               Write(ViewBag.ErrorSystem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 34 "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\News\NewsCategory.cshtml"
             if (Model != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\News\NewsCategory.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-xs-12 col-sm-6 col-md-4 col-lg-4\">\r\n                        <div class=\"thumbnail\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1438, "\"", 1470, 2);
            WriteAttributeValue("", 1445, "/news/detail/", 1445, 13, true);
#nullable restore
#line 40 "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\News\NewsCategory.cshtml"
WriteAttributeValue("", 1458, item.NewsId, 1458, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><div><img");
            BeginWriteAttribute("src", " src=\"", 1481, "\"", 1529, 2);
            WriteAttributeValue("", 1487, "https://localhost:44384/images/", 1487, 31, true);
#nullable restore
#line 40 "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\News\NewsCategory.cshtml"
WriteAttributeValue("", 1518, item.Image, 1518, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1530, "\"", 1536, 0);
            EndWriteAttribute();
            WriteLiteral("></div></a>\r\n\r\n                            <div class=\"caption\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1637, "\"", 1669, 2);
            WriteAttributeValue("", 1644, "/news/detail/", 1644, 13, true);
#nullable restore
#line 43 "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\News\NewsCategory.cshtml"
WriteAttributeValue("", 1657, item.NewsId, 1657, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 44 "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\News\NewsCategory.cshtml"
                                     if (@item.Name.Length > 70)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <h4> ");
#nullable restore
#line 46 "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\News\NewsCategory.cshtml"
                                        Write(item.Name.Substring(0, 70));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ...</h4>\r\n");
#nullable restore
#line 47 "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\News\NewsCategory.cshtml"
                                    }
                                    else if (@item.Name.Length < 35)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <h4> ");
#nullable restore
#line 50 "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\News\NewsCategory.cshtml"
                                        Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4><br />\r\n");
#nullable restore
#line 51 "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\News\NewsCategory.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <h4> ");
#nullable restore
#line 54 "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\News\NewsCategory.cshtml"
                                        Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n");
#nullable restore
#line 55 "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\News\NewsCategory.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </a>\r\n                                <div class=\"eye\">\r\n\r\n                                    <p>\r\n                                        <span class=\"fa fa-calendar\"></span>&nbsp;");
#nullable restore
#line 60 "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\News\NewsCategory.cshtml"
                                                                             Write(item.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        &nbsp;&nbsp; &nbsp;<small><span class=\"fa fa-eye\"></span>&nbsp;");
#nullable restore
#line 61 "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\News\NewsCategory.cshtml"
                                                                                                  Write(item.ViewCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                    </p>\r\n\r\n                                </div>\r\n\r\n");
#nullable restore
#line 66 "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\News\NewsCategory.cshtml"
                                 if (@item.Description.Length > 180)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p class=\"content\">\r\n");
            WriteLiteral("                                        ");
#nullable restore
#line 70 "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\News\NewsCategory.cshtml"
                                   Write(item.Description.Substring(0, 180));

#line default
#line hidden
#nullable disable
            WriteLiteral("...\r\n                                    </p>\r\n");
#nullable restore
#line 72 "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\News\NewsCategory.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p class=\"content\">\r\n                                        ");
#nullable restore
#line 76 "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\News\NewsCategory.cshtml"
                                   Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </p>\r\n");
#nullable restore
#line 78 "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\News\NewsCategory.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div> <!-- the end column1 row 1 -->\r\n");
#nullable restore
#line 83 "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\News\NewsCategory.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\News\NewsCategory.cshtml"
                 
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h5 style=\"color: red;\">Th??ng tin kh??ng c?? ch??ng t??i s??? c???p nh???t s???m</h5>\r\n");
#nullable restore
#line 88 "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\News\NewsCategory.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
            WriteLiteral("    </div>\r\n</div> <!-- the end row 1 -->\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<News>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
