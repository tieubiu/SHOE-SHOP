#pragma checksum "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2fa7efcbcfc42c20287341eba9b8e04246fea27"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Product\Index.cshtml"
using PagedList.Core.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2fa7efcbcfc42c20287341eba9b8e04246fea27", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03350a0a69106539bd5bc7a986cfffe7a4c319da", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedList.Core.IPagedList<OnlineMarket.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("widgets-searchbox"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100%; height:200px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-full"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("pager-container"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::PagedList.Core.Mvc.PagerTagHelper __PagedList_Core_Mvc_PagerTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Shop - " + ViewBag.CurrentPage;
    Layout = "~/Views/Shared/_Layout.cshtml";
    int PageCurrent = ViewBag.CurrentPage;
    int PageNext = ViewBag.CurrentPage + 1;

#line default
#line hidden
#nullable disable
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n\r\n    <style type=\"text/css\">\r\n        .bg-image {\r\n            background-image: url(\'");
#nullable restore
#line 13 "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Product\Index.cshtml"
                              Write(Url.Content("~/assets/images/breadcrumb/bg.jpg"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\');\r\n            background-size: cover;\r\n            height: 600px;\r\n        }\r\n    </style>\r\n");
            }
            );
            WriteLiteral(@"<!-- Begin Main Content Area -->
<main class=""main-content"">
    <div class=""breadcrumb-area breadcrumb-height bg-image"">
        <div class=""container h-100"">
            <div class=""row h-100"">
                <div class=""col-lg-12"">
                    <div class=""breadcrumb-item"">
                        <h1 class=""breadcrumb-heading text-white"">KTNT SHOP</h1>
                        <ul>
                            <li>
                                <a class=""text-white"" href=""/"">Trang chủ <i class=""text-white pe-7s-angle-right""></i></a>
                            </li>
                            <li class=""text-white"">DANH SÁCH SẢN PHẨM</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""shop-area section-space-y-axis-100"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-3 order-lg-1 order-2 pt-10 pt-lg-0"">
                    <div clas");
            WriteLiteral("s=\"sidebar-area\">\r\n                        <div class=\"widgets-searchbox mb-9\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2fa7efcbcfc42c20287341eba9b8e04246fea277504", async() => {
                WriteLiteral(@"
                                <div class=""input-affix m-v-10"">
                                    <i class=""prefix-icon anticon-search opacity-04""></i>
                                    <input id=""keyword"" name=""keyword"" type=""text"" class=""input-field"" placeholder=""Tìm kiếm sản phẩm"" />
                                </div>
                                <button class=""widgets-searchbox-btn"" type=""submit"">
                                    <i class=""pe-7s-search""></i>
                                </button>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                        <div class=""widgets-area mb-9"">
                            <h2 class=""widgets-title mb-5"">Refine By</h2>
                            <div class=""widgets-item"">
                                <ul class=""widgets-checkbox"">
                                    <li>
                                        <input class=""input-checkbox"" type=""checkbox"" id=""refine-item"">
                                        <label class=""label-checkbox mb-0"" for=""refine-item"">
                                            best seller
                                            <span>4</span>
                                        </label>
                                    </li>
                                    <li>
                                        <input class=""input-checkbox"" type=""checkbox"" id=""bestseller""  name=""refine-item-2"">
                                        <label class=""label-checkbox mb-0"" for=""refine-item-2"">
                      ");
            WriteLiteral(@"                      Best Seller
                                            <span>4</span>
                                        </label>
                                    </li>
                                    <li>
                                        <input class=""input-checkbox"" type=""checkbox"" id=""refine-item-3"">
                                        <label class=""label-checkbox mb-0"" for=""refine-item-3"">
                                            In Stock
                                            <span>4</span>
                                        </label>
                                    </li>
                                </ul>
                            </div>
                        </div>
                        <div class=""widgets-area widgets-filter mb-9"">
                            <h2 class=""widgets-title mb-5"">Price Filter</h2>
                            <div class=""price-filter"">
                                <div id=""slider-range""></div>
       ");
            WriteLiteral(@"                         <div class=""price-slider-amount"">
                                    <button class=""btn btn-primary btn-secondary-hover"">Filter</button>
                                    <div class=""label-input position-relative"">
                                        <label>price : </label>
                                        <input type=""text"" id=""amount"" name=""price"" placeholder=""Add Your Price"" />
                                    </div>
                                </div>
                            </div>
                        </div>


                    </div>
                </div>
                <div class=""col-lg-9 order-lg-2 order-1"">
                    <div class=""product-topbar"">
                        <ul>
                            <li class=""product-view-wrap"">
                                <ul class=""nav"" role=""tablist"">
                                    <li class=""grid-view"" role=""presentation"">
                                        <a c");
            WriteLiteral(@"lass=""active"" id=""grid-view-tab"" data-bs-toggle=""tab"" href=""#grid-view"" role=""tab"" aria-selected=""true"">
                                            <i class=""fa fa-th""></i>
                                        </a>
                                    </li>
                                    <li class=""list-view"" role=""presentation"">
                                        <a id=""list-view-tab"" data-bs-toggle=""tab"" href=""#list-view"" role=""tab"" aria-selected=""true"">
                                            <i class=""fa fa-th-list""></i>
                                        </a>
                                    </li>
                                </ul>
                            </li>
                            <li class=""page-count"">
                                <strong> ");
#nullable restore
#line 117 "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Product\Index.cshtml"
                                    Write(Model.TotalItemCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong><strong>Sản phẩm</strong>
                            </li>

                        </ul>
                    </div>
                    <div class=""tab-content text-charcoal pt-8"">
                        <div class=""tab-pane fade show active"" id=""grid-view"" role=""tabpanel"" aria-labelledby=""grid-view-tab"">
                            <div class=""product-grid-view row"" id=""records_table"">
");
#nullable restore
#line 125 "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Product\Index.cshtml"
                                 if (Model != null && Model.Count() > 0)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 127 "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Product\Index.cshtml"
                                     foreach (var item in Model)
                                    {
                                        string url = $"/{item.Alias}-{item.ProductId}";

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"col-lg-4 col-sm-6\">\r\n                                            <div class=\"product-item\">\r\n                                                <div class=\"product-img img-zoom-effect\">\r\n");
#nullable restore
#line 133 "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Product\Index.cshtml"
                                                     if (item.BestSeller == true)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                        <div style=""margin-bottom: 30px; z-index: 1; position: absolute; background-color: red; border-style: double; color: white; border-radius: 20px"">
                                                            <p style=""background-color:;margin:auto;padding:0px 10px;color:white"">Best Seller</p>
                                                        </div>
");
#nullable restore
#line 138 "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Product\Index.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <a");
            BeginWriteAttribute("href", " href=\"", 7789, "\"", 7800, 1);
#nullable restore
#line 139 "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Product\Index.cshtml"
WriteAttributeValue("", 7796, url, 7796, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b2fa7efcbcfc42c20287341eba9b8e04246fea2716475", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 7921, "~/images/products/", 7921, 18, true);
#nullable restore
#line 140 "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Product\Index.cshtml"
AddHtmlAttributeValue("", 7939, item.Thumb, 7939, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 140 "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Product\Index.cshtml"
AddHtmlAttributeValue("", 7957, item.Title, 7957, 11, false);

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
            WriteLiteral(@"
                                                    </a>
                                                    <div class=""product-add-action"">
                                                        <ul>
                                                            <li>
                                                                <a");
            BeginWriteAttribute("href", " href=\"", 8310, "\"", 8321, 1);
#nullable restore
#line 145 "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Product\Index.cshtml"
WriteAttributeValue("", 8317, url, 8317, 4, false);

#line default
#line hidden
#nullable disable
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
            BeginWriteAttribute("href", " href=\"", 8893, "\"", 8904, 1);
#nullable restore
#line 154 "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Product\Index.cshtml"
WriteAttributeValue("", 8900, url, 8900, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 154 "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Product\Index.cshtml"
                                                                                   Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                                    <div class=\"price-box pb-1\">\r\n                                                        <span class=\"new-price\">");
#nullable restore
#line 156 "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Product\Index.cshtml"
                                                                           Write(item.Price.Value.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                                    </div>
                                                    <div class=""rating-box"">
                                                        <ul>
                                                            <li><i class=""pe-7s-star""></i></li>
                                                            <li><i class=""pe-7s-star""></i></li>
                                                            <li><i class=""pe-7s-star""></i></li>
                                                            <li><i class=""pe-7s-star""></i></li>
                                                            <li><i class=""pe-7s-star""></i></li>
                                                        </ul>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
");
#nullable restore
#line 170 "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Product\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 170 "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Product\Index.cshtml"
                                     

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                            </div>
                        </div>
                        <div class=""tab-pane fade"" id=""list-view"" role=""tabpanel"" aria-labelledby=""list-view-tab"">
                            <div class=""product-list-view row"" id=""records_list"">
");
#nullable restore
#line 179 "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Product\Index.cshtml"
                                 if (Model != null && Model.Count() > 0)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 181 "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Product\Index.cshtml"
                                     foreach (var item in Model)
                                    {
                                        string url = $"/{item.Alias}-{item.ProductId}";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        <div class=""col-12"">
                                            <div class=""product-item"">
                                                <div class=""product-img img-zoom-effect"">
                                                    <a");
            BeginWriteAttribute("href", " href=\"", 11028, "\"", 11039, 1);
#nullable restore
#line 187 "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Product\Index.cshtml"
WriteAttributeValue("", 11035, url, 11035, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b2fa7efcbcfc42c20287341eba9b8e04246fea2723965", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 11126, "~/images/products/", 11126, 18, true);
#nullable restore
#line 188 "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Product\Index.cshtml"
AddHtmlAttributeValue("", 11144, item.Thumb, 11144, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 188 "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Product\Index.cshtml"
AddHtmlAttributeValue("", 11162, item.Title, 11162, 11, false);

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
            WriteLiteral(@"
                                                    </a>
                                                    <div class=""product-add-action"">
                                                        <ul>
                                                            <li>
                                                                <a href=""cart.html"">
                                                                    <i class=""pe-7s-cart""></i>
                                                                </a>
                                                            </li>
                                                            <li>
                                                                <a href=""compare.html"">
                                                                    <i class=""pe-7s-shuffle""></i>
                                                                </a>
                                                            </li>
                                        ");
            WriteLiteral(@"                    <li>
                                                                <a href=""wishlist.html"">
                                                                    <i class=""pe-7s-like""></i>
                                                                </a>
                                                            </li>
                                                        </ul>
                                                    </div>
                                                </div>
                                                <div class=""product-content align-self-center"">
                                                    <a class=""product-name pb-2""");
            BeginWriteAttribute("href", " href=\"", 12904, "\"", 12915, 1);
#nullable restore
#line 211 "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Product\Index.cshtml"
WriteAttributeValue("", 12911, url, 12911, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 211 "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Product\Index.cshtml"
                                                                                        Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                                    <div class=\"price-box pb-1\">\r\n                                                        <span class=\"new-price\">");
#nullable restore
#line 213 "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Product\Index.cshtml"
                                                                           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                                    </div>
                                                    <div class=""rating-box pb-2"">
                                                        <ul>
                                                            <li><i class=""pe-7s-star""></i></li>
                                                            <li><i class=""pe-7s-star""></i></li>
                                                            <li><i class=""pe-7s-star""></i></li>
                                                            <li><i class=""pe-7s-star""></i></li>
                                                            <li><i class=""pe-7s-star""></i></li>
                                                        </ul>
                                                    </div>
                                                    <p class=""short-desc mb-0"">");
#nullable restore
#line 224 "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Product\Index.cshtml"
                                                                          Write(item.ShortDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                </div>\r\n                                            </div>\r\n                                        </div>\r\n");
#nullable restore
#line 228 "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Product\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 228 "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Product\Index.cshtml"
                                     
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                            </div>
                        </div>
                    </div>
                    <div class=""pagination-area pt-10"">
                        <ul class=""pagination justify-content-center"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2fa7efcbcfc42c20287341eba9b8e04246fea2730883", async() => {
            }
            );
            __PagedList_Core_Mvc_PagerTagHelper = CreateTagHelper<global::PagedList.Core.Mvc.PagerTagHelper>();
            __tagHelperExecutionContext.Add(__PagedList_Core_Mvc_PagerTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#nullable restore
#line 237 "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Product\Index.cshtml"
__PagedList_Core_Mvc_PagerTagHelper.Options = PagedListRenderOptions.Bootstrap4PageNumbersOnly;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("options", __PagedList_Core_Mvc_PagerTagHelper.Options, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 237 "C:\Users\admin\Desktop\ag2022-mvc-1\Views\Product\Index.cshtml"
__PagedList_Core_Mvc_PagerTagHelper.List = Model;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("list", __PagedList_Core_Mvc_PagerTagHelper.List, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __PagedList_Core_Mvc_PagerTagHelper.AspAction = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </ul>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</main>\r\n<!-- Main Content Area End Here -->\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
    $(document).ready(function () {
        jQuery(""#txtCatID"").change(function () {
            var catID = jQuery(this).children("":selected"").attr(""value"");
            catID = parseFloat(catID);
            $('#txtCatID option').removeAttr('selected');
            $(""#txtCatID > [value="" + catID + ""]"").attr(""selected"", ""true"");
            $.ajax({
                url: '/Products/Filtter',
                dataType: ""json"",
                type: ""GET"",
                data: { CatID: catID },
                async: true,
                success: function (results) {
                    if (results.status == ""success"") {
                        window.location.href = results.redirectUrl;
                    }
                },
                error: function (xhr) {
                    alert('error');
                }
            });
        });
        $(""#keyword"").keyup(function () {
            var strkeyword = $('#keyword').val();
            $.ajax({
          ");
                WriteLiteral(@"      url: 'Search/FindProduct/',
                datatype: ""json"",
                type: ""POST"",
                data: { keyword: strkeyword },
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
            $(""#bestseller"").click(function () {
        var strkeyword = $('#keyword').val();
        $.ajax({
            url: 'Search/FindProductByBS/',
            datatype: ""json"",
            type: ""POST"",
            data: { keyword: strkeyword },
            async: true,
            success: function (results) {
                    $(""#records_table"").html("""");
                $(""#records_table"").html(results);

            },
            error: function (xhr) {
                alert('error');
            }
 ");
                WriteLiteral("       });\r\n        });\r\n    });\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedList.Core.IPagedList<OnlineMarket.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
