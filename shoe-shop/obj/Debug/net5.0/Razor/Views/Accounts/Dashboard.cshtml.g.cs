#pragma checksum "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Accounts\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1efccfee6714f2237b1bc175577c62a8ea962494"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accounts_Dashboard), @"mvc.1.0.view", @"/Views/Accounts/Dashboard.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1efccfee6714f2237b1bc175577c62a8ea962494", @"/Views/Accounts/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03350a0a69106539bd5bc7a986cfffe7a4c319da", @"/Views/_ViewImports.cshtml")]
    public class Views_Accounts_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineMarket.Models.Customer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Accounts\Dashboard.cshtml"
  
    ViewData["Title"] = "Dashboard";
    Layout = "~/Views/Shared/_Layout.cshtml";
    List<OnlineMarket.Models.Order> DanhSachDonHang = ViewBag.DonHang;
    OnlineMarket.ModelViews.ChangePasswordViewModel changepassword = new OnlineMarket.ModelViews.ChangePasswordViewModel();

#line default
#line hidden
#nullable disable
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n\r\n    <style type=\"text/css\">\r\n        .bg-image {\r\n            background-image: url(\'");
#nullable restore
#line 13 "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Accounts\Dashboard.cshtml"
                              Write(Url.Content("~/assets/images/breadcrumb/bg.jpg"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\');\r\n            background-size: cover;\r\n            height: 600px;\r\n        }\r\n    </style>\r\n");
            }
            );
            WriteLiteral(@"<main class=""main-content"">
    <div class=""breadcrumb-area breadcrumb-height bg-image"">
        <div class=""container h-100"">
            <div class=""row h-100"">
                <div class=""col-lg-12"">
                    <div class=""breadcrumb-item"">
                        <h1 class=""breadcrumb-heading text-white"">KTNT SHOP</h1>
                        <ul>
                            <li>
                                <a class=""text-white"" href=""/"">Tài khoản <i class=""text-white pe-7s-angle-right""></i></a>
                            </li>
                            <li class=""text-white"">THÔNG TIN TÀI KHOẢN</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""account-page-area section-space-y-axis-100"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-3"">
                    <ul class=""nav myaccount-tab-trigger"" id=""account-page-tab"" role=""t");
            WriteLiteral(@"ablist"">
                        <li class=""nav-item"">
                            <a class=""nav-link active"" id=""account-dashboard-tab"" data-bs-toggle=""tab"" href=""#account-dashboard"" role=""tab"" aria-controls=""account-dashboard"" aria-selected=""true"">Thông tin tài khoản</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" id=""account-orders-tab"" data-bs-toggle=""tab"" href=""#account-orders"" role=""tab"" aria-controls=""account-orders"" aria-selected=""false"">Danh sách đơn hàng</a>
                        </li>

                        <li class=""nav-item"">
                            <a class=""nav-link"" id=""account-details-tab"" data-bs-toggle=""tab"" href=""#account-details"" role=""tab"" aria-controls=""account-details"" aria-selected=""false"">Thay đổi thông tin</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" id=""account-logout-tab"" href=""/dang-xuat.html"" role=");
            WriteLiteral(@"""tab"" aria-selected=""false"">Đăng xuất</a>
                        </li>
                    </ul>
                </div>
                <div class=""col-lg-9"">
                    <div class=""tab-content myaccount-tab-content"" id=""account-page-tab-content"">
                        <div class=""tab-pane fade show active"" id=""account-dashboard"" role=""tabpanel"" aria-labelledby=""account-dashboard-tab"">
                            <div class=""myaccount-dashboard"">
                                <p>
                                    Xin chào, <b>");
#nullable restore
#line 62 "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Accounts\Dashboard.cshtml"
                                            Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                                </p>\r\n                                <p> Email: ");
#nullable restore
#line 64 "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Accounts\Dashboard.cshtml"
                                      Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p> Số điện thoại: ");
#nullable restore
#line 65 "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Accounts\Dashboard.cshtml"
                                              Write(Model.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p> Địa chỉ: ");
#nullable restore
#line 66 "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Accounts\Dashboard.cshtml"
                                        Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                            </div>
                        </div>
                        <div class=""tab-pane fade"" id=""account-orders"" role=""tabpanel"" aria-labelledby=""account-orders-tab"">
                            <div class=""myaccount-orders"">
                                <h4 class=""small-title"">Danh sách đơn hàng</h4>
");
#nullable restore
#line 72 "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Accounts\Dashboard.cshtml"
                                 if (DanhSachDonHang != null && DanhSachDonHang.Count() > 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <div class=""table-responsive"">
                                        <table class=""table table-bordered table-hover"">
                                            <tbody>
                                                <tr>
                                                    <td>ID</td>
                                                    <td>Ngày</td>
                                                    <td>Ngày vận chuyển</td>
                                                    <td>Trạng thái</td>
                                                    <td>Tổng tiền</td>
                                                    <td></td>
                                                </tr>
");
#nullable restore
#line 85 "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Accounts\Dashboard.cshtml"
                                                 foreach (var item in DanhSachDonHang)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr>\r\n                                                        <td><a class=\"account-order-id\" href=\"javascript:void(0)\">");
#nullable restore
#line 88 "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Accounts\Dashboard.cshtml"
                                                                                                             Write(item.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                                                        <td>");
#nullable restore
#line 89 "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Accounts\Dashboard.cshtml"
                                                       Write(item.OrderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 90 "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Accounts\Dashboard.cshtml"
                                                       Write(item.ShipDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 91 "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Accounts\Dashboard.cshtml"
                                                       Write(item.TransactStatus.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 92 "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Accounts\Dashboard.cshtml"
                                                       Write(item.TotalMoney.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</td>\r\n                                                        <td>\r\n                                                            <a class=\"xemdonhang\" href=\"javascript:void(0)\" data-madonhang=\"");
#nullable restore
#line 94 "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Accounts\Dashboard.cshtml"
                                                                                                                       Write(item.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Xem đơn hàng</a>\r\n                                                        </td>\r\n                                                    </tr>\r\n");
#nullable restore
#line 97 "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Accounts\Dashboard.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            </tbody>
                                        </table>
                                        <div id=""records_table"">

                                        </div>
                                    </div>
");
#nullable restore
#line 104 "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Accounts\Dashboard.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p>Chưa có đơn hàng!</p>\r\n");
#nullable restore
#line 108 "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Accounts\Dashboard.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""tab-pane fade"" id=""account-address"" role=""tabpanel"" aria-labelledby=""account-address-tab"">
                            <div class=""myaccount-address"">
                                <p>The following addresses will be used on the checkout page by default.</p>
                                <div class=""row"">
                                    <div class=""col"">
                                        <h4 class=""small-title"">BILLING ADDRESS</h4>
                                        <address>
                                            ");
#nullable restore
#line 119 "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Accounts\Dashboard.cshtml"
                                       Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </address>
                                    </div>
                                    <div class=""col"">
                                        <h4 class=""small-title"">SHIPPING ADDRESS</h4>
                                        <address>
                                            ");
#nullable restore
#line 125 "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Accounts\Dashboard.cshtml"
                                       Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </address>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""tab-pane fade"" id=""account-details"" role=""tabpanel"" aria-labelledby=""account-details-tab"">
                            ");
#nullable restore
#line 132 "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Accounts\Dashboard.cshtml"
                       Write(await Html.PartialAsync("_ChangeInfomationPartialView", changepassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</main>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $("".xemdonhang"").click(function () {
                var madonhang = $(this).attr(""data-madonhang"")
                $.ajax({
                    url: '/DonHang/Details',
                    datatype: ""json"",
                    type: ""POST"",
                    data: { id: madonhang },
                    async: true,
                    success: function (results) {
                        $(""#records_table"").html("""");
                        $(""#records_table"").html(results);
                    },
                    error: function (xhr) {
                        alert('error');
                    }
                });
            });
        });
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineMarket.Models.Customer> Html { get; private set; }
    }
}
#pragma warning restore 1591
