#pragma checksum "C:\Users\admin\Desktop\admin\Areas\Admin\Views\AdminOrders\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58517407fb7338f970f20240016f2ef68f86195e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminOrders_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminOrders/Details.cshtml")]
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
#line 1 "C:\Users\admin\Desktop\admin\Areas\Admin\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\admin\Desktop\admin\Areas\Admin\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58517407fb7338f970f20240016f2ef68f86195e", @"/Areas/Admin/Views/AdminOrders/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03350a0a69106539bd5bc7a986cfffe7a4c319da", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_AdminOrders_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineMarket.Models.Order>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("breadcrumb-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AdminOrders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\admin\Desktop\admin\Areas\Admin\Views\AdminOrders\Details.cshtml"
  
    ViewData["Title"] = "Thông tin đơn hàng : "+ Model.OrderId;
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";
    List <OnlineMarket.Models.OrderDetail> orderDetails = ViewBag.Chitiet;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""page-container"">


    <!-- Content Wrapper START -->
    <div class=""main-content"">
        <div class=""page-header"">
          
            <div class=""header-sub-title"">
                <nav class=""breadcrumb breadcrumb-dash"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58517407fb7338f970f20240016f2ef68f86195e5443", async() => {
                WriteLiteral("<i class=\"anticon anticon-home m-r-5\"></i>Trang chủ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58517407fb7338f970f20240016f2ef68f86195e7154", async() => {
                WriteLiteral("Danh sách đơn hàng");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <span class=""breadcrumb-item active"">Thông tin đơn hàng</span>
                </nav>
            </div>
        </div>
        <div class=""container"">
            <div class=""card"">
                <div class=""card-body"">
                   
                    <div id=""invoice"" class=""p-h-30"">
                       
                        <div class=""row  "">
                            <div class=""col-sm-8"">
                                <div class=""text-dark text-uppercase d-inline-block"">
                                    <h3>THÔNG TIN KHÁCH HÀNG</h3>
                                </div>
                                <img class=""img-fluid"" src=""assets/images/logo/logo.png""");
            BeginWriteAttribute("alt", " alt=\"", 1530, "\"", 1536, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <address class=\"p-l-10 m-t-10\">\r\n                                    <span class=\"font-weight-semibold text-dark\">Tên người nhận: ");
#nullable restore
#line 36 "C:\Users\admin\Desktop\admin\Areas\Admin\Views\AdminOrders\Details.cshtml"
                                                                                            Write(Model.Customer.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br>\r\n                                    <span>Địa chỉ: ");
#nullable restore
#line 37 "C:\Users\admin\Desktop\admin\Areas\Admin\Views\AdminOrders\Details.cshtml"
                                              Write(ViewBag.FullAdress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br>\r\n                                    <span>Email: ");
#nullable restore
#line 38 "C:\Users\admin\Desktop\admin\Areas\Admin\Views\AdminOrders\Details.cshtml"
                                            Write(Model.Customer.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br>\r\n                                    <abbr class=\"text-dark\" title=\"Phone\">Số điện thoại:</abbr>\r\n                                    <span>");
#nullable restore
#line 40 "C:\Users\admin\Desktop\admin\Areas\Admin\Views\AdminOrders\Details.cshtml"
                                     Write(Model.Customer.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                </address>
                            </div>
                            <div class=""col-sm-4"">
                                <div>
                                    <div class=""text-dark text-uppercase d-inline-block"">
                                        <h3>THÔNG TIN MUA HÀNG</h3>
                                    </div>
                                    <div class=""float-right"">#");
#nullable restore
#line 48 "C:\Users\admin\Desktop\admin\Areas\Admin\Views\AdminOrders\Details.cshtml"
                                                         Write(Model.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                                </div>
                                <div class=""text-dark  d-inline-block m-t-10"">
                                    <span class=""font-weight-semibold text-dark"">Ngày mua :</span>
                                </div>
                                <div class=""float-right"">");
#nullable restore
#line 53 "C:\Users\admin\Desktop\admin\Areas\Admin\Views\AdminOrders\Details.cshtml"
                                                    Write(Model.OrderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                                <div class=""text-dark  d-inline-block"">
                                    <span class=""font-weight-semibold text-dark"">Ngày giao hàng :</span>
                                </div>
                                <div class=""float-right"">");
#nullable restore
#line 57 "C:\Users\admin\Desktop\admin\Areas\Admin\Views\AdminOrders\Details.cshtml"
                                                    Write(Model.ShipDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                                <br />
                                <div class=""text-dark d-inline-block"">
                                    <span class=""font-weight-semibold text-dark"">Trạng thái đơn hàng :</span>
                                </div>
                                <div class=""float-right"">");
#nullable restore
#line 62 "C:\Users\admin\Desktop\admin\Areas\Admin\Views\AdminOrders\Details.cshtml"
                                                    Write(Model.TransactStatus.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>

                            </div>
                        </div>
                        <div class=""m-t-20"">
                            <div class=""table-responsive"">
                                <table class=""table"">
                                    <thead>
                                        <tr>
                                            <th>Thứ tự</th>
                                            <th>Sản phẩm</th>
                                            <th>Số lượng</th>
                                            <th>Đơn giá</th>
                                            <th>Thành tiền</th>
                                        </tr>
                                    </thead>
                                    <tbody>
");
#nullable restore
#line 79 "C:\Users\admin\Desktop\admin\Areas\Admin\Views\AdminOrders\Details.cshtml"
                                         if (orderDetails != null && orderDetails.Count() > 0)
                                        {
                                            int i = 1;
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "C:\Users\admin\Desktop\admin\Areas\Admin\Views\AdminOrders\Details.cshtml"
                                             foreach (var item in orderDetails)
                                            {
                                                string url = $"/{item.product.Alias}-{item.product.ProductId}";

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <tr>\r\n                                                    <th>");
#nullable restore
#line 86 "C:\Users\admin\Desktop\admin\Areas\Admin\Views\AdminOrders\Details.cshtml"
                                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                                    <td><a target=\"_blank\"");
            BeginWriteAttribute("href", " href=\"", 4932, "\"", 4943, 1);
#nullable restore
#line 87 "C:\Users\admin\Desktop\admin\Areas\Admin\Views\AdminOrders\Details.cshtml"
WriteAttributeValue("", 4939, url, 4939, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 87 "C:\Users\admin\Desktop\admin\Areas\Admin\Views\AdminOrders\Details.cshtml"
                                                                                  Write(item.product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                                                    <td>");
#nullable restore
#line 88 "C:\Users\admin\Desktop\admin\Areas\Admin\Views\AdminOrders\Details.cshtml"
                                                   Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 89 "C:\Users\admin\Desktop\admin\Areas\Admin\Views\AdminOrders\Details.cshtml"
                                                   Write(item.Price.Value.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</td>\r\n                                                    <td>");
#nullable restore
#line 90 "C:\Users\admin\Desktop\admin\Areas\Admin\Views\AdminOrders\Details.cshtml"
                                                   Write(item.TotalMoney.Value.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</td>\r\n                                                </tr>\r\n");
#nullable restore
#line 92 "C:\Users\admin\Desktop\admin\Areas\Admin\Views\AdminOrders\Details.cshtml"
                                                i++;
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "C:\Users\admin\Desktop\admin\Areas\Admin\Views\AdminOrders\Details.cshtml"
                                             
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                                    </tbody>
                                </table>
                            </div>
                            <div class=""row m-t-30 lh-1-8"">
                                <div class=""col-sm-12"">
                                    <div class=""float-right text-right"">
                                        <h3><span class=""font-weight-semibold text-dark"">Tổng tiền :</span> ");
#nullable restore
#line 103 "C:\Users\admin\Desktop\admin\Areas\Admin\Views\AdminOrders\Details.cshtml"
                                                                                                       Write(Model.TotalMoney.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" VNĐ</h3>
                                    </div>
                                </div>
                            </div>
                           
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Content Wrapper END -->
    <!-- Footer START -->
    <footer class=""footer"">
        <div class=""footer-content"">
            <p class=""m-b-0"">Copyright © 2019 Theme_Nate. All rights reserved.</p>
            <span>
                <a");
            BeginWriteAttribute("href", " href=\"", 6471, "\"", 6478, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"text-gray m-r-15\">Term &amp; Conditions</a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 6550, "\"", 6557, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"text-gray\">Privacy &amp; Policy</a>\r\n            </span>\r\n        </div>\r\n    </footer>\r\n    <!-- Footer END -->\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineMarket.Models.Order> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
