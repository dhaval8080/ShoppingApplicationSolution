#pragma checksum "E:\Dhaval\WebApiReferance\ShoppingApplicationSolution-master (1)\ShoppingApplicationSolution-master\WebApp\Views\Products\ViewCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e15835dd9e17210acc0c99adb8ee93830ee81c9a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_ViewCart), @"mvc.1.0.view", @"/Views/Products/ViewCart.cshtml")]
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
#line 1 "E:\Dhaval\WebApiReferance\ShoppingApplicationSolution-master (1)\ShoppingApplicationSolution-master\WebApp\Views\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Dhaval\WebApiReferance\ShoppingApplicationSolution-master (1)\ShoppingApplicationSolution-master\WebApp\Views\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e15835dd9e17210acc0c99adb8ee93830ee81c9a", @"/Views/Products/ViewCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dec085bf195b01abb92852e860e2ca042d6a2857", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_ViewCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApp.Models.Cart>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Payment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Dhaval\WebApiReferance\ShoppingApplicationSolution-master (1)\ShoppingApplicationSolution-master\WebApp\Views\Products\ViewCart.cshtml"
  
    ViewData["Title"] = "ViewCart";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>ViewCart</h1>\n<br />\n<br />\n\n<div class=\"col-lg-12\">\n    <div class=\"row\">\n");
#nullable restore
#line 13 "E:\Dhaval\WebApiReferance\ShoppingApplicationSolution-master (1)\ShoppingApplicationSolution-master\WebApp\Views\Products\ViewCart.cshtml"
         foreach (var item in ViewBag.cartlist)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-lg-3\" style=\"margin:5px;background-color:palegreen\">\n");
            WriteLiteral("\n                <a style=\" all:unset;cursor:pointer\">\n                    <div style=\"text-align:center;\">\n                        <h4 style=\"padding-top:20px\">\n                            Name :  ");
#nullable restore
#line 25 "E:\Dhaval\WebApiReferance\ShoppingApplicationSolution-master (1)\ShoppingApplicationSolution-master\WebApp\Views\Products\ViewCart.cshtml"
                               Write(item.product.Productname);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </h4>\n                    </div>\n                    <div style=\"text-align:center;\">\n                        <h5 style=\"padding-top:20px\">\n                            Price : ");
#nullable restore
#line 30 "E:\Dhaval\WebApiReferance\ShoppingApplicationSolution-master (1)\ShoppingApplicationSolution-master\WebApp\Views\Products\ViewCart.cshtml"
                               Write(item.totalprice);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </h5>\n                    </div>\n                    <div style=\"text-align:center;\">\n                        <h5 style=\"padding-top:20px\">\n                            Quantity :  ");
#nullable restore
#line 35 "E:\Dhaval\WebApiReferance\ShoppingApplicationSolution-master (1)\ShoppingApplicationSolution-master\WebApp\Views\Products\ViewCart.cshtml"
                                   Write(item.Quantitys);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </h5>\n                    </div>\n");
            WriteLiteral("                </a>\n\n");
            WriteLiteral("            </div>\n");
#nullable restore
#line 45 "E:\Dhaval\WebApiReferance\ShoppingApplicationSolution-master (1)\ShoppingApplicationSolution-master\WebApp\Views\Products\ViewCart.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n\n</div>\n\n<br />\n<br />\n\n<div class=\"col-lg-12\">\n    <div class=\"row\">\n        <div class=\"col-lg-6\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e15835dd9e17210acc0c99adb8ee93830ee81c9a7438", async() => {
                WriteLiteral("\n                <div style=\"text-align:center;padding-bottom:10px;\">\n                    <input type=\"submit\" value=\"Order Now\" class=\"btn btn-primary\" />\n                </div>\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </div>\n        <div class=\"col-lg-6\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e15835dd9e17210acc0c99adb8ee93830ee81c9a9128", async() => {
                WriteLiteral("Continue Shopping");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApp.Models.Cart> Html { get; private set; }
    }
}
#pragma warning restore 1591