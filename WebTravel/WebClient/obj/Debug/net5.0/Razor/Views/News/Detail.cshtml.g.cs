#pragma checksum "E:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\News\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65482b2f0ac0268a673a266a50f99f5190bf871c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_News_Detail), @"mvc.1.0.view", @"/Views/News/Detail.cshtml")]
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
#line 1 "E:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\_ViewImports.cshtml"
using WebClient.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\_ViewImports.cshtml"
using WebClient.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65482b2f0ac0268a673a266a50f99f5190bf871c", @"/Views/News/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"169f23584bdde1d27398dd2e1409d4fef4c01ec3", @"/Views/_ViewImports.cshtml")]
    public class Views_News_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<News>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/detailnews.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/catenews360.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("360"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("new image360"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/catenewsbia.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/catenews1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("news1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("new"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "E:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\News\Detail.cshtml"
  
    List<News> news10hot = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "65482b2f0ac0268a673a266a50f99f5190bf871c6631", async() => {
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
                    <small>Trang chủ > </small>
                    <small>Cam nang du lich</small>
                    <small>Vietravel Airlines khai trương các đường bay mới kết nối nhiều tỉnh, thành phố trong cả nước</small>
                </div>
            </div>
        </div>
    </div>
</div> <!-- the end goi nho -->
<!-- Thong tin ch tiet bai viet -->
<div class=""baiviet"">
    <div class=""container"">
        <div class=""row"">
            <h5 style=""color: red;"">");
#nullable restore
#line 25 "E:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\News\Detail.cshtml"
                               Write(ViewBag.ErrorSystem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <div class=\"col-xs-12 col-sm-12 col-md-8 col-lg-8\">\r\n                <div class=\"titlenews\">\r\n");
#nullable restore
#line 28 "E:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\News\Detail.cshtml"
                     if (Model != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "E:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\News\Detail.cshtml"
                   Write(Model.Name);

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "E:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\News\Detail.cshtml"
                                   
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <div class=\"descriptionnews\">\r\n");
#nullable restore
#line 34 "E:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\News\Detail.cshtml"
                     if (Model != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "E:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\News\Detail.cshtml"
                   Write(Html.Raw(System.Web.HttpUtility.HtmlDecode(Model.Detail)));

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "E:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\News\Detail.cshtml"
                                                                                  
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div >\r\n");
            WriteLiteral(@"                <!-- the one conten -->
            </div>
            <!-- the end left -->

            <div class=""col-xs-12 col-sm-12 col-md-4 col-lg-4"">
                <div class=""tongtoptrainghiem"">
                    <div class=""col-xs-7 col-sm-7 col-md-7 col-lg-7 trainghiem"">
                        TRẢI NGHIỆM 360
                    </div>

                    <div class=""col-xs-5 col-sm-5 col-md-5 col-lg-5 gachngangtrainghiem"">
                        <p></p>
                    </div>
                </div>

                <!-- the end top bai viet -->

                <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "65482b2f0ac0268a673a266a50f99f5190bf871c11111", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-xs-12 col-sm-12 col-md-12 col-lg-12\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "65482b2f0ac0268a673a266a50f99f5190bf871c12430", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <!-- the end image right -->


                <div class=""totinquantam row"">
                    <div class=""col-xs-6 col-sm-6 col-md-6 col-lg-6 quantam"">
                        TIN ĐƯỢC QUAN TÂM
                    </div>

                    <div class=""col-xs-6 col-sm-6 col-md-6 col-lg-6 gachngangquantam"">
                        <p></p>
                    </div>
                </div>


                <!-- the end top bai viet quan tam -->


                <div class=""noidungquantam"">
                    <div class=""col-xs-4 col-sm-4 col-md-4 col-lg-4"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "65482b2f0ac0268a673a266a50f99f5190bf871c14289", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>

                    <!-- left -->

                    <div class=""col-xs-8 col-sm-8 col-md-8 col-lg-8"">
                        <div class=""titletinquantam"">
                            Trở lại Thái Lan – vi vu khám phá theo cách riêng của bạn
                        </div>

                        <div class=""hourtinquantam"">
                            <p><span class=""fa fa-history"">&nbsp;</span>11/2/2021</p>
                        </div>
                    </div>
                    <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12 gachduoi"">
                        <p></p>
                    </div>
                </div>
                <div class=""noidungquantam"">
                    <div class=""col-xs-4 col-sm-4 col-md-4 col-lg-4"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "65482b2f0ac0268a673a266a50f99f5190bf871c16325", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>

                    <!-- left -->

                    <div class=""col-xs-8 col-sm-8 col-md-8 col-lg-8"">
                        <div class=""titletinquantam"">
                            Trở lại Thái Lan – vi vu khám phá theo cách riêng của bạn
                        </div>

                        <div class=""hourtinquantam"">
                            <p><span class=""fa fa-history"">&nbsp;</span>11/2/2021</p>
                        </div>
                    </div>
                    <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12 gachduoi"">
                        <p></p>
                    </div>
                </div>

                <!-- the end tin quan tam -->
            </div>
            <!-- the end right -->

        </div>
    </div>
</div>


<!-- infor relation -->
<div class=""thongtinlienquan"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12"">
           ");
            WriteLiteral(@"     <h3>THÔNG TIN NỔI BẬT</h3>
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
#line 195 "E:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\News\Detail.cshtml"
                         if (news10hot != null)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 197 "E:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\News\Detail.cshtml"
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
            BeginWriteAttribute("src", " src=\"", 9395, "\"", 9443, 2);
            WriteAttributeValue("", 9401, "https://localhost:44384/images/", 9401, 31, true);
#nullable restore
#line 203 "E:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\News\Detail.cshtml"
WriteAttributeValue("", 9432, news.Image, 9432, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 9444, "\"", 9450, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <div class=\"caption\">\r\n\r\n");
#nullable restore
#line 206 "E:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\News\Detail.cshtml"
                                                     if (news.Name.Length > 65)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <h4>");
#nullable restore
#line 208 "E:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\News\Detail.cshtml"
                                                       Write(news.Name.Substring(0, 65));

#line default
#line hidden
#nullable disable
            WriteLiteral("...</h4>\r\n");
#nullable restore
#line 209 "E:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\News\Detail.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <h4>");
#nullable restore
#line 212 "E:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\News\Detail.cshtml"
                                                       Write(news.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n");
#nullable restore
#line 213 "E:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\News\Detail.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                                    <div class=\"eye\">\r\n                                                        <p>\r\n                                                            <span class=\"fa fa-calendar\"></span>&nbsp; ");
#nullable restore
#line 218 "E:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\News\Detail.cshtml"
                                                                                                  Write(news.ModifiedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                            &nbsp;&nbsp; &nbsp;<small><span class=\"fa fa-eye\"></span>&nbsp;");
#nullable restore
#line 219 "E:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\News\Detail.cshtml"
                                                                                                                      Write(news.ViewCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                                        </p>\r\n                                                    </div>\r\n\r\n\r\n");
#nullable restore
#line 224 "E:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\News\Detail.cshtml"
                                                     if (news.Description.Length > 145)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <p>");
#nullable restore
#line 226 "E:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\News\Detail.cshtml"
                                                      Write(news.Description.Substring(0, 145).ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("...</p>\r\n");
#nullable restore
#line 227 "E:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\News\Detail.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <p>");
#nullable restore
#line 230 "E:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\News\Detail.cshtml"
                                                      Write(news.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 231 "E:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\News\Detail.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                                </div>\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 239 "E:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\News\Detail.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 239 "E:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\News\Detail.cshtml"
                             
                        }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<News> Html { get; private set; }
    }
}
#pragma warning restore 1591
