#pragma checksum "C:\Users\admin\Desktop\admin\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66111a575b7376b3f0013ec9073478f7ccea3b63"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\admin\Desktop\admin\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\admin\Desktop\admin\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\admin\Desktop\admin\Views\Home\Index.cshtml"
using PagedList.Core.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66111a575b7376b3f0013ec9073478f7ccea3b63", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03350a0a69106539bd5bc7a986cfffe7a4c319da", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineMarket.ModelViews.HomeViewVM>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\admin\Desktop\admin\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "KTNT Shop";
    Layout = "~/Views/Shared/_Layout.cshtml";
    List<OnlineMarket.Models.Product> allProduct = ViewBag.AllProducts;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n\r\n    <style type=\"text/css\">\r\n        .bg-image {\r\n            background-image: url(\'");
#nullable restore
#line 13 "C:\Users\admin\Desktop\admin\Views\Home\Index.cshtml"
                              Write(Url.Content("~/assets/images/breadcrumb/bg.jpg"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\');\r\n            background-size: cover;\r\n\r\n        }\r\n                .bg2-image {\r\n            background-image: url(\'");
#nullable restore
#line 18 "C:\Users\admin\Desktop\admin\Views\Home\Index.cshtml"
                              Write(Url.Content("~/assets/images/breadcrumb/bg1.jpg"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\');\r\n            background-size: cover;\r\n\r\n        }\r\n    </style>\r\n");
            }
            );
            WriteLiteral(@"<!-- Begin Slider Area -->
<div class=""slider-area"">

    <!-- Main Slider -->
    <div class=""swiper-container main-slider swiper-arrow bg-image"">
        <div class=""swiper-wrapper"">
            <div class=""swiper-slide animation-style-01"">
                <div class=""slide-inner bg-height bg-image"">

                    <div class=""container"">
                        <div class=""parallax-with-content"">
                            <div class=""slide-content"">
                                <span class=""sub-title mb-3 text-white-50"" style=""font-weight: bold"">KTNT SHOP</span>
                                <h2 class=""title mb-9 text-white"" style=""font-weight: bold"">Đồng hành cùng ước mơ của bạn</h2>
");
            WriteLiteral(@"                            </div>

                        </div>
                    </div>
                </div>
            </div>
            <div class=""swiper-slide animation-style-01"">
                <div class=""slide-inner bg-height bg2-image"">

                    <div class=""container"">
                        <div class=""parallax-with-content"">
                            <div class=""slide-content"">
");
            WriteLiteral(@"                            </div>

                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- Add Pagination -->
        <div class=""swiper-pagination with-bg d-md-none""></div>

        <!-- Add Arrows -->
        <div class=""swiper-button-next""></div>
        <div class=""swiper-button-prev""></div>
    </div>

</div>
<!-- Slider Area End Here -->
<!-- Begin Shipping Area -->
");
            WriteLiteral("<!-- Shipping Area End Here -->\r\n<!-- Begin Banner Area -->\r\n\r\n");
            WriteLiteral("<!-- Banner Area End Here -->\r\n<!-- Begin Product Area -->\r\n<!-- Product Area End Here -->\r\n<!-- Begin Blog Area -->\r\n");
            WriteLiteral("\r\n<!-- Blog Area End Here -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineMarket.ModelViews.HomeViewVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
