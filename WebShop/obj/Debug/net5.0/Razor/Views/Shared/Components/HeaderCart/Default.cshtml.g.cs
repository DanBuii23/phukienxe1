#pragma checksum "D:\Developments\Code\Doantotnghiep_pyt_website.mvc\WebShop\Views\Shared\Components\HeaderCart\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "18b8a9fda212dc5cc92fe9ebd2f0b1ceeeef1d3a4b5e389a60d5d1a310523fdf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_HeaderCart_Default), @"mvc.1.0.view", @"/Views/Shared/Components/HeaderCart/Default.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Developments\Code\Doantotnghiep_pyt_website.mvc\WebShop\Views\_ViewImports.cshtml"
using WebShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Developments\Code\Doantotnghiep_pyt_website.mvc\WebShop\Views\_ViewImports.cshtml"
using WebShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"18b8a9fda212dc5cc92fe9ebd2f0b1ceeeef1d3a4b5e389a60d5d1a310523fdf", @"/Views/Shared/Components/HeaderCart/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"2454517d99edfb35bbc85b1c078a3af78c358f2ed592677f7d34ebb910827d85", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_HeaderCart_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WebShop.ModelViews.CartItem>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-full"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\Developments\Code\Doantotnghiep_pyt_website.mvc\WebShop\Views\Shared\Components\HeaderCart\Default.cshtml"
 if (Model != null && Model.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""offcanvas-body"">
        <div class=""minicart-content"">
            <div class=""minicart-heading"">
                <h4 class=""mb-0"">Giỏ hàng</h4>
                <a href=""#"" class=""button-close""><i class=""pe-7s-close""></i></a>
            </div>
            <ul class=""minicart-list"">
");
#nullable restore
#line 11 "D:\Developments\Code\Doantotnghiep_pyt_website.mvc\WebShop\Views\Shared\Components\HeaderCart\Default.cshtml"
                 foreach (var item in Model)
                {
                    string url = $"/{item.product.Alias}-{item.product.ProductId}.html";

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"minicart-product\">\r\n                        <a class=\"product-item_remove\" href=\"#\">\r\n                            <i class=\"pe-7s-close\"></i>\r\n                        </a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 780, "\"", 791, 1);
#nullable restore
#line 18 "D:\Developments\Code\Doantotnghiep_pyt_website.mvc\WebShop\Views\Shared\Components\HeaderCart\Default.cshtml"
WriteAttributeValue("", 787, url, 787, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"product-item_img\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "18b8a9fda212dc5cc92fe9ebd2f0b1ceeeef1d3a4b5e389a60d5d1a310523fdf5394", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 875, "~/images/products/", 875, 18, true);
#nullable restore
#line 19 "D:\Developments\Code\Doantotnghiep_pyt_website.mvc\WebShop\Views\Shared\Components\HeaderCart\Default.cshtml"
AddHtmlAttributeValue("", 893, item.product.Thumb, 893, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 19 "D:\Developments\Code\Doantotnghiep_pyt_website.mvc\WebShop\Views\Shared\Components\HeaderCart\Default.cshtml"
AddHtmlAttributeValue("", 919, item.product.ProductName, 919, 25, false);

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
            WriteLiteral("\r\n                        </a>\r\n                        <div class=\"product-item_content\">\r\n                            <a class=\"product-item_title\"");
            BeginWriteAttribute("href", " href=\"", 1095, "\"", 1106, 1);
#nullable restore
#line 22 "D:\Developments\Code\Doantotnghiep_pyt_website.mvc\WebShop\Views\Shared\Components\HeaderCart\Default.cshtml"
WriteAttributeValue("", 1102, url, 1102, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 22 "D:\Developments\Code\Doantotnghiep_pyt_website.mvc\WebShop\Views\Shared\Components\HeaderCart\Default.cshtml"
                                                                 Write(item.product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            <span class=\"product-item_quantity\">");
#nullable restore
#line 23 "D:\Developments\Code\Doantotnghiep_pyt_website.mvc\WebShop\Views\Shared\Components\HeaderCart\Default.cshtml"
                                                           Write(item.amount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" x ");
#nullable restore
#line 23 "D:\Developments\Code\Doantotnghiep_pyt_website.mvc\WebShop\Views\Shared\Components\HeaderCart\Default.cshtml"
                                                                          Write(item.product.Price.Value.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</span>\r\n                        </div>\r\n                    </li>\r\n");
#nullable restore
#line 26 "D:\Developments\Code\Doantotnghiep_pyt_website.mvc\WebShop\Views\Shared\Components\HeaderCart\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </ul>\r\n        </div>\r\n        <div class=\"minicart-item_total\">\r\n            <span>Tổng tiền</span>\r\n            <span class=\"ammount\">");
#nullable restore
#line 33 "D:\Developments\Code\Doantotnghiep_pyt_website.mvc\WebShop\Views\Shared\Components\HeaderCart\Default.cshtml"
                             Write(Model.Sum(x => x.TotalMoney).ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</span>\r\n        </div>\r\n        <div class=\"group-btn_wrap d-grid gap-2\">\r\n            <a href=\"cart.html\" class=\"btn btn-secondary btn-primary-hover\">Xem giỏ hàng</a>\r\n");
#nullable restore
#line 37 "D:\Developments\Code\Doantotnghiep_pyt_website.mvc\WebShop\Views\Shared\Components\HeaderCart\Default.cshtml"
             if (User.Identity.IsAuthenticated)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a href=\"/checkout.html\" class=\"btn btn-secondary btn-primary-hover\">Thanh toán</a>\r\n");
#nullable restore
#line 40 "D:\Developments\Code\Doantotnghiep_pyt_website.mvc\WebShop\Views\Shared\Components\HeaderCart\Default.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a href=\"/dang-nhap.html?returnUrl=/checkout.html\" class=\"btn btn-secondary btn-primary-hover\">Thanh toán</a>\r\n");
#nullable restore
#line 44 "D:\Developments\Code\Doantotnghiep_pyt_website.mvc\WebShop\Views\Shared\Components\HeaderCart\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n");
#nullable restore
#line 48 "D:\Developments\Code\Doantotnghiep_pyt_website.mvc\WebShop\Views\Shared\Components\HeaderCart\Default.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"offcanvas-body\">\r\n        <div class=\"minicart-content\">\r\n            <div class=\"minicart-heading\">\r\n                <h4 class=\"mb-0\">Giỏ hàng rỗng</h4>\r\n\r\n            </div>\r\n\r\n        </div>\r\n\r\n    </div>\r\n");
#nullable restore
#line 61 "D:\Developments\Code\Doantotnghiep_pyt_website.mvc\WebShop\Views\Shared\Components\HeaderCart\Default.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WebShop.ModelViews.CartItem>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
