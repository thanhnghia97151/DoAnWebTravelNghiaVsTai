#pragma checksum "F:\Khoa_Luan_Tot_Nghiep\DoANCodeSourse\WebTravel\WebClient\Areas\Dashboard\Views\News\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f95de25bc139a5a0c571ca89a450ae6aec8b5b00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Dashboard_Views_News_Index), @"mvc.1.0.view", @"/Areas/Dashboard/Views/News/Index.cshtml")]
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
#line 1 "F:\Khoa_Luan_Tot_Nghiep\DoANCodeSourse\WebTravel\WebClient\Areas\Dashboard\Views\_ViewImports.cshtml"
using WebClient.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Khoa_Luan_Tot_Nghiep\DoANCodeSourse\WebTravel\WebClient\Areas\Dashboard\Views\_ViewImports.cshtml"
using WebClient.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f95de25bc139a5a0c571ca89a450ae6aec8b5b00", @"/Areas/Dashboard/Views/News/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b8fad72161a928ca3d5d332110946d494b91cc1", @"/Areas/Dashboard/Views/_ViewImports.cshtml")]
    public class Areas_Dashboard_Views_News_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<News>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f95de25bc139a5a0c571ca89a450ae6aec8b5b004143", async() => {
                WriteLiteral("Create");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<table class=""table table-bordered"">
    <thead class=""table-dark"">
        <tr>
            <th>Id</th>
            <th>Name</th>
            <th>Meta Title</th>
            <th>Description</th>
            <th>Code</th>
            <th>Image</th>
            <th>Detail</th>
            <th>Note</th>
            <th>NewCategory Id</th>
            <th>Created Date</th>
            <th>Created By</th>
            <th>Modified Date</th>
            <th>Modified By</th>
            <th>Status</th>
            <th>Top hot</th>
            <th>View Count</th>
            <th>Edit</th>
            <th>Remove</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 27 "F:\Khoa_Luan_Tot_Nghiep\DoANCodeSourse\WebTravel\WebClient\Areas\Dashboard\Views\News\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 30 "F:\Khoa_Luan_Tot_Nghiep\DoANCodeSourse\WebTravel\WebClient\Areas\Dashboard\Views\News\Index.cshtml"
               Write(item.NewsId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "F:\Khoa_Luan_Tot_Nghiep\DoANCodeSourse\WebTravel\WebClient\Areas\Dashboard\Views\News\Index.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "F:\Khoa_Luan_Tot_Nghiep\DoANCodeSourse\WebTravel\WebClient\Areas\Dashboard\Views\News\Index.cshtml"
               Write(item.MetaTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "F:\Khoa_Luan_Tot_Nghiep\DoANCodeSourse\WebTravel\WebClient\Areas\Dashboard\Views\News\Index.cshtml"
               Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "F:\Khoa_Luan_Tot_Nghiep\DoANCodeSourse\WebTravel\WebClient\Areas\Dashboard\Views\News\Index.cshtml"
               Write(item.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><img");
            BeginWriteAttribute("src", " src=\"", 1047, "\"", 1095, 2);
            WriteAttributeValue("", 1053, "https://localhost:44384/images/", 1053, 31, true);
#nullable restore
#line 35 "F:\Khoa_Luan_Tot_Nghiep\DoANCodeSourse\WebTravel\WebClient\Areas\Dashboard\Views\News\Index.cshtml"
WriteAttributeValue("", 1084, item.Image, 1084, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"70\" /></td>\r\n                <td>");
#nullable restore
#line 36 "F:\Khoa_Luan_Tot_Nghiep\DoANCodeSourse\WebTravel\WebClient\Areas\Dashboard\Views\News\Index.cshtml"
               Write(Html.Raw(System.Web.HttpUtility.HtmlDecode(item.Detail)));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 37 "F:\Khoa_Luan_Tot_Nghiep\DoANCodeSourse\WebTravel\WebClient\Areas\Dashboard\Views\News\Index.cshtml"
               Write(item.Note);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 38 "F:\Khoa_Luan_Tot_Nghiep\DoANCodeSourse\WebTravel\WebClient\Areas\Dashboard\Views\News\Index.cshtml"
               Write(item.NewCategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 39 "F:\Khoa_Luan_Tot_Nghiep\DoANCodeSourse\WebTravel\WebClient\Areas\Dashboard\Views\News\Index.cshtml"
               Write(item.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 40 "F:\Khoa_Luan_Tot_Nghiep\DoANCodeSourse\WebTravel\WebClient\Areas\Dashboard\Views\News\Index.cshtml"
               Write(item.CreatedBy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 41 "F:\Khoa_Luan_Tot_Nghiep\DoANCodeSourse\WebTravel\WebClient\Areas\Dashboard\Views\News\Index.cshtml"
               Write(item.ModifiedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 42 "F:\Khoa_Luan_Tot_Nghiep\DoANCodeSourse\WebTravel\WebClient\Areas\Dashboard\Views\News\Index.cshtml"
               Write(item.ModifiedBy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 43 "F:\Khoa_Luan_Tot_Nghiep\DoANCodeSourse\WebTravel\WebClient\Areas\Dashboard\Views\News\Index.cshtml"
               Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 44 "F:\Khoa_Luan_Tot_Nghiep\DoANCodeSourse\WebTravel\WebClient\Areas\Dashboard\Views\News\Index.cshtml"
               Write(item.TopHot);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 45 "F:\Khoa_Luan_Tot_Nghiep\DoANCodeSourse\WebTravel\WebClient\Areas\Dashboard\Views\News\Index.cshtml"
               Write(item.ViewCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f95de25bc139a5a0c571ca89a450ae6aec8b5b0011125", async() => {
                WriteLiteral("<i class=\"fa fa-edit\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "F:\Khoa_Luan_Tot_Nghiep\DoANCodeSourse\WebTravel\WebClient\Areas\Dashboard\Views\News\Index.cshtml"
                                           WriteLiteral(item.NewsId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1768, "\"", 1817, 2);
            WriteAttributeValue("", 1775, "/dashboard/news/confirmdelete/", 1775, 30, true);
#nullable restore
#line 50 "F:\Khoa_Luan_Tot_Nghiep\DoANCodeSourse\WebTravel\WebClient\Areas\Dashboard\Views\News\Index.cshtml"
WriteAttributeValue("", 1805, item.NewsId, 1805, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-trash\"></i></a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 53 "F:\Khoa_Luan_Tot_Nghiep\DoANCodeSourse\WebTravel\WebClient\Areas\Dashboard\Views\News\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<News>> Html { get; private set; }
    }
}
#pragma warning restore 1591
