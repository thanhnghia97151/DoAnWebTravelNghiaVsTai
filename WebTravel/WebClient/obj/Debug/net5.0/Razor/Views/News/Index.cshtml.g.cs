#pragma checksum "D:\DoAn_Tai_vs_Nghia\WebTravel\WebClient\Views\News\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ea3990633e3b871f751aee7191791e0210ce806"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_News_Index), @"mvc.1.0.view", @"/Views/News/Index.cshtml")]
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
#line 1 "D:\DoAn_Tai_vs_Nghia\WebTravel\WebClient\Views\_ViewImports.cshtml"
using WebClient.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DoAn_Tai_vs_Nghia\WebTravel\WebClient\Views\_ViewImports.cshtml"
using WebClient.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ea3990633e3b871f751aee7191791e0210ce806", @"/Views/News/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b8fad72161a928ca3d5d332110946d494b91cc1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_News_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<News>>
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
#nullable restore
#line 2 "D:\DoAn_Tai_vs_Nghia\WebTravel\WebClient\Views\News\Index.cshtml"
   int p = ViewContext.RouteData.Values["id"] != null ? Convert.ToInt32(ViewContext.RouteData.Values["id"]) : 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4ea3990633e3b871f751aee7191791e0210ce8064433", async() => {
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
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4ea3990633e3b871f751aee7191791e0210ce8065552", async() => {
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
           <h2>Tin Tức</h2>
         </div>
       </div>
        <div class=""row"">
         <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12"">
           <p class=""danhgia"">Đánh giá:</p>
         </div>
       </div>
        <div class=""row"">
         <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12"">
           <p class=""tinkhachsan"">Tin tức Du lịch - Tin tức Du lịch 2022 cung cấp các thông tin Du lịch Việt Nam, Thông tin Du lịch Thế Giới, các Sự kiện Du lịch diễn ra trong ngày. Thông qua các bài viết được cập nhật liên tục, du khách có thể nắm bắt thêm được nhiều thông tin hữu ích về du lịch.</p>
         </div>
       </div>

       <!-- <div class=""row hanglienhe"">
         <div class=""col-xs-12 col-sm-4 col-md-4 col-lg-4"">
           <p class=""social""><i class=""fa fa-facebook""></i><a href=""faceb");
            WriteLiteral(@"ook.com"">liên hệ facebook</a></p>
         </div>
         <div class=""col-xs-12 col-sm-4 col-md-4 col-lg-4"">
           <p class=""social""><i class=""fa fa-envelope""></i><a href=""facebook.com"">liên hệ email</a></p>
         </div>
         <div class=""col-xs-12 col-sm-4 col-md-4 col-lg-4 lienhe"">
           <a href=""£"" class=""btn btn-info"">LIÊN HỆ ĐẶT VÉ MÁY BAY</a>
         </div>
       </div> -->
     </div>
   </div>

   

    <!--  Section -->
    
    <div class=""row1"">
      <div class=""container"">
      <div class=""row"">
");
#nullable restore
#line 46 "D:\DoAn_Tai_vs_Nghia\WebTravel\WebClient\Views\News\Index.cshtml"
           foreach (var item in Model)
         {

#line default
#line hidden
#nullable disable
            WriteLiteral("             <div class=\"col-xs-12 col-sm-6 col-md-4 col-lg-4\"  >\r\n               <div class=\"thumbnail\">\r\n                   <a");
            BeginWriteAttribute("href", " href=\"", 1996, "\"", 2028, 2);
            WriteAttributeValue("", 2003, "/news/detail/", 2003, 13, true);
#nullable restore
#line 50 "D:\DoAn_Tai_vs_Nghia\WebTravel\WebClient\Views\News\Index.cshtml"
WriteAttributeValue("", 2016, item.NewsId, 2016, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><div><img");
            BeginWriteAttribute("src", " src=\"", 2039, "\"", 2087, 2);
            WriteAttributeValue("", 2045, "https://localhost:44384/images/", 2045, 31, true);
#nullable restore
#line 50 "D:\DoAn_Tai_vs_Nghia\WebTravel\WebClient\Views\News\Index.cshtml"
WriteAttributeValue("", 2076, item.Image, 2076, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2088, "\"", 2094, 0);
            EndWriteAttribute();
            WriteLiteral("></div></a>\r\n                 \r\n                 <div class=\"caption\">\r\n                   <a");
            BeginWriteAttribute("href", " href=\"", 2188, "\"", 2220, 2);
            WriteAttributeValue("", 2195, "/news/detail/", 2195, 13, true);
#nullable restore
#line 53 "D:\DoAn_Tai_vs_Nghia\WebTravel\WebClient\Views\News\Index.cshtml"
WriteAttributeValue("", 2208, item.NewsId, 2208, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><h4>");
            WriteLiteral(" ");
#nullable restore
#line 53 "D:\DoAn_Tai_vs_Nghia\WebTravel\WebClient\Views\News\Index.cshtml"
                                                                                                                                 Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></a>\r\n                   <div class=\"eye\">\r\n                        \r\n                            <p><span class=\"fa fa-calendar\"></span>&nbsp; ");
            WriteLiteral(" ");
#nullable restore
#line 56 "D:\DoAn_Tai_vs_Nghia\WebTravel\WebClient\Views\News\Index.cshtml"
                                                                                   Write(item.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            &nbsp;&nbsp; &nbsp;<small><span class=\"fa fa-eye\"></span>&nbsp;5000</small>\r\n                            </p>\r\n\r\n                            </div>\r\n\r\n                   <p class=\"content\">\r\n");
            WriteLiteral("                    ");
#nullable restore
#line 64 "D:\DoAn_Tai_vs_Nghia\WebTravel\WebClient\Views\News\Index.cshtml"
               Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n                 </p>\r\n               \r\n                 </div>\r\n               </div>\r\n             </div> <!-- the end column1 row 1 -->\r\n");
#nullable restore
#line 70 "D:\DoAn_Tai_vs_Nghia\WebTravel\WebClient\Views\News\Index.cshtml"
         }

#line default
#line hidden
#nullable disable
            WriteLiteral("         \r\n");
            WriteLiteral("       \r\n      </div>\r\n\r\n      <nav aria-label=\"Page navigation example\">\r\n  <ul class=\"pagination justify-content-center\">\r\n      <li class=\"page-item disabled\">\r\n      <a class=\"page-link\" href=\"#\" tabindex=\"-1\">Previous</a>\r\n    </li>\r\n");
#nullable restore
#line 240 "D:\DoAn_Tai_vs_Nghia\WebTravel\WebClient\Views\News\Index.cshtml"
                 for(int i =1 ; i <= ViewBag.total; i++)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 242 "D:\DoAn_Tai_vs_Nghia\WebTravel\WebClient\Views\News\Index.cshtml"
                     if(p == i)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"page-item active\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 10652, "\"", 10673, 2);
            WriteAttributeValue("", 10659, "/news/index/", 10659, 12, true);
#nullable restore
#line 244 "D:\DoAn_Tai_vs_Nghia\WebTravel\WebClient\Views\News\Index.cshtml"
WriteAttributeValue("", 10671, i, 10671, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 244 "D:\DoAn_Tai_vs_Nghia\WebTravel\WebClient\Views\News\Index.cshtml"
                                                                                           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 245 "D:\DoAn_Tai_vs_Nghia\WebTravel\WebClient\Views\News\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 10826, "\"", 10847, 2);
            WriteAttributeValue("", 10833, "/news/index/", 10833, 12, true);
#nullable restore
#line 248 "D:\DoAn_Tai_vs_Nghia\WebTravel\WebClient\Views\News\Index.cshtml"
WriteAttributeValue("", 10845, i, 10845, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 248 "D:\DoAn_Tai_vs_Nghia\WebTravel\WebClient\Views\News\Index.cshtml"
                                                                                    Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 249 "D:\DoAn_Tai_vs_Nghia\WebTravel\WebClient\Views\News\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 249 "D:\DoAn_Tai_vs_Nghia\WebTravel\WebClient\Views\News\Index.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </ul>\r\n</nav>\r\n    </div>\r\n    </div> <!-- the end row 1 -->\r\n    \r\n   ");
        }
        #pragma warning restore 1998
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
