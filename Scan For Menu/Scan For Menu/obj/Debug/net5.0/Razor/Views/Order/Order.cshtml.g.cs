#pragma checksum "C:\Users\Amahle\Desktop\3rd year\Scan For Menu\Scan For Menu\Views\Order\Order.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f32396d03bf0b98f1b22a3c2a8fa884e0b828ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Order), @"mvc.1.0.view", @"/Views/Order/Order.cshtml")]
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
#line 1 "C:\Users\Amahle\Desktop\3rd year\Scan For Menu\Scan For Menu\Views\_ViewImports.cshtml"
using Scan_For_Menu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Amahle\Desktop\3rd year\Scan For Menu\Scan For Menu\Views\_ViewImports.cshtml"
using Scan_For_Menu.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f32396d03bf0b98f1b22a3c2a8fa884e0b828ca", @"/Views/Order/Order.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06f4643d51ae6c95c6a06d16d37449646e2d7196", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Order : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Amahle\Desktop\3rd year\Scan For Menu\Scan For Menu\Views\Order\Order.cshtml"
  
    ViewData["Title"] = "Order";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""image_gallary"">
    <h3>mabe add a cute slide show here</h3>
</div>
<div class=""container"">
    <div class=""tab"">
        <ul class=""nav_tabs"">
            <li class=""active""><a data-toggle=""tab"" href=""#Steaks_And_Grills""> Steaks and Grills </a></li>
            <li class=""active""><a data-toggle=""tab"" href=""#Burgers""> Burgers </a></li>
            <li class=""active""><a data-toggle=""tab"" href=""#Drinks""> Drinks </a></li>
            <li class=""active""><a data-toggle=""tab"" href=""#salads""> Soups and Salads </a></li>
            <li class=""active""><a data-toggle=""tab"" href=""#Desserts""> Desserts </a></li>
        </ul>
    </div>

    <div class=""tab-content"">
        <div id=""Steaks_And_Grills"" class=""tab-pane fade in active"">
            <h4> Steaks and Grills </h4>
            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.</p>
        </div>

        <div id=""Burgers"" class=""tab-pane fade"">
       ");
            WriteLiteral(@"     <h4>Burgers</h4>
            <p>Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.</p>
        </div>

        <div id=""Drinks"" class=""tab-pane fade"">
            <h4> Drinks </h4>
            <p>Eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.</p>
        </div>

        <div id=""salads"" class=""tab-pane fade"">
            <h4>Soups and Salads</h4>
            <p>Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam.</p>
        </div>

        <div id=""Desserts"" class=""tab-pane fade"">
            <h4> Desserts </h4>
            <p>Eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.</p>
        </div>
    </div>
</div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
