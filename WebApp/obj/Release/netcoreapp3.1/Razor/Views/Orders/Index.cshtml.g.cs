#pragma checksum "E:\Dhaval\WebApiReferance\ShoppingApplicationSolution-master (1)\ShoppingApplicationSolution-master\WebApp\Views\Orders\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11aff46628248e67dbf37420cee801fd5ae30c7b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Index), @"mvc.1.0.view", @"/Views/Orders/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11aff46628248e67dbf37420cee801fd5ae30c7b", @"/Views/Orders/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dec085bf195b01abb92852e860e2ca042d6a2857", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApp.Models.Orders>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Dhaval\WebApiReferance\ShoppingApplicationSolution-master (1)\ShoppingApplicationSolution-master\WebApp\Views\Orders\Index.cshtml"
  
    ViewData["Title"] = "Orders";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Orders</h1>\n<table class=\"table\" id=\"mytable\">\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 12 "E:\Dhaval\WebApiReferance\ShoppingApplicationSolution-master (1)\ShoppingApplicationSolution-master\WebApp\Views\Orders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Productid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ProductName\n            </th>\n            <th>\n                ");
#nullable restore
#line 18 "E:\Dhaval\WebApiReferance\ShoppingApplicationSolution-master (1)\ShoppingApplicationSolution-master\WebApp\Views\Orders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 21 "E:\Dhaval\WebApiReferance\ShoppingApplicationSolution-master (1)\ShoppingApplicationSolution-master\WebApp\Views\Orders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Totalcost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 24 "E:\Dhaval\WebApiReferance\ShoppingApplicationSolution-master (1)\ShoppingApplicationSolution-master\WebApp\Views\Orders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Ordertime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 27 "E:\Dhaval\WebApiReferance\ShoppingApplicationSolution-master (1)\ShoppingApplicationSolution-master\WebApp\Views\Orders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Orderstatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                Delivery Status\n            </th>\n            <th>\n                Delivery Guy\n            </th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 38 "E:\Dhaval\WebApiReferance\ShoppingApplicationSolution-master (1)\ShoppingApplicationSolution-master\WebApp\Views\Orders\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
#line 42 "E:\Dhaval\WebApiReferance\ShoppingApplicationSolution-master (1)\ShoppingApplicationSolution-master\WebApp\Views\Orders\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Productid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n");
#nullable restore
#line 45 "E:\Dhaval\WebApiReferance\ShoppingApplicationSolution-master (1)\ShoppingApplicationSolution-master\WebApp\Views\Orders\Index.cshtml"
                 foreach (Product p in (IEnumerable<Product>)ViewBag.productlist)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "E:\Dhaval\WebApiReferance\ShoppingApplicationSolution-master (1)\ShoppingApplicationSolution-master\WebApp\Views\Orders\Index.cshtml"
                     if (p.Id == item.Productid)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "E:\Dhaval\WebApiReferance\ShoppingApplicationSolution-master (1)\ShoppingApplicationSolution-master\WebApp\Views\Orders\Index.cshtml"
                   Write(p.Productname);

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "E:\Dhaval\WebApiReferance\ShoppingApplicationSolution-master (1)\ShoppingApplicationSolution-master\WebApp\Views\Orders\Index.cshtml"
                                      
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "E:\Dhaval\WebApiReferance\ShoppingApplicationSolution-master (1)\ShoppingApplicationSolution-master\WebApp\Views\Orders\Index.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\n            <td>\n                ");
#nullable restore
#line 54 "E:\Dhaval\WebApiReferance\ShoppingApplicationSolution-master (1)\ShoppingApplicationSolution-master\WebApp\Views\Orders\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 57 "E:\Dhaval\WebApiReferance\ShoppingApplicationSolution-master (1)\ShoppingApplicationSolution-master\WebApp\Views\Orders\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Totalcost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 60 "E:\Dhaval\WebApiReferance\ShoppingApplicationSolution-master (1)\ShoppingApplicationSolution-master\WebApp\Views\Orders\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Ordertime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n            </td>\n            <td>\n                ");
#nullable restore
#line 64 "E:\Dhaval\WebApiReferance\ShoppingApplicationSolution-master (1)\ShoppingApplicationSolution-master\WebApp\Views\Orders\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Orderstatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n");
#nullable restore
#line 67 "E:\Dhaval\WebApiReferance\ShoppingApplicationSolution-master (1)\ShoppingApplicationSolution-master\WebApp\Views\Orders\Index.cshtml"
                 foreach (Shipmentagent3 p in (IEnumerable<Shipmentagent3>)ViewBag.sglist)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "E:\Dhaval\WebApiReferance\ShoppingApplicationSolution-master (1)\ShoppingApplicationSolution-master\WebApp\Views\Orders\Index.cshtml"
                     if (p.Orderid == item.Id)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "E:\Dhaval\WebApiReferance\ShoppingApplicationSolution-master (1)\ShoppingApplicationSolution-master\WebApp\Views\Orders\Index.cshtml"
                   Write(p.Statuss);

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "E:\Dhaval\WebApiReferance\ShoppingApplicationSolution-master (1)\ShoppingApplicationSolution-master\WebApp\Views\Orders\Index.cshtml"
                                  
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "E:\Dhaval\WebApiReferance\ShoppingApplicationSolution-master (1)\ShoppingApplicationSolution-master\WebApp\Views\Orders\Index.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\n            <td>\n");
#nullable restore
#line 76 "E:\Dhaval\WebApiReferance\ShoppingApplicationSolution-master (1)\ShoppingApplicationSolution-master\WebApp\Views\Orders\Index.cshtml"
                 foreach (Shipmentagent3 p in (IEnumerable<Shipmentagent3>)ViewBag.sglist)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "E:\Dhaval\WebApiReferance\ShoppingApplicationSolution-master (1)\ShoppingApplicationSolution-master\WebApp\Views\Orders\Index.cshtml"
                     if (p.Orderid == item.Id)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "E:\Dhaval\WebApiReferance\ShoppingApplicationSolution-master (1)\ShoppingApplicationSolution-master\WebApp\Views\Orders\Index.cshtml"
                   Write(p.DeliveryGuy);

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "E:\Dhaval\WebApiReferance\ShoppingApplicationSolution-master (1)\ShoppingApplicationSolution-master\WebApp\Views\Orders\Index.cshtml"
                                      
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "E:\Dhaval\WebApiReferance\ShoppingApplicationSolution-master (1)\ShoppingApplicationSolution-master\WebApp\Views\Orders\Index.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\n            <td>\n");
            WriteLiteral("            </td>\n        </tr>\n");
#nullable restore
#line 90 "E:\Dhaval\WebApiReferance\ShoppingApplicationSolution-master (1)\ShoppingApplicationSolution-master\WebApp\Views\Orders\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApp.Models.Orders>> Html { get; private set; }
    }
}
#pragma warning restore 1591
