#pragma checksum "D:\DoAnTaiNghia\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Policy\ChinhSachDatTour.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66dd4d233bff4cc5ba4d1ec3f9d187557cfdf8fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Policy_ChinhSachDatTour), @"mvc.1.0.view", @"/Views/Policy/ChinhSachDatTour.cshtml")]
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
#line 1 "D:\DoAnTaiNghia\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\_ViewImports.cshtml"
using WebClient.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DoAnTaiNghia\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\_ViewImports.cshtml"
using WebClient.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DoAnTaiNghia\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66dd4d233bff4cc5ba4d1ec3f9d187557cfdf8fd", @"/Views/Policy/ChinhSachDatTour.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"169f23584bdde1d27398dd2e1409d4fef4c01ec3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Policy_ChinhSachDatTour : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Policy>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\DoAnTaiNghia\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Policy\ChinhSachDatTour.cshtml"
 if(Model != null){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-12 col-xs-12 col-md-12 col-sm-12\" style=\"margin-top:5%\"> CHÍNH SÁCH ĐẶT TOUR:</div>\r\n            <div class=\"col-lg-12 col-xs-12 col-md-12 col-sm-12\">\r\n                ");
#nullable restore
#line 8 "D:\DoAnTaiNghia\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Policy\ChinhSachDatTour.cshtml"
           Write(Html.Raw(System.Web.HttpUtility.HtmlDecode(@Model[1].Content)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 12 "D:\DoAnTaiNghia\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Policy\ChinhSachDatTour.cshtml"
    
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Policy>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
