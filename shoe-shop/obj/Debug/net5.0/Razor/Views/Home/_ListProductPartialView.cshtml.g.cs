#pragma checksum "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Home\_ListProductPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b17b814a6344dee2988f1d73c84e8778a60472d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__ListProductPartialView), @"mvc.1.0.view", @"/Views/Home/_ListProductPartialView.cshtml")]
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
#line 1 "C:\Users\admin\Desktop\ag2022-mvc-1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\admin\Desktop\ag2022-mvc-1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b17b814a6344dee2988f1d73c84e8778a60472d", @"/Views/Home/_ListProductPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03350a0a69106539bd5bc7a986cfffe7a4c319da", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__ListProductPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OnlineMarket.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-full"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100%; height:200px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Home\_ListProductPartialView.cshtml"
 if (Model != null && Model.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"product-item-wrap row\">\r\n");
#nullable restore
#line 5 "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Home\_ListProductPartialView.cshtml"
         foreach (var item in Model)
        {
            string url = $"/{item.Alias}/{item.ProductId}.html";

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-xl-3 col-lg-4 col-sm-6\" style=\"margin-top:10px\">\r\n                <div class=\"product-item\">\r\n                    <div class=\"product-img img-zoom-effect\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 454, "\"", 465, 1);
#nullable restore
#line 11 "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Home\_ListProductPartialView.cshtml"
WriteAttributeValue("", 461, url, 461, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 12 "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Home\_ListProductPartialView.cshtml"
                             if (item.BestSeller == true)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div style=""margin-bottom: 30px; z-index: 1; position: absolute; background-color: red; border-style: double; color: white; border-radius: 20px"">
                                    <p style=""background-color:;margin:auto;padding:0px 10px;"">Best Seller</p>
                                </div>
");
#nullable restore
#line 17 "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Home\_ListProductPartialView.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0b17b814a6344dee2988f1d73c84e8778a60472d5863", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 976, "~/images/products/", 976, 18, true);
#nullable restore
#line 18 "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Home\_ListProductPartialView.cshtml"
AddHtmlAttributeValue("", 994, item.Thumb, 994, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 18 "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Home\_ListProductPartialView.cshtml"
AddHtmlAttributeValue("", 1046, item.Title, 1046, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                        </a>\r\n                        <div class=\"product-add-action\">\r\n                            <ul>\r\n                                <li>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1263, "\"", 1270, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                        <i class=""pe-7s-cart""></i>
                                    </a>
                                </li>
                            </ul>
                        </div>
                    </div>
                    <div class=""product-content"">
                        <a class=""product-name""");
            BeginWriteAttribute("href", " href=\"", 1616, "\"", 1627, 1);
#nullable restore
#line 32 "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Home\_ListProductPartialView.cshtml"
WriteAttributeValue("", 1623, url, 1623, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 32 "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Home\_ListProductPartialView.cshtml"
                                                       Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        <div class=\"price-box pb-1\">\r\n                            <span class=\"new-price\">");
#nullable restore
#line 34 "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Home\_ListProductPartialView.cshtml"
                                               Write(item.Price.Value.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</span>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 39 "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Home\_ListProductPartialView.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 41 "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Home\_ListProductPartialView.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OnlineMarket.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
