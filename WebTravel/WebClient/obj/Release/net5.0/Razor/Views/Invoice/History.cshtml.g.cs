#pragma checksum "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Invoice\History.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a83c0c47a034fe071e7b6b9e33272b5eba5b7603"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Invoice_History), @"mvc.1.0.view", @"/Views/Invoice/History.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a83c0c47a034fe071e7b6b9e33272b5eba5b7603", @"/Views/Invoice/History.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"169f23584bdde1d27398dd2e1409d4fef4c01ec3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Invoice_History : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<InvoiceModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Invoice\History.cshtml"
 if (Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12"">
                <table class=""table table-bordered"">
                    <thead class=""table-dark"">
                        <tr>
                            <th>Id</th>
                            <th>Image</th>
                            <th>Name Tour</th>
                            <th>Price</th>
                            <th>Quantity</th>
                            <th>Thanh to??n</th>
                            <th>H???y</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 22 "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Invoice\History.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 25 "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Invoice\History.cshtml"
                               Write(item.InvoiceId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td><img");
            BeginWriteAttribute("src", " src=\"", 928, "\"", 981, 2);
            WriteAttributeValue("", 934, "https://localhost:44384/images/", 934, 31, true);
#nullable restore
#line 26 "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Invoice\History.cshtml"
WriteAttributeValue("", 965, item.Tour.Image, 965, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"70\" /> </td>\r\n                                <td>");
#nullable restore
#line 27 "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Invoice\History.cshtml"
                               Write(item.Tour.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 28 "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Invoice\History.cshtml"
                               Write(item.Price.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("vi-VN")));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 29 "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Invoice\History.cshtml"
                               Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 30 "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Invoice\History.cshtml"
                                 if(item.Status){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td><small>???? thanh to??n</small></td>\r\n                                    <td></td>\r\n");
#nullable restore
#line 33 "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Invoice\History.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td><a class=\"btn btn-success\" href=\"/payment/payment\">Thanh to??n</a></td>\r\n                                    <td><a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 1703, "\"", 1748, 2);
            WriteAttributeValue("", 1710, "/invoice/confirmdelete/", 1710, 23, true);
#nullable restore
#line 37 "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Invoice\History.cshtml"
WriteAttributeValue("", 1733, item.InvoiceId, 1733, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">H???y</a></td>\r\n");
#nullable restore
#line 38 "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Invoice\History.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                \r\n                                \r\n                            </tr>\r\n");
#nullable restore
#line 42 "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Invoice\History.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 48 "D:\DoAnNghiavsTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\Invoice\History.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<InvoiceModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
