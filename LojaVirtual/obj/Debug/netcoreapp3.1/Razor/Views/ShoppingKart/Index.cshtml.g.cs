#pragma checksum "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\ShoppingKart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2a595b9141248d064ea181f212023af166959a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShoppingKart_Index), @"mvc.1.0.view", @"/Views/ShoppingKart/Index.cshtml")]
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
#line 4 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ProductAggregator;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ViewModel.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ViewModel.Payment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models.Const;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Libraries.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Libraries.Login;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2a595b9141248d064ea181f212023af166959a6", @"/Views/ShoppingKart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eaf59391fd8bf20db6995d5a617cb2a9b9cb16a1", @"/Views/_ViewImports.cshtml")]
    public class Views_ShoppingKart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProductItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Show", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/img-example.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-thumbnail img-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ShoppingKart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark text-black py-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Client", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning col-12 p-3 btn-proceed"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeliveryAddress", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\ShoppingKart\Index.cshtml"
  
    ViewData["Title"] = "Carrinho de compras";

    decimal Subtotal = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 10 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\ShoppingKart\Index.cshtml"
 if (Model.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <section class=""container"" id=""order"">
        <h1 class=""display-4 text-center my-5"">Carrinho de compras</h1>
        <div class=""alert alert-danger"" style=""display: none;"" role=""alert"">
        </div>
        <div id=""code_cart"">
            <div class=""card"">
                <table class=""table table-hover shopping-cart-wrap"">
                    <thead class=""text-muted"">
                        <tr>
                            <th scope=""col"">Nome do produto</th>
                            <th scope=""col"" width=""120"">Quantidade</th>
                            <th scope=""col"" width=""120"">Preço</th>
                            <th scope=""col"" width=""200"" class=""text-right"">Ações</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 28 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\ShoppingKart\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td width=\"55%\">\r\n                                    <figure class=\"media\">\r\n                                        <div class=\"img-wrap\">\r\n");
#nullable restore
#line 34 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\ShoppingKart\Index.cshtml"
                                             if (item.Images.Count > 0)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2a595b9141248d064ea181f212023af166959a611263", async() => {
                WriteLiteral("<img");
                BeginWriteAttribute("src", " src=\"", 1510, "\"", 1541, 1);
#nullable restore
#line 36 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\ShoppingKart\Index.cshtml"
WriteAttributeValue("", 1516, item.Images.First().Path, 1516, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"img-thumbnail img-sm\" />");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 36 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\ShoppingKart\Index.cshtml"
                                                                                                WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 37 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\ShoppingKart\Index.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d2a595b9141248d064ea181f212023af166959a614535", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 41 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\ShoppingKart\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </div>\r\n                                        <figcaption class=\"media-body\">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2a595b9141248d064ea181f212023af166959a616078", async() => {
                WriteLiteral("<h6 class=\"title text-truncate\">");
#nullable restore
#line 44 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\ShoppingKart\Index.cshtml"
                                                                                                                                             Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\ShoppingKart\Index.cshtml"
                                                                                            WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            <dl class=\"dlist-inline small\">\r\n                                                <dt>Descrição: </dt>\r\n                                                <dd>");
#nullable restore
#line 47 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\ShoppingKart\Index.cshtml"
                                               Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</dd>
                                            </dl>
                                        </figcaption>
                                    </figure>
                                </td>
                                <td>
                                    <div>
                                        <div class=""input-group input-spinner"">
                                            <div>
                                                <a href=""#"" class=""btn btn-dark btn-amount btn-less"" id=""button-plus-less""> <i class=""fa fa-minus""></i> </a>
                                            </div>
                                            <input type=""text"" class=""form-control text-center input-product-amount-kart pr-1 pl-1""");
            BeginWriteAttribute("value", " value=\"", 3142, "\"", 3171, 1);
#nullable restore
#line 58 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\ShoppingKart\Index.cshtml"
WriteAttributeValue("", 3150, item.ItensKartAmount, 3150, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" readonly />
                                            <div>
                                                <a href=""#"" class=""btn btn-dark btn-amount btn-more"" id=""button-plus-more""> <i class=""fa fa-plus""></i> </a>
                                            </div>

                                            <input type=""hidden"" class=""input-product-id""");
            BeginWriteAttribute("value", " value=\"", 3537, "\"", 3553, 1);
#nullable restore
#line 63 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\ShoppingKart\Index.cshtml"
WriteAttributeValue("", 3545, item.Id, 3545, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                            <input type=\"hidden\" class=\"input-product-stock\"");
            BeginWriteAttribute("value", " value=\"", 3651, "\"", 3671, 1);
#nullable restore
#line 64 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\ShoppingKart\Index.cshtml"
WriteAttributeValue("", 3659, item.Amount, 3659, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                            <input type=\"hidden\" class=\"input-product-unitary-price\"");
            BeginWriteAttribute("value", " value=\"", 3777, "\"", 3796, 1);
#nullable restore
#line 65 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\ShoppingKart\Index.cshtml"
WriteAttributeValue("", 3785, item.Price, 3785, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                        </div>\r\n                                    </div>\r\n                                </td>\r\n");
#nullable restore
#line 69 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\ShoppingKart\Index.cshtml"
                                  
                                    var subtotalItem = item.Price * item.ItensKartAmount;
                                    Subtotal = Subtotal + subtotalItem;
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>\r\n                                    <div class=\"price-wrap\">\r\n                                        <var class=\"price\">");
#nullable restore
#line 75 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\ShoppingKart\Index.cshtml"
                                                       Write((item.Price * item.ItensKartAmount).ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</var>\r\n                                        <small class=\"text-muted\">unid/ (");
#nullable restore
#line 76 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\ShoppingKart\Index.cshtml"
                                                                    Write(item.Price.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral(")</small>\r\n                                    </div>\r\n                                </td>\r\n                                <td class=\"text-right d-none d-md-block\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2a595b9141248d064ea181f212023af166959a623996", async() => {
                WriteLiteral(" Remover");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 80 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\ShoppingKart\Index.cshtml"
                                                                                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 83 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\ShoppingKart\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </section>\r\n");
            WriteLiteral(@"    <section class=""container mt-3"">
        <div class=""row"">
            <aside class=""col-md-4"">
                <h4 class=""subtitle-doc my-3"">
                    Frete
                </h4>
                <div id=""code_desc_simple"">
                    <div class=""box"">
                        <dl>
                            <dt class=""mb-2"">CEP </dt>
                            <dd>
                                <input type=""text"" name=""cep"" class=""form-control cep"" placeholder=""Digite o CEP."" /><a href=""#"" class=""col-md-12 mt-2 btn btn-dark btn-calcular-frete"">Calcular frete</a>
                            </dd>
                        </dl>
                            <div class=""container-frete"">
                        </div>
                    </div>
                </div>
            </aside>
            <aside class=""col-md-4"">
                <h4 class=""subtitle-doc my-3"">
                    Resumo
                </h4>
                <div id=""code_desc_right"">
   ");
            WriteLiteral("                 <div class=\"box\">\r\n                        <dl class=\"dlist-align\">\r\n                            <dt>Subtotal: </dt>\r\n                            <dd class=\"text-right subtotal\">");
#nullable restore
#line 117 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\ShoppingKart\Index.cshtml"
                                                       Write(Subtotal.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</dd>
                        </dl>
                        <dl class=""dlist-align"">
                            <dt>Frete:</dt>
                            <dd class=""text-right frete"">R$ 0,00</dd>
                        </dl>
                        <dl class=""dlist-align"">
                            <dt>Total:</dt>
                            <dd class=""text-right h5 b total"">R$ 0,00</dd>
                        </dl>
                    </div>
                </div>
            </aside>
            <aside class=""col-md-4"">
                <h4 class=""subtitle-doc my-3"">
                    Terminou?
                </h4>
                <div id=""code_desc_right"">
                    <div class=""box text-center"">
");
#nullable restore
#line 136 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\ShoppingKart\Index.cshtml"
                         if (_clientLogin.GetClient() == null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2a595b9141248d064ea181f212023af166959a629667", async() => {
                WriteLiteral("<strong>Continuar</strong>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-returnUrl", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 138 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\ShoppingKart\Index.cshtml"
                                                                                                   WriteLiteral(Url.Action("DeliveryAddress", "ShoppingKart", new { area = "" }));

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["returnUrl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-returnUrl", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["returnUrl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 139 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\ShoppingKart\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2a595b9141248d064ea181f212023af166959a632816", async() => {
                WriteLiteral("<strong>Continuar</strong>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 143 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\ShoppingKart\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </aside>\r\n        </div>\r\n    </section>\r\n");
#nullable restore
#line 149 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\ShoppingKart\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container\">\r\n        <br />\r\n        <br />\r\n        <div class=\"row\">\r\n            <div class=\"col-md-12 text-center display-4\">\r\n                Ainda não colocou nada no carrinho? <br/>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2a595b9141248d064ea181f212023af166959a635083", async() => {
                WriteLiteral("Clique aqui");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" e mude isso\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 161 "C:\Users\jvXvj\Documents\GitHub\lojavirtual-aspnetcore\LojaVirtual\Views\ShoppingKart\Index.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ClientLogin _clientLogin { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProductItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
