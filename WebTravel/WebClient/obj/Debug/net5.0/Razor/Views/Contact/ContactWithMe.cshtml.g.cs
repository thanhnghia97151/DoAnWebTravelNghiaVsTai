#pragma checksum "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Contact\ContactWithMe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c8fa1e3e9a45014aea80441019ea2beadb01206"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_ContactWithMe), @"mvc.1.0.view", @"/Views/Contact/ContactWithMe.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c8fa1e3e9a45014aea80441019ea2beadb01206", @"/Views/Contact/ContactWithMe.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"169f23584bdde1d27398dd2e1409d4fef4c01ec3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Contact_ContactWithMe : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/ordercontact.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Contact\ContactWithMe.cshtml"
  
    var news10hot = (List<News>)ViewBag.news10hot;
    var abouts = (List<About>)ViewBag.abouts;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6c8fa1e3e9a45014aea80441019ea2beadb012064384", async() => {
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
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12"">
                <div class=""thongtin"">
                    <small>Trang chủ > </small>
                    <small>Liên hệ tới chúng tôi</small>
                </div>
            </div>
        </div>
    </div>
</div> <!-- the end goi nho -->
<!-- Section -->
<div class=""lienhechungtoiorder"">
    <div class=""container"">
");
#nullable restore
#line 23 "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Contact\ContactWithMe.cshtml"
         if (abouts != null)
	     {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""row"">
            <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12 text-center"">
                <p class=""contentorderlienhe"">
                    HÃY LIÊN HỆ VỚI CHÚNG TÔI SỚM ĐỂ NẮM RÕ THÔNG TIN HÓA ĐƠN
                </p>
            </div>
            <!-- the end title -->

            <div class=""informationorder"">
                <div class=""row"">
                    <div class=""col-xs-12 col-sm-6 col-md-6 col-lg-6 text-right"">
                        <p>Địa chỉ tòa nhà công ty: </p>
                    </div>
                    <div class=""col-xs-12 col-sm-6 col-md-6 col-lg-6 text-left"">
                        <small class=""aaaa"">");
#nullable restore
#line 39 "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Contact\ContactWithMe.cshtml"
                                       Write(abouts.ElementAtOrDefault(0).Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</small>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-xs-12 col-sm-6 col-md-6 col-lg-6 text-right"">
                        <p>Số điện thoại liên hệ: </p>
                    </div>
                    <div class=""col-xs-12 col-sm-6 col-md-6 col-lg-6 text-left"">
                        <small>");
#nullable restore
#line 47 "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Contact\ContactWithMe.cshtml"
                          Write(abouts.ElementAtOrDefault(0).Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</small>
                    </div>
                </div>

                <div class=""row"">
                    <div class=""col-xs-12 col-sm-6 col-md-6 col-lg-6 text-right"">
                        <p>Thông tin email liên hệ: </p>
                    </div>
                    <div class=""col-xs-12 col-sm-6 col-md-6 col-lg-6 text-left"">
                        <small>");
#nullable restore
#line 56 "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Contact\ContactWithMe.cshtml"
                          Write(abouts.ElementAtOrDefault(0).Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</small>
                    </div>
                </div>
            </div>
            <!-- the end lien he -->

            <div class=""bandolienhe"">
                <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12 text-center"">
                    <iframe");
            BeginWriteAttribute("src", " src=\"", 2538, "\"", 2579, 1);
#nullable restore
#line 64 "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Contact\ContactWithMe.cshtml"
WriteAttributeValue("", 2544, abouts.ElementAtOrDefault(0).Image, 2544, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100%\" height=\"300\" style=\"border:0;\"");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 2624, "\"", 2642, 0);
            EndWriteAttribute();
            WriteLiteral(" loading=\"lazy\"></iframe>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 68 "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Contact\ContactWithMe.cshtml"
	     }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
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
#line 90 "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Contact\ContactWithMe.cshtml"
                         if (news10hot != null)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Contact\ContactWithMe.cshtml"
                             foreach (var news in news10hot)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""item"">
                                    <div class=""row"">
                                        <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12"">
                                            <div class=""thumbnail"">
                                                <img");
            BeginWriteAttribute("src", " src=\"", 3802, "\"", 3850, 2);
            WriteAttributeValue("", 3808, "https://localhost:44384/images/", 3808, 31, true);
#nullable restore
#line 98 "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Contact\ContactWithMe.cshtml"
WriteAttributeValue("", 3839, news.Image, 3839, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3851, "\"", 3857, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <div class=\"caption\">\r\n\r\n");
#nullable restore
#line 101 "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Contact\ContactWithMe.cshtml"
                                                     if (news.Name.Length > 65)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <h4>");
#nullable restore
#line 103 "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Contact\ContactWithMe.cshtml"
                                                       Write(news.Name.Substring(0, 65));

#line default
#line hidden
#nullable disable
            WriteLiteral("...</h4>\r\n");
#nullable restore
#line 104 "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Contact\ContactWithMe.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <h4>");
#nullable restore
#line 107 "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Contact\ContactWithMe.cshtml"
                                                       Write(news.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n");
#nullable restore
#line 108 "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Contact\ContactWithMe.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                                    <div class=\"eye\">\r\n                                                        <p>\r\n                                                            <span class=\"fa fa-calendar\"></span>&nbsp; ");
#nullable restore
#line 113 "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Contact\ContactWithMe.cshtml"
                                                                                                  Write(news.ModifiedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                            &nbsp;&nbsp; &nbsp;<small><span class=\"fa fa-eye\"></span>&nbsp;");
#nullable restore
#line 114 "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Contact\ContactWithMe.cshtml"
                                                                                                                      Write(news.ViewCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                                        </p>\r\n                                                    </div>\r\n\r\n\r\n");
#nullable restore
#line 119 "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Contact\ContactWithMe.cshtml"
                                                     if (news.Description.Length > 145)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <p>");
#nullable restore
#line 121 "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Contact\ContactWithMe.cshtml"
                                                      Write(news.Description.Substring(0, 145).ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("...</p>\r\n");
#nullable restore
#line 122 "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Contact\ContactWithMe.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <p>");
#nullable restore
#line 125 "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Contact\ContactWithMe.cshtml"
                                                      Write(news.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 126 "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Contact\ContactWithMe.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                                </div>\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 134 "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Contact\ContactWithMe.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 134 "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Contact\ContactWithMe.cshtml"
                             
                        }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
