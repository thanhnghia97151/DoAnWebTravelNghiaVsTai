#pragma checksum "F:\Khoa_Luan_Tot_Nghiep\DoANCodeSourse\WebTravel\WebClient\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "427c84f06c5f28a55aabf659338836cd6a58bf8d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
#line 1 "F:\Khoa_Luan_Tot_Nghiep\DoANCodeSourse\WebTravel\WebClient\Views\_ViewImports.cshtml"
using WebClient.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Khoa_Luan_Tot_Nghiep\DoANCodeSourse\WebTravel\WebClient\Views\_ViewImports.cshtml"
using WebClient.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Khoa_Luan_Tot_Nghiep\DoANCodeSourse\WebTravel\WebClient\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"427c84f06c5f28a55aabf659338836cd6a58bf8d", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"169f23584bdde1d27398dd2e1409d4fef4c01ec3", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/contact.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Contact_submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("accept-charset", new global::Microsoft.AspNetCore.Html.HtmlString("utf-8"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "427c84f06c5f28a55aabf659338836cd6a58bf8d5286", async() => {
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
 <!-- Display Section -->
   <div class=""display"">
      <div class=""container"">
         <div class=""row"">
            <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12"">
               <div class=""thongtin"">
                <small>Trang Chủ > Liên Hệ</small>
               </div>
            </div>
         </div>
      </div>
   </div> 
 <!-- Content Contact -->
   <div class=""ContactContent"">
      <div class=""container"">
         <div class=""row"">
            <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12"">
               <h3>Thông tin liên hệ</h3>
            </div>
            <div class=""col-xs-12 col-sm-6 col-md-6 col-lg-6 contentleft"">
               <div class=""caption"">
                  <p>Nếu quý khách có thắc mắc hay đóng góp xin vui lòng điền vào Form dưới đây và gửi cho chúng tôi. Xin chân thành cảm ơn!
                  </p>              
               </div>
               ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "427c84f06c5f28a55aabf659338836cd6a58bf8d7359", async() => {
                WriteLiteral(@"
                  <div class=""form-group editform"">
                     <label>Họ tên <span>(*)</span></label>
                     <input type=""text"" placeholder=""Họ tên"" class=""form-control"" 
                     id=""hoten"">
                  </div>
                   <div class=""form-group editform"">
                     <label>Tên công ty</label>
                     <input type=""text"" placeholder=""Tên công ty"" class=""form-control"" 
                     id=""tencongty"">
                  </div>
                  <div class=""row"">
                     <div class=""col-xs-6 col-sm-6 col-md-6 col-lg-6"">
                        <div class=""form-group editform"">
                           <label>Email <span>(*)</span></label>
                           <input type=""text"" placeholder=""Email"" class=""form-control"" 
                             id=""email"">
                        </div>
                     </div> <!-- the end cot 1 -->

                     <div class=""col-xs-6 col-sm-6 col-md");
                WriteLiteral(@"-6 col-lg-6"">
                        <div class=""form-group editform"">
                           <label>Điện thoại <span>(*)</span></label>
                           <input type=""text"" placeholder=""Điện thoại"" class=""form-control"" 
                             id=""dienthoai"">
                        </div>
                     </div>
                  </div>
                  <div class=""form-group editform"">
                     <label>Tiêu đề <span>(*)</span></label>
                     <input type=""text"" placeholder=""Tiêu đề"" class=""form-control"" 
                     id=""tieude"">
                  </div>
                  <div class=""form-group editform"">
                     <label>Nội dung <span>(*)</span></label>
                     <textarea class=""form-control"" id=""noidung"" rows=""4""></textarea>
                  </div>
                  
                  <div class=""form-group guilienhe"">
                     <button type=""submit""><span class=""btn-value"">Gửi</span></button>
");
                WriteLiteral("                  </div>\r\n               ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
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
            <div class=""col-xs-12 col-sm-6 col-md-6 col-lg-6 contentright"">
               <div class=""row"">
                  <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12"">
                     <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3918.822525206539!2d106.67811951411683!3d10.82488996125894!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x317528fcee860259%3A0x79663fad584e298d!2zMTkgSOG6oW5oIFRow7RuZywgUGjGsOG7nW5nIDMsIEfDsiBW4bqlcCwgVGjDoG5oIHBo4buRIEjhu5MgQ2jDrSBNaW5oLCBWaeG7h3QgTmFt!5e0!3m2!1svi!2s!4v1645591921629!5m2!1svi!2s"" width=""100%"" height=300"" style=""border:0;"" allowfullscreen="""" loading=""lazy""></iframe>
                  </div>
                  <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12 thongtinphu"">
                     <div>
                        <h3>CÔNG TY CỔ PHẦN TRUYỀN THÔNG DU LỊCH VIỆT</h3>
                     </div>
                     <div>
                        <p><i class=""fa fa-home""></i>&nbsp;&nbsp;");
            WriteLiteral(@"<span>Địa chỉ:</span> 239A Hoàng Văn Thụ, Phường 8, Quận Phú Nhuận, TP. Hồ Chí Minh</p>
                     </div>
                     <div>
                        <p><i class=""fa fa-phone""></i>&nbsp;&nbsp;<span>Điện thoại:</span>  1900 1177</p>
                     </div>
                     <div class=""nganduoi"">
                        <p><i class=""fa fa-envelope""></i>&nbsp;&nbsp;<span>Email:</span> info@dulichviet.com.vn</p>
                     </div>
                  </div>

                     <!-- thong tin chi nhanh -->
                  <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12 thongtinphu"">
                     <div>
                        <h3>CÔNG TY THÀNH VIÊN</h3>
                     </div>
                     <div>
                        <p><i class=""fa fa-home""></i>&nbsp;&nbsp;<span>Địa chỉ:</span> 239A Hoàng Văn Thụ, Phường 8, Quận Phú Nhuận, TP. Hồ Chí Minh</p>
                     </div>
                     <div class=""nganduoi"">
                     ");
            WriteLiteral(@"   <p><i class=""fa fa-phone""></i>&nbsp;&nbsp;<span>Điện thoại:</span>  1900 1177</p>
                     </div>                    
                  </div>

                  <!-- Tro Giup -->
                  <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12 thongtinphu"">
                     <div>
                        <h3>BẠN CẦN TRỢ GIÚP?</h3>
                     </div>
                     
                     <div>
                        <p><i class=""fa fa-phone""></i>&nbsp;&nbsp;<span>Hotline:</span> 1900 1177</p>
                     </div>
                     <div>
                        <p><i class=""fa fa-envelope""></i>&nbsp;&nbsp;<span>Email:</span> info@dulichviet.com.vn</p>
                     </div>
                     <div>
                        <p><i class=""glyphicon glyphicon-time""></i>&nbsp;&nbsp;<span>Hoạt động:</span> Từ 8h:00 - 18h:00 hằng ngày</p>
                     </div>
                  </div>
               </div>
            </div>
         </");
            WriteLiteral("div>\r\n      </div>\r\n   </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
