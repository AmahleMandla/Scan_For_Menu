#pragma checksum "C:\Users\Amahle\Desktop\3rd year\Scan For Menu\Scan For Menu\Views\Cart\ViewCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e5f8e759e9e3dfb5ac67eab94434843b512fbe3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_ViewCart), @"mvc.1.0.view", @"/Views/Cart/ViewCart.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Amahle\Desktop\3rd year\Scan For Menu\Scan For Menu\Views\Cart\ViewCart.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Amahle\Desktop\3rd year\Scan For Menu\Scan For Menu\Views\Cart\ViewCart.cshtml"
using Scan_For_Menu.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e5f8e759e9e3dfb5ac67eab94434843b512fbe3", @"/Views/Cart/ViewCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06f4643d51ae6c95c6a06d16d37449646e2d7196", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_ViewCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Scan_For_Menu.Models.Cart>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border-radius: 10px; background-color: #555 ; color: bisque; border: none; padding: 15px 20px; text-align: center; text-decoration: none; display: inline-block; font-size: 18px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "clearCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("s"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "removeItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger mx-2 far fa-trash-alt"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border-radius: 10px; margin:auto 30% auto 30%; background-color: #555 ; color: bisque; border: none; padding: 15px 20px; text-align: center; text-decoration: none; display: inline-block; font-size: 18px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "choosePayment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("btnProceed"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Proceed to payment"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btnProceed"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_15 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Amahle\Desktop\3rd year\Scan For Menu\Scan For Menu\Views\Cart\ViewCart.cshtml"
  
    ViewData["Title"] = "ViewCart";
    Layout = "~/Views/Shared/_LayoutCart.cshtml";
    float subTotal = 0;
    float gratuity = 0;
    var togNo = 0;
    float TotalAmount = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 14 "C:\Users\Amahle\Desktop\3rd year\Scan For Menu\Scan For Menu\Views\Cart\ViewCart.cshtml"
 if (Context.Session.GetInt32("CartCounter") > 0)
{


#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""container "" style=""margin: auto 0px auto 0px; width:stretch; left:10%;"">
        <div class=""row pt-4"">
            <div class=""col-6"">
                <h3 class=""text-primary""></h3>
            </div>
            <div class=""col-6 text-right"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e5f8e759e9e3dfb5ac67eab94434843b512fbe310519", async() => {
                WriteLiteral("\r\n                    <i class=\"fas fa-minus\"></i> &nbsp; Clear cart\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>

        <br /><br />

        <table class=""table table-bordered table-striped"" style="" margin:auto 5% auto 5%; width:100%"">
            <thead>
                <tr>
                    <th>Name</th>
                    <th>Price</th>
                    <th>Quantity</th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 41 "C:\Users\Amahle\Desktop\3rd year\Scan For Menu\Scan For Menu\Views\Cart\ViewCart.cshtml"
                 foreach (var obj in Model)
                {
                    subTotal += @obj.ItemPrice * @obj.ItemQty;
                    TotalAmount = gratuity + subTotal;
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n                        <td width=\"15%\" class=\"text-center\">");
#nullable restore
#line 46 "C:\Users\Amahle\Desktop\3rd year\Scan For Menu\Scan For Menu\Views\Cart\ViewCart.cshtml"
                                                       Write(obj.ItemName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td width=\"25%\" class=\"text-center\"> ");
#nullable restore
#line 47 "C:\Users\Amahle\Desktop\3rd year\Scan For Menu\Scan For Menu\Views\Cart\ViewCart.cshtml"
                                                        Write(String.Format("R {0}", @obj.ItemPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                        <td width=""40%"" class=""text-center"">
                            <div>
                                <button style=""border-radius: 30%; background-color: #555 ; color: bisque; border: none; padding: 10px 10px; text-align: center; text-decoration: none; display: inline-block; font-size: 16px;"" id=""order_toggle"" ;");
            BeginWriteAttribute("onclick", " onclick=\"", 2165, "\"", 2192, 3);
            WriteAttributeValue("", 2175, "decrement(", 2175, 10, true);
#nullable restore
#line 50 "C:\Users\Amahle\Desktop\3rd year\Scan For Menu\Scan For Menu\Views\Cart\ViewCart.cshtml"
WriteAttributeValue("", 2185, togNo, 2185, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2191, ")", 2191, 1, true);
            EndWriteAttribute();
            WriteLiteral(">-</button>\r\n                                <input class=\"tableNum\" style=\" border-color:#555; border-radius:15px; font-size:16px; background-color:beige; height:40px; width:40px\"");
            BeginWriteAttribute("id", " id=", 2373, "", 2383, 1);
#nullable restore
#line 51 "C:\Users\Amahle\Desktop\3rd year\Scan For Menu\Scan For Menu\Views\Cart\ViewCart.cshtml"
WriteAttributeValue("", 2377, togNo, 2377, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=number");
            BeginWriteAttribute("value", " value=\"", 2395, "\"", 2415, 1);
#nullable restore
#line 51 "C:\Users\Amahle\Desktop\3rd year\Scan For Menu\Scan For Menu\Views\Cart\ViewCart.cshtml"
WriteAttributeValue("", 2403, obj.ItemQty, 2403, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" min=0 max=20>
                                <button style=""border-radius: 30%; background-color: #555 ; color: bisque; border:none; padding: 10px 10px; text-align: center; text-decoration: none; display: inline-block; font-size: 16px;"" id=""order_toggle""");
            BeginWriteAttribute("onclick", " onclick=\"", 2673, "\"", 2700, 3);
            WriteAttributeValue("", 2683, "increment(", 2683, 10, true);
#nullable restore
#line 52 "C:\Users\Amahle\Desktop\3rd year\Scan For Menu\Scan For Menu\Views\Cart\ViewCart.cshtml"
WriteAttributeValue("", 2693, togNo, 2693, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2699, ")", 2699, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">+</button>
                                <button style=""border-radius: 10px; background-color: #555 ; color: bisque; border: none; padding: 5px 5px; text-align: center; text-decoration: none; display: inline-block; font-size: 16px;"" class=""button"" id=""update_order""");
            BeginWriteAttribute("itemid", " itemid=\"", 2970, "\"", 2990, 1);
#nullable restore
#line 53 "C:\Users\Amahle\Desktop\3rd year\Scan For Menu\Scan For Menu\Views\Cart\ViewCart.cshtml"
WriteAttributeValue("", 2979, obj.ItemId, 2979, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 2991, "\"", 3024, 3);
            WriteAttributeValue("", 3001, "updateCart(this,", 3001, 16, true);
#nullable restore
#line 53 "C:\Users\Amahle\Desktop\3rd year\Scan For Menu\Scan For Menu\Views\Cart\ViewCart.cshtml"
WriteAttributeValue("", 3017, togNo, 3017, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3023, ")", 3023, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Update</button>\r\n                            </div>\r\n                        </td>\r\n                        <td width=\"10%\" class=\"text-center\">\r\n                            <div class=\"w-75 btn-group\" role=\"group\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e5f8e759e9e3dfb5ac67eab94434843b512fbe317848", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 58 "C:\Users\Amahle\Desktop\3rd year\Scan For Menu\Scan For Menu\Views\Cart\ViewCart.cshtml"
                                                                    WriteLiteral(obj.ItemId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 63 "C:\Users\Amahle\Desktop\3rd year\Scan For Menu\Scan For Menu\Views\Cart\ViewCart.cshtml"

                    togNo = togNo + 1;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n        <br /> <br />\r\n\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e5f8e759e9e3dfb5ac67eab94434843b512fbe320819", async() => {
                WriteLiteral(@"
            <div style=""margin:auto 5% auto 5%; width:100%;"">
                <table class=""table table-striped"" id=""totals"">
                    <thead>
                        <tr>
                            <th width=""50%"" class=""text-center""></th>
                            <th width=""50%"" class=""text-center""></th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td width=""50%"" class=""text-center"">
                                Subtotal :
                            </td>
                            <td width=""50%"" class=""text-center"">R ");
#nullable restore
#line 85 "C:\Users\Amahle\Desktop\3rd year\Scan For Menu\Scan For Menu\Views\Cart\ViewCart.cshtml"
                                                             Write(subTotal.ToString("#,##0.00"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</td>
                        </tr>
                        <tr>
                            <td width=""50%"" class=""text-center"">
                                Gratuity :
                            </td>
                            <td width=""50%"" class=""text-center"">
                                <input name=""GratuityAmt""");
                BeginWriteAttribute("oninput", " oninput=\"", 4741, "\"", 4797, 4);
                WriteAttributeValue("", 4751, "calcTotal(", 4751, 10, true);
#nullable restore
#line 92 "C:\Users\Amahle\Desktop\3rd year\Scan For Menu\Scan For Menu\Views\Cart\ViewCart.cshtml"
WriteAttributeValue("", 4761, subTotal.ToString(), 4761, 20, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4781, ",", 4781, 1, true);
                WriteAttributeValue(" ", 4782, "\'GratuityAmt\')", 4783, 15, true);
                EndWriteAttribute();
                WriteLiteral(" class=\"gratuity\" style=\" border-color:#555; border-radius:15px; font-size:16px; background-color:beige; height:40px; width:80px\" id=\"GratuityAmt\" type=number");
                BeginWriteAttribute("value", " value=", 4956, "", 4972, 1);
#nullable restore
#line 92 "C:\Users\Amahle\Desktop\3rd year\Scan For Menu\Scan For Menu\Views\Cart\ViewCart.cshtml"
WriteAttributeValue("", 4963, gratuity, 4963, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" min=0 max=10000 />
                            </td>
                        </tr>
                        <tr>
                            <td width=""50%"" class=""text-center"">
                                Total :
                            </td>
                            <td id=""totalAmt"" value=""total"" width=""50%"" class=""text-center"">
                                R  ");
#nullable restore
#line 100 "C:\Users\Amahle\Desktop\3rd year\Scan For Menu\Scan For Menu\Views\Cart\ViewCart.cshtml"
                              Write(TotalAmount.ToString("#,##0.00"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </td>
                        </tr>
                    </tbody>
                </table>
            </div>

            <div class=""btnSubmit"" style=""justify-content:center; align-content:center;align-items:center"">
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5e5f8e759e9e3dfb5ac67eab94434843b512fbe324533", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_15.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_15);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 111 "C:\Users\Amahle\Desktop\3rd year\Scan For Menu\Scan For Menu\Views\Cart\ViewCart.cshtml"
          
            Context.Session.SetString("total", TotalAmount.ToString());
            Context.Session.SetString("subtotal", subTotal.ToString());  
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 116 "C:\Users\Amahle\Desktop\3rd year\Scan For Menu\Scan For Menu\Views\Cart\ViewCart.cshtml"

}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-bordered table-striped"" style="" margin:auto 5% auto 5%; width:100%"">
        <thead>
            <tr>
                <th>Name</th>
                <th>Price</th>
                <th>Quantity</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e5f8e759e9e3dfb5ac67eab94434843b512fbe328923", async() => {
                WriteLiteral(@"
                <div style=""margin:auto 5% auto 5%; width:100%;"">
                    <table class=""table table-striped"" id=""totals"">
                        <thead>
                            <tr>
                                <th width=""50%"" class=""text-center""></th>
                                <th width=""50%"" class=""text-center""></th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td width=""50%"" class=""text-center"">
                                    Subtotal :
                                </td>
                                <td width=""50%"" class=""text-center"">R ");
#nullable restore
#line 144 "C:\Users\Amahle\Desktop\3rd year\Scan For Menu\Scan For Menu\Views\Cart\ViewCart.cshtml"
                                                                 Write(subTotal.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</td>
                            </tr>
                            <tr>
                                <td width=""50%"" class=""text-center"">
                                    Gratuity :
                                </td>
                                <td width=""50%"" class=""text-center"">
                                    <input");
                BeginWriteAttribute("oninput", " oninput=\"", 7662, "\"", 7718, 4);
                WriteAttributeValue("", 7672, "calcTotal(", 7672, 10, true);
#nullable restore
#line 151 "C:\Users\Amahle\Desktop\3rd year\Scan For Menu\Scan For Menu\Views\Cart\ViewCart.cshtml"
WriteAttributeValue("", 7682, subTotal.ToString(), 7682, 20, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 7702, ",", 7702, 1, true);
                WriteAttributeValue(" ", 7703, "\'GratuityAmt\')", 7704, 15, true);
                EndWriteAttribute();
                WriteLiteral(" class=\"gratuity\" style=\" border-color:#555; border-radius:15px; font-size:16px; background-color:beige; height:40px; width:80px\" id=\"GratuityAmt\" type=number");
                BeginWriteAttribute("value", " value=\"", 7877, "\"", 7894, 1);
#nullable restore
#line 151 "C:\Users\Amahle\Desktop\3rd year\Scan For Menu\Scan For Menu\Views\Cart\ViewCart.cshtml"
WriteAttributeValue("", 7885, gratuity, 7885, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" min=0 max=100 />
                                </td>
                            </tr>
                            <tr>
                                <td width=""50%"" class=""text-center"">
                                    Total :
                                </td>
                                <td id=""total"" width=""50%"" class=""text-center"">
                                    R ");
#nullable restore
#line 159 "C:\Users\Amahle\Desktop\3rd year\Scan For Menu\Scan For Menu\Views\Cart\ViewCart.cshtml"
                                 Write(TotalAmount.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n                        </tbody>\r\n                    </table>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 168 "C:\Users\Amahle\Desktop\3rd year\Scan For Menu\Scan For Menu\Views\Cart\ViewCart.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Scan_For_Menu.Models.Cart>> Html { get; private set; }
    }
}
#pragma warning restore 1591
