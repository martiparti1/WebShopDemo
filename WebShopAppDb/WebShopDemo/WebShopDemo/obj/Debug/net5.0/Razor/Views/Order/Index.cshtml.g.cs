#pragma checksum "C:\Users\Student\Documents\martiparti\WebShopDemo\WebShopDemo\WebShopAppDb\WebShopDemo\WebShopDemo\Views\Order\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57363bd948026714c69c3aaf4daacfd623799618"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Index), @"mvc.1.0.view", @"/Views/Order/Index.cshtml")]
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
#line 1 "C:\Users\Student\Documents\martiparti\WebShopDemo\WebShopDemo\WebShopAppDb\WebShopDemo\WebShopDemo\Views\_ViewImports.cshtml"
using WebShopDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Student\Documents\martiparti\WebShopDemo\WebShopDemo\WebShopAppDb\WebShopDemo\WebShopDemo\Views\_ViewImports.cshtml"
using WebShopDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57363bd948026714c69c3aaf4daacfd623799618", @"/Views/Order/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a8a1fff20dfbd0a39b55fd7d1a8c2171d0d9d86", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebShopDemo.Models.Orders.OrderIndexVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Student\Documents\martiparti\WebShopDemo\WebShopDemo\WebShopAppDb\WebShopDemo\WebShopDemo\Views\Order\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n");
            WriteLiteral("<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\Student\Documents\martiparti\WebShopDemo\WebShopDemo\WebShopAppDb\WebShopDemo\WebShopDemo\Views\Order\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.OrderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n           \r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\Student\Documents\martiparti\WebShopDemo\WebShopDemo\WebShopAppDb\WebShopDemo\WebShopDemo\Views\Order\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.User));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 24 "C:\Users\Student\Documents\martiparti\WebShopDemo\WebShopDemo\WebShopAppDb\WebShopDemo\WebShopDemo\Views\Order\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Product));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "C:\Users\Student\Documents\martiparti\WebShopDemo\WebShopDemo\WebShopAppDb\WebShopDemo\WebShopDemo\Views\Order\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Picture));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 30 "C:\Users\Student\Documents\martiparti\WebShopDemo\WebShopDemo\WebShopAppDb\WebShopDemo\WebShopDemo\Views\Order\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 33 "C:\Users\Student\Documents\martiparti\WebShopDemo\WebShopDemo\WebShopAppDb\WebShopDemo\WebShopDemo\Views\Order\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 36 "C:\Users\Student\Documents\martiparti\WebShopDemo\WebShopDemo\WebShopAppDb\WebShopDemo\WebShopDemo\Views\Order\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Discount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 39 "C:\Users\Student\Documents\martiparti\WebShopDemo\WebShopDemo\WebShopAppDb\WebShopDemo\WebShopDemo\Views\Order\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TotalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 45 "C:\Users\Student\Documents\martiparti\WebShopDemo\WebShopDemo\WebShopAppDb\WebShopDemo\WebShopDemo\Views\Order\Index.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\Student\Documents\martiparti\WebShopDemo\WebShopDemo\WebShopAppDb\WebShopDemo\WebShopDemo\Views\Order\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.OrderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n         \r\n            <td>\r\n                ");
#nullable restore
#line 53 "C:\Users\Student\Documents\martiparti\WebShopDemo\WebShopDemo\WebShopAppDb\WebShopDemo\WebShopDemo\Views\Order\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.User));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n         \r\n            <td>\r\n                ");
#nullable restore
#line 57 "C:\Users\Student\Documents\martiparti\WebShopDemo\WebShopDemo\WebShopAppDb\WebShopDemo\WebShopDemo\Views\Order\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Product));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <img");
            BeginWriteAttribute("src", " src =\"", 1505, "\"", 1555, 1);
#nullable restore
#line 60 "C:\Users\Student\Documents\martiparti\WebShopDemo\WebShopDemo\WebShopAppDb\WebShopDemo\WebShopDemo\Views\Order\Index.cshtml"
WriteAttributeValue("", 1512, Html.DisplayFor(modelItem => item.Picture), 1512, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Image\" width=\"100\" />\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 63 "C:\Users\Student\Documents\martiparti\WebShopDemo\WebShopDemo\WebShopAppDb\WebShopDemo\WebShopDemo\Views\Order\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 66 "C:\Users\Student\Documents\martiparti\WebShopDemo\WebShopDemo\WebShopAppDb\WebShopDemo\WebShopDemo\Views\Order\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 69 "C:\Users\Student\Documents\martiparti\WebShopDemo\WebShopDemo\WebShopAppDb\WebShopDemo\WebShopDemo\Views\Order\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Discount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 72 "C:\Users\Student\Documents\martiparti\WebShopDemo\WebShopDemo\WebShopAppDb\WebShopDemo\WebShopDemo\Views\Order\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TotalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 75 "C:\Users\Student\Documents\martiparti\WebShopDemo\WebShopDemo\WebShopAppDb\WebShopDemo\WebShopDemo\Views\Order\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(" \r\n");
#nullable restore
#line 79 "C:\Users\Student\Documents\martiparti\WebShopDemo\WebShopDemo\WebShopAppDb\WebShopDemo\WebShopDemo\Views\Order\Index.cshtml"
       await Html.RenderPartialAsync("_ValidationScriptsPartial");
     

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebShopDemo.Models.Orders.OrderIndexVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
