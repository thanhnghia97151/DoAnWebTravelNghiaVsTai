#pragma checksum "F:\BÁO_CAO_KHOA_LUẬN_TOT_NGHIÊP_LEVANTAI_NGUYENTHANHNGHIA\DoANCodeSourse\WebTravel\WebClient\Views\Invoice\History.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ab1b869a908b007cf7a9975407812df9fa04c13"
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
#line 1 "F:\BÁO_CAO_KHOA_LUẬN_TOT_NGHIÊP_LEVANTAI_NGUYENTHANHNGHIA\DoANCodeSourse\WebTravel\WebClient\Views\_ViewImports.cshtml"
using WebClient.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\BÁO_CAO_KHOA_LUẬN_TOT_NGHIÊP_LEVANTAI_NGUYENTHANHNGHIA\DoANCodeSourse\WebTravel\WebClient\Views\_ViewImports.cshtml"
using WebClient.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\BÁO_CAO_KHOA_LUẬN_TOT_NGHIÊP_LEVANTAI_NGUYENTHANHNGHIA\DoANCodeSourse\WebTravel\WebClient\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ab1b869a908b007cf7a9975407812df9fa04c13", @"/Views/Invoice/History.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"169f23584bdde1d27398dd2e1409d4fef4c01ec3", @"/Views/_ViewImports.cshtml")]
    public class Views_Invoice_History : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<InvoiceModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Invoice", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreatePDF", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">
        <div class=""col-xs-12 col-ms-12 col-md-12 col-lg-12 text-center"">
            <h2>THÔNG TIN HÓA ĐƠN</h2>
        </div>
    </div>
</div>
<br />

<div class=""container"">
    <div class=""row"">
        <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12"">
");
#nullable restore
#line 15 "F:\BÁO_CAO_KHOA_LUẬN_TOT_NGHIÊP_LEVANTAI_NGUYENTHANHNGHIA\DoANCodeSourse\WebTravel\WebClient\Views\Invoice\History.cshtml"
             if (Model != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ab1b869a908b007cf7a9975407812df9fa04c135143", async() => {
                WriteLiteral(@"
                <div class=""container"">
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
                                        <th>Thanh toán</th>
                                        <th>Hủy</th>
                                        <th>Tích</th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 35 "F:\BÁO_CAO_KHOA_LUẬN_TOT_NGHIÊP_LEVANTAI_NGUYENTHANHNGHIA\DoANCodeSourse\WebTravel\WebClient\Views\Invoice\History.cshtml"
                                      
                                        decimal totalMoney = 0;
                                        int i = 0;
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "F:\BÁO_CAO_KHOA_LUẬN_TOT_NGHIÊP_LEVANTAI_NGUYENTHANHNGHIA\DoANCodeSourse\WebTravel\WebClient\Views\Invoice\History.cshtml"
                                     foreach (var item in Model)
                                    {
                                        if (item.Tour != null)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 44 "F:\BÁO_CAO_KHOA_LUẬN_TOT_NGHIÊP_LEVANTAI_NGUYENTHANHNGHIA\DoANCodeSourse\WebTravel\WebClient\Views\Invoice\History.cshtml"
                                       Write(item.InvoiceId.Substring(0, 30));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                        \r\n                                        <td><img");
                BeginWriteAttribute("src", " src=\"", 2009, "\"", 2062, 2);
                WriteAttributeValue("", 2015, "https://localhost:44384/images/", 2015, 31, true);
#nullable restore
#line 46 "F:\BÁO_CAO_KHOA_LUẬN_TOT_NGHIÊP_LEVANTAI_NGUYENTHANHNGHIA\DoANCodeSourse\WebTravel\WebClient\Views\Invoice\History.cshtml"
WriteAttributeValue("", 2046, item.Tour.Image, 2046, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" width=\"70\" /> </td>\r\n                                        \r\n                                        <td>");
#nullable restore
#line 48 "F:\BÁO_CAO_KHOA_LUẬN_TOT_NGHIÊP_LEVANTAI_NGUYENTHANHNGHIA\DoANCodeSourse\WebTravel\WebClient\Views\Invoice\History.cshtml"
                                       Write(item.Tour.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                       \r\n                                        <td>");
#nullable restore
#line 50 "F:\BÁO_CAO_KHOA_LUẬN_TOT_NGHIÊP_LEVANTAI_NGUYENTHANHNGHIA\DoANCodeSourse\WebTravel\WebClient\Views\Invoice\History.cshtml"
                                       Write(item.Price.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("vi-VN")));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                       \r\n                                        <td>");
#nullable restore
#line 52 "F:\BÁO_CAO_KHOA_LUẬN_TOT_NGHIÊP_LEVANTAI_NGUYENTHANHNGHIA\DoANCodeSourse\WebTravel\WebClient\Views\Invoice\History.cshtml"
                                       Write(item.Quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                     \r\n");
#nullable restore
#line 54 "F:\BÁO_CAO_KHOA_LUẬN_TOT_NGHIÊP_LEVANTAI_NGUYENTHANHNGHIA\DoANCodeSourse\WebTravel\WebClient\Views\Invoice\History.cshtml"
                                         if (item.Status)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <td><small>Đã thanh toán</small></td>\r\n");
                WriteLiteral("                                            <td><input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 2812, "\"", 2828, 2);
                WriteAttributeValue("", 2819, "Status+", 2819, 7, true);
#nullable restore
#line 58 "F:\BÁO_CAO_KHOA_LUẬN_TOT_NGHIÊP_LEVANTAI_NGUYENTHANHNGHIA\DoANCodeSourse\WebTravel\WebClient\Views\Invoice\History.cshtml"
WriteAttributeValue("", 2826, i, 2826, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" value=\"1\" /></td>\r\n");
#nullable restore
#line 59 "F:\BÁO_CAO_KHOA_LUẬN_TOT_NGHIÊP_LEVANTAI_NGUYENTHANHNGHIA\DoANCodeSourse\WebTravel\WebClient\Views\Invoice\History.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <td><small>Chưa thanh toán</small></td>\r\n                                            <td><a class=\"btn btn-danger\"");
                BeginWriteAttribute("href", " href=\"", 3139, "\"", 3184, 2);
                WriteAttributeValue("", 3146, "/invoice/confirmdelete/", 3146, 23, true);
#nullable restore
#line 63 "F:\BÁO_CAO_KHOA_LUẬN_TOT_NGHIÊP_LEVANTAI_NGUYENTHANHNGHIA\DoANCodeSourse\WebTravel\WebClient\Views\Invoice\History.cshtml"
WriteAttributeValue("", 3169, item.InvoiceId, 3169, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Hủy</a></td>\r\n");
#nullable restore
#line 64 "F:\BÁO_CAO_KHOA_LUẬN_TOT_NGHIÊP_LEVANTAI_NGUYENTHANHNGHIA\DoANCodeSourse\WebTravel\WebClient\Views\Invoice\History.cshtml"
                                            totalMoney = totalMoney + (item.Price * item.Quantity);
                                           
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        <td><input type=\"checkbox\"");
                BeginWriteAttribute("name", " name=\"", 3457, "\"", 3472, 2);
                WriteAttributeValue("", 3464, "Check+", 3464, 6, true);
#nullable restore
#line 68 "F:\BÁO_CAO_KHOA_LUẬN_TOT_NGHIÊP_LEVANTAI_NGUYENTHANHNGHIA\DoANCodeSourse\WebTravel\WebClient\Views\Invoice\History.cshtml"
WriteAttributeValue("", 3470, i, 3470, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" value=\"1\" /></td>\r\n                                    </tr>\r\n                                    <tr>\r\n                                        <td><input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 3642, "\"", 3662, 2);
                WriteAttributeValue("", 3649, "InvoicedId+", 3649, 11, true);
#nullable restore
#line 71 "F:\BÁO_CAO_KHOA_LUẬN_TOT_NGHIÊP_LEVANTAI_NGUYENTHANHNGHIA\DoANCodeSourse\WebTravel\WebClient\Views\Invoice\History.cshtml"
WriteAttributeValue("", 3660, i, 3660, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 3663, "\"", 3686, 1);
#nullable restore
#line 71 "F:\BÁO_CAO_KHOA_LUẬN_TOT_NGHIÊP_LEVANTAI_NGUYENTHANHNGHIA\DoANCodeSourse\WebTravel\WebClient\Views\Invoice\History.cshtml"
WriteAttributeValue("", 3671, item.InvoiceId, 3671, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></td>\r\n                                        <td><input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 3761, "\"", 3775, 2);
                WriteAttributeValue("", 3768, "Name+", 3768, 5, true);
#nullable restore
#line 72 "F:\BÁO_CAO_KHOA_LUẬN_TOT_NGHIÊP_LEVANTAI_NGUYENTHANHNGHIA\DoANCodeSourse\WebTravel\WebClient\Views\Invoice\History.cshtml"
WriteAttributeValue("", 3773, i, 3773, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 3776, "\"", 3799, 1);
#nullable restore
#line 72 "F:\BÁO_CAO_KHOA_LUẬN_TOT_NGHIÊP_LEVANTAI_NGUYENTHANHNGHIA\DoANCodeSourse\WebTravel\WebClient\Views\Invoice\History.cshtml"
WriteAttributeValue("", 3784, item.Tour.Name, 3784, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></td>\r\n                                        <td><input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 3874, "\"", 3889, 2);
                WriteAttributeValue("", 3881, "Price+", 3881, 6, true);
#nullable restore
#line 73 "F:\BÁO_CAO_KHOA_LUẬN_TOT_NGHIÊP_LEVANTAI_NGUYENTHANHNGHIA\DoANCodeSourse\WebTravel\WebClient\Views\Invoice\History.cshtml"
WriteAttributeValue("", 3887, i, 3887, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 3890, "\"", 3909, 1);
#nullable restore
#line 73 "F:\BÁO_CAO_KHOA_LUẬN_TOT_NGHIÊP_LEVANTAI_NGUYENTHANHNGHIA\DoANCodeSourse\WebTravel\WebClient\Views\Invoice\History.cshtml"
WriteAttributeValue("", 3898, item.Price, 3898, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></td>\r\n                                        <td><input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 3984, "\"", 4002, 2);
                WriteAttributeValue("", 3991, "Quantity+", 3991, 9, true);
#nullable restore
#line 74 "F:\BÁO_CAO_KHOA_LUẬN_TOT_NGHIÊP_LEVANTAI_NGUYENTHANHNGHIA\DoANCodeSourse\WebTravel\WebClient\Views\Invoice\History.cshtml"
WriteAttributeValue("", 4000, i, 4000, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 4003, "\"", 4025, 1);
#nullable restore
#line 74 "F:\BÁO_CAO_KHOA_LUẬN_TOT_NGHIÊP_LEVANTAI_NGUYENTHANHNGHIA\DoANCodeSourse\WebTravel\WebClient\Views\Invoice\History.cshtml"
WriteAttributeValue("", 4011, item.Quantity, 4011, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></td>\r\n                                       \r\n                                    </tr>\r\n");
#nullable restore
#line 77 "F:\BÁO_CAO_KHOA_LUẬN_TOT_NGHIÊP_LEVANTAI_NGUYENTHANHNGHIA\DoANCodeSourse\WebTravel\WebClient\Views\Invoice\History.cshtml"
                                            i++;
                                        }
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <tr><td> <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 4313, "\"", 4323, 1);
#nullable restore
#line 80 "F:\BÁO_CAO_KHOA_LUẬN_TOT_NGHIÊP_LEVANTAI_NGUYENTHANHNGHIA\DoANCodeSourse\WebTravel\WebClient\Views\Invoice\History.cshtml"
WriteAttributeValue("", 4321, i, 4321, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""Result"" /></td></tr>
                                </tbody>
                            </table>
                        </div>
                        <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12 text-right"">
                            <input type=""submit"" class=""btn btn-danger"" value=""Xuất dữ liệu"" />
                        </div><br /><br />
                        <div class=""row"">

                        </div>
");
                WriteLiteral("                        <div class=\"col-xs-12 col-sm-12 col-md-12 col-lg-12 text-right\">\r\n                            <p style=\"font-size: 18px;\">Tổng tiền thanh toán:&nbsp;&nbsp;&nbsp; <small>");
#nullable restore
#line 92 "F:\BÁO_CAO_KHOA_LUẬN_TOT_NGHIÊP_LEVANTAI_NGUYENTHANHNGHIA\DoANCodeSourse\WebTravel\WebClient\Views\Invoice\History.cshtml"
                                                                                                  Write(totalMoney);

#line default
#line hidden
#nullable disable
                WriteLiteral(" đ</small> </p>\r\n                        </div>\r\n                        <div></div>\r\n                        <div class=\"col-xs-12 col-sm-12 col-md-12 col-lg-12 text-right\">\r\n\r\n");
#nullable restore
#line 97 "F:\BÁO_CAO_KHOA_LUẬN_TOT_NGHIÊP_LEVANTAI_NGUYENTHANHNGHIA\DoANCodeSourse\WebTravel\WebClient\Views\Invoice\History.cshtml"
                              
                                var result = @totalMoney / 23000;
                                

#line default
#line hidden
#nullable disable
                WriteLiteral("<p style=\"font-size: 18px;\">Tổng tiền thanh toán($):&nbsp;&nbsp;&nbsp; <small id=\"total\">");
#nullable restore
#line 99 "F:\BÁO_CAO_KHOA_LUẬN_TOT_NGHIÊP_LEVANTAI_NGUYENTHANHNGHIA\DoANCodeSourse\WebTravel\WebClient\Views\Invoice\History.cshtml"
                                                                                                                    Write(result.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-US")));

#line default
#line hidden
#nullable disable
                WriteLiteral(" $</small></p>\r\n");
                WriteLiteral(@"                        </div>
                        <div></div>
                        <div class=""col-xs-12 col-sm-6 col-md-10 col-lg-10 text-right"">
                            <p style=""font-size: 18px;"">Thanh toán tại đây:</p>
                        </div>
                        <div class=""col-xs-12 col-sm-6 col-md-2 col-lg-2 text-right"">
                            <div id=""paypal-button""></div>
                        </div>


                    </div>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 114 "F:\BÁO_CAO_KHOA_LUẬN_TOT_NGHIÊP_LEVANTAI_NGUYENTHANHNGHIA\DoANCodeSourse\WebTravel\WebClient\Views\Invoice\History.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
</div>

<script src=""https://www.paypalobjects.com/api/checkout.js""></script>
<script>
    var result = document.getElementById(""total"").innerHTML;
    paypal.Button.render({
        // Configure environment
        env: 'sandbox',
        client: {
            sandbox: 'AQ0vdtbnYnilxGirwMwQ7nx3UuE-j5UCVhKz1dU8hm6apMn5QlJIYREUtRqpfBl_nrBiTvu7KaX8EI49',
            production: 'demo_production_client_id'
        },
        // Customize button (optional)
        locale: 'en_US',
        style: {
            size: 'small',
            color: 'gold',
            shape: 'pill',
        },

        // Enable Pay Now checkout flow (optional)
        commit: true,

        // Set up a payment
        payment: function (data, actions) {
            return actions.payment.create({
                transactions: [{
                    amount: {
                        total: '0.1',
                        currency: 'USD'
                    }
                }]
");
            WriteLiteral(@"            });
        },
        // Execute the payment
        onAuthorize: function (data, actions) {
            return actions.payment.execute().then(function () {
                // Show a confirmation message to the buyer
                window.location.assign(""/Invoice/Checkout?MemberId = "" + """");
            });
        }
    }, '#paypal-button');

</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<InvoiceModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
