#pragma checksum "D:\User\Documents\GitHub\DDAC_Assignment\DDAC_Assignment\DDAC_Assignment\Views\OrderList\SingleOrderPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "baa2dd6d856f3322bd78f9666adeae31b301a6ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OrderList_SingleOrderPage), @"mvc.1.0.view", @"/Views/OrderList/SingleOrderPage.cshtml")]
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
#line 1 "D:\User\Documents\GitHub\DDAC_Assignment\DDAC_Assignment\DDAC_Assignment\Views\_ViewImports.cshtml"
using DDAC_Assignment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\User\Documents\GitHub\DDAC_Assignment\DDAC_Assignment\DDAC_Assignment\Views\_ViewImports.cshtml"
using DDAC_Assignment.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"baa2dd6d856f3322bd78f9666adeae31b301a6ff", @"/Views/OrderList/SingleOrderPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c51234a140c0c184d7660ee6a397c9cdca1c9ae0", @"/Views/_ViewImports.cshtml")]
    public class Views_OrderList_SingleOrderPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderFullInfo>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "editOrderPage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Review", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\User\Documents\GitHub\DDAC_Assignment\DDAC_Assignment\DDAC_Assignment\Views\OrderList\SingleOrderPage.cshtml"
  
    ViewData["Title"] = "SingleOrderPage";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "baa2dd6d856f3322bd78f9666adeae31b301a6ff5274", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>orders</title>

    <!-- font awesome cdn link  -->
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.1.1/css/all.min.css"">

    <!-- custom css file link  -->
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "baa2dd6d856f3322bd78f9666adeae31b301a6ff5926", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "baa2dd6d856f3322bd78f9666adeae31b301a6ff7813", async() => {
                WriteLiteral("\r\n    <div class=\"heading\">\r\n        <h3>Order ");
#nullable restore
#line 24 "D:\User\Documents\GitHub\DDAC_Assignment\DDAC_Assignment\DDAC_Assignment\Views\OrderList\SingleOrderPage.cshtml"
             Write(Model.order.OrderID);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n    </div>\r\n");
#nullable restore
#line 26 "D:\User\Documents\GitHub\DDAC_Assignment\DDAC_Assignment\DDAC_Assignment\Views\OrderList\SingleOrderPage.cshtml"
     if (User.IsInRole("Admin"))
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "baa2dd6d856f3322bd78f9666adeae31b301a6ff8690", async() => {
                    WriteLiteral("Edit");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-OrderID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "D:\User\Documents\GitHub\DDAC_Assignment\DDAC_Assignment\DDAC_Assignment\Views\OrderList\SingleOrderPage.cshtml"
                                             WriteLiteral(Model.order.OrderID);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["OrderID"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-OrderID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["OrderID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 29 "D:\User\Documents\GitHub\DDAC_Assignment\DDAC_Assignment\DDAC_Assignment\Views\OrderList\SingleOrderPage.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    <section class=\"orderItem\">\r\n        <table width=\"100%\">\r\n            <tr>\r\n                <th width=\"20%\">ID</th>\r\n                <td width=\"80%\"> ");
#nullable restore
#line 34 "D:\User\Documents\GitHub\DDAC_Assignment\DDAC_Assignment\DDAC_Assignment\Views\OrderList\SingleOrderPage.cshtml"
                            Write(Model.order.OrderID);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 36 "D:\User\Documents\GitHub\DDAC_Assignment\DDAC_Assignment\DDAC_Assignment\Views\OrderList\SingleOrderPage.cshtml"
             if (User.IsInRole("Admin"))
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <th width=\"20%\">User ID</th>\r\n                    <td width=\"80%\"> ");
#nullable restore
#line 40 "D:\User\Documents\GitHub\DDAC_Assignment\DDAC_Assignment\DDAC_Assignment\Views\OrderList\SingleOrderPage.cshtml"
                                Write(Model.order.UserID);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 42 "D:\User\Documents\GitHub\DDAC_Assignment\DDAC_Assignment\DDAC_Assignment\Views\OrderList\SingleOrderPage.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <th width=\"20%\">Placed On</th>\r\n                <td width=\"80%\"> ");
#nullable restore
#line 45 "D:\User\Documents\GitHub\DDAC_Assignment\DDAC_Assignment\DDAC_Assignment\Views\OrderList\SingleOrderPage.cshtml"
                            Write(Model.order.DatePlacedOn);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</td>
            </tr>
        </table>
        <div class=""box-container"" style=""margin-top: 10px"">

            <div class=""box"">
                <h4>Order Details</h4>
                <table width=""100%"">
                    <tr>
                        <th width=""20%"">Payment Method</th>
                        <td width=""80%"">");
#nullable restore
#line 55 "D:\User\Documents\GitHub\DDAC_Assignment\DDAC_Assignment\DDAC_Assignment\Views\OrderList\SingleOrderPage.cshtml"
                                   Write(Model.order.PaymentMethod);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <tr>\r\n                    <tr>\r\n                        <th width=\"20%\">Payment Status</th>\r\n                        <td width=\"80%\">");
#nullable restore
#line 59 "D:\User\Documents\GitHub\DDAC_Assignment\DDAC_Assignment\DDAC_Assignment\Views\OrderList\SingleOrderPage.cshtml"
                                   Write(Model.order.PaymentStatus);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th width=\"20%\">Delivery Contact</th>\r\n                        <td width=\"80%\">");
#nullable restore
#line 63 "D:\User\Documents\GitHub\DDAC_Assignment\DDAC_Assignment\DDAC_Assignment\Views\OrderList\SingleOrderPage.cshtml"
                                   Write(Model.order.DeliveryContact);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th width=\"20%\">Delivery Address</th>\r\n                        <td width=\"80%\">");
#nullable restore
#line 67 "D:\User\Documents\GitHub\DDAC_Assignment\DDAC_Assignment\DDAC_Assignment\Views\OrderList\SingleOrderPage.cshtml"
                                   Write(Model.order.DeliveryAddress);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th width=\"20%\">Delivery Status</th>\r\n                        <td width=\"80%\">");
#nullable restore
#line 71 "D:\User\Documents\GitHub\DDAC_Assignment\DDAC_Assignment\DDAC_Assignment\Views\OrderList\SingleOrderPage.cshtml"
                                   Write(Model.order.DeliveryStatus);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th width=\"20%\">Estimated Arrival Date</th>\r\n                        <td width=\"80%\">");
#nullable restore
#line 75 "D:\User\Documents\GitHub\DDAC_Assignment\DDAC_Assignment\DDAC_Assignment\Views\OrderList\SingleOrderPage.cshtml"
                                   Write(Model.order.EstimatedArrivalDate.ToShortDateString());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</td>
                    </tr>
                </table>
            </div>

            <div class=""box"">
                <h4>Order Items</h4>
                <table width=""100%"">
                    <thead>
                        <tr>
                            <th width=""10%"">Qty</th>
                            <th width=""40%"">Product Name</th>
                            <th width=""15%"">Unit Price</th>
                            <th width=""15%"">Sub Total</th>
                            <th width=""20%""></th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 93 "D:\User\Documents\GitHub\DDAC_Assignment\DDAC_Assignment\DDAC_Assignment\Views\OrderList\SingleOrderPage.cshtml"
                         foreach (var orderproduct in Model.orderProducts)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 96 "D:\User\Documents\GitHub\DDAC_Assignment\DDAC_Assignment\DDAC_Assignment\Views\OrderList\SingleOrderPage.cshtml"
                               Write(orderproduct.ProductQuantity);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 97 "D:\User\Documents\GitHub\DDAC_Assignment\DDAC_Assignment\DDAC_Assignment\Views\OrderList\SingleOrderPage.cshtml"
                               Write(orderproduct.ProductName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>RM ");
#nullable restore
#line 98 "D:\User\Documents\GitHub\DDAC_Assignment\DDAC_Assignment\DDAC_Assignment\Views\OrderList\SingleOrderPage.cshtml"
                                  Write(orderproduct.ProductUnitPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 99 "D:\User\Documents\GitHub\DDAC_Assignment\DDAC_Assignment\DDAC_Assignment\Views\OrderList\SingleOrderPage.cshtml"
                                  
                                    var subproductprice = orderproduct.ProductQuantity * orderproduct.ProductUnitPrice;
                                

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <td>RM ");
#nullable restore
#line 102 "D:\User\Documents\GitHub\DDAC_Assignment\DDAC_Assignment\DDAC_Assignment\Views\OrderList\SingleOrderPage.cshtml"
                                  Write(subproductprice);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>Rate Product</td>\r\n                                <td>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "baa2dd6d856f3322bd78f9666adeae31b301a6ff19028", async() => {
                    WriteLiteral("Review");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-OrderProductID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 104 "D:\User\Documents\GitHub\DDAC_Assignment\DDAC_Assignment\DDAC_Assignment\Views\OrderList\SingleOrderPage.cshtml"
                                                                         WriteLiteral(orderproduct.OrderProductID);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["OrderProductID"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-OrderProductID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["OrderProductID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 106 "D:\User\Documents\GitHub\DDAC_Assignment\DDAC_Assignment\DDAC_Assignment\Views\OrderList\SingleOrderPage.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </tbody>
                    <tfoot>
                        <tr>
                            <td style=""font-weight: bold"" colspan=""3"" align=""right"">Total</td>
                            <td style=""font-weight: bold"" colspan=""2"" align=""center"">RM ");
#nullable restore
#line 111 "D:\User\Documents\GitHub\DDAC_Assignment\DDAC_Assignment\DDAC_Assignment\Views\OrderList\SingleOrderPage.cshtml"
                                                                                   Write(Model.order.TotalPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        </tr>\r\n                    </tfoot>\r\n                </table>\r\n            </div>\r\n        </div>\r\n\r\n    </section>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrderFullInfo> Html { get; private set; }
    }
}
#pragma warning restore 1591
