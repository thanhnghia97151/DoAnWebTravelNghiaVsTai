#pragma checksum "F:\BÁO_CAO_KHOA_LUẬN_TOT_NGHIÊP_LEVANTAI_NGUYENTHANHNGHIA\DoANCodeSourse\WebTravel\WebClient\Areas\Dashboard\Views\TourCategory\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4a87b26092422e37e374fc479d017ee713452a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Dashboard_Views_TourCategory_Index), @"mvc.1.0.view", @"/Areas/Dashboard/Views/TourCategory/Index.cshtml")]
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
#line 1 "F:\BÁO_CAO_KHOA_LUẬN_TOT_NGHIÊP_LEVANTAI_NGUYENTHANHNGHIA\DoANCodeSourse\WebTravel\WebClient\Areas\Dashboard\Views\_ViewImports.cshtml"
using WebClient.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\BÁO_CAO_KHOA_LUẬN_TOT_NGHIÊP_LEVANTAI_NGUYENTHANHNGHIA\DoANCodeSourse\WebTravel\WebClient\Areas\Dashboard\Views\_ViewImports.cshtml"
using WebClient.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4a87b26092422e37e374fc479d017ee713452a2", @"/Areas/Dashboard/Views/TourCategory/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b8fad72161a928ca3d5d332110946d494b91cc1", @"/Areas/Dashboard/Views/_ViewImports.cshtml")]
    public class Areas_Dashboard_Views_TourCategory_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TourCategory>>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4a87b26092422e37e374fc479d017ee713452a24293", async() => {
                WriteLiteral("Crate");
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
            <th>Id </th>
            <th>Name</th>
            <th>SeoTitle</th>
            <th>MetaTitle</th>
            <th>Created Date</th>
            <th>Created By</th>
            <th>Modified Date</th>
            <th>Modified By</th>
            <th> Status</th>
            <th>Show On HOme</th>
            <th>Type Of Tour</th>
            <th> ParentId</th>
            <th>Edit|Detail|Delete</th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 23 "F:\BÁO_CAO_KHOA_LUẬN_TOT_NGHIÊP_LEVANTAI_NGUYENTHANHNGHIA\DoANCodeSourse\WebTravel\WebClient\Areas\Dashboard\Views\TourCategory\Index.cshtml"
         foreach (var item in Model)
       {

#line default
#line hidden
#nullable disable
            WriteLiteral("           <tr>\r\n               <td>");
#nullable restore
#line 26 "F:\BÁO_CAO_KHOA_LUẬN_TOT_NGHIÊP_LEVANTAI_NGUYENTHANHNGHIA\DoANCodeSourse\WebTravel\WebClient\Areas\Dashboard\Views\TourCategory\Index.cshtml"
              Write(item.TourCategoriesId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n               <td>");
#nullable restore
#line 27 "F:\BÁO_CAO_KHOA_LUẬN_TOT_NGHIÊP_LEVANTAI_NGUYENTHANHNGHIA\DoANCodeSourse\WebTravel\WebClient\Areas\Dashboard\Views\TourCategory\Index.cshtml"
              Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n               <td>");
#nullable restore
#line 28 "F:\BÁO_CAO_KHOA_LUẬN_TOT_NGHIÊP_LEVANTAI_NGUYENTHANHNGHIA\DoANCodeSourse\WebTravel\WebClient\Areas\Dashboard\Views\TourCategory\Index.cshtml"
              Write(item.SeoTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n               <td>");
#nullable restore
#line 29 "F:\BÁO_CAO_KHOA_LUẬN_TOT_NGHIÊP_LEVANTAI_NGUYENTHANHNGHIA\DoANCodeSourse\WebTravel\WebClient\Areas\Dashboard\Views\TourCategory\Index.cshtml"
              Write(item.MetaTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n               <td>");
#nullable restore
#line 30 "F:\BÁO_CAO_KHOA_LUẬN_TOT_NGHIÊP_LEVANTAI_NGUYENTHANHNGHIA\DoANCodeSourse\WebTravel\WebClient\Areas\Dashboard\Views\TourCategory\Index.cshtml"
              Write(item.CreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n               <td>");
#nullable restore
#line 31 "F:\BÁO_CAO_KHOA_LUẬN_TOT_NGHIÊP_LEVANTAI_NGUYENTHANHNGHIA\DoANCodeSourse\WebTravel\WebClient\Areas\Dashboard\Views\TourCategory\Index.cshtml"
              Write(item.CreatedBy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n               <td>");
#nullable restore
#line 32 "F:\BÁO_CAO_KHOA_LUẬN_TOT_NGHIÊP_LEVANTAI_NGUYENTHANHNGHIA\DoANCodeSourse\WebTravel\WebClient\Areas\Dashboard\Views\TourCategory\Index.cshtml"
              Write(item.ModifiedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n               <td>");
#nullable restore
#line 33 "F:\BÁO_CAO_KHOA_LUẬN_TOT_NGHIÊP_LEVANTAI_NGUYENTHANHNGHIA\DoANCodeSourse\WebTravel\WebClient\Areas\Dashboard\Views\TourCategory\Index.cshtml"
              Write(item.ModifiedBy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n               <td>");
#nullable restore
#line 34 "F:\BÁO_CAO_KHOA_LUẬN_TOT_NGHIÊP_LEVANTAI_NGUYENTHANHNGHIA\DoANCodeSourse\WebTravel\WebClient\Areas\Dashboard\Views\TourCategory\Index.cshtml"
              Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n               <td>");
#nullable restore
#line 35 "F:\BÁO_CAO_KHOA_LUẬN_TOT_NGHIÊP_LEVANTAI_NGUYENTHANHNGHIA\DoANCodeSourse\WebTravel\WebClient\Areas\Dashboard\Views\TourCategory\Index.cshtml"
              Write(item.ShowOnHome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n               <td>");
#nullable restore
#line 36 "F:\BÁO_CAO_KHOA_LUẬN_TOT_NGHIÊP_LEVANTAI_NGUYENTHANHNGHIA\DoANCodeSourse\WebTravel\WebClient\Areas\Dashboard\Views\TourCategory\Index.cshtml"
              Write(item.TypeOfTourId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n               <td>");
#nullable restore
#line 37 "F:\BÁO_CAO_KHOA_LUẬN_TOT_NGHIÊP_LEVANTAI_NGUYENTHANHNGHIA\DoANCodeSourse\WebTravel\WebClient\Areas\Dashboard\Views\TourCategory\Index.cshtml"
              Write(item.ParentId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n               <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4a87b26092422e37e374fc479d017ee713452a210306", async() => {
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
#line 39 "F:\BÁO_CAO_KHOA_LUẬN_TOT_NGHIÊP_LEVANTAI_NGUYENTHANHNGHIA\DoANCodeSourse\WebTravel\WebClient\Areas\Dashboard\Views\TourCategory\Index.cshtml"
                                           WriteLiteral(item.TourCategoriesId);

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
            WriteLiteral("\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1378, "\"", 1437, 2);
            WriteAttributeValue("", 1385, "/dashboard/news/confirmdelete/", 1385, 30, true);
#nullable restore
#line 40 "F:\BÁO_CAO_KHOA_LUẬN_TOT_NGHIÊP_LEVANTAI_NGUYENTHANHNGHIA\DoANCodeSourse\WebTravel\WebClient\Areas\Dashboard\Views\TourCategory\Index.cshtml"
WriteAttributeValue("", 1415, item.TourCategoriesId, 1415, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-trash\"></i></a>\r\n                </td>\r\n           </tr>\r\n");
#nullable restore
#line 43 "F:\BÁO_CAO_KHOA_LUẬN_TOT_NGHIÊP_LEVANTAI_NGUYENTHANHNGHIA\DoANCodeSourse\WebTravel\WebClient\Areas\Dashboard\Views\TourCategory\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TourCategory>> Html { get; private set; }
    }
}
#pragma warning restore 1591
