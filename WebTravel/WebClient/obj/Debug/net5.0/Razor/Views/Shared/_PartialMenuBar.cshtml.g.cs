#pragma checksum "D:\DoAn_Tai_vs_Nghia\WebTravel\WebClient\Views\Shared\_PartialMenuBar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5df28d55172dcebfa517772a67596b4d3494f43c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PartialMenuBar), @"mvc.1.0.view", @"/Views/Shared/_PartialMenuBar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5df28d55172dcebfa517772a67596b4d3494f43c", @"/Views/Shared/_PartialMenuBar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b8fad72161a928ca3d5d332110946d494b91cc1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__PartialMenuBar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/logo6.PNG"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<div>\r\n      <nav class=\"navbar navbar-default menutop\" role=\"navigation\">\r\n      <div class=\"container\">\r\n         <!-- Brand and toggle get grouped for better mobile display -->\r\n         <div class=\"navbar-header sizemin\"");
            BeginWriteAttribute("style", " style=\"", 224, "\"", 232, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            <button type=""button"" class=""navbar-toggle"" data-toggle=""collapse"" data-target="".navbar-ex1-collapse"">
               <span class=""sr-only"">Toggle navigation</span>
               <span class=""icon-bar""></span>
               <span class=""icon-bar""></span>
               <span class=""icon-bar""></span>
            </button>
            <div>
              <a class=""navbar-brand"" href=""/home"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5df28d55172dcebfa517772a67596b4d3494f43c5025", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</a>
            </div>
         </div>
   
         <!-- Collect the nav links, forms, and other content for toggling -->
         <div class=""collapse navbar-collapse navbar-ex1-collapse"">
            <ul class=""nav navbar-nav navbar-right"">
               <li class=""dropdown"">
                <a href=""#"" class=""dropdown-toggle downmenu"" data-toggle=""dropdown""
                  role=""button"" aria-haspopup=""true"" aria-expanded=""false"">
                DU LỊCH
                </a>
                <ul class=""dropdown-menu"">
");
#nullable restore
#line 28 "D:\DoAn_Tai_vs_Nghia\WebTravel\WebClient\Views\Shared\_PartialMenuBar.cshtml"
                       
                                IEnumerable<TypeOfTour> listTypeOfTour = ViewData["TypeTour"] as IEnumerable<TypeOfTour>;
                                IEnumerable<NewsCategory> listNewsCate = ViewData["NewsCate"] as IEnumerable<NewsCategory>;
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 33 "D:\DoAn_Tai_vs_Nghia\WebTravel\WebClient\Views\Shared\_PartialMenuBar.cshtml"
                                              foreach (TypeOfTour item in listTypeOfTour)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 1855, "\"", 1887, 2);
            WriteAttributeValue("", 1862, "/tour/typeoftour/", 1862, 17, true);
#nullable restore
#line 35 "D:\DoAn_Tai_vs_Nghia\WebTravel\WebClient\Views\Shared\_PartialMenuBar.cshtml"
WriteAttributeValue("", 1879, item.Id, 1879, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 35 "D:\DoAn_Tai_vs_Nghia\WebTravel\WebClient\Views\Shared\_PartialMenuBar.cshtml"
                                                                       Write(item.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 36 "D:\DoAn_Tai_vs_Nghia\WebTravel\WebClient\Views\Shared\_PartialMenuBar.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                           
                </ul>
              </li>
               <li><a href=""/contact"">LIÊN HỆ</a></li>
               <li class=""dropdown"">
                  <a href=""#"" class=""dropdown-toggle downmenu"" data-toggle=""dropdown""
                  role=""button"" aria-haspopup=""true"" aria-expanded=""false"">TIN TỨC</a>
                  <ul class=""dropdown-menu"">

");
#nullable restore
#line 53 "D:\DoAn_Tai_vs_Nghia\WebTravel\WebClient\Views\Shared\_PartialMenuBar.cshtml"
                      foreach (var item in listNewsCate)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2832, "\"", 2878, 2);
            WriteAttributeValue("", 2839, "/news/newscategory/", 2839, 19, true);
#nullable restore
#line 55 "D:\DoAn_Tai_vs_Nghia\WebTravel\WebClient\Views\Shared\_PartialMenuBar.cshtml"
WriteAttributeValue("", 2858, item.NewsCategoryId, 2858, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 55 "D:\DoAn_Tai_vs_Nghia\WebTravel\WebClient\Views\Shared\_PartialMenuBar.cshtml"
                                                                         Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 56 "D:\DoAn_Tai_vs_Nghia\WebTravel\WebClient\Views\Shared\_PartialMenuBar.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                  </ul>\r\n               </li>\r\n               <li class=\"dropdown\">\r\n                  <a href=\"#\" class=\"dropdown-toggle\" data-toggle=\"dropdown\">GIỚI THIỆU</a>\r\n                  <ul class=\"dropdown-menu\">\r\n");
#nullable restore
#line 62 "D:\DoAn_Tai_vs_Nghia\WebTravel\WebClient\Views\Shared\_PartialMenuBar.cshtml"
                             if (User.Identity.IsAuthenticated)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <li><a href=""/introduce"">Giới Thiệu Doanh Nghiệp</a></li>
                                <li><a href=""/contact/contactwithme"">Liên hệ với tôi</a></li>
                                <li><a href=""/auth/changepassword"">Thay đổi mật khẩu</a></li>
                                <li><a href=""/dashboard""><small>Dashboard</small></a></li>
");
#nullable restore
#line 68 "D:\DoAn_Tai_vs_Nghia\WebTravel\WebClient\Views\Shared\_PartialMenuBar.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <li><a href=""/introduce""><small>Giới Thiệu Doanh Nghiệp</small></a></li>
                                <li><a href=""/contact/contactwithme"">Liên hệ với tôi</a></li>
                    <li><a href=""/auth/register""><small>Register</small></a></li>
                        <li><a href=""/auth/login""><small>Login</small></a></li>
");
#nullable restore
#line 75 "D:\DoAn_Tai_vs_Nghia\WebTravel\WebClient\Views\Shared\_PartialMenuBar.cshtml"
                                
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            
                  </ul>
               </li>

               <li class=""dropdown"">
                  <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"">NGÔN NGỮ</a>
                  <ul class=""dropdown-menu"">
                     <li><a href=""#"">Vietnamese</a></li>
                     <li><a href=""#"">English</a></li>
                  </ul>
               </li>
            </ul>
            
         </div><!-- /.navbar-collapse -->
      </div>
   </nav> <!-- end menu -->
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
