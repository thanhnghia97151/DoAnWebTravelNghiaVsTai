#pragma checksum "D:\DoAnNghiaTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Areas\Dashboard\Views\Invoice\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f41efc4079f0aa9a171b37232248fdd1a9d3d000"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Dashboard_Views_Invoice_Index), @"mvc.1.0.view", @"/Areas/Dashboard/Views/Invoice/Index.cshtml")]
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
#line 1 "D:\DoAnNghiaTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Areas\Dashboard\Views\_ViewImports.cshtml"
using WebClient.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DoAnNghiaTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Areas\Dashboard\Views\_ViewImports.cshtml"
using WebClient.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f41efc4079f0aa9a171b37232248fdd1a9d3d000", @"/Areas/Dashboard/Views/Invoice/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b8fad72161a928ca3d5d332110946d494b91cc1", @"/Areas/Dashboard/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Dashboard_Views_Invoice_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<InvoiceModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/jquery.dataTables.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.dataTables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f41efc4079f0aa9a171b37232248fdd1a9d3d0004406", async() => {
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
#nullable restore
#line 3 "D:\DoAnNghiaTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Areas\Dashboard\Views\Invoice\Index.cshtml"
  
    InvoiceModel temp = new InvoiceModel();

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<table class=""table table-bordered"">
    <thead class=""table-dark"">
        <tr>
            <th>Tour Name</th>
            <th>Date Book</th>
            <th>Price</th>
            <th>Quantity</th>
            <th>Payment</th>
            <th>Customer</th>
            <th>Phone</th>
            <th>Email</th>

            <th>Delete</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 22 "D:\DoAnNghiaTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Areas\Dashboard\Views\Invoice\Index.cshtml"
         if(Model != null)
        {
                 

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\DoAnNghiaTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Areas\Dashboard\Views\Invoice\Index.cshtml"
                  foreach (InvoiceModel item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 27 "D:\DoAnNghiaTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Areas\Dashboard\Views\Invoice\Index.cshtml"
                   Write(item.Tour.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "D:\DoAnNghiaTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Areas\Dashboard\Views\Invoice\Index.cshtml"
                   Write(item.IncoiceDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 29 "D:\DoAnNghiaTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Areas\Dashboard\Views\Invoice\Index.cshtml"
                   Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 30 "D:\DoAnNghiaTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Areas\Dashboard\Views\Invoice\Index.cshtml"
                   Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 31 "D:\DoAnNghiaTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Areas\Dashboard\Views\Invoice\Index.cshtml"
                   Write(item.Payment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 32 "D:\DoAnNghiaTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Areas\Dashboard\Views\Invoice\Index.cshtml"
                   Write(item.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 33 "D:\DoAnNghiaTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Areas\Dashboard\Views\Invoice\Index.cshtml"
                   Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 34 "D:\DoAnNghiaTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Areas\Dashboard\Views\Invoice\Index.cshtml"
                   Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td>\r\n                        <!-- Trigger the modal with a button -->\r\n                    \r\n                        <button id=\"c\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1186, "\"", 1232, 3);
            WriteAttributeValue("", 1196, "remove(\'", 1196, 8, true);
#nullable restore
#line 39 "D:\DoAnNghiaTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Areas\Dashboard\Views\Invoice\Index.cshtml"
WriteAttributeValue("", 1204, item.InvoiceId.ToString(), 1204, 26, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1230, "\')", 1230, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</button>\r\n");
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 43 "D:\DoAnNghiaTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Areas\Dashboard\Views\Invoice\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "D:\DoAnNghiaTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Areas\Dashboard\Views\Invoice\Index.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("       \r\n    </tbody>\r\n</table>\r\n\r\n\r\n");
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f41efc4079f0aa9a171b37232248fdd1a9d3d00010415", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<script>\r\n    $(\'.table\').DataTable();\r\n    function remove(id){\r\n");
            WriteLiteral("        \r\n        $.post(\"/dashboard/invoice/delete/\"+id,function(result){\r\n            console.log(result);\r\n            window.location.href=\"/dashboard/invoice\";\r\n        });\r\n        \r\n    };\r\n        \r\n\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<InvoiceModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
