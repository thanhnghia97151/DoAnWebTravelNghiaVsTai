#pragma checksum "D:\DoAnNghiaTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Areas\Dashboard\Views\Member\Role.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77d0dc762f9e2a48641a20493d71b93e4c2bf17f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Dashboard_Views_Member_Role), @"mvc.1.0.view", @"/Areas/Dashboard/Views/Member/Role.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77d0dc762f9e2a48641a20493d71b93e4c2bf17f", @"/Areas/Dashboard/Views/Member/Role.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b8fad72161a928ca3d5d332110946d494b91cc1", @"/Areas/Dashboard/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Dashboard_Views_Member_Role : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Member>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"card\">\r\n    <div class=\"card-header\">\r\n        <div class=\"card-title\">");
#nullable restore
#line 4 "D:\DoAnNghiaTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Areas\Dashboard\Views\Member\Role.cshtml"
                           Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
    </div>
    <div class=""card-body"">
        <table class=""table table-bordered"">
            <thead class=""table-dark"">
                <tr>
                    <th>Roles</th>
                    <th>Checked</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 15 "D:\DoAnNghiaTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Areas\Dashboard\Views\Member\Role.cshtml"
                 foreach (RoleChecked item in ViewBag.roles)
               {

#line default
#line hidden
#nullable disable
            WriteLiteral("                   <tr>\r\n                       <td>");
#nullable restore
#line 18 "D:\DoAnNghiaTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Areas\Dashboard\Views\Member\Role.cshtml"
                      Write(item.RoleName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                       <td>\r\n");
#nullable restore
#line 20 "D:\DoAnNghiaTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Areas\Dashboard\Views\Member\Role.cshtml"
                             if (item.Checked)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <input class=\"c\" type=\"checkbox\"");
            BeginWriteAttribute("value", " value=\"", 735, "\"", 755, 1);
#nullable restore
#line 22 "D:\DoAnNghiaTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Areas\Dashboard\Views\Member\Role.cshtml"
WriteAttributeValue("", 743, item.RoleID, 743, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" checked />\r\n");
#nullable restore
#line 23 "D:\DoAnNghiaTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Areas\Dashboard\Views\Member\Role.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <input class=\"c\" type=\"checkbox\"");
            BeginWriteAttribute("value", " value=\"", 929, "\"", 949, 1);
#nullable restore
#line 26 "D:\DoAnNghiaTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Areas\Dashboard\Views\Member\Role.cshtml"
WriteAttributeValue("", 937, item.RoleID, 937, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 27 "D:\DoAnNghiaTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Areas\Dashboard\Views\Member\Role.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                   </tr>\r\n");
#nullable restore
#line 31 "D:\DoAnNghiaTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Areas\Dashboard\Views\Member\Role.cshtml"
               }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n    <div class=\"card-footer\"></div>\r\n</div>\r\n<script>\r\n    $(\'.c\').click(function(){\r\n       var rid = $(this).val();\r\n       //console.log(rid);\r\n       var o = {memberID: \'");
#nullable restore
#line 41 "D:\DoAnNghiaTai\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Areas\Dashboard\Views\Member\Role.cshtml"
                      Write(Model.MemberID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\',roleID: rid};\r\n       //console.log(o);\r\n       $.post(\'/dashboard/member/addroles\',o,(d)=>{\r\n           console.log(d);\r\n       });\r\n    });\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Member> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
