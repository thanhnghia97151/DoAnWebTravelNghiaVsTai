#pragma checksum "D:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\News\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20459456842203cd7a946f0fb4ed2eb60c040b69"
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
#line 1 "D:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\_ViewImports.cshtml"
using WebClient.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DoAnWebTravelNghiaVsTai\WebTravel\WebClient\Views\_ViewImports.cshtml"
using WebClient.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20459456842203cd7a946f0fb4ed2eb60c040b69", @"/Views/News/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b8fad72161a928ca3d5d332110946d494b91cc1", @"/Views/_ViewImports.cshtml")]
    public class Views_News_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<News>>
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
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "20459456842203cd7a946f0fb4ed2eb60c040b694146", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "20459456842203cd7a946f0fb4ed2eb60c040b695265", async() => {
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
         <div class=""col-xs-12 col-sm-6 col-md-4 col-lg-4"">
           <div class=""thumbnail"">
             <img src=""images/news1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 1838, "\"", 1844, 0);
            EndWriteAttribute();
            WriteLiteral(@">
             <div class=""caption"">
               <h4>Khám phá chợ hoa Hồ Thị Kỷ - Thiên đường ẩm thực và hoa tươi ở Sài Gòn</h4>
               <div class=""eye"">
                        
                        <p><span class=""fa fa-calendar""></span>&nbsp; 19/2/2021
                        &nbsp;&nbsp; &nbsp;<small><span class=""fa fa-eye""></span>&nbsp;5000</small>
                        </p>

                        </div>

               <p class=""content"">
                 Chợ hoa Hồ Thị Kỷ chính là nét đẹp riêng biệt và độc đáo của người dân Sài Gòn. Nếu có dịp đến du lịch Sài Gòn, đừng quên ghé thăm và khám phá khu chợ
               </p>
               
             </div>
           </div>
         </div> <!-- the end column1 row 1 -->
         <div class=""col-xs-12 col-sm-6 col-md-4 col-lg-4"">
           <div class=""thumbnail"">
             <img src=""images/news2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 2756, "\"", 2762, 0);
            EndWriteAttribute();
            WriteLiteral(@">
             <div class=""caption"">
               <h4>Bỏ túi những mẹo vặt sức khỏe hữu ích dành cho bạn khi đi du lịch</h4>
               <div class=""eye"">
                        
                        <p><span class=""fa fa-calendar""></span>&nbsp; 19/2/2021
                        &nbsp;&nbsp; &nbsp;<small><span class=""fa fa-eye""></span>&nbsp;5000</small>
                        </p>

                        </div>

               <p class=""content"">
                 Các mẹo vặt sức khỏe dưới đây, Du Lịch Việt sẽ giúp cho bạn giữ gìn sức khỏe khi đi du lịch thật tốt để tận hưởng được chuyến đi nghỉ dưỡng này.
               </p>
               
             </div>
           </div>
         </div> <!-- the end column2 row 1 -->
         <div class=""col-xs-12 col-sm-6 col-md-4 col-lg-4"">
           <div class=""thumbnail"">
             <img src=""images/news3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 3663, "\"", 3669, 0);
            EndWriteAttribute();
            WriteLiteral(@">
             <div class=""caption"">
               <h4>Khám phá vẻ đẹp hoang sơ cao nguyên Vân Hòa - Đà Lạt thứ 2 thu nhỏ tại Phú Yên</h4>
               <div class=""eye"">
                        
                        <p><span class=""fa fa-calendar""></span>&nbsp; 19/2/2021
                        &nbsp;&nbsp; &nbsp;<small><span class=""fa fa-eye""></span>&nbsp;5000</small>
                        </p>

                        </div>

               <p class=""content"">
                 Cao nguyên Vân Hòa chính là nơi lý tưởng dành cho bạn vào những ngày cuối tuần đầy mệt mỏi để xả stress trong chuyến du lịch Phú Yên lần này. Cùng
               </p>
               
             </div>
           </div>
         </div> <!-- the end column3 row 1 -->
         <div class=""col-xs-12 col-sm-6 col-md-4 col-lg-4"">
           <div class=""thumbnail"">
             <img src=""images/news4.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 4585, "\"", 4591, 0);
            EndWriteAttribute();
            WriteLiteral(@">
             <div class=""caption"">
               <h4>HOLIDAY DEALs CÙNG PHILIPPINE AIRLINES</h4>
               <div class=""eye"">
                        
                        <p><span class=""fa fa-calendar""></span>&nbsp; 19/2/2021
                        &nbsp;&nbsp; &nbsp;<small><span class=""fa fa-eye""></span>&nbsp;5000</small>
                        </p>

                        </div>

               <p class=""content"">
                 Cuối tuần hay ngày Lễ/Tết không có giá rẻ, vé rẻ chủ yếu sẽ chỉ khuyến mãi giờ bay ít người di chuyển (như buổi sáng sớm/ hay lúc khuya muộn) tùy ngày
               </p>
               
             </div>
           </div>
         </div> <!-- the end column4 row 1 -->
         <div class=""col-xs-12 col-sm-6 col-md-4 col-lg-4"">
           <div class=""thumbnail"">
             <img src=""images/news5.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 5471, "\"", 5477, 0);
            EndWriteAttribute();
            WriteLiteral(@">
             <div class=""caption"">
               <h4>HOLIDAY DEALs CÙNG PHILIPPINE AIRLINES</h4>
               <div class=""eye"">
                        
                        <p><span class=""fa fa-calendar""></span>&nbsp; 19/2/2021
                        &nbsp;&nbsp; &nbsp;<small><span class=""fa fa-eye""></span>&nbsp;5000</small>
                        </p>

                        </div>

               <p class=""content"">
                 Cuối tuần hay ngày Lễ/Tết không có giá rẻ, vé rẻ chủ yếu sẽ chỉ khuyến mãi giờ bay ít người di chuyển (như buổi sáng sớm/ hay lúc khuya muộn) tùy ngày
               </p>
               
             </div>
           </div>
         </div> <!-- the end column5 row 1 -->
         <div class=""col-xs-12 col-sm-6 col-md-4 col-lg-4"">
           <div class=""thumbnail"">
             <img src=""images/news6.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 6357, "\"", 6363, 0);
            EndWriteAttribute();
            WriteLiteral(@">
             <div class=""caption"">
               <h4>Khám phá vẻ đẹp hoang sơ cao nguyên Vân Hòa - Đà Lạt thứ 2 thu nhỏ tại Phú Yên</h4>
               <div class=""eye"">
                        
                        <p><span class=""fa fa-calendar""></span>&nbsp; 19/2/2021
                        &nbsp;&nbsp; &nbsp;<small><span class=""fa fa-eye""></span>&nbsp;5000</small>
                        </p>

                        </div>

               <p class=""content"">
                 Cuối tuần hay ngày Lễ/Tết không có giá rẻ, vé rẻ chủ yếu sẽ chỉ khuyến mãi giờ bay ít người di chuyển (như buổi sáng sớm/ hay lúc khuya muộn) tùy ngày
               </p>
               
             </div>
           </div>
         </div> <!-- the end column6 row 1 -->
          <div class=""col-xs-12 col-sm-6 col-md-4 col-lg-4"">
           <div class=""thumbnail"">
             <img src=""images/news1.jpg""");
            BeginWriteAttribute("alt", "  alt=\"", 7284, "\"", 7291, 0);
            EndWriteAttribute();
            WriteLiteral(@">
             <div class=""caption"">
               <h4>HOLIDAY DEALs CÙNG PHILIPPINE AIRLINES</h4>
               <div class=""eye"">
                        
                        <p><span class=""fa fa-calendar""></span>&nbsp; 19/2/2021
                        &nbsp;&nbsp; &nbsp;<small><span class=""fa fa-eye""></span>&nbsp;5000</small>
                        </p>

                        </div>

               <p class=""content"">
                 Cuối tuần hay ngày Lễ/Tết không có giá rẻ, vé rẻ chủ yếu sẽ chỉ khuyến mãi giờ bay ít người di chuyển (như buổi sáng sớm/ hay lúc khuya muộn) tùy ngày
               </p>
               
             </div>
           </div>
         </div> <!-- the end column7 row 1 -->
          <div class=""col-xs-12 col-sm-6 col-md-4 col-lg-4"">
           <div class=""thumbnail"">
             <img src=""images/news2.jpg""");
            BeginWriteAttribute("alt", "  alt=\"", 8172, "\"", 8179, 0);
            EndWriteAttribute();
            WriteLiteral(@">
             <div class=""caption"">
               <h4>HOLIDAY DEALs CÙNG PHILIPPINE AIRLINES</h4>
               <div class=""eye"">
                        
                        <p><span class=""fa fa-calendar""></span>&nbsp; 19/2/2021
                        &nbsp;&nbsp; &nbsp;<small><span class=""fa fa-eye""></span>&nbsp;5000</small>
                        </p>

                        </div>

               <p class=""content"">
                 Cuối tuần hay ngày Lễ/Tết không có giá rẻ, vé rẻ chủ yếu sẽ chỉ khuyến 
               </p>
               
             </div>
           </div>
         </div> <!-- the end column8 row 1 -->
         <div class=""col-xs-12 col-sm-6 col-md-4 col-lg-4"">
           <div class=""thumbnail"">
             <img src=""images/news3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 8980, "\"", 8986, 0);
            EndWriteAttribute();
            WriteLiteral(@">
             <div class=""caption"">
               <h4>HOLIDAY DEALs CÙNG PHILIPPINE AIRLINES</h4>
               <div class=""eye"">
                        
                        <p><span class=""fa fa-calendar""></span>&nbsp; 19/2/2021
                        &nbsp;&nbsp; &nbsp;<small><span class=""fa fa-eye""></span>&nbsp;5000</small>
                        </p>

                        </div>

               <p class=""content"">
                 Cuối tuần hay ngày Lễ/Tết không có giá rẻ, vé rẻ chủ yếu sẽ chỉ khuyến mãi giờ bay ít người di chuyển (như buổi sáng sớm/ hay lúc khuya muộn) tùy ngày
               </p>
               
             </div>
           </div>
         </div> <!-- the end column9 row 1 -->
       
      </div>
    </div>
    </div> <!-- the end row 1 -->
    

   ");
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